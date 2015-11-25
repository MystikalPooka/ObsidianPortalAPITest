using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using DevDefined.OAuth.Consumer;
using DevDefined.OAuth.Framework;
using DevDefined.OAuth.Tests;

namespace ObsidianAPITEST.OAuth
{
    /*
    OAuth details for Obsidian Portal API Test
        Consumer Key:
        fboJGwhLjiHNKmh7CY4l
        Consumer Secret:
        Ad1tnuZKt0wn1AHFESqOHLGW1WIExK5VLWb8bJEC
        Request Token URL
        https://www.obsidianportal.com/oauth/request_token
        Access Token URL
        https://www.obsidianportal.com/oauth/access_token
        Authorize URL
        https://www.obsidianportal.com/oauth/authorize

        We support HMAC-SHA1 for OAuth signature methods. */

    public class ObsidianConsumer
    {
        //private static X509Certificate2 certificate = TestCertificates.OAuthTestCertificate();
        private const string requestUrl = "https://www.obsidianportal.com/oauth/request_token";
        private const string userAuthorizeUrl = "https://www.obsidianportal.com/oauth/authorize";
        private const string accessUrl = "https://www.obsidianportal.com/oauth/access_token";
        //string callBackUrl = "http://www.mysite.com/callback";

        public static OAuthConsumerContext consumerContext = new OAuthConsumerContext
        {
            ConsumerKey = "fboJGwhLjiHNKmh7CY4l",
            SignatureMethod = SignatureMethod.HmacSha1,
            ConsumerSecret = "Ad1tnuZKt0wn1AHFESqOHLGW1WIExK5VLWb8bJEC"
        };
        public static OAuthSession session = new OAuthSession(consumerContext, requestUrl, userAuthorizeUrl, accessUrl);

        // get a request token from the provider
        private static IToken requestToken = session.GetRequestToken();

        // generate a user authorize url for this token (which you can use in a redirect from the current site)
        private static string authorizationLink = session.GetUserAuthorizationUrlForToken(requestToken);

        // exchange a request token for an access token
        private static IToken accessToken = session.ExchangeRequestTokenForAccessToken(requestToken);

        // make a request for a protected resource
        //string responseText = session.Request().Get().ForUrl("http://www.google.com/m8/feeds/contacts/default/base").ToString();
    }
}
