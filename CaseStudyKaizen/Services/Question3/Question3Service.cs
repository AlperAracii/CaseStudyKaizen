using CaseStudyKaizen.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CaseStudyKaizen.Services.Question3
{
    public class Question3Service : IQuestion3Service
    {
        public Question3Service()
        {

        }

        public string JsonToString()
        {
            var responseJson = File.ReadAllTextAsync(@"C:\Users\alper.araci\Desktop\CaseStudyKaizen\CaseStudyKaizen\Models\response.json").Result;
            var model = JsonConvert.DeserializeObject<List<Question3JasonModel>>(responseJson);
            var text = "";
            var temp = 0;

            //Kordinatlara göre mapleme

            model.ForEach(aa => { 
                if(aa.locale == null)
                {
                    var x = aa.boundingPoly.vertices.FirstOrDefault().x;
                    if(temp != 0)
                    {
                        if (temp < x)
                            text += aa.description + " ";
                        else if (temp >= x)
                            text += "\n" + aa.description + " ";
                    }
                    temp = x;
                }   
            });

            return text;
        }
    }
}
