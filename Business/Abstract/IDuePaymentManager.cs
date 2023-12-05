using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDuePaymentManager
    {
        IDataResult<DuePayment> Get();
        IResult Add(DuePayment duePayment);
        IResult Update(DuePayment duePayment);
    }
}
