using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.ListCollection
{
    class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
    }

    class DictionaryOverListCl
    {
        static void Main()
        {
            string countryCodeInp;
            string isContinue = string.Empty;
            Country findResult;

            Country country1 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };
            Country country2 = new Country() { Code = "IND", Name = "INDIA", Capital = "New Delhi" };
            Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "Washington D.C." };
            Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };

            Dictionary< string,Country> countryList = new Dictionary<string, Country>();
            countryList.Add(country1.Code, country1);
            countryList.Add(country2.Code, country2);
            countryList.Add(country3.Code, country3);
            countryList.Add(country4.Code, country4);

            do
            {
                Console.WriteLine("Please enter the country code");
                countryCodeInp = Console.ReadLine();
                countryList.TryGetValue(countryCodeInp, out findResult);
                if (findResult != null)
                {
                    Console.WriteLine("Country : {0}, Capital : {1}", findResult.Name, findResult.Capital);
                }
                else
                {
                    Console.WriteLine("Country code not found");
                }

                do
                {
                    Console.WriteLine("Do you want to continue? YES or NO");
                    isContinue = Console.ReadLine().ToUpper();
                } while (isContinue != "YES" && isContinue != "NO");

            } while (isContinue == "YES");

            //List<Country> countryList = new List<Country>();
            //countryList.Add(country1);
            //countryList.Add(country2);
            //countryList.Add(country3);
            //countryList.Add(country4);

            //do
            //{
            //    Console.WriteLine("Please enter the country code");
            //    countryCodeInp = Console.ReadLine();
            //    findResult = countryList.Find(_c => _c.Code == countryCodeInp);
            //    if (findResult != null)
            //    {
            //        Console.WriteLine("Country : {0}, Capital : {1}", findResult.Name, findResult.Capital);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Country code not found");
            //    }

            //    do
            //    {
            //        Console.WriteLine("Do you want to continue? YES or NO");
            //        isContinue = Console.ReadLine().ToUpper();
            //    } while (isContinue != "YES" && isContinue != "NO");

            //} while (isContinue == "YES");

            Console.ReadKey();
        }
    }
}
