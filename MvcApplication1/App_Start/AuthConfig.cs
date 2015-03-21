using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using MvcApplication1.Models;

namespace MvcApplication1
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            OAuthWebSecurity.RegisterMicrosoftClient( 
                  clientId: "0000000040146604",   
                  clientSecret: "YfvyZDPEuhbMA4b0HCxLQN-Z-hr2MRVk");

          OAuthWebSecurity.RegisterTwitterClient(
              consumerKey: "rci7Slsz4pFZTpYT0fcfbTyCE",
            consumerSecret: "EeMhh29OxVtEFCFln7PjX0GfFv4gxJAgCmUnDBYtMhPHGTSFMK");

          //  consumerKey: "KJJJ8K6ywqpHIStFpZZbX3erB",
          //  consumerSecret: "iCmyYuH2L5nBN0PnHoocPGG30Y2UgiZKu0EdaMWroDm91fNqVU");

           OAuthWebSecurity.RegisterFacebookClient(
                   appId: "664835416976040",
                    appSecret: "362932536d56683b11af9470c7c29579");

         //  OAuthWebSecurity.RegisterGoogleClient( );
        }
    }
}
