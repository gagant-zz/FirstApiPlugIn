using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEmmaApi
{
    public class MyEmmaBaseOutput
    {
        public string ApiUrl { get; private set; }
        public bool IsAPIValid { get; set; }
        public string ErrorMessage { get; set; }
        public string SubmitUrl { get; set; }
        public string ApiMethod { get; set; }
        public EnumValues.MethodRequestType ApiMethodType { get; set; }
        public string ApiAccountID { get; set; }
        public string ApiPublicKey { get; set; }
        public string ApiPrivateKey { get; set; }



        public MyEmmaBaseOutput(MyEmmaBaseInput input)
        {
            this.ApiUrl = input.ApiUrl;
            this.IsAPIValid = input.IsAPIValid;
            this.ErrorMessage = input.ErrorMessage;
            this.SubmitUrl = input.SubmitUrl;
            this.ApiMethod = input.ApiMethod;
            this.ApiMethodType = input.ApiMethodType;
            this.ApiAccountID = input.ApiAccountID;
            this.ApiPublicKey = input.ApiPublicKey;
            this.ApiPrivateKey = input.ApiPrivateKey;
        }
    }
}
