using Day20_MoodAnalyser_Test_Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        //UC1
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
        public void Giving_Any_Mood_Expecting_Happy_Results()
        {
            //Arrangement 
            MoodAnalyser mood = new MoodAnalyser("I am in Any Mood");
            string expected = "HAPPY";

            //Act
            string actualMsg = mood.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actualMsg);
        }


        //Refactor UC1
        [TestMethod]  //Refactor-TC 1.1
        public void Giving_SAD_Mood_Expecting_Sad_Result()
        {
            //Arrangement 
            MoodAnalyser mood = new MoodAnalyser("I am in Sad Mood");
            string expected = "SAD";

            //Act
            string result = mood.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]  //Refactor-TC 1.2
        public void Giving_HappyMood_Expecting_Sad_Result()
        {
            //Arrangement 
            MoodAnalyser mood = new MoodAnalyser("I am in Happy Mood");
            string message = "HAPPY";

            //Act
            string actualmsg = mood.AnalyseMood();

            //Assert
            Assert.AreEqual(message, actualmsg);
        }

        // UC2
        [TestMethod] 
        //[ExpectedException(typeof(Exception))] //not needed if we use "retrun" insteadof "throw" 
        public void Giving_NullMood_Expecting_Exception_Results()
        {
            //Arrangement
            MoodAnalyser mood = new MoodAnalyser(null);
            string expected = "Object reference not set to an instance of an object.";

            try
            {
                //Act
                string actualMsg = mood.AnalyseMood();
            }

            catch(NullReferenceException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
            
        }

        //TC 2.1
        [TestMethod] 
        //[ExpectedException(typeof(MoodAnalyserCustomException))]
        public void Giving_MoodNull_Should_Return_Happy()
        {
            //Arrange
            //string message = null;
            MoodAnalyser obj = new MoodAnalyser("null");
            string expected = "HAPPY";

            //Act
            string actualMsg = obj.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actualMsg);

        }

        //TC 3.1
        [TestMethod]
        //[ExpectedException(typeof(MoodAnalyserCustomException))]
        public void Giving_NullMood_Expecting_CustomException_Results()
        {
            //Arrange
            MoodAnalyser obj = new MoodAnalyser(null);
            string expected = "Mood should not be NULL";

            try
            {
                //Act
                string actualMsg = obj.AnalyseMood();
            }

            catch(MoodAnalyserCustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }

            
        }

        //TC 3.2
        [TestMethod]
        //[ExpectedException(typeof(MoodAnalyserCustomException))]
        public void Giving_EmptyMood_Expecting_CustomException_Results()
        {
            //Arrange
            MoodAnalyser obj = new MoodAnalyser("");
            string expected = "Mood should not be EMPTY";

            try
            {
                //Act
                string actualMsg = obj.AnalyseMood();
            }

            catch (MoodAnalyserCustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
            
        }

        //TC 4.1
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject() //have to check by passing the full address in place of null
        {
            //Arrange
            string message = null;
            MoodAnalyser expected = new MoodAnalyser(message);

            //Act
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("Day20_MoodAnalyser_Test_Assignment.MoodAnalyser", "MoodAnalyser");
            //expected.Equals(obj);

            //Assert
            Assert.AreNotEqual(expected, obj);
        }

        
        //TC 5.1
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            //Arrange
            object expected = new MoodAnalyser("HAPPY");

            //Act
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("Day20_MoodAnalyser_Test_Assignment.MoodAnalyser", "MoodAnalyser", "HAPPY");

            //Assert
            expected.Equals(obj);
        }

        //TC 6.1
        [TestMethod]
        public void Given_HappyMood_Should_Return_Happy()
        {
            //Arrange
            string expected = "HAPPY";

            //Act
            string mood = MoodAnalyserFactory.InvokeAnalyserMood("Happy", "AnalyseMood");

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
