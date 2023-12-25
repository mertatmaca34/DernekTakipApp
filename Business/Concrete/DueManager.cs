using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class DueManager : IDueManager
    {
        private readonly IDueDal _dueDal;

        public DueManager(IDueDal dueDal)
        {
            _dueDal = dueDal;
        }

        public IResult Add(Due due)
        {
            var result = BusinessRules.Run(CheckDueExist(due))!;

            if (result == null)
            {
                var filteredData = _dueDal.GetAll(d => d.DueDate.Year == due.DueDate.Year && d.DueDate.Month == due.DueDate.Month).FirstOrDefault();

                due.Id = filteredData!.Id;

                this.Update(due);

                return new SuccessResult(Messages.DueUpdated);
            }
            else
            {
                _dueDal.Add(due);

                return new SuccessResult(Messages.DueAdded);
            }
        }

        public IResult Delete(Due due)
        {
            IResult result = BusinessRules.Run(CheckDueExist(due))!;

            if (result == null)
            {
                _dueDal.Delete(due);

                return new SuccessResult(Messages.DueDeleted);
            }

            return new ErrorDataResult<Due>(Messages.InvalidDelete);
        }

        public IDataResult<Due> Get(Expression<Func<Due, bool>>? filter)
        {
            var res = _dueDal.Get(filter!);

            if (res != null)
            {
                return new SuccessDataResult<Due>(_dueDal.Get(filter!));
            }
            else
            {
                return new ErrorDataResult<Due>();
            }

        }

        public IDataResult<List<Due>> GetAll(Expression<Func<Due, bool>>? filter)
        {
            return new SuccessDataResult<List<Due>>(_dueDal.GetAll(filter!));
        }

        public IResult Update(Due due)
        {
            _dueDal.Update(due);

            return new SuccessResult(Messages.DueUpdated);
        }

        private IResult CheckDueExist(Due due)
        {
            if (due == null) return new ErrorResult(Messages.IncompleteInfo);
            var filteredData = _dueDal.GetAll(d => d.DueDate.Year == due.DueDate.Year && d.DueDate.Month == due.DueDate.Month).FirstOrDefault();

            if (filteredData != null)
            {
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult(Messages.DataNotFound);
            }

        }
    }
}
