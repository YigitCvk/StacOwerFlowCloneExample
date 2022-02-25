using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IQuestionService
    {
        IDataResult<List<Question>> GetAll();
        IDataResult<Question> GetById(int questionId);
        IResult Add(Question question);
        IResult Delete(Question question);
        IResult Update(Question question);
    }
}
