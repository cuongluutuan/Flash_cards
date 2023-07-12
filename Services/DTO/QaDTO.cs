using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    
    public class QaDTO
    {
        public string? question {  get; set; }   
        public List<string>? falseAnswers { get; set; }  
        public string? correctAns { get; set; }

        public List<string> getSuffled()
        {
            List<string> result = new List<string>();
            int countFalse = 0;
            Random rand = new Random();
            int correctIndex = rand.Next(0, 4);
            for (int i = 0; i < 4; i++)
            {
                if(i == correctIndex)
                {
                    result.Add(correctAns!);
                }
                else
                {
                    result.Add(falseAnswers[countFalse]);
                    countFalse ++;
                }
                
            }
            

            return result;
        }

    }

    
}
