using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Solution2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string sort(string s)
        {
            string[] numList = s.Split(',');  //remove commas

            List<double> floatList = new List<double>();


            foreach (string num in numList)

            {

                if (double.TryParse(num, out double n)) floatList.Add(n); // all good add to double list to sort it
                else return "Please Enter COMMA SEPERATED LIST OF NUMBERS"; // there is somthing wrong with input lets return


            }



            floatList.Sort();

            return string.Join(",", floatList);  // rejoin the list into comma seperated number string and return


        }
    }

}
