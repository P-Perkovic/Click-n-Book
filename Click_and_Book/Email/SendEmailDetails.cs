﻿namespace Click_and_Book.Email
{
    public class SendEmailDetails
    {
        public string FromName { get; set; }
        public string FromEmail { get; set; }
        public string ToName { get; set; }
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public bool IsHTML { get; set; }
    }
}