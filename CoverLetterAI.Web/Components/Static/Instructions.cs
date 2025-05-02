namespace CoverLetterAI.Web.Components.Static
{
    public enum LanguagesEnum
    {
        English = 1,
        German = 2,
        Spanish = 3,
        SpanishLatinoamerica = 4,
    }


    public static class DynamicTags
    {
        public static string Language { get; set; } = @"[Language]";
        public static string CompanyName { get; set; } = @"[CompanyName]";
        public static string CompanyFullAddress { get; set; } = @"[CompanyFullAddress]";
        public static string CompanyTelephone { get; set; } = @"[CompanyTelephone]";
        public static string CompanyWebsite { get; set; } = @"[CompanyWebsite]";
        public static string CompanyRelevantInformation { get; set; } = @"[CompanyRelevantInformation]";
    }


    public static class Instructions
    {
        public static string CompanyRequestInstructions { get; set; } = @"
            
            Based on this text, find the address of the company, telephone and relevant information of the company like what is the porpuse or business of the company.

            Follow this text structure for each line, at the begining and the end:
            1.  [t1][/t1], for Company Name
            2.  [t2][/t2], for my company full address.
            3.  [t3][/t3], for my company telephone.
            4.  [t4][/t4], for the url of the company.
            5.  [t5][/t5], based on the url and company name found, find relevant info about the company like business or field where they work.

            ============COMPANY INFORMATION=========================

        ";

        public static string CoverLetterRequestInstructions { get; set; } = @"
            
            We have the following information about the company:

            1. Company Full Address : [CompanyAddress].
            2. Company Telephone : [CompanyTelephone].
            3. Company Website : [CompanyWebsite].
            4. Company Relevant Information : [CompanyRelevantInformation].

            We have the following job offer. I want to create a a formal cover letter in [Language] and in [Language] format. Please follow these instructions:

            1. Use the company information mentioned previously to create the cover Letter.
            2. Show me only the text of the cover letter, but it should contain the headers and the footer. Avoid any comments that are not part of the final file.
            3. State that I meet each requirement with relevant experience that they are looking for.
            4. Only 4 paragraphs.
            5. The Cover Letter must be written in [Language].
            6. The cover mandatorily letter should contain the 20 tags from [t1] to [t20]
            7. DONT TRANSLATE, ELABORATE THE COVER LETTER IN [Language] FROM THE BEGINING.
            8. CORRECT ANY [Language] GRAMMAR OR [Language] ORTOGRAPHY MISTAKE.
            9. The Cover Letter should ALWAYS use keywords COMMING FROM Applicant Tracking Systems (ATS).

            Information about me that should be included in the letter:

            1. My name is Frank Ramos, and I am a software engineer.
            2. My address is Mannheimer Str. 80, 69198 Schriesheim, Baden-Württemberg, Germany.
            3. My telephone number is +49 151 58827093.
            4. My email is frankntr@gmail.com.
            5. My background is as follows: [Senior Full-Stack Developer with a degree in Systems Engineering, strong leadership, research, and creativity skills. More than 15 years of experience working with databases, backend, and frontend, basing my expertise in MSSQL, C#, and .Net. Additionally, my experience includes Cloud Computing and Microservices].
            6. Do not include an Enclosures/Anlagen section.
            7. Always include that I speak English (C1), Spanish (native), French (B2), and Portuguese (B2). I am also studying German in daily lessons and currently I have A2 level and my goal is to reach (B2) level soon, [but do not mention it in a negative way].
            8. I will be living in Germany from {GetGermanDateFormat(14)} and I can start working right after that. Mention that I am very excited about the move because of the new experience and culture.
            9. I have already received my State of Compatibility (Zeugnisbewertung) for the Software Engineer profession.
            10. Always include this : I have worked across the USA, Canada, South America, and the UK in various multicultural environments.


            Follow this text structure for each line, at the begining of eacg information there should be an '[t(n)]' and the end '[/t(n)]', for example [t1]Frank Ramos[/t1] or [t7]Audi Company[/t7]:


            1.  [t1][/t1], for my name.
            2.  [t2][/t2], for my address.
            3.  [t3][/t3], for my postal code and city.
            4.  [t4][/t4], for my Country.
            5.  [t5][/t5], for my phone.
            6.  [t6][/t6], for my email.
            7.  [t7][/t7], for company name.
            8.  [t8][/t8], for company human resoruces department or perdon in charge mentioned in the post, set this in german.
            9.  [t9][/t9], for company address (this format : [Street/avenue name] [number]).
            10. [t10][/t10], for company postal code and city of the address.
            11. [t11][/t11], for company country.
            12. [t12][/t12], for my city and use this fix date {GetGermanDateFormat()}, (DONT USE THE CURRENT DATE).
            13. [t13][/t13], for subject content.
            14. [t14][/t14], for sir/madam.
            15. [t15][/t15], for paragraph 1 of the body.
            16. [t16][/t16], for paragraph 2 of the body.
            17. [t17][/t17], for paragraph 3 of the body.
            18. [t18][/t18], for paragraph 4 of the body.
            19. [t19][/t19], for goodbye footer.
            20. [t20][/t20], for my name footer .

            IMPORTANT: IN THE RESULT, REMOVE ANY [t<counter>] AND [/t<counter>] THTA IS INSIDE OR BETWEEN OTHER [t<counter>] AND [/t<counter>].
            IMPORTANT: EACH OF THESE TAGS SHOULD BE IN GERMAN

            ============JOB OFFER=================
        ";

        public static string MyBackground { get; set; } =
            @"Information about me that should be included in the letter:

            1. My name is Frank Ramos, and I am a software engineer.
            2. My address is Mannheimer Str. 80, 69198 Schriesheim, Baden-Württemberg, Germany.
            3. My telephone number is +49 151 58827093.
            4. My email is frankntr@gmail.com.
            5. My background is as follows: [Senior Full-Stack Developer with a degree in Systems Engineering, strong leadership, research, and creativity skills. More than 15 years of experience working with databases, backend, and frontend, basing my expertise in MSSQL, C#, and .Net. Additionally, my experience includes Cloud Computing and Microservices].
            6. Do not include an Enclosures/Anlagen section.
            7. Always include that I speak English (C1), Spanish (native), French (B2), and Portuguese (B2). I am also studying German in daily lessons and currently I have A2 level and my goal is to reach (B2) level soon, [but do not mention it in a negative way].
            8. I will be living in Germany from {GetGermanDateFormat(14)} and I can start working right after that. Mention that I am very excited about the move because of the new experience and culture.
            9. I have already received my State of Compatibility (Zeugnisbewertung) for the Software Engineer profession.
            10. Always include this : I have worked across the USA, Canada, South America, and the UK in various multicultural environments.
        ";
    }
}
