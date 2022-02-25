using Core.Dal.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
    }
}
