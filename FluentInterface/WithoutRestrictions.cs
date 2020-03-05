using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterface
{
    /*public enum Coffee
    {
        Americano,
        Espresso,
        Cappuccino,
        Latte,
        Mocha,
        Macchiato
    }

    public enum Beans
    {
        Arabica,
        Robusta,
        Liberia
    }

    //fluent without restrictions
    public interface IMakeBeverage
    {
        IMakeBeverage CoffeeName(Coffee coffee);
        IMakeBeverage AddBeans(Beans beans);
        IMakeBeverage GrindBeans(bool grounded);
        IMakeBeverage AddWater(int ml);
        IMakeBeverage AddSteamedMilk(int ml);
        IMakeBeverage AddMilkFoam(int ml);
        IMakeBeverage AddChocolateSyrup(int ml);
        IMakeBeverage AddWhippedCream(int ml);
        IMakeBeverage Serve();
        void YourOrder();
    }

    class FluentCoffee : IMakeBeverage
    {
        public string Name { get; set }
        public string BeanType { get; set; }
        public bool IsGrounded { get; set; }
        public int Water { get; set; }
        public int SteamedMilk { get; set; }
        public int MilkFoam { get; set; }
        public int ChocolateSyrup { get; set; }
        public int WhippedCream { get; set; }

        public IMakeBeverage CoffeeName(Coffee coffee)
        {
            Name = coffee.ToString();
            return this;
        }

        public IMakeBeverage AddBeans(Beans beans)
        {
            BeanType = beans.ToString();
            return this;
        }
        public IMakeBeverage GrindBeans(bool grounded)
        {
            IsGrounded = grounded;
            return this;
        }
        public IMakeBeverage AddWater(int ml)
        {
            Water += ml;
            return this;
        }
        public IMakeBeverage AddSteamedMilk(int ml)
        {
            SteamedMilk = ml;
            return this;
        }
        public IMakeBeverage AddMilkFoam(int ml)
        {
            MilkFoam = ml;
            return this;
        }
        public IMakeBeverage AddChocolateSyrup(int ml)
        {
            ChocolateSyrup = ml;
            return this;
        }
        public IMakeBeverage AddWhippedCream(int ml)
        {
            WhippedCream = ml;
            return this;
        }

        public IMakeBeverage Serve()
        {
            return this;
        }

        public void YourOrder()
        {
            Console.WriteLine("Coffee Name: {0}, Used bean: {1} , grounded: {2}, water: {3} ml, steamed milk: {4} ml, milkfoam {5}, chocolate: {6}, cream: {7} ml", Name, BeanType, IsGrounded, Water, SteamedMilk, MilkFoam, ChocolateSyrup, WhippedCream);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            IMakeBeverage espresso = new FluentCoffee().CoffeeName(Coffee.Espresso).AddBeans(Beans.Liberia).GrindBeans(true).AddWater(30);
            espresso.YourOrder();

            //ITopping mocha = new FluentCoffee().CoffeeName(Coffee.Mocha).AddBeans(Beans.Robusta).GrindBeans(true).     //.AddWater(30).AddChocolateSyrup(20).AddSteamedMilk(25).AddWhippedCream(20).Serve();
            //mocha.YourOrder();

            //ITopping americano = new FluentCoffee().CoffeeName(Coffee.Americano).AddBeans(Beans.Arabica).GrindBeans(true).BaseWater(30).AddWater(60).YourOrder();
            //americano.YourOrder();

            Console.ReadKey();

        }
    }*/
}
