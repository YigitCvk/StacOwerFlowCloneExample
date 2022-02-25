using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class QuestionDetailDto:IDto
    {
        public int QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public string Content { get; set; }
    }
}
