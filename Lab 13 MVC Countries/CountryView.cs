using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab_13_MVC_Countries
{
    internal class CountryView
    {
        public Country DisplayCountry { get; set; }
        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }

        //This method will print out the Name,Continent, and Colors of the Country CountryDisplay property
        public void Display()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("COUNTRY DISPLAY: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
           
            Console.WriteLine($"Name: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("FLAG COLORS: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");


            foreach (string c in DisplayCountry.Colors)
            {
                string color = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(c);
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(color);
                Console.BackgroundColor = Enum.Parse<ConsoleColor>(color);
                Console.WriteLine(c);
                Console.ResetColor();
            }
           
        }
    }
}
