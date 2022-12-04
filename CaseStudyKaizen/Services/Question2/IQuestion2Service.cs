using CaseStudyKaizen.Models;
using System.Threading.Tasks;

namespace CaseStudyKaizen.Services.Question2
{
    public interface IQuestion2Service
    {
        Task<ContentWithLanguageResponseModel> GetContentWithLanguage(string languageCode);
    }
}
