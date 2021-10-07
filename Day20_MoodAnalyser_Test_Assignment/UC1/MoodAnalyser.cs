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
            
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
        }
    }
}
