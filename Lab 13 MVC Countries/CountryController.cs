using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab_13_MVC_Countries
{
    internal class CountryController
    {
        public List<Country> CountryDb { get; set; } = new List<Country>()
        {
            
            new Country("Cambodia",Continent.Asia, new List<string> {"Blue      ","Red       ","White     "}),
            new Country("Japan",Continent.East_Asia, new List<string> {"Red       ","White     "}),
            new Country("North Korea",Continent.East_Asia, new List<string> {"Red       ","Yellow    "}),
            new Country("South Korea",Continent.East_Asia, new List<string> {"Red       ","White     ","Blue      ","Black     "}),
            new Country("Iraq",Continent.Asia_Middle_East, new List<string> {"Red       ","White     ","Black     "}),
            new Country("Kuwait",Continent.Asia_Middle_East, new List<string> {"Black     ","Red       ","White     ","Green     "}),
            new Country("Burundi",Continent.Africa, new List<string> {"Green     ","White     ","Red       "}),
            new Country("Rwanda",Continent.East_Africa, new List<string> {"Blue      ","Yellow    ","Green     "}),
            new Country("Seychelles",Continent.East_Africa, new List<string> {"Blue      ","Yellow    ","Red       ","White     ","Green     "}),
            new Country("Cyprus",Continent.Europe, new List<string> {"Green     ","White     ","Yellow    "}),
            new Country("Estonia",Continent.Europe, new List<string> {"Blue      ","White     ","Black     "}),
            new Country("Germany",Continent.Europe, new List<string> {"Black     ","Red       ","Yellow    "}),
            new Country("Barbados",Continent.North_America, new List<string> {"Blue      ","Yellow    ","Black     "}),
            new Country("USA",Continent.North_America, new List<string> {"Red       ","White     ","Blue      "}),
            new Country("Canada",Continent.North_America, new List<string> {"Red       ","White     "}),
            new Country("Venezuala",Continent.Aouth_America, new List<string> {"Yellow    ","Red       ","Blue      "}),
            new Country("Suriname",Continent.Aouth_America, new List<string> {"Yellow     ","Red        ","Green      "}),
            new Country("Aruba",Continent.Aouth_America, new List<string> { "Blue      ","Yellow    ","Red       " }),
            



        };

        public CountryController() { }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            
            cv.Display();
        }
        public void WelcomeAction()
        {
            bool goAgain = true;
            while(goAgain)
            {
                try
                {
                    CountryListView cvl = new CountryListView(CountryDb);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                    Console.WriteLine("Hello, welcome to the country app.Please select a country from the following list: ");
                    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                    Console.ResetColor();
                    cvl.Display();
                    int index = int.Parse(Console.ReadLine());
                    CountryAction(CountryDb[index]);
                }
                catch (FormatException e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentOutOfRangeException a)
                {
                    Console.WriteLine();
                    Console.WriteLine(a.Message);
                }
                Console.ForegroundColor= ConsoleColor.DarkCyan;
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("Learn Another Country? [YES] OR [NO]: ");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.ResetColor();
                string input = Console.ReadLine().ToUpper().Trim();
                if(input == "YES" || input == "Y")
                {
                    Console.Clear();
                    continue;
                }
                else if (input == "NO" || input == "N")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                    Console.WriteLine("Thank you for viewing the collection.");
                    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                    Console.ResetColor();
                    goAgain = false;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter a Number: ");
                    Console.WriteLine("=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|=|");
                    Console.WriteLine();
                    Console.ResetColor();
                    goAgain = true;
                }
            }
        }
    }
}
