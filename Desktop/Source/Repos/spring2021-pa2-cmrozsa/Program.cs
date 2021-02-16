using System;

namespace spring2021_pa2_cmrozsa
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = " ";
            while(choice != "3")
            {
                choice = GetMenuChoice();
                ErrorHandling(choice);
                Route(choice);
            }
           
            
        }
        static void ErrorHandling(string choice)
        {
            int myChoice = int.Parse(choice);
            if(myChoice < 1 || myChoice > 3)
            {
                Console.WriteLine("Invalid choice, please try again");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
        static string GetMenuChoice()
        {
            Console.WriteLine("Welcome to our app!\nPlease choose an option:");
            Console.WriteLine("1. Convert Currencies\n2. Restaurant POS\n3. Exit");
            return Console.ReadLine();
        }
        static void Route(string myChoice)
        {
            if(myChoice == "1")
            {
                ConvertCurrencies();
            }
            else if(myChoice == "2")
            {
                RestaurantPosSystem();
            }     
        }
        static void ConvertCurrencies()
        {
            
            Console.WriteLine("Welcome to the Currency Conversion Section!");
            Console.WriteLine("Please select and option:\n1. Convert to U.S. Dollars\n2. Convert from U.S. Dollars\n3. Convert to Euros\n4. Convert from Euros\n5. Return to Main Menu");
            string myChoice = Console.ReadLine();
                       
            CurrencyMenuErrorHandling(myChoice);
            RouteCurrencies(myChoice);
            
        }
        static void RouteCurrencies(string myChoice)
        {
                  
            if(myChoice == "1")
            {
                ConvertToDollars(myChoice);
            }
            else if(myChoice == "2")
            {
                ConvertFromDollars(myChoice);
            }           
            else if (myChoice == "3")
            {
                ConvertToEuros(myChoice);
            }  
            else if (myChoice == "4")
            {
                ConvertFromEuros(myChoice);
            }
            
        }
        static void ConvertFromDollars(string choice)
        {
            Console.WriteLine("Please select a currency to convert to: 1. Canadian Dollar\n2. Euro\n3. Indian Rupee\n4. Japenese Yen\n5. Mexican Peso\n6. British Pound");
            string myChoice = Console.ReadLine();
            
            CurrencyErrorHandling(myChoice);
            RouteFromCurrencies(myChoice);
            ConvertCurrencies();
        }
        
        static void ConvertToDollars(string choice)
        {
            Console.WriteLine("Please select a currency to convert from:\n1. Canadian Dollar\n2. Euro\n3. Indian Rupee\n4. Japenese Yen\n5. Mexican Peso\n6. British Pound");
            string myChoice = Console.ReadLine();
            
            CurrencyErrorHandling(myChoice);
            RouteToCurrencies(myChoice);
            ConvertCurrencies();
        }
        static void CurrencyMenuErrorHandling(string choice)
        {
            int myChoice = int.Parse(choice);
            if(myChoice < 1 || myChoice > 5)
            {
                Console.WriteLine("Invalid choice, please try again");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                ConvertCurrencies();
            }
        }
        static void CurrencyErrorHandling(string myChoice)
        {
            int choice = int.Parse(myChoice);
            if(choice < 1 || choice > 6)
            {
                Console.WriteLine("Invalid choice, please try again");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
            
        }

        static void RouteToCurrencies(string myChoice)
        {
               
            if(myChoice == "1")
            {
                CanadianDollar();
            }
            else if(myChoice == "2")
            {
                Euro();
            }  
            else if (myChoice == "3")
            {
                IndianRupee();
            }
            else if (myChoice =="4")
            {
                JapeneseYen();
            }
            else if (myChoice == "5")
            {
                MexicanPeso();
            }
            else if (myChoice == "6")
            {
                BritishPound();
            }
        }
        static void CanadianDollar()
        {
            Console.WriteLine("Please enter the amount of Canadian Dollars you have.");
            double canadianDollars = double.Parse(Console.ReadLine());
            double usDollars = canadianDollars / 0.9813;
            Math.Round(usDollars, 2);
            Console.WriteLine("Your amount in US Dollars is: " + usDollars);

        }
        
        static void Euro()
        {
            Console.WriteLine("Please enter the amount of Euro you have.");
            double euro = double.Parse(Console.ReadLine());
            double usDollars = euro / .757;
            Math.Round(usDollars, 2);
            Console.WriteLine("Your amount in US Dollars is " + usDollars);
        }

        static void IndianRupee()
        {
            Console.WriteLine("Please enter the amount of Indian Rupees you have.");
            double indianRupee = double.Parse(Console.ReadLine());
            double usDollars = indianRupee / 52.53;
            Math.Round(usDollars, 2);
            Console.WriteLine("Your amount in US Dollars is " + usDollars);
        }

        static void JapeneseYen()
        {
            Console.WriteLine("Please enter the amount of Japenese Yen you have.");
            double japeneseYen = double.Parse(Console.ReadLine());
            double usDollars = japeneseYen / 80.92;
            Math.Round(usDollars, 2);
            Console.WriteLine("Your amount in US Dollars is " + usDollars);
        }

        static void MexicanPeso()
        {
            Console.WriteLine("Please enter the amount of Mexican Peso you have.");
            double mexicanPeso = double.Parse(Console.ReadLine());
            double usDollars = mexicanPeso / 13.1544;
            Math.Round(usDollars, 2);
            Console.WriteLine("Your amount in US Dollars is " + usDollars);
        }

        static void BritishPound()
        {
            Console.WriteLine("Please enter the amount of British Pound you have.");
            double britishPound = double.Parse(Console.ReadLine());
            double usDollars = britishPound / 0.6178;
            Math.Round(usDollars, 2);
            Console.WriteLine("Your amount in US Dollars is " + usDollars);
        }
        static void RouteFromCurrencies(string myChoice)
        {
               
            if(myChoice == "1")
            {
                ToCanadianDollar();
            }
            else if(myChoice == "2")
            {
                ToEuro();
            }  
            else if (myChoice == "3")
            {
                ToIndianRupee();
            }
            else if (myChoice =="4")
            {
                ToJapeneseYen();
            }
            else if (myChoice == "5")
            {
                ToMexicanPeso();
            }
            else if (myChoice == "6")
            {
                ToBritishPound();
            }
        }
        static void ToCanadianDollar()
        {
            Console.WriteLine("Please enter the amount of US Dollars you have.");
            double usDollars = double.Parse(Console.ReadLine());
            double canadianDollars = usDollars * 0.9813;
            Math.Round(canadianDollars, 2);
            Console.WriteLine("Your amount in Canadian Dollars is: " + canadianDollars);

        }
        
        static void ToEuro()
        {
            Console.WriteLine("Please enter the amount of US Dollars you have.");
            double usDollars = double.Parse(Console.ReadLine());
            double euro = usDollars * .757;
            Math.Round(euro, 2);
            Console.WriteLine("Your amount in Euros is " + euro);
        }

        static void ToIndianRupee()
        {
            Console.WriteLine("Please enter the amount of US Dollars you have.");
            double usDollars = double.Parse(Console.ReadLine());
            double indianRupee = usDollars * 52.53;
            Math.Round(indianRupee, 2);
            Console.WriteLine("Your amount in Indian Rupees is " + indianRupee);
        }

        static void ToJapeneseYen()
        {
            Console.WriteLine("Please enter the amount of US Dollars you have.");
            double usDollars = double.Parse(Console.ReadLine());
            double japeneseYen = usDollars * 80.92;
            Math.Round(japeneseYen, 2);
            Console.WriteLine("Your amount in Japenese Yen is " + japeneseYen);
        }

        static void ToMexicanPeso()
        {
            Console.WriteLine("Please enter the amount of US Dollars you have.");
            double usDollars = double.Parse(Console.ReadLine());
            double mexicanPeso = usDollars * 13.1544;
            Math.Round(mexicanPeso, 2);
            Console.WriteLine("Your amount in Mexican Pesos is " + mexicanPeso);
        }

        static void ToBritishPound()
        {
            Console.WriteLine("Please enter the amount of US Dollars you have.");
            double usDollars = double.Parse(Console.ReadLine());
            double britishPound = usDollars * 0.6178;
            Math.Round(britishPound, 2);
            Console.WriteLine("Your amount in British Pounds is " + britishPound);
        }
        static void ConvertFromEuros(string choice)
        {
            Console.WriteLine("Please select a currency to convert to: 1. Canadian Dollar\n2. U.S. Dollars\n3. Indian Rupee\n4. Japenese Yen\n5. Mexican Peso\n6. British Pound");
            string myChoice = Console.ReadLine();
            
            CurrencyErrorHandling(myChoice);
            RouteEurosFromCurrencies(myChoice);
            ConvertCurrencies();
        }
        
        static void ConvertToEuros(string choice)
        {
            Console.WriteLine("Please select a currency to convert from:\n1. Canadian Dollar\n2. U.S. Dollars\n3. Indian Rupee\n4. Japenese Yen\n5. Mexican Peso\n6. British Pound");
            string myChoice = Console.ReadLine();
            
            CurrencyErrorHandling(myChoice);
            RouteEurosToCurrencies(myChoice);
            ConvertCurrencies();
        }
        static void RouteEurosToCurrencies(string myChoice)
        {
               
            if(myChoice == "1")
            {
                EurosToCanadianDollar();
            }
            else if(myChoice == "2")
            {
                EurosToUsDollars();
            }  
            else if (myChoice == "3")
            {
                EurosToIndianRupee();
            }
            else if (myChoice =="4")
            {
                EurosToJapeneseYen();
            }
            else if (myChoice == "5")
            {
                EurosToMexicanPeso();
            }
            else if (myChoice == "6")
            {
                EurosToBritishPound();
            }
        }
        static void EurosToCanadianDollar()
        {
            Console.WriteLine("Please enter the amount of Euros you have.");
            double euros = double.Parse(Console.ReadLine());
            double usDollars = euros / .757;
            double canadianDollars = usDollars * .9813;
            Math.Round(canadianDollars, 2);
            Console.WriteLine("Your amount in Canadian Dollars is: " + canadianDollars);

        }
        
        static void EurosToUsDollars()
        {
            Console.WriteLine("Please enter the amount of Euros you have.");
            double euros = double.Parse(Console.ReadLine());
            double usDollars = euros / .757;
            Math.Round(usDollars, 2);
            Console.WriteLine("Your amount in U.S. Dollars is: " + usDollars);
        }

        static void EurosToIndianRupee()
        {
            Console.WriteLine("Please enter the amount of Euros you have.");
            double euros = double.Parse(Console.ReadLine());
            double usDollars = euros / .757;
            double indianRupee = usDollars * 52.53;
            Math.Round(indianRupee, 2);
            Console.WriteLine("Your amount in Indian Rupees is: " + indianRupee);
        }

        static void EurosToJapeneseYen()
        {
            Console.WriteLine("Please enter the amount of Euros you have.");
            double euros = double.Parse(Console.ReadLine());
            double usDollars = euros / .757;
            double japeneseYen = usDollars * 80.92;
            Math.Round(japeneseYen, 2);
            Console.WriteLine("Your amount in Japenese Yen is " + japeneseYen);
        }

        static void EurosToMexicanPeso()
        {
            Console.WriteLine("Please enter the amount of Euros you have.");
            double euros = double.Parse(Console.ReadLine());
            double usDollars = euros / .757;
            double mexicanPeso = usDollars * 13.1544;
            Math.Round(mexicanPeso, 2);
            Console.WriteLine("Your amount in Mexican Pesos is " + mexicanPeso);
        }

        static void EurosToBritishPound()
        {
            Console.WriteLine("Please enter the amount of Euros you have.");
            double euros = double.Parse(Console.ReadLine());
            double usDollars = euros / .757;
            double britishPound = usDollars * .6178;
            Math.Round(britishPound, 2);
            Console.WriteLine("Your amount in British Pounds is " + britishPound);
        }
        static void RouteEurosFromCurrencies(string myChoice)
        {
               
            if(myChoice == "1")
            {
                CanadianDollartoEuros();
            }
            else if(myChoice == "2")
            {
                UsDollarsToEuros();
            }  
            else if (myChoice == "3")
            {
                IndianRupeeToEuros();
            }
            else if (myChoice =="4")
            {
                JapeneseYenToEuros();
            }
            else if (myChoice == "5")
            {
                MexicanPesoToEuros();
            }
            else if (myChoice == "6")
            {
                BritishPoundtoEuros();
            }
        }
        static void CanadianDollartoEuros()
        {
            Console.WriteLine("Please enter the amount of Canadian Dollars you have.");
            double canadianDollars = double.Parse(Console.ReadLine());
            double usDollars = canadianDollars / 0.9813;
            double euros = usDollars * .757;
            Math.Round(usDollars, 2);
            Console.WriteLine("Your amount in Euros is: " + euros);

        }
        
        static void UsDollarsToEuros()
        {
            Console.WriteLine("Please enter the amount of Euro you have.");
            double euro = double.Parse(Console.ReadLine());
            double usDollars = euro / .757;
            Math.Round(usDollars, 2);
            Console.WriteLine("Your amount in US Dollars is " + usDollars);
        }

        static void IndianRupeeToEuros()
        {
            Console.WriteLine("Please enter the amount of Indian Rupees you have.");
            double indianRupee = double.Parse(Console.ReadLine());
            double usDollars = indianRupee / 52.53;
            double euros = usDollars * .757;
            Math.Round(usDollars, 2);
            Console.WriteLine("Your amount in Euros is " + euros);
        }

        static void JapeneseYenToEuros()
        {
            Console.WriteLine("Please enter the amount of Japenese Yen you have.");
            double japeneseYen = double.Parse(Console.ReadLine());
            double usDollars = japeneseYen / 80.92;
            double euros = usDollars * .757;
            Math.Round(usDollars, 2);
            Console.WriteLine("Your amount in Euros is " + euros);
        }

        static void MexicanPesoToEuros()
        {
            Console.WriteLine("Please enter the amount of Mexican Peso you have.");
            double mexicanPeso = double.Parse(Console.ReadLine());
            double usDollars = mexicanPeso / 13.1544;
            double euros = usDollars * .757;
            Math.Round(usDollars, 2);
            Console.WriteLine("Your amount in Euros is " + euros);
        }

        static void BritishPoundtoEuros()
        {
            Console.WriteLine("Please enter the amount of British Pound you have.");
            double britishPound = double.Parse(Console.ReadLine());
            double usDollars = britishPound / 0.6178;
            double euros = usDollars * .757;
            Math.Round(usDollars, 2);
            Console.WriteLine("Your amount in Euros is " + euros);
        }
        static void RestaurantPosSystem()
        {
            Console.WriteLine("Welcome to the Restaurant POS System!");
            double amountDue = CalculatingTotal();
            Math.Round(amountDue, 2);
            Console.WriteLine("Please input the amount paid");
            double amountPaid = double.Parse(Console.ReadLine());
            Math.Round(amountPaid, 2);
            while (amountDue > amountPaid)
            {
                Console.WriteLine("That is not enough money. Please pay more.");
                Console.WriteLine("Please input the amount paid");
                amountPaid = double.Parse(Console.ReadLine());
            }
            if (amountPaid > amountDue)
            {
                double change = amountPaid - amountDue;
                Console.WriteLine("Thank you. You're change is " + change);                
            }
            
        }
        static double CalculatingTotal()
        {
            Console.WriteLine("Please enter your food total:");
            double foodTotal = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your alcohol total:");
            double alcoholTotal = double.Parse(Console.ReadLine());
            double sum = foodTotal + alcoholTotal;
            double tax = AddTax(sum);
            double tip = AddTip(foodTotal);
            double total = sum + tax + tip;
            Math.Round(total, 2);
            Console.WriteLine("Your total after tax and tip is "+ total);
            return total;
        }
        
        static double AddTax(double sum)
        {
            double tax = .09 * sum;
            Console.WriteLine("Your tax is " + tax);
            // double totalTax = 1.09 * sum;
            // Console.WriteLine("Your total with tax is " + totalTax);
            return tax;
        }
        static double AddTip(double foodTotal)
        {
            double tip = .18 * foodTotal;
            Console.WriteLine("Your tip is " + tip);
            // double totalTip = 1.18 * foodTotal;
            // Console.WriteLine("Your total food plus tip is " + totalTip);
            return tip;
        }
    }
}