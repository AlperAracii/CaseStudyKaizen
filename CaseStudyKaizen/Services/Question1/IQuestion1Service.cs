using System.Collections.Generic;

namespace CaseStudyKaizen.Services.Question1
{
    public interface IQuestion1Service
    {
        List<string> CreateCampaignCode(int howManyCode);
        bool CheckCode(string code);
    }
}
