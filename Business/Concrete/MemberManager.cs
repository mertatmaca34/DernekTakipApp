using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class MemberManager : IMemberManager
    {
        readonly IMemberDal _memberDal;

        public MemberManager(IMemberDal MemberDal)
        {
            _memberDal = MemberDal;
        }

        public IResult Add(Member Member)
        {
            IResult result = BusinessRules.Run(CheckMemberExist(Member))!;

            if (result == null)
            {
                this.Update(Member);

                return new SuccessResult(Messages.MemberUpdated);
            }
            else if (result != null)
            {
                _memberDal.Add(Member);

                return new SuccessResult(Messages.MemberAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Member Member)
        {
            IResult result = BusinessRules.Run(CheckMemberExist(Member))!;

            if (result == null)
            {
                _memberDal.Delete(Member);

                return new SuccessResult(Messages.MemberDeleted);
            }

            return new ErrorDataResult<Member>(Messages.InvalidDelete);
        }

        public IDataResult<Member> Get(Expression<Func<Member, bool>>? filter = null)
        {
            return new SuccessDataResult<Member>(_memberDal.Get(filter!));
        }

        public IDataResult<List<Member>> GetAll(Expression<Func<Member, bool>>? filter = null)
        {
            return new SuccessDataResult<List<Member>>(_memberDal.GetAll(filter!));
        }

        public IResult Update(Member Member)
        {
            IResult result = BusinessRules.Run(CheckMemberExist(Member))!;

            if (result == null)
            {
                _memberDal.Update(Member);

                return new SuccessResult(Messages.MemberUpdated);
            }

            this.Add(Member);

            return new SuccessResult(Messages.MemberAdded);
        }

        private IResult CheckMemberExist(Member Member)
        {
            if (Member != null)
            {
                var filteredData = _memberDal.GetAll(d => d.TcKimlik == Member.TcKimlik).FirstOrDefault();

                if (filteredData != null)
                {
                    return new SuccessResult();
                }
                else
                {
                    return new ErrorResult(Messages.DataNotFound);
                }
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }
    }
}