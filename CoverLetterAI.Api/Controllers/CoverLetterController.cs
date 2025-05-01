using CoverLetterAI.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;

namespace CoverLetterAI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoverLetterController : ControllerBase
    {
        [HttpPost(Name = "Generate")]
        public async Task<IActionResult> GenerateAsync(CoverLetterRequest request)
        {

            string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=AIzaSyAgvxfKgeF5CsUXm8hQ4rPF0GNZ5_lz5To";

            var requestBody = new
            {
                contents = new[]
                {
                new
                {
                    parts = new[]
                    {
                        new { text = Command }
                    }
                }
            }
            };


            

            using var client = new HttpClient();
            var json = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);
            string responseString = await response.Content.ReadAsStringAsync();




            int a = 0;
            return Ok();
        }

        private string Command { get; set; } = "We have the following job offer. I want to create a a formal cover letter in german and in german format. Please follow these instructions:\r\n\r\n1. Search the internet for information about the company that posted the job and use all the details to fill the cover letter, such as the full address, telephone number, and company name.\r\n2. Show me only the text of the cover letter, but it should contain the headers and the footer. Avoid any comments that are not part of the final file.\r\n3. State that I meet each requirement with relevant experience that they are looking for.\r\n4. Only 4 paragraphs.\r\n\r\nInformation about me that should be included in the letter:\r\n\r\n1. My name is Frank Ramos, and I am a software engineer.\r\n2. My address is Mannheimer Str. 80, 69198 Schriesheim, Baden-Württemberg, Germany.\r\n3. My telephone number is +49 1515 8827093.\r\n4. My email is frankntr@gmail.com.\r\n5. My background is as follows: [Senior Full-Stack Developer with a degree in Systems Engineering, strong leadership, research, and creativity skills. More than 15 years of experience working with databases, backend, and frontend, basing my expertise in MSSQL, C#, and .Net. Additionally, my experience includes Cloud Computing and Microservices, working across the USA, Canada, South America, and the UK in various multicultural environments.].\r\n6. Do not include an Enclosures/Anlagen section.\r\n7. I speak English (C1), Spanish (native), French (B2), and Portuguese (B2). I am also learning German and currently have an A2 level, but do not mention it in a negative way.\r\n8. Find the current date when this cover letter is generated and specify that I am moving permanently to Germany starting 2 weeks after that. Mention that I am very excited about the move because of the new experience and culture.\r\n9. I have already received my State of Compatibility (Zeugnisbewertung) for the Software Engineer profession.\r\n\r\nFollow this text structure:\r\n\r\nFor the text header, for each line, at the begining and the end:\r\n\r\n1.  [h1][/h1], for my name.\r\n2.  [h2][/h2], for my address.\r\n3.  [h3][/h3], for my postal code and city.\r\n4.  [h4][/h4], for my Country.\r\n5.  [h5][/h5], for my phone.\r\n6.  [h6][/h6], for my email.\r\n7.  [h7][/h7], for company name.\r\n8.  [h8][/h8], for company human resoruces department or perdon in charge mentioned in the post.\r\n9.  [h9][/h9], for company address.\r\n10. [h10][/h10], for company postal code and city.\r\n11. [h11][/h11], for company country.\r\n12. [h12][/h12], for city and current date.\r\n13. [h13][/h13], for subject content.\r\n14. [h14][/h14], for sir/madam.\r\n16. [p1][/p1], for each paragraph and increase the counter in \"p1\" .\r\n17. [f1][/f1], for goodbye footer.\r\n18. [f2][/f2], for my name footer .\r\n\r\n\r\n\r\n============JOB OFFER=================\r\n\r\nFull Stack Developer (m/f/d) - German Speaker\r\nDentsply Sirona, Inc\r\n&nbsp;\r\n3.4\r\n3.4 von 5 Sternen\r\n&nbsp;\r\n64625 Bensheim\r\nErstellen Sie ein Indeed-Konto, bevor Sie zur Website des Unternehmens weitergeleitet werden.\r\nArbeitsort\r\n64625 Bensheim\r\n&nbsp;\r\nVollständige Stellenbeschreibung\r\nDentsply Sirona is the world’s largest manufacturer of professional dental products and technologies, with a 130-year history of innovation and service to the dental industry and patients worldwide. Dentsply Sirona develops, manufactures, and markets a comprehensive solutions offering including dental and oral health products as well as other consumable medical devices under a strong portfolio of world class brands. Dentsply Sirona’s products provide innovative, high-quality and effective solutions to advance patient care and deliver better and safer dentistry. Dentsply Sirona’s global headquarters is located in Charlotte, North Carolina, USA. The company’s shares are listed in the United States on NASDAQ under the symbol XRAY.\r\n\r\n\r\n\r\nSenior Full Stack Developer (m/f/d) - German Speaker\r\n\r\n\r\nWhat We Are Look ing For - Scope of Role\r\n\r\n\r\nWe are looking for an experienced and talented Software Engineer to join our team. You will independently deliver small to moderate projects with guidance, improving software quality. The role encompasses ownership of user stories and drives their implementation through effective task breakdown. You will be part of a motivated and talented team that focuses on developing and maintaining features for our dental X-ray imaging portfolio. This includes connecting our extraoral and intraoral X-ray devices to our DSCore cloud platform by implementing the corresponding backend services as well as UI workflows in collaboration with our UXD team in a medical environment.\r\n\r\n\r\nWhat Will You Do - Responsibilities for Employment\r\n\r\n\r\nTechnical Implementation & Development\r\n\r\nWrite and maintain clean, efficient code following our architectural standards.\r\nDevelop using a modern tech stack (Golang, Dart/Flutter, Kubernetes, GCP) and document according to software development process and medical regulations\r\nWrite and maintain comprehensive unit tests and automated testing scripts to ensure code quality.\r\nCollaborate cross-functionally with UX, QA, and product teams including hardware development to deliver effective solutions.\r\nParticipate actively in code reviews, providing constructive feedback.\r\n\r\nProject Scope & Complexity\r\n\r\nHandle more complex tasks and stories with guidance, balancing speed and quality.\r\nIndependently deliver user stories through effective task breakdown.\r\n\r\nCommunication & Impact\r\n\r\nEngage effectively with team members and stakeholders to refine technical solutions.\r\n\r\nWho You Are - Qualifications\r\n\r\n\r\nEducation:\r\n\r\nBachelor's or Master's degree in Computer Science, Software Engineering, or related field.\r\n\r\nYears and Type of Experience:\r\n\r\nExperience of software engineering experience.\r\nExperience writing and maintaining unit tests.\r\nExperience with code review processes and best practices.\r\nExperience with CI/CD pipelines and workflows.\r\nExperience in full stack development (Golang/C#/C++, Flutter/Dart/WPF/Angular or comparable) is advantageous.\r\nExperience in framework development and software architecture\r\nExperience with automated testing frameworks is a plus.\r\n\r\nKey Skills, Knowledge & Capabilities:\r\n\r\nIntermediate programming skills with focus on maintainable code.\r\nStrong code review and feedback capabilities.\r\nExperience in CI/CD, Containerization (Docker) and Cloud Computing (e.g., GCP, Kubernetes)\r\nBasic knowledge in SQL/PostgreSQL\r\nProficiency in automated testing practices is advantageous.\r\nGood knowledge of English and German, both written and spoken.\r\nKnowledge of modern software development architecture.\r\n\r\n#LI-RB1\r\n\r\n\r\nDentsply Sirona is an Equal Opportunity/ Affirmative Action employer. All qualified applicants will receive consideration for employment without regard to race, color, religion, sex, national origin, age, sexual orientation, disability, or protected Veteran status. We appreciate your interest in Dentsply Sirona.\r\n\r\nIf you need assistance with completing the online application due to a disability, please send an accommodation request to careers@dentsplysirona.com. Please be sure to include “Accommodation Request” in the subject.";


    }
}
