using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAnswerService
    {
        IDataResult<List<Answer>> GetAll();
        IDataResult<Answer> GetById(int answerId);
        IDataResult<List<AnswerDetailDto>>GetAnswerDetails();
        IResult Add(Answer answer);
        IResult Delete(Answer answer);
        IResult Update(Answer answer);
    }
}
