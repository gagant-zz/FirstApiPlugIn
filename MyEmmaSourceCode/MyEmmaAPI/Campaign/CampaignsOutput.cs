using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.Text;

namespace MyEmmaApi.Types
{
    public class CampaignsOutput : MyEmmaBaseOutput
    {
        public IList<CampaignsResult> Result { get; set; }

        

        public CampaignsOutput(CampaignsInput input)
            : base(input)
        {
            // Need to take variable for input parm for campaing Cache . 
            
        }

        public void FormatJason(string data)
        {
            var l = JsonSerializer.DeserializeFromString<CampaignsResult[]>(data);
            if (l.Count() > 0)
                Result = l.ToList<CampaignsResult>();
            
        }

        
    }
}
