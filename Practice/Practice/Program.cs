using System;


namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella") ;
            
        }


        class Pizza
        {
            String bread;
            String sauce;
            String cheese;
            String topping;

            internal Pizza (string bread, string sauce, string cheese, string topping)
            {
                this.bread = bread;
                this.sauce = sauce;
                this.cheese = cheese;
                this.topping = topping;
            }

            internal Pizza(string bread, string sauce, string cheese)
            {
                this.bread = bread;
                this.sauce = sauce;
                this.cheese = cheese;
            }
        }

    }
}
