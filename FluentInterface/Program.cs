using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterface
{
      

    public enum BeanType
    {
        Arabica,
        Robusta,
        Liberia
    }


    public interface IMakeBeverage
    {

        IMakeBeverage AddBeans(BeanType beanType);
        IMakeBeverage GroundBeans(bool grounded);
        IMakeBeverage AddWater(int ml);
        IMakeBeverage AddSteamedMilk(int ml);
        IMakeBeverage AddMilkFoam(int ml);
        IMakeBeverage AddChocolateSyrup(int ml);
        IMakeBeverage AddWhippedCream(int ml);
        IMakeBeverage Serve();
        void YourOrder();
    }

    /*public interface ServeUp
    {
        
    }*/

    
    class FluentCoffee : IMakeBeverage
    {
        public string BeanType { get; set; }


        public bool IsGrounded { get; set; }
        public int Water { get; set; }

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

        public IMakeBeverage AddBeans(BeanType beanType)
        {
            BeanType = beanType.ToString();
            return this;
        }
        public IMakeBeverage GroundBeans(bool grounded)
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
            Console.WriteLine("Used bean: {0} , grounded: {1}, water: {2} ml, steamed milk: {3} ml, milkfoam {4}, chocolate: {5}, cream: {6} ml", BeanType, IsGrounded, Water, SteamedMilk, MilkFoam, ChocolateSyrup, WhippedCream);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            IMakeBeverage espresso = new FluentCoffee().AddBeans(BeanType.Liberia).GroundBeans(true).AddWater(30).Serve();
            espresso.YourOrder();

            IMakeBeverage mocha = new FluentCoffee().AddBeans(BeanType.Robusta).GroundBeans(true).AddWater(30).AddChocolateSyrup(20).AddSteamedMilk(25).AddWhippedCream(20).Serve();
            mocha.YourOrder();

            IMakeBeverage americano = new FluentCoffee().AddBeans(BeanType.Arabica).GroundBeans(true).AddWater(30).AddWater(60).Serve();
            americano.YourOrder();

            Console.ReadKey();

        }
    }
}
