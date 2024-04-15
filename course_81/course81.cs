using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
public class Program
{
    public static void Main()
    {
        Country country1 = new Country()
        {
            Code = "AUS",
            Name = "AUSTRALIA",
            Capital = "Canberra"
        };

        Country country2 = new Country()
        {
            Code = "IND",
            Name = "INDIA ",
            Capital = "New Delhi"
        };

        Country country3 = new Country()
        {
            Code = "USA",
            Name = "UNITED STATES",
            Capital = "Washington D.C."
        };

        Country country4 = new Country()
        {
            Code = "GBR",
            Name = "UNITED KINGDOM",
            Capital = "London"
        };

        Country country5 = new Country()
        {
            Code = "CAN",
            Name = "CANADA",
            Capital = "Ottawa"
        };

        Dictionary<string, Country> dictionaryCountry = new Dictionary<string, Country>();
        dictionaryCountry.Add(country1.Code, country1);
        dictionaryCountry.Add(country2.Code, country2);
        dictionaryCountry.Add(country3.Code, country3);
        dictionaryCountry.Add(country4.Code, country4);
        dictionaryCountry.Add(country5.Code, country5);

        string struserChooice = String.Empty;
        do
        {
            Console.WriteLine("Please entter the country code: ");
            string strCountryCode = Console.ReadLine().ToUpper();

            Country resultCountry = dictionaryCountry.ContainsKey(strCountryCode) ? dictionaryCountry[strCountryCode] : null;
            if (resultCountry == null)
            {
                Console.WriteLine("Country Code not valid");
            }
            else
            {

                Console.WriteLine("Nmae = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
            }
            do
            {
                Console.WriteLine("do you want to continue: yes or no");
                struserChooice = Console.ReadLine().ToUpper();
            } while (struserChooice != "NO" && struserChooice != "YES");
        } while (struserChooice == "YES");

    }
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }

    }
}
