using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;
using System.Xml;

namespace InsuranceApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //globel Variable



            // Methods or Functions
            static int CheckInt(string question, int min, int max)
            {
                while (true)
                {

                    try
                    {
                        Console.WriteLine(question);

                        int userChoice = Convert.ToInt32(Console.ReadLine());


                        if (userChoice >= min && userChoice <= max)
                        {
                            return userChoice;
                        }


                        Console.WriteLine("Error: enter number between 1-3");
                    }
                    catch
                    {

                        Console.WriteLine("Error Please Enter a valid number");

                    }
                }
            }

            static string CheckProceed()
            {

                string proceed;


                while (true)
                {
                    Console.WriteLine("Press <Enter> to addanother devices infomation or type stop to quit");
                    proceed = Console.ReadLine().ToUpper();

                    if (proceed.Equals("") || proceed.Equals("STOP"))
                    {
                        return proceed;
                    }

                    Console.WriteLine("Error: Invlid imput.");

                }


            }

            static void OneDevice()
            {
                int userChoice = 0;
                int deviceAmount = 0;
                int DeviceCost = 0;

                List<string> Laptop = new List<string>();
                List<string> Desktop = new List<string>();
                List<string> other = new List<string>();
                int DeviceAmount = 0;
                double insuranceDiscount = 0.90;
                double deviceInsurance = 0;
                string proceed;
                double priceLoss = 0;
                double priceDecrease = .95;

                // Device Name
                Console.WriteLine("Enter Device Name");
                string deviceName = Console.ReadLine();


                Console.WriteLine();


                // Device Catagory
                userChoice = CheckInt("Enter Device Type\n1.Laptop\n2. Desktop\n3. Other\n-------------------------------------", 1, 3);


                if (userChoice == 1)
                {
                    Laptop.Add("laptop");
                }
                else if (userChoice == 2 - 1)
                {
                    Desktop.Add("Desktop");
                }
                else if (userChoice == 3 - 1) ;
                {
                    other.Add("Other");
                }



                Console.WriteLine($"Device Type Chosen {userChoice}");


                Console.WriteLine("Enter Amount of Devices");
                DeviceAmount = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("Enter Device Cost");
                DeviceCost = Convert.ToInt32(Console.ReadLine());





                if (DeviceAmount <= 5)
                {
                    deviceInsurance = DeviceAmount * DeviceCost;


                }


                else

                    //Device Insurance Calculation

                    deviceInsurance = ((DeviceCost * 5) + (DeviceAmount - 5) * DeviceCost * insuranceDiscount);
                deviceInsurance = Math.Round(deviceInsurance, 2);
                Console.WriteLine($"Your first 5 devices were at ${DeviceCost} each, Your other devices were insured at 10%");



                priceLoss = deviceInsurance * .95;
                Console.WriteLine($"The price Decrese is: {Math.Round(priceLoss, 2)}");
                priceLoss *= priceDecrease;
                Console.WriteLine($"The price Decrese is: {Math.Round(priceLoss, 2)}");
                priceLoss *= priceDecrease;
                Console.WriteLine($"The price Decrese is: {Math.Round(priceLoss, 2)}");
                priceLoss *= priceDecrease;
                Console.WriteLine($"The price Decrese is: {Math.Round(priceLoss, 2)}");
                priceLoss *= priceDecrease;
                Console.WriteLine($"The price Decrese is: {Math.Round(priceLoss, 2)}");
                priceLoss *= priceDecrease;
                Console.WriteLine($"The price Decrese is: {Math.Round(priceLoss, 2)}");
                priceLoss *= priceDecrease;


                Console.WriteLine($"Device name is {deviceName}");
                Console.WriteLine($"Device type is {userChoice}");
                Console.WriteLine($"Amount of devices is {DeviceAmount}");
                Console.WriteLine($"Cost per device {DeviceCost}");
                Console.WriteLine($"your device is insured at {deviceInsurance}");




            }

            //Call Method
            string proceed = "";
            while (proceed.Equals(""))
            {


                // Call OneDevice Method
                OneDevice();


                proceed = CheckProceed();
            }

        }
    }
}

