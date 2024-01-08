using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IEmailSettingsManager
    {
        IDataResult<EmailSettings> Get(Expression<Func<EmailSettings, bool>>? filter);
        IResult Add(EmailSettings emailSettings);
        IResult Update(EmailSettings emailSettings);
    }
}
