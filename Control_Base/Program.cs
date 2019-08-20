using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Base
{
    public struct City
    {
        public string Cities;
        public string Population;
        public string Area;


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter list of the cities");
            string input = Console.ReadLine();
           
            string longestName = string.Empty;
            string maxPopulated = string.Empty;
            int maxNumber = 0;
            double population = 0;
            double destiny;
            string[] cities = input.Split(';');
            City[] city = new City[cities.Length];
            double area = 0;
           
            for (int i = 0; i < cities.Length; i++)
            {

                city[i].Cities = cities[i].Split('=')[0];
                city[i].Population = cities[i].Split(',')[0].Split('=')[1];
                city[i].Area = cities[i].Split(',')[1].Split(';')[0];

                if (longestName.Length < city[i].Cities.Length)
                {
                    longestName = city[i].Cities.Trim(' ');
                }

                if (int.TryParse(city[i].Population, out int numb))
                {
                    if (maxNumber < numb)
                    {
                        maxNumber = numb;
                        maxPopulated = city[i].Cities.Trim(' ');
                        
                    }

                }
                
            }
            Console.Clear();
            Console.WriteLine($"Most populated: {maxPopulated} ({maxNumber} people).");
            Console.WriteLine($"Longest name: {longestName} ({longestName.Length} letters).");
            Console.WriteLine("Density:");
            for (int j = 0; j < cities.Length; j++)
            {
                if (double.TryParse(city[j].Population, out double numb))
                {
                    population = numb;                                                                   

                }

                if (double.TryParse(city[j].Area, out double ar))
                {
                    area = ar;
                }
               destiny = population / area;
                double destiny1 = Math.Round(destiny, 2);
                Console.WriteLine($"\t{city[j].Cities} - {destiny1}.");

            }
                                         
            
            Console.ReadKey();                   
                                                               

        }
    }
}
