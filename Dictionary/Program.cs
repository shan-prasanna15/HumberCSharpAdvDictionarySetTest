using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            City stJohns = new City(545, "Newfoundland and Labrador");
            City charlottetown = new City(585, "Prince Edward Island");
            City halifax = new City(345, "Nova Scotia");
            City toronto = new City(87575, "Ontario");
            City fredericton = new City(575765, "New Brunswick");
            City quebecCity = new City(79875, "Quebec");
            City winnipeg= new City(64, "Manitoba");
            City regina = new City(55, "Saskatchewan");
            City edmonton = new City(123, "Alberta");
            City Victoria = new City(94944, "British Columbia");
            City iqaluit = new City(5, "Nunavut");
            City yellowknife = new City(10, "North West Territories");
            City whiteHorse= new City(785, "Yukon");

            Dictionary<string, City> capitalCities = new Dictionary<string, City>();
            capitalCities.Add("StJohns", stJohns);
            capitalCities.Add("Charlotte Town", charlottetown);
            capitalCities.Add("Halifax", halifax);
            capitalCities.Add("Toronto", toronto);
            capitalCities.Add("Fredericton", fredericton);
            capitalCities.Add("Quebec City", quebecCity);
            capitalCities.Add("Winnipeg", winnipeg);
            capitalCities.Add("Regina", regina);
            capitalCities.Add("Edmonton", edmonton);
            capitalCities.Add("Victoria", Victoria);
            capitalCities.Add("Iqaluit", iqaluit);
            capitalCities.Add("Yellowknife", yellowknife);
            capitalCities.Add("WhiteHorse", whiteHorse);            

            HashSet<string> topTenMostPopulated = new HashSet<string>();
            topTenMostPopulated.Add("Mexico");
            topTenMostPopulated.Add("New York");
            topTenMostPopulated.Add("Los Angeles");
            topTenMostPopulated.Add("Toronto");
            topTenMostPopulated.Add("Chicago");
            topTenMostPopulated.Add("Houston");
            topTenMostPopulated.Add("Havana");
            topTenMostPopulated.Add("Ecatepec de Morelos");
            topTenMostPopulated.Add("Montreal");
            topTenMostPopulated.Add("Philadelphia");


            HashSet<string> citiesOfCanada = new HashSet<string>(capitalCities.Keys);

            topTenMostPopulated.IntersectWith(citiesOfCanada);
            foreach (string val_ in topTenMostPopulated) {
                Console.WriteLine(val_);
            }
        }


        class City {
            public City(int pop , string prov)
            {
                this.population = pop;
                this.province = prov;
            }

            public int population { get; set; }
            public string province { get; set; }
        }
    }
}



