using System;
using System.Collections.Generic;

namespace Exatensions
{
    public static class StringExstensions
    {
        public static string StringFilter(this String input)
        {
            string newWord = null;
            input = input.ToLower().Replace('(',' ').Replace(')',' ').Replace(',',' ');

            if (input.Contains("novi sad"))
            {
                string string2 = "novi sad";

                string input_part1 = input.Substring(0, input.IndexOf(string2));
                string input_part2 = input.Substring(
                    input.IndexOf(string2) + string2.Length, input.Length - (input.IndexOf(string2) + string2.Length));

                input = input_part1 + input_part2;
            }
            if (input.Contains("sremska mitrovica"))
            {
                string string2 = "sremska mitrovica";

                string input_part1 = input.Substring(0, input.IndexOf(string2));
                string input_part2 = input.Substring(
                    input.IndexOf(string2) + string2.Length, input.Length - (input.IndexOf(string2) + string2.Length));

                input = input_part1 + input_part2;
            }
            if (input.Contains("novi pazar"))
            {
                string string2 = "novi pazar";

                string input_part1 = input.Substring(0, input.IndexOf(string2));
                string input_part2 = input.Substring(
                    input.IndexOf(string2) + string2.Length, input.Length - (input.IndexOf(string2) + string2.Length));

                input = input_part1 + input_part2;
            }

            

            var word = input.ToLower().Split(' ');
            string cityToRemove = null;

            foreach (var item in word)
            {
                foreach (var city in FilterCities())
                {
                    if (item.ToLower() == city.ToLower())
                    {
                        cityToRemove = item;
                    }
                }

                if (!(item == "d.o.o." || item == "DOO" || item == "doo" || item == "a.d." || item.Length < 3 || item == cityToRemove))
                {
                    newWord += " " + item;
                }
            }
            return newWord.Remove(0, 1);
        }

        public static List<string> FilterCities()
        {
            return new List<string>()
            {
                "Beograd",
                "Novi Sad",
                "Niš",
                "Kragujevac",
                "Priština",
                "Subotica",
                "Zrenjanin",
                "Pančevo",
                "Čačak",
                "Kruševac",
                "Kraljevo",
                "Novi Pazar",
                "Smederevo",
                "Leskovac",
                "Vranje",
                "Užice",
                "Valjevo",
                "Šabac",
                "Sombor",
                "Požarevac",
                "Pirot",
                "Zaječar",
                "Kikinda",
                "Sremska Mitrovica",
                "Jagodina",
                "Vršac",
                "Bor",
                "Prokuplje",
                "Loznica",
                "Srbija"
            };
        }
    }
}
