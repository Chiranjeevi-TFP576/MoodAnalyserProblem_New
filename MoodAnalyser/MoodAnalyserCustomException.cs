using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD, EMPTY_MOOD
        }
        public ExceptionType exceptionType;
        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.exceptionType = type;
        }
    }
}
