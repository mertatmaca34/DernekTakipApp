using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IDuePaymentManager
    {
        IDataResult<List<DuePayment>> GetAll(Expression<Func<DuePayment, bool>>? filter = null);
        IDataResult<DuePayment> Get(Expression<Func<DuePayment, bool>>? filter = null);
        IResult Add(DuePayment duePayment);
        IResult Update(DuePayment duePayment);
    }
}
