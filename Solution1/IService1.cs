using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Solution1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        // TODO: Add your service operations here
        //This is 1st web service it does c2f and f2c conversions

        //this is a contract with the service
        [OperationContract]
        int c2f(int c);

        //this defines a contract f2c
        [OperationContract]
        int f2c(int f);



    }
}
