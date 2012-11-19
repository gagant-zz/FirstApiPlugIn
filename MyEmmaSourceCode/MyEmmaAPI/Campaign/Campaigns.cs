using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyEmmaApi.Types;

namespace MyEmmaApi.Methods
{
    public class Campaigns: APIBaseExecute
    {
        private  CampaignsInput Input { get; set; }
        private  CampaignsOutput Output { get; set; }

        

        public Campaigns(CampaignsInput  input) 
        {
            if (input == null)
            {
                throw new Exception("Input Parameters are empty.");
            }
            Input = input;
            Output = new CampaignsOutput(input);// Need to set some of the default values. 
        }

        public CampaignsOutput Execute()
        {
            APiRun(Input);
            return Output; // setting values up in ExecuteJson();

        }



        

        protected override void ExecuteJson()
        {   
            this.Input.IsAPIValid=true;
            //if(WriteValidateInputMethod==true)
            // Add filters if any
            // bind provided Api keys if required
            //Check chunk if required
            string request;
            string apiResponse = ApiRequest.ProcessRequest(this.Input, new Dictionary<string, string>(), out request);
            Output.FormatJason(apiResponse);
        }
    }
}
