using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Customer : BaseEntity
    {
        public Customer(int id, string CustomerName, string CustomerSurname, string CustomerPhoneNumber, string CustomerEmailAdress, string CustomerAdress):base(id)
        {
            this.CustomerName = CustomerName;
            this.CustomerSurname = CustomerSurname;
            this.CustomerPhoneNumber = CustomerPhoneNumber;
            this.CustomerEmailAdress = CustomerEmailAdress;
            this.CustomerAdress = CustomerAdress;
        }

        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmailAdress { get; set; }
        public string CustomerAdress { get; set; }


    }
}
