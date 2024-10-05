using System.Security.Cryptography.X509Certificates;

namespace ASS2Assignment2
{

    public class BabyDress
    {
        public int Size { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public BabyDress(int size, string color, string brand, double price)
        {
            Size = size;
            Color = color;
            Brand = brand;
            Price = price;

        }
    }
    public class BabyDressUtility
    {
        public void AddDressToCart(BabyDress dress)
        {

        }
        public bool RemoveDressFromCart(string brand) {

            return Program.DressCart.Remove(Program.DressCart.Find(f=>f.Brand == brand));



            int count = 0;
            for(int i = 0;i<Program.DressCart.Count-1; i--)
            {
                if(Program.DressCart[i].Brand == brand)
                {
                    count++;
                }
            }
            return count > 0;

        }

    }
    public class Program
    {
        public static List<BabyDress> DressCart { get; set; } = new List<BabyDress>();
        public static void Main(string[] args)
        {
            BabyDressUtility utility = new BabyDressUtility();
            while (true)
            {
                Console.WriteLine("1.AddDressToCart");
                Console.WriteLine("2.RemoveDressFromCart ");
                Console.WriteLine("3.Exit");

            
            Console.WriteLine("Enter your choice");
            int choices = int.Parse(Console.ReadLine());
                switch (choices)
                {
                    case 1:
                        Console.WriteLine("enter the size");
                        int Size = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter the color");
                        string Color = Console.ReadLine();
                        Console.WriteLine("enter the brand");
                        string Brand = Console.ReadLine();
                        Console.WriteLine("enetr the price");
                        double Price = double.Parse(Console.ReadLine());
                        BabyDress dress = new BabyDress(Size, Color, Brand, Price);
                        utility.AddDressToCart(dress);
                        Console.WriteLine("Successfully added to the dress cart");
                        break;
                    case 2:
                        Console.WriteLine("enter the brand to remove");
                        string removedBrand = Console.ReadLine();
                        if (utility.RemoveDressFromCart(removedBrand))
                        {
                            Console.WriteLine("Successfully removed from the cart");
                        }
                        else
                        {
                            Console.WriteLine("Dress not found in the cart");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Thank you");
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            }

        


        }
    }
}
