using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramewok.Context;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate.EntityFramewok
{
    public class EFCompanyDal : EfEntityFrameworkBase<Company,ContextDb>, ICompanyDal
    {

    }
}
