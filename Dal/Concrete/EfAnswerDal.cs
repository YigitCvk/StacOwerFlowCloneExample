using Core.Dal.EntityFramework;
using Dal.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace Dal.Concrete
{
    public class EfAnswerDal : EfEntityRepositoryBase<Answer, StackContext>, IAnswerDal
    {
        IAnswerDal _answerDal;

        public EfAnswerDal(IAnswerDal answerDal)
        {
            _answerDal = answerDal;
        }

        public List<AnswerDetailDto> GetAnswerDetails()
        {
            using (StackContext context = new StackContext())
            {
                var result = from a in context.Answers
                             join q in context.Questions
                             on a.QuestionId equals q.Id
                             select new AnswerDetailDto
                             {
                                 AnswerId = a.Id,
                                 QuestionId = a.Id
                                 
                             };
                return result.ToList();
            }
        }

       
    }
}
