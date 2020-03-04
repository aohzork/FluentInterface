using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterface
{
    /*public class Customer
        {
            private string _FullName;
            public string FullName
            {
                get { return _FullName; }
                set { _FullName = value; }
            }
            private DateTime _Dob;
            public DateTime Dob
            {
                get { return _Dob; }
                set { _Dob = value; }
            }
            private string _Address;
            public string Address
            {
                get { return _Address; }
                set { _Address = value; }
            }

        }

        public class CustomerFluent
        {
            private Customer obj = new Customer();
            public CustomerFluent NameOfCustomer(string Name)
            {
                obj.FullName = Name;
                return this;
            }
            public CustomerFluent Bornon(string Dob)
            {
                obj.Dob = Convert.ToDateTime(Dob);
                return this;
            }
            public void StaysAt(string Address)
            {
                obj.Address = Address;

            }
        }*/

    public interface IName
    {
        IAge WithName(string name);
    }

    public interface IAge
    {
        IPersist WithAge(int age);
        IPersist ExpectedDeath(int age);
    }

    public interface IPersist
    {
        void Save();
    }

    public class Person : IName, IAge, IPersist
    {

        public string Name { get; private set; }
        public int Age { get; private set; }

        private Person()
        {
        }

        public static IName Create()
        {
            return new Person();
        }

        public IAge WithName(string name)
        {
            Name = name;
            return this;
        }

        public IPersist WithAge(int age)
        {
            Age = age;
            return this;
        }

        public IPersist ExpectedDeath(int age)
        {
            Age = age;
            return this;
        }

        public void Save()
        {
            // save changes here
            Console.WriteLine("Name is :" + Name);
            Console.WriteLine("Age is :" + Age);
            Console.WriteLine("Save Called");
        }
    }

   /* class Program
    {
        static void Main(string[] args)
        {
            MakeBeverage espresso = new FluentCoffee().AddBeans(BeanType.Liberia).GroundBeans(true).AddWater(30).Serve();
            espresso.YourOrder();


             CustomerFluent customer = new CustomerFluent();
             customer.Bornon("2000/01/01").NameOfCustomer("johannes").StaysAt("ALLE");

            //Person.Create().WithName().

            Console.ReadKey();

        }
    }*/
}
