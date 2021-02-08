namespace Click_and_Book.Email
{
    public class SendEmailDetails
    {
        public string ToName { get; set; }
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public bool IsHTML { get; set; }
        public EmailTemplateData TemplateData { get; set; }

        internal static readonly string FromName = "Click n'Book";
        internal static readonly string FromEmail = "pperko00@fesb.hr";
        internal static readonly string TemplateId = "d-04fcd51ac4e6410190cc218a857a853c";
    }
}