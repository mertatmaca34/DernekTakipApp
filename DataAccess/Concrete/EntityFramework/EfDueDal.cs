using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDueDal : EfEntityRepositoryBase<Due, IBKSContext>, IDueDal { }
}
