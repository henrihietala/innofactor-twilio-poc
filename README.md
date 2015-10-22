#Innofactor Twilio POC

1. Open `BrowserCalls.Web/Web.config` and update the following keys:
   ```
   <appSettings>
     <!-- omitted for clarity -->
     <add key="TwilioAccountSid" value="TWILIO_ACCOUNT_SID" />
     <add key="TwilioAuthToken" value="TWILIO_AUTH_TOKEN" />
     <add key="TwiMLApplicationSid" value="TWIML_APPLICATION_SID" />
     <add key="TwilioPhoneNumber" value="TWILIO_PHONE_NUMBER" />
   </appSettings>
   ```

2. Build the solution.

3. Run the application.

That's it!