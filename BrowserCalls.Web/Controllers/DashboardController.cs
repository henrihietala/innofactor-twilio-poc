using System;
using System.Web.Mvc;
using BrowserCalls.Web.Domain.Twilio;
using Twilio;
using Twilio.TwiML.Mvc;

namespace BrowserCalls.Web.Controllers
{
    public class DashboardController : TwilioController
    {
        private readonly ICredentials _credentials;

        public DashboardController() : this(new Credentials()) { }

        public DashboardController(ICredentials credentials)
        {
            _credentials = credentials;
        }


        // GET: Dashboard
        public ActionResult Index()
        {
            //var tickets = _repository.All();
            var twilio = new TwilioRestClient(_credentials.AccountSid, _credentials.AuthToken);

            // Build the parameters 
            var options = new CallListRequest();

            var calls = twilio.ListCalls(options);
            foreach (var call in calls.Calls)
            {
                Console.WriteLine(call.Direction);
            }
            return View(calls.Calls);
        }
    }
}
