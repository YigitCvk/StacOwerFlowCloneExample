using Business.Abstract;
using Core.Utilities.Results;
using Dal.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AnswerManager : IAnswerService
    {
        IAnswerDal _anserDal;

        public AnswerManager(IAnswerDal anserDal)
        {
            _anserDal = anserDal;
        }

        public IResult Add(Answer answer)
        {
            _anserDal.Add(answer);
            return new SuccessResult();
        }

        public IResult Delete(Answer answer)
        {
            _anserDal.Delete(answer);
            return new SuccessResult();
        }

        public IDataResult<List<Answer>> GetAll()
        {
            return new SuccessDataResult<List<Answer>>(_anserDal.GetAll());
        }

        public IDataResult<List<AnswerDetailDto>> GetAnswerDetails()
        {
            return new SuccessDataResult<List<AnswerDetailDto>>(_anserDal.GetAnswerDetails());
        }

        public IDataResult<Answer> GetById(int answerId)
        {
            return new SuccessDataResult<Answer>(_anserDal.Get(a=>a.Id==answerId));
        }

        public IResult Update(Answer answer)
        {
            _anserDal.Delete(answer);
            return new SuccessResult();
        }
    }
}
