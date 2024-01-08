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

        public IResult Add(Member member)
        {
            IResult result = BusinessRules.Run(CheckMemberExist(member))!;

            if (result == null)
            {
                this.Update(member);

                return new SuccessResult(Messages.MemberUpdated);
            }
            else if (result != null)
            {
                _memberDal.Add(member);

                return new SuccessResult(Messages.MemberAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Member member)
        {
            IResult result = BusinessRules.Run(CheckMemberExist(member))!;

            if (result == null)
            {
                var existMember = _memberDal.Get(m => m.TcKimlik == member.TcKimlik);
                _memberDal.Delete(existMember);

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

        public IResult Update(Member member)
        {
            IResult result = BusinessRules.Run(CheckMemberExist(member))!;

            if (result == null)
            {
                _memberDal.Update(member);

                return new SuccessResult(Messages.MemberUpdated);
            }

            this.Add(member);

            return new SuccessResult(Messages.MemberAdded);
        }

        private IResult CheckMemberExist(Member member)
        {
            if (member != null)
            {
                var filteredData = _memberDal.GetAll(d => d.TcKimlik == member.TcKimlik).FirstOrDefault();

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