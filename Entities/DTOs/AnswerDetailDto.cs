using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class AnswerDetailDto:IDto
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
    }
}
