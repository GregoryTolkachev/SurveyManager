using System;
using System.Collections.Generic;

namespace SurveyManager.Data
{
    public class SurveyItem
    {
        public string Question { get; set; }
        public List<string> Choices { get; set; }
        public int AnswerIndex { get; set; }
        public int Score { get; set; }

        public SurveyItem()
        {
            Choices = new List<string>();
        }
    }
}