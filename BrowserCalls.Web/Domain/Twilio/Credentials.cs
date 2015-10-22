using System.Web.Configuration;

namespace BrowserCalls.Web.Domain.Twilio
{
    public interface ICredentials
    {
        string AccountSid { get; }
        string AuthToken { get; }
        string TwiMlApplicationSid { get; }
        string PhoneNumber { get; }
    }

    public class Credentials : ICredentials
    {
        public string AccountSid => WebConfigurationManager.AppSettings["TwilioAccountSid"];

        public string AuthToken => WebConfigurationManager.AppSettings["TwilioAuthToken"];

        public string TwiMlApplicationSid => WebConfigurationManager.AppSettings["TwiMLApplicationSid"];

        public string PhoneNumber => WebConfigurationManager.AppSettings["TwilioPhoneNumber"];
    }
}