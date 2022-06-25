using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
       
        static List<OrderItem> OIList=new List<OrderItem>();
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("1.Add item to the store.\n");
                Console.WriteLine("2.Display item.\n");
                Console.WriteLine("3.Exit.\n");
                do
                {
                    Console.WriteLine("Choose your choice:");
                    x = int.Parse(Console.ReadLine());
                    if ((x != 1 && x != 2 && x != 3))
                        Console.WriteLine("Error");
                } while (x != 1 && x != 2 && x != 3);

                if (x == 1)
                {
                    OrderItem OI = new OrderItem();
                    OI.getname();
                    OI.getprice();
                    OI.getno();
                    OI.getpdiscount();
                    OI.Discount = (OI.price * OI.NoOfItem) * OI.percentageDiscount;
                    OI.Total = (OI.price * OI.NoOfItem)- OI.Discount;
                    OIList.Add(OI);
                    Console.Clear();
                }
                else if (x == 2)
                {
                    if (OIList.Count == 0)
                    {
                        Console.Write("no item saved!! ");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Write("No\t\tItem Name\t\tUnit price\t\tItem no\t\tItem Discount\t\tTotal price\n");
                        for (int i = 0; i < OIList.Count; i++)
                        {
                            Console.WriteLine((i + 1) + "\t\t" + OIList[i].name + "\t\t\t" + OIList[i].price + "\t\t\t" + OIList[i].NoOfItem + "\t\t" + OIList[i].Discount + "\t\t\t" + OIList[i].Total);
                            
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

            }while (x==1||x==2);
        }
    }
    class OrderItem
    {
        public String? name;
        public int NoOfItem;
        public double price;
        public double percentageDiscount;
        public double Discount;
        public double Total;

       public void getname()
        {
            Console.Write("Enter the name of item: ");
            name = Console.ReadLine();
            
        }
        public void getprice()
        {  
            do
            {
                Console.Write("Enter the price of item: ");
                price = double.Parse(Console.ReadLine());
                if (price <= 0)
                    Console.Write("error!!\n");
            } while (price <= 0);
          
        }
        public void getno()
        {
           
            do
            {
                Console.Write("Enter the number of item: ");
                NoOfItem = int.Parse(Console.ReadLine());
                if (NoOfItem <= 0)
                    Console.Write("error!!\n");
            } while (NoOfItem <= 0);
        }
        public void getpdiscount()
        {
            
            do
            {
                Console.Write("Enter the Persantage Discount of item: ");
                percentageDiscount = double.Parse(Console.ReadLine());
                if (percentageDiscount <= 0)
                    Console.Write("error!!\n");
            } while (percentageDiscount <= 0);
           
        }
    }
}