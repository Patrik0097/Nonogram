using SendGrid;
using SendGrid.Helpers.Mail;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading.Tasks;

public class EmailService
{
    private readonly string apiKey;
    private readonly string fromEmail;

    public EmailService()
    {
        var config = JObject.Parse(File.ReadAllText("appsettings.json"));
        apiKey = config["SendGridSettings"]["ApiKey"].ToString();
        fromEmail = config["SendGridSettings"]["FromEmail"].ToString();
    }

    public async Task SendEmailAsync(string toEmail, string subject, string body)
    {
        var client = new SendGridClient(apiKey);
        var from = new EmailAddress(fromEmail, "Your Name");
        var to = new EmailAddress(toEmail);
        var msg = MailHelper.CreateSingleEmail(from, to, subject, body, body);
        var response = await client.SendEmailAsync(msg);
    }
}
