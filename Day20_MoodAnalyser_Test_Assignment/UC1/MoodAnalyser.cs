using Day20_MoodAnalyser_Test_Assignment.CustomException;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day20_MoodAnalyser_Test_Assignment.UC1
{
    public class MoodAnalyser
    {
        //variable
        string message;

        //constructor with a string type parameter
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        //method for checking mood
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyser_CustomException(MoodAnalyser_CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyser_CustomException(MoodAnalyser_CustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}
