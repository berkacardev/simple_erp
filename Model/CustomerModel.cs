using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CustomerModel
    {
        public CustomerModel(int id, string CustomerName, string CustomerSurname, string CustomerPhoneNumber, string CustomerEmailAdress, string CustomerAdress)
        {
            this.CustomerId = id;
            this.CustomerName = CustomerName;
            this.CustomerSurname = CustomerSurname;
            this.CustomerPhoneNumber = CustomerPhoneNumber;
            this.CustomerEmailAdress = CustomerEmailAdress;
            this.CustomerAdress = CustomerAdress;
        }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmailAdress { get; set; }
        public string CustomerAdress { get; set; }

        public override string ToString()
        {
            return this.CustomerName + " " + this.CustomerSurname + " | " + "0" + this.CustomerPhoneNumber;
        }
    }
}
