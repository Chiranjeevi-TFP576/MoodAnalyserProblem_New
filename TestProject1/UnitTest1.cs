using MoodAnalyser;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private AnalyseMood analysemood;

        //Return SAD in Sad Mood
        [TestMethod]
        public void ReturningSad()
        {
            //Assert
            AnalyseMood analyserMood = new AnalyseMood();
            //Act
            string actualResult = analyserMood.GetMood("I am in SAD Mood");
            //Assert
            Assert.AreEqual("SAD", actualResult);
            
        }
        //TC1.2 Return Happy in any Mood
        [TestMethod]
        public void ReturningHappy()
        {
            //Assert
            AnalyseMood analyserMood = new AnalyseMood();
            //Act
            string actualResult = analyserMood.GetMood("I am in any Mood");
            //Assert
            Assert.AreEqual("Happy", actualResult);

        }
        //Exception Handle
        [TestMethod]
        public void GivenNullMoodShouldReturnHAPPY()
        {

            //Assert
            AnalyseMood analyserMood = new AnalyseMood();
            //Act
            string actualResult = analyserMood.GetMood("null");
            
            //Assert
            Assert.AreEqual("Happy", actualResult);
        }

        //UC3
        [TestMethod]
        public void GivenMessage_WhenNull_USingCustomException_ShouldReturnNullMood()
        {
            analysemood = new AnalyseMood();
            try
            {
                string message = analysemood.GetMood("");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(MoodAnalyserCustomException.ExceptionType.NULL_MOOD, exception.exceptionType);
            }

        }

    }
}