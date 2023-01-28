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
        public string GetMood(string message)

        {
            try
            {
                if (message.ToLower().Contains("Sad"))
                {
                    return "SAD";
                }

                else
                {
                    return "Happy";
                }
            }

            catch(NullReferenceException )
            {
                return "Happy";
            }
         
                                     
            
        }

        



    }
    
}
