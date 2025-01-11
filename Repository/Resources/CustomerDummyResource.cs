using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Resources
{
    public class CustomerDummyResource : AbstractReosurce<Customer>
    {
        private static List<Customer> Customers = new List<Customer>();
        public CustomerDummyResource() : base(Customers)
        {
            Customers.Add(new Customer(1,"Berk","Acar","55544433322","berkacar.050@gmail.com","İnönü Mahallesi 987/23 Sokak No: 18 K: 4 Bayraklı/İzmir"));
            Customers.Add(new Customer(2,"Metin Orhan","Er","999888777","metin0520@gmail.com","Konya Ovası"));
            Customers.Add(new Customer(3,"Burak","Uysal","46846589289489","baura@gmail.com","İnternetin olmadığı mahalle"));
        }
    }
}
