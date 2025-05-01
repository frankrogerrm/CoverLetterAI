using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Office.Interop.Word;
using System.Globalization;

namespace CoverLetterAI.Service.Services
{
    public interface ICoverLetterService
    {
        void ProcessFile(List<string> coverLetterTags);
    }

    public class CoverLetterService : ICoverLetterService
    {
        public void ProcessFile(List<string> coverLetterTags)
        {

            var sourceFolder = $"c:\\CoverLetterFiles";
            var sourceFile = $"{sourceFolder}\\FRANK RAMOS - Anschreiben.docx";

            string companyFolder = $"{sourceFolder}\\{coverLetterTags[6]}";
            if (!Directory.Exists(companyFolder))
            {
                Directory.CreateDirectory(companyFolder);
            }

            var finalResultPdf = $"{companyFolder}\\FRANK RAMOS - {coverLetterTags[6]} - Anschreiben.pdf";
            var fileResult = $"{companyFolder}\\FRANK RAMOS - {coverLetterTags[6]} - Anschreiben.docx";

            if (File.Exists(fileResult))
            {
                File.Delete(fileResult);
            }

            File.Copy(sourceFile, fileResult);

            var tagToMatchList = new List<string>() { 
                "senderfullname",
                "senderaddress",
                "senderpostalcode",
                "sendercountry",
                "senderphone",
                "senderemail",
                "companyname",
                "companyto",
                "companyaddress",
                "companypostalcode",
                "companycountry",
                "letterdate",
                "lettersubject",
                "lettersirmadam",
                "letterparfirst",
                "letterparsecond",
                "letterparthird",
                "letterparfourth",
                "footertext",
                "footername"
            };

            foreach(var item in coverLetterTags)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========================================================");
            //coverLetterTags[11] = $"{((coverLetterTags[11])!.Split(','))[0]}, {GetDateGermanFormat()}";

            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(fileResult, true))
            {
                // Access the main document part
                var body = wordDoc.MainDocumentPart.Document.Body;

                // Search for the text to replace
                foreach (var text in body.Descendants<Text>())
                {
                    for(int i = 0; i<tagToMatchList.Count; i++)
                    {
                        if (text.Text.Contains(tagToMatchList[i]))
                        {
                            text.Text = text.Text.Replace(tagToMatchList[i], coverLetterTags[i]);
                        }
                    }
                }
                wordDoc.MainDocumentPart.Document.Save();

            }

            Application app = new Application();
            var doc = app.Documents.Open(fileResult);
            doc.SaveAs2(finalResultPdf, WdSaveFormat.wdFormatPDF);
            doc.Close();
            app.Quit();

        }
        private string GetDateGermanFormat()
        {
            DateTime currentDate = DateTime.Now;
            CultureInfo germanCulture = new CultureInfo("de-DE");
            string formattedDate = currentDate.ToString("MMMM dd, yyyy", germanCulture);
            return formattedDate;


        }
    }
    
   
}
