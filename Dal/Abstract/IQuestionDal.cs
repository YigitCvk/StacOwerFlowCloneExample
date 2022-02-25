using Core.Dal.EntityFramework;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dal.Abstract
{
    public interface IQuestionDal:IEntityRepository<Question>
    {
      
    }
}
