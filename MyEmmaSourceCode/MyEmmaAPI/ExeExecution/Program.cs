using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyEmmaApi;
using MyEmmaApi.Types;
using MyEmmaApi.Methods;
using System.Reflection;


namespace MyEmmaApi
{
    class Program
    {

         

        static void Main(string[] args)
        {
            GetAllCampaigns();
            

        }

        public static void GetAllCampaigns()
        {
            CampaignsInput objEmmaInput = new CampaignsInput();
            objEmmaInput.ApiPrivateKey = "f9c4d4c0b118051c18d3";
            objEmmaInput.ApiPublicKey = "4f932c1659a49045ae39";
            objEmmaInput.ApiAccountID = "1717169";
            Campaigns cmd = new Campaigns(objEmmaInput);
            CampaignsOutput objOut = cmd.Execute();
            PrintObject<CampaignsResult>(objOut.Result);
        }




        public static void PrintObject<TypeName>(IEnumerable<TypeName> data)
        {
            
            if (data.Count() > 0)
            {
                foreach (TypeName item in data)
                {
                    FieldInfo[] fi = item.GetType().GetFields(BindingFlags.Public |
                                              BindingFlags.NonPublic |
                                              BindingFlags.Instance);
                    foreach (FieldInfo t in fi)
                    {
                        Console.WriteLine("{0} = {1}", t.Name.Replace("<", "").Replace(">k__BackingField", ""), t.GetValue(item));
                        
                        
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }
            Console.Read();
        }
    }
}
