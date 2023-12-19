using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IMemberManager
    {
        IDataResult<List<Member>> GetAll(Expression<Func<Member, bool>> filter = null);
        IDataResult<Member> Get(Expression<Func<Member, bool>> filter = null);
        IResult Add(Member member);
        IResult Update(Member member);
        IResult Delete(Member member);
    }
}
