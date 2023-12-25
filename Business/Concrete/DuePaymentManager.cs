using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class DuePaymentManager : IDuePaymentManager
    {
        private readonly IDuePaymentDal _duePaymentDal;

        public DuePaymentManager(IDuePaymentDal duePaymentDal)
        {
            _duePaymentDal = duePaymentDal;
        }

        public IResult Add(DuePayment duePayment)
        {
            var result = BusinessRules.Run(CheckDuePaymentExist(duePayment))!;

            if (result == null)
            {
                var filteredData = _duePaymentDal.GetAll(d => d.DueId == duePayment.DueId).FirstOrDefault();

                duePayment.Id = filteredData!.Id;

                this.Update(duePayment);

                return new SuccessResult(Messages.DuePaymentUpdated);
            }
            else
            {
                _duePaymentDal.Add(duePayment);

                return new SuccessResult(Messages.DuePaymentAdded);
            }
        }

        public IResult Delete(DuePayment DuePayment)
        {
            IResult result = BusinessRules.Run(CheckDuePaymentExist(DuePayment))!;

            if (result == null)
            {
                _duePaymentDal.Delete(DuePayment);

                return new SuccessResult(Messages.DuePaymentDeleted);
            }

            return new ErrorDataResult<DuePayment>(Messages.InvalidDelete);
        }

        public IDataResult<DuePayment> Get(Expression<Func<DuePayment, bool>>? filter)
        {
            var res = _duePaymentDal.Get(filter!);

            if (res != null)
            {
                return new SuccessDataResult<DuePayment>(_duePaymentDal.Get(filter!));
            }
            else
            {
                return new ErrorDataResult<DuePayment>();
            }

        }

        public IDataResult<List<DuePayment>> GetAll(Expression<Func<DuePayment, bool>>? filter)
        {
            return new SuccessDataResult<List<DuePayment>>(_duePaymentDal.GetAll(filter!));
        }

        public IResult Update(DuePayment DuePayment)
        {
            _duePaymentDal.Update(DuePayment);

            return new SuccessResult(Messages.DuePaymentUpdated);
        }

        private IResult CheckDuePaymentExist(DuePayment duePayment)
        {
            if (duePayment != null)
            {
                var filteredData = _duePaymentDal.GetAll(d => d.DueId == duePayment.DueId && d.MemberTC == duePayment.MemberTC).FirstOrDefault();

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
