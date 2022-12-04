using CaseStudyKaizen.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CaseStudyKaizen.Services.Question2
{
    public class Question2Service : IQuestion2Service
    {
        public Question2Service()
        {

        }

        public async Task<ContentWithLanguageResponseModel> GetContentWithLanguage(string languageCode)
        {
            var model = new ContentWithLanguageResponseModel();
            using (var connection = new SqlConnection("connectionstring"))
            using (var command = connection.CreateCommand())
            {
                await connection.OpenAsync();
                command.CommandText = @"SELECT [C].[Name], [C].[Title], [C].[Detail], [C].[ImageUrls], [C].[Category], [C].[LanguageCode] 
                    FROM [dbo].[Content] as [C] 
                    WHERE [C].[LanguageCode] = @languageCode;";

                //@"DECLARE @languageCode nvarchar(50) = '" + languageCode + @"';

                command.Parameters.AddWithValue("languageCode", languageCode);


                var reader = await command.ExecuteReaderAsync();
                while (reader.Read())
                {
                    model.Name = reader.GetString(0);
                    model.Title = reader.GetString(1);
                    model.Detail = reader.GetString(2);
                    model.ImageUrls = reader.GetString(3);
                    model.Category = reader.GetString(4);
                    model.LanguageCode = reader.GetString(5);
                }

                return model;
            }
        }
    }
}
