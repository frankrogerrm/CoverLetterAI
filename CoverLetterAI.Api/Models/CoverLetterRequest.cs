using CoverLetterAI.Api.Utils;

namespace CoverLetterAI.Api.Models
{
    public class CoverLetterRequest
    {
        public string Url { get; set; } = string.Empty;
        public string FullName { get; set; }=string.Empty;
        public CoverLetterLanguagesEnum Languages { get; set; } = CoverLetterLanguagesEnum.English;
    }
}
