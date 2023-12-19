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
        readonly IDueDal _dueDal;

        public DueManager(IDueDal DueDal)
        {
            _dueDal = DueDal;
        }

        public IResult Add(Due Due)
        {
            IResult result = BusinessRules.Run(CheckDueExist(Due));

            if (result == null)
            {
                this.Update(Due);

                return new SuccessResult(Messages.DueUpdated);
            }
            else if (result != null)
            {
                _dueDal.Add(Due);

                return new SuccessResult(Messages.DueAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Due Due)
        {
            IResult result = BusinessRules.Run(CheckDueExist(Due));

            if (result == null)
            {
                _dueDal.Delete(Due);

                return new SuccessResult(Messages.DueDeleted);
            }

            return new ErrorDataResult<Due>(Messages.InvalidDelete);
        }

        public IDataResult<Due> Get(Expression<Func<Due, bool>> filter)
        {
            var res = _dueDal.Get(filter);

            if(res != null)
            {
                return new SuccessDataResult<Due>(_dueDal.Get(filter));
            }
            else
            {
                return new ErrorDataResult<Due>();
            }

        }

        public IDataResult<List<Due>> GetAll(Expression<Func<Due, bool>> filter)
        {
            return new SuccessDataResult<List<Due>>(_dueDal.GetAll(filter));
        }

        public IResult Update(Due Due)
        {
            IResult result = BusinessRules.Run(CheckDueExist(Due));

            if (result == null)
            {
                _dueDal.Update(Due);

                return new SuccessResult(Messages.DueUpdated);
            }

            this.Add(Due);

            return new SuccessResult(Messages.DueAdded);
        }

        private IResult CheckDueExist(Due Due)
        {
            if (Due != null)
            {
                var filteredData = _dueDal.GetAll(d => d.Id == Due.Id).FirstOrDefault();

                if (filteredData != null)
                {
                    return new SuccessResult();
                }
                else
                {
                    return new ErrorResult(Messages.DataNotFound);
                }
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }
    }
}
