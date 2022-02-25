using Core.Dal.EntityFramework;
using Core.Utilities.Results;
using Dal.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dal.Concrete
{
    public class EfQuestionDal : EfEntityRepositoryBase<Question, StackContext>, IQuestionDal
    {
        
    }
}
