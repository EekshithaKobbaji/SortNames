// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using Model;

namespace SortNames // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
           string unsortedFilepath = @"C:\Users\Bharath\source\repos\SortNames\SortNames\unsorted-names-list.txt";
           string sortedFilepath = @"C:\Users\Bharath\source\repos\SortNames\SortNames\sorted-names-list.txt";

            List<string> unsortedList = new List<string>(File.ReadAllLines(unsortedFilepath));

            SortedDictionary<string,string> sortedNames = new SortedDictionary<string, string>();

            SortNamesModel model = new SortNamesModel();
            sortedNames = model.SortNames(unsortedList, sortedFilepath);
            
            foreach (string sortedList in sortedNames.Values)
            {
                Console.WriteLine(sortedList);
            }
            Console.ReadKey();
        }      
    }
}

/*unsortedList.Add("Janet Parsons");
           unsortedList.Add("Vaughn Lewis");
           unsortedList.Add("Adonis Julius Archer");
           unsortedList.Add("Shelby Nathan Yoder");
           unsortedList.Add("Marin Alvarez");
           unsortedList.Add("London Lindsey");
           unsortedList.Add("Beau Tristan Bently");
           unsortedList.Add("Leo Gardner");
           unsortedList.Add("hunter Uriah Mathew Clarke");M
           unsortedList.Add("Mikayla Lopez");
           unsortedList.Add("Frankie conner Ritter");*/

/*unsortedList.Sort((n1, n2) => n1.Split(" ")[n1.Split(" ").Length - 1]
                       .CompareTo(n2.Split(" ")[n2.Split(" ").Length - 1]));*/
