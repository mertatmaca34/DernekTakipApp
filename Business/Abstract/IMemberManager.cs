using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMemberManager
    {
        IDataResult<Member> Get();
        IResult Add(Member member);
        IResult Update(Member member);
    }
}
