using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EmailSettingsManager : IEmailSettingsManager
    {
        private readonly IEmailSettingsDal _emailSettingsDal;

        public EmailSettingsManager(IEmailSettingsDal emailSettingsDal)
        {
            _emailSettingsDal = emailSettingsDal;
        }

        public IResult Add(EmailSettings emailSettings)
        {
            var result = BusinessRules.Run(CheckEmailSettingsExist(emailSettings))!;

            if (result == null)
            {
                this.Update(emailSettings);

                return new SuccessResult(Messages.EmailSettingsUpdated);
            }
            else
            {
                _emailSettingsDal.Add(emailSettings);

                return new SuccessResult(Messages.EmailSettingsAdded);
            }
        }

        public IResult Delete(EmailSettings emailSettings)
        {
            IResult result = BusinessRules.Run(CheckEmailSettingsExist(emailSettings))!;

            if (result == null)
            {
                _emailSettingsDal.Delete(emailSettings);

                return new SuccessResult(Messages.EmailSettingsDeleted);
            }

            return new ErrorDataResult<EmailSettings>(Messages.InvalidDelete);
        }

        public IDataResult<EmailSettings> Get(Expression<Func<EmailSettings, bool>>? filter)
        {
            var res = _emailSettingsDal.Get(filter!);

            if (res != null)
            {
                return new SuccessDataResult<EmailSettings>(_emailSettingsDal.Get(filter!));
            }
            else
            {
                return new ErrorDataResult<EmailSettings>();
            }
        }

        public IDataResult<List<EmailSettings>> GetAll(Expression<Func<EmailSettings, bool>>? filter)
        {
            return new SuccessDataResult<List<EmailSettings>>(_emailSettingsDal.GetAll(filter!));
        }

        public IResult Update(EmailSettings emailSettings)
        {
            var res = _emailSettingsDal.Get(e => e.Id == 1);

            emailSettings.Id = res.Id;

            _emailSettingsDal.Update(emailSettings);

            return new SuccessResult(Messages.EmailSettingsUpdated);
        }

        private IResult CheckEmailSettingsExist(EmailSettings emailSettings)
        {
            if (emailSettings == null) return new ErrorResult(Messages.IncompleteInfo);
            var res = _emailSettingsDal.Get(e=> e.Id == 1);

            if (res != null)
            {
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult(Messages.DataNotFound);
            }
        }
    }
}
