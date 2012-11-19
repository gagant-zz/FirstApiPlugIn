using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEmmaApi
{
    
    public class MyEmmaBaseInput
    {

        public string ApiUrl { get; private set; }
        public bool IsAPIValid { get; set; }
        public string ErrorMessage { get; set; }
        public string SubmitUrl{ get; set; }
        public string ApiMethod { get; set; }
        public EnumValues.MethodRequestType ApiMethodType { get; set; }
        public string ApiAccountID { get; set; }
        public string ApiPublicKey { get; set; }
        public string ApiPrivateKey { get; set; }

        public MyEmmaBaseInput()
        {
            this.ApiUrl = APISettings.ApiUrl;
            setMethodNameAndType();
           
        }

        private void setMethodNameAndType()
        {
            string typeName = this.GetType().Name;            
            switch (typeName)
            {
                case "CampaignsInput":
                    {
                        this.ApiMethod = "mailings";
                        this.ApiMethodType = EnumValues.MethodRequestType.GET;
                        break;
                    }
                default:
                        {
                            ApiMethod= "";
                            break;
                        }
            }
            
        }



        
    }
}
