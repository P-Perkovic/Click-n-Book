using Newtonsoft.Json;

namespace Click_and_Book.Email
{
    public class EmailTemplateData
    {
        [JsonProperty("action_url")]
        public string ActionUrl { get; set; }
    }
}