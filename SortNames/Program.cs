// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using Model;

namespace SortNames {
    class Program
    {
        static void Main(string[] args)
        {
           string unsortedFilepath = @"C:\Users\Bharath\source\repos\SortNames\SortNames\unsorted-names-list.txt";
           string sortedFilepath = @"C:\Users\Bharath\source\repos\SortNames\SortNames\sorted-names-list.txt";

            //To read all the lines in the unsorted-names-list.txt

            List<string> unsortedList = new List<string>(File.ReadAllLines(unsortedFilepath));

        

            SortedDictionary<string,string> sortedNames = new SortedDictionary<string, string>();

            /*
             created an object of SortNamesModel to
              SortNames method to generate output 
            */

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

