namespace CoffeeShop
{
    internal class Program
    {
        static void Main()
        {
            double price=1.0;
            string coffeeType="coffee";
            string CoffeeSize="small";
            //bool  Milk=true;
            //bool sugar=false;
            string wantSugar = "yes";
            string wantMilk = "yes";


            Console.WriteLine("Welcome to the Coffee Shop!");
            Console.WriteLine("Menu : \n 1.Americano - $2.50 \n 2.Latte - $3.00 \n 3.Cappuccino - $3.50");

           //Coffee Type 
            Console.WriteLine("Select a coffee (1-3):");
            int CustomerCoffee = Convert.ToInt16(Console.ReadLine());
            if (CustomerCoffee == 1)
            {
                price = 2.50;
                coffeeType = "Americano";

            }
            else if (CustomerCoffee == 2)
            {
                price = 3.00;
                coffeeType = "Latte";

            }
            else if (CustomerCoffee==3){
                price = 3.50;
                coffeeType = "Cappuccino";
            }
            else
            {
                Console.WriteLine("Please Select your coffee type ");
            }

            //Coffee Size 
            Console.WriteLine("Customizations: \n"+
                "1.Small\r\n"+
                "2.Medium\r\n"+
                "3.Large");
            Console.WriteLine("Select a size (1-3):");
            int size = Convert.ToInt16(Console.ReadLine());
            if (size == 1)
            {
                CoffeeSize = "Small";

            }
            else if (size == 2)
            {
                CoffeeSize = "Medium";
            }
            else if (size == 3)
            {
                CoffeeSize = "Large";
            }
            else
            {
                Console.WriteLine("Please Select your prefered size ");
            }

            // asking the customer if he want sugar or not  
            Console.WriteLine("Do you want sugar? (yes/no): ");
            string WantSugar = Console.ReadLine();
            if (WantSugar == "yes" || WantSugar == "Yes")
            {
                wantSugar = "with suger";


            }
            else
            {
                wantSugar = "without suger";


            }

            //Asking if the customer want milk or not 
            Console.WriteLine("Do you want milk? (yes/no):  ");
            string WantMilk = Console.ReadLine();
            if (WantMilk == "yes" || WantMilk == "Yes")
            {
                wantMilk = "with milk";
               

            }
            else
            {
                wantMilk="without milk";

            }

            //The Order Summery Output
            Console.WriteLine(" Your Order Summary: " + coffeeType + " ( " + CoffeeSize + " ) " + wantSugar +" "+ wantMilk +" .");
            Console.WriteLine("Total Cost: " + price);
            Console.WriteLine("Thank you for ordering!");









        }
    }
}