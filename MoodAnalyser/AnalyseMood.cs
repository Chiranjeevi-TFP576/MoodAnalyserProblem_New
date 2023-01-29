using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MoodAnalyser
{
    public class AnalyseMood
    {


        public string message;
        
        public AnalyseMood()
        {

        }     
        public AnalyseMood(string message)
        {
            this.message = message.ToUpper();
        }
        public string GetMood(string Mood)
        {
            if (Mood.Contains("SAD"))
                return "SAD";
            else
                return "Happy";
        }
        //UC-2 Using Try Catch Blocks to Handle Null Exception.
        public string GetMood1()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                    return "SAD";
                else return "HAPPY";
            }
            
            catch (NullReferenceException)
            {
                return "HAPPY";
            }

        }



    }
    
}
