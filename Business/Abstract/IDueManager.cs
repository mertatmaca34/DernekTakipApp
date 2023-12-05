using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IDueManager
    {
        IDataResult<List<Member>> GetAll(Expression<Func<Member, bool>> filter = null);
        IDataResult<Due> Get();
        IResult Add(Due due);
        IResult Update(Due due);
    }
}
