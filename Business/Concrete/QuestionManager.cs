﻿using Business.Abstract;
using Core.Utilities.Results;
using Dal.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public IResult Add(Question question)
        {
            _questionDal.Add(question);
            return new SuccessResult();
        }

        public IResult Delete(Question question)
        {
            _questionDal.Delete(question);
            return new SuccessResult();
        }

        public IDataResult<List<Question>> GetAll()
        {
            return new SuccessDataResult<List<Question>>(_questionDal.GetAll());
        }

        public IDataResult<Question> GetById(int questionId)
        {
            return new SuccessDataResult<Question>(_questionDal.Get(q=>q.Id==questionId));
        }

        public IResult Update(Question question)
        {
            _questionDal.Update(question);
            return new SuccessResult();
        }
    }
}
