using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmailSettingsManager
    {
        IDataResult<EmailSettings> Get();
        IResult Add(EmailSettings emailSettings);
        IResult Update(EmailSettings emailSettings);
    }
}
