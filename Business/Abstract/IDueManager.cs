using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDueManager
    {
        IDataResult<Due> Get();
        IResult Add(Due due);
        IResult Update(Due due);
    }
}
