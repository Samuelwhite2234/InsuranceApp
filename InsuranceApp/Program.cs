namespace InsuranceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //globel Variable

            int DeviceCost = 0;
            int userChoice = 0;
            List<string> Laptop = new List<string>();
            List<string> Desktop = new List<string>();
            List<string> other = new List<string>();
            int DeviceAmount = 0;

            Console.WriteLine("Enter Device Name");
            String deviceName = Console.ReadLine();



            Console.WriteLine("Enter Device Type");

            Console.WriteLine("1.Laptop");
            Console.WriteLine("2. Desktop");
            Console.WriteLine("3. Other");
            Console.WriteLine("-------------------------------------");
            userChoice =Convert.ToInt32(Console.ReadLine());



            if (userChoice == 1 )
            {
                Laptop.Add("laptop");
            }
            else if (userChoice == 2 - 1)
            {
                Desktop.Add("Desktop");
            }
            else if (userChoice == 3 - 1);
            {
                other.Add("Other");
            }


                Console.WriteLine($"Device Type Chosen {userChoice}");


            Console.WriteLine("Enter Amount of Devices");
            DeviceAmount = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter Device Cost");
            DeviceCost = Convert.ToInt32(Console.ReadLine());




        }
    }
}
