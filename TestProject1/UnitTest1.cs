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
        //UC2_Exception Handle

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

        //UC3 CustomException
        [TestMethod]
        public void GivenMessage_WhenNull_USingCustomException_ShouldReturnNullMood()
        {
            analysemood = new AnalyseMood();
            try
            {
                string message = analysemood.GetMood("null");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(MoodAnalyserCustomException.ExceptionType.NULL_MOOD, exception.exceptionType);
            }

        }
        //UC3.2_ Empty DefaultConstructor
        [TestMethod]
        public void GivenMessage_WhenEmpty_UsingCustomException_ShouldReturnNullMood()
        {
            analysemood = new AnalyseMood();
            try
            {
                string message = analysemood.GetMood1();
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(MoodAnalyserCustomException.ExceptionType.EMPTY_MOOD, exception.exceptionType);
            }
        }
        
        [TestMethod]

        public void ReturnMoodAnalyseObject_USingParameterizedConstructor()
        {
            analysemood = new AnalyseMood();
            
            //MoodAnalyser obj = (MoodAnalyser)expected;
            object expected1 = analysemood;
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser", "HAPPY");
            // expected.Equals(obj);
            Assert.AreEqual(analysemood, expected1);
        }


    }
}