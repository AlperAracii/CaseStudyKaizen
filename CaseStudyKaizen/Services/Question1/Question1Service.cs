using CaseStudyKaizen.Services.Question1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CaseStudyKaizen.Services.CampaignCode
{
    public class Question1Service : IQuestion1Service
    {
        static Random rnd = new Random();
        public Question1Service()
        {

        }

        public List<string> CreateCampaignCode(int howManyCode)
        {
            var lettersList = new[] { "A", "C", "D", "E", "F", "G", "H", "K", "L", "M", "N", "P", "R", "T", "X", "Y", "Z" };
            var numberList = new[] { "2", "3", "4", "5", "7", "9" };
            var codeList = new List<string>();

            //LLNLNNLL
            for (int k = 0; k < howManyCode; k++)
            {
                var code = "";
                for (int i = 1; i <= 8; i++)
                {
                    if (i == 3 || i == 5 || i == 6)
                    {
                        var a = numberList[rnd.Next(numberList.Count())];
                        code += a;
                    }
                    else
                    {
                        var b = lettersList[rnd.Next(lettersList.Count())];
                        code += b;
                    }
                }
                if (!codeList.Contains(code))
                    codeList.Add(code);
                else
                    k--;
            }

            return codeList;
        }

        public bool CheckCode(string code)
        {

            var lettersList = new[] { "A", "C", "D", "E", "F", "G", "H", "K", "L", "M", "N", "P", "R", "T", "X", "Y", "Z" };
            var numberList = new[] { "2", "3", "4", "5", "7", "9" };

            if (code.Length != 8)
                return false;
            
            var charList = code.ToUpper().ToCharArray();

            for(int i = 1; i < charList.Length+1; i++)
            {
                if (i == 3 || i == 5 || i == 6)
                {
                    if (!numberList.Contains(charList[i - 1].ToString()))
                        return false;
                }
                else
                {
                    if (!lettersList.Contains(charList[i - 1].ToString()))
                        return false;
                }
            }
            return true;
        }
    }
}
