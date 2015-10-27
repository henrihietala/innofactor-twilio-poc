#Twilio-QuickBlox POC

The purpose of this demo application is to create a proof of concept working with Twilio and Quickblox. 
This app is mostly copy and paste from both Twilio's and Quickblox's sample apps.

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
   
2. Edit Quickblox configuration in demo-qbconfig.js

3. Build the solution.

4. Run the application!