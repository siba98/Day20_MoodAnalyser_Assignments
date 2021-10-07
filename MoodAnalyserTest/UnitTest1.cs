using Day20_MoodAnalyser_Test_Assignment.Refactor_UC1;
using Day20_MoodAnalyser_Test_Assignment.UC1;
using Day20_MoodAnalyser_Test_Assignment.UC2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] //TC1.1
        public void Given_SadMood_Expecting_Sad_Results()
        {
            //Arrangement 
            MoodAnalyser mood = new MoodAnalyser("I am in Sad Mood");
            string expected = "SAD";

            //Act
            string actualMsg = mood.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actualMsg);
        }

        [TestMethod] //TC1.2
        public void Given_Any_Mood_Expecting_Happy_Results()
        {
            //Arrangement 
            MoodAnalyser mood = new MoodAnalyser("I am in Any Mood");
            string expected = "HAPPY";

            //Act
            string actualMsg = mood.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actualMsg);
        }

        [TestMethod]  //Refactor-TC 1.1
        public void Given_SAD_Mood_Expecting_Sad_Results()
        {
            //Arrangement 
            MoodAnalyser_RefactorUC1 mood = new MoodAnalyser_RefactorUC1();
            string message = "I am in Sad Mood";

            //Act
            string result = mood.AnalyseMood();

            //Assert
            Assert.AreEqual(message, result);
        }

        [TestMethod]  //Refactor-TC 1.2
        public void Given_ANY_Mood_Expecting_Happy_Results()
        {
            //Arrangement 
            MoodAnalyser_RefactorUC1 mood = new MoodAnalyser_RefactorUC1();
            string message = "I am in Happy Mood";

            //Act
            string result = mood.AnalyseMood();

            //Assert
            Assert.AreEqual(message, result);
        }

        [TestMethod] //TC 2.1
        public void Handling_Exception_If_Msg_Is_Null_Or_Empty()
        {
            //Arrangement
            MoodAnalyser_HandleException mood = new MoodAnalyser_HandleException(null);
            string expected = "Happy";

            //Act
            string actualMsg = mood.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actualMsg);
        }
    }
}
