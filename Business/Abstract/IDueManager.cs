using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IDueManager
    {
        IDataResult<List<Due>> GetAll(Expression<Func<Due, bool>>? filter = null);
        IDataResult<Due> Get(Expression<Func<Due, bool>>? filter = null);
        IResult Add(Due due);
        IResult Update(Due due);
    }
}
