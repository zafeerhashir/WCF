using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Name = "IService1")]
    public interface IService1
    {
        [OperationContract(Name = "GetCustomer")]
        IEnumerable<customer> GetCustomer();

        [OperationContract(Name = "GetCustomerbyid")]
        customer GetCustomer(int id);


        [OperationContract(Name = "PutCustomer")]
        void PutCustomer(customer Customer);

        [OperationContract(Name = "PostCustomer")]
        void PostCustomer(customer customer);

        [OperationContract(Name = "DeleteCustomer")]
        void DeleteCustomer(int id);




        // TODO: Add your service operations here
    }

}
