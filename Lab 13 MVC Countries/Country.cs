using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab_13_MVC_Countries
{
    internal class Country
    {
        //properties
    
        public string Name { get; set; }
        public Continent Continent { get; set; }
        public  List<string> Colors { get; set; }

        //Constructor

        public Country(string Name, Continent Continent,List<string> Colors)
        {
            this.Name = Name;
            this.Continent = Continent;
            this.Colors = Colors;
        }

    }

    public enum Continent : int
    {
        //How can I add space in enum??
        Asia,        
        East_Asia,       
        Asia_Middle_East,       
        East_Africa,      
        North_America,       
        Aouth_America,      
        Africa,      
        Europe

    }
}
