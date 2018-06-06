using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    public class Service1 : IService1
    {
        martEntities db = new martEntities();
        

        public void DeleteCustomer(int id)
        {
            var customer = db.customers.Find(id);
            db.customers.Remove(customer);
            db.SaveChanges();
        }

        public IEnumerable<customer> GetCustomer()
        {
            var Customer = db.customers.ToList();
            return (Customer);
        }

        public customer GetCustomer(int id)
        {
            var Customer = db.customers.First(x => x.c_id == id);
            return (Customer);
        }

        public void PostCustomer(customer customer)
        {

            db.customers.Add(customer);
            db.SaveChanges();
        }



        public void PutCustomer(customer Customer)
        {
            db.Entry(Customer).State = System.Data.Entity.EntityState.Modified;
        }
    }


}
