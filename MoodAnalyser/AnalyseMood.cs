using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class AnalyseMood
    {
        
            public string GetMood(string Mood)
            {
                if (Mood.Contains("SAD"))
                    return "SAD";
                else
                    return "Happy";
            }
    }
}
