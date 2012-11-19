using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace MyEmmaApi
{
    public class ApiRequest
    {
        internal static string ProcessRequest(MyEmmaBaseInput input, Dictionary<string, string> parms, out string request)
        {
            request = string.Empty;
            string myEmmaURL = input.ApiUrl;
            StringBuilder requestUrl = new StringBuilder(myEmmaURL);
            requestUrl.Append("/" + input.ApiAccountID);            
            requestUrl.Append("/" + input.ApiMethod);

            string authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(input.ApiPublicKey + ":" + input.ApiPrivateKey));

            HttpWebRequest wRequest = null;
            string getUrl;

            if (input.ApiMethodType == EnumValues.MethodRequestType.GET) // Construct the URL with filter options
            {
                foreach (var item in parms)
                {
                    requestUrl.Append(string.Format("&{0}={1}", item.Key, System.Web.HttpUtility.UrlEncode(item.Value)));
                }

                getUrl = requestUrl.ToString();
                wRequest = ((HttpWebRequest)(WebRequest.Create(getUrl)));
                wRequest.Headers["Authorization"] = "Basic " + authInfo;                                
                wRequest.Method = "GET";
                request = getUrl;
            }

            else if (input.ApiMethodType == EnumValues.MethodRequestType.POST)
            {
                // Will soon add
                wRequest = ((HttpWebRequest)(WebRequest.Create("www.xyz.com")));
            }
            string apiResponse =string.Empty;
            using (HttpWebResponse wResponse = ((HttpWebResponse)wRequest.GetResponse()))
            {
                using (StreamReader data = new StreamReader(wResponse.GetResponseStream()))
                {
                    apiResponse = data.ReadToEnd();
                }
            }
            apiResponse= apiResponse.Replace(">\n<", "><");
            return apiResponse;
        }
    }
}
