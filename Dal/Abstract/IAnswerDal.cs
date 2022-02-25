using Core.Dal.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Abstract
{
    public interface IAnswerDal:IEntityRepository<Answer>
    {
        List<AnswerDetailDto> GetAnswerDetails();
        
    }
}
