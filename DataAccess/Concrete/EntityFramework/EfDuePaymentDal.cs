﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDuePaymentDal : EfEntityRepositoryBase<DuePayment, IBKSContext>, IDuePaymentDal { }
}