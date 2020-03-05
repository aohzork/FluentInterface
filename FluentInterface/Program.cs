using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterface
{
    public enum Coffee
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
    public interface ICoffeeName
    {
        ICoffeeBase CoffeeName(Coffee coffee);
    }

    public interface ICoffeeBase
    {
        ICoffeeBase AddBeans(Beans beans);
        ICoffeeBase GrindBeans(bool grounded);
        ITopping BaseWater(int ml);
    }

    public interface ITopping
    {
        IOrder AddWater(int ml);
        IOrder AddSteamedMilk(int ml);
        IOrder AddMilkFoam(int ml);
        IOrder AddChocolateSyrup(int ml);
        IOrder AddWhippedCream(int ml);
       // IOrder Serve();
    }

    public class Espresso: ICoffeeName, ICoffeeBase
    {

    }

    public interface IOrder
    {
        void YourOrder();
    }
    
    class FluentCoffee : ICoffeeName, ICoffeeBase, ITopping, IOrder
    {
        public string Name { get; set }
        public string BeanType { get; set; }
        public bool IsGrounded { get; set; }
        public int Water { get; set }
        public int ToppingWater { get; set; }
        public int SteamedMilk { get; set; }
        public int MilkFoam { get; set; }
        public int ChocolateSyrup { get; set; }
        public int WhippedCream { get; set; }


        /*private FluentCoffee()
        {

        }*/

        /*public static ServeUp CreateFluentCoffee()
        {
            return new FluentCoffee();
        }*/

        public ICoffeeBase CoffeeName(Coffee coffee)
        {
            Name = coffee.ToString();
            return this;
        }

        public ICoffeeBase AddBeans(Beans beans)
        {
            BeanType = beans.ToString();
            return this;
        }
        public ICoffeeBase GrindBeans(bool grounded)
        {
            IsGrounded = grounded;
            return this;
        }
        public ITopping BaseWater(int ml)
        {
            Water = ml;
            return this;
        }

        public IOrder AddWater(int ml)
        {
            ToppingWater = ml;
            return this;
        }

        public IOrder AddSteamedMilk(int ml)
        {
            SteamedMilk = ml;
            return this;
        }
        public IOrder AddMilkFoam(int ml)
        {
            MilkFoam = ml;
            return this;
        }
        public IOrder AddChocolateSyrup(int ml)
        {
            ChocolateSyrup = ml;
            return this;
        }
        public IOrder AddWhippedCream(int ml)
        {
            WhippedCream = ml;
            return this;
        }

        public void Serve()
        {
            Console.WriteLine("Coffee Name: {0}, Used bean: {1} , grounded: {2}, water: {3} ml, steamed milk: {4} ml, milkfoam {5}, chocolate: {6}, cream: {7} ml", Name, BeanType, IsGrounded, ToppingWater, SteamedMilk, MilkFoam, ChocolateSyrup, WhippedCream);
        }

        public void YourOrder()
        {
            Console.WriteLine("Coffee Name: {0}, Used bean: {1} , grounded: {2}, water: {3} ml, steamed milk: {4} ml, milkfoam {5}, chocolate: {6}, cream: {7} ml", Name, BeanType, IsGrounded, ToppingWater, SteamedMilk, MilkFoam, ChocolateSyrup, WhippedCream);
            
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            ITopping espresso = new FluentCoffee().CoffeeName(Coffee.Espresso).AddBeans(Beans.Liberia).GrindBeans(true).BaseWater(30)
            espresso.YourOrder();

            ITopping mocha = new FluentCoffee().CoffeeName(Coffee.Mocha).AddBeans(Beans.Robusta).GrindBeans(true).     //.AddWater(30).AddChocolateSyrup(20).AddSteamedMilk(25).AddWhippedCream(20).Serve();
            mocha.YourOrder();

            ITopping americano = new FluentCoffee().CoffeeName(Coffee.Americano).AddBeans(Beans.Arabica).GrindBeans(true).BaseWater(30).AddWater(60).YourOrder();
            //americano.YourOrder();

            Console.ReadKey();

        }
    }
}
