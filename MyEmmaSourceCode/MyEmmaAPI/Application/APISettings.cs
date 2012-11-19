using System.Collections.Generic;


namespace MyEmmaApi
{
    //Class added for compatibility with WebApp. Inherited ConfigurationSection class to extract values from web.config. GaganT
    public class APISettings 
    {
        private static APISettings _instance;
        private static APISettings Instance
        {
            get {
                if (_instance == null)
                {                    
                    if (_instance == null) _instance = new APISettings();
                }
                return _instance;            
            }
        }


        #region API Access Settings
        public static string ApiUrl
        {
            get
            {
                return "https://api.e2ma.net";
            }
        }
        #endregion



        

        #region Campaigns start Settinsg
        
        public static int DefaultStart
        {
            get{ return 0;}
        }

        public static int DefaultLimitCampaigns
        {
            get { return 10; }
        }

        #endregion



    }
}
