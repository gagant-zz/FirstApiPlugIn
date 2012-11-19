using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;


namespace MyEmmaApi
{
    public class EnumValues
    {

        
        // ‘m’ (regular), ‘t’ (test), ‘r’ (trigger).
       public enum MailingTypes
        {
            [Description("m")]
            regular,
            [Description("t")]
            test,
            [Description("r")]
            trigger
        }

       public enum MailingStatus
       {
           [Description("p")]
           pending,
           [Description("a")]
           paused,
           [Description("s")]
           sending,
           [Description("x")]
           canceled,
           [Description("c")]
           complete,
            [Description("f")]
           failed
       }

       public enum MethodRequestType
       {
           GET,
           POST
       }

       public struct MethodCallName
       {
           public static string Campaigns = "mailings";
       }


        
    }
}
