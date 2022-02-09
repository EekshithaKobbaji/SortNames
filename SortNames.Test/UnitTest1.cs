using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace SortNames.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            #region SetInputs
            string fileLocation = @"C:\Users\Bharath\source\repos\SortNames\SortNames\sorted-names-list.txt";

            List<string> names = new List<string>();
            names.Add("Janet Parsons");
            names.Add("Vaughn Lewis");
            names.Add("Adonis Julius Archer");
            names.Add("Shelby Nathan Yoder");
            names.Add("Marin Alvarez");
            names.Add("London Lindsey");
            names.Add("Beau Tristan Bentley");
            names.Add("Leo Gardner");
            names.Add("Hunter Uriah Mathew Clarke");
            names.Add("Mikayla Lopez");
            names.Add("Frankie Conner Ritter");
            #endregion

            #region Set ExpectedOutput
            List<string> expectedOutput = new List<string>();
            expectedOutput.Add("Marin Alvarez");
            expectedOutput.Add("Adonis Julius Archer");
            expectedOutput.Add("Beau Tristan Bentley");
            expectedOutput.Add("Hunter Uriah Mathew Clarke");
            expectedOutput.Add("Leo Gardner");
            expectedOutput.Add("Vaughn Lewis");
            expectedOutput.Add("London Lindsey");
            expectedOutput.Add("Mikayla Lopez");
            expectedOutput.Add("Janet Parsons");
            expectedOutput.Add("Frankie Conner Ritter");
            expectedOutput.Add("Shelby Nathan Yoder");
            #endregion

            SortNamesModel model = new SortNamesModel();
            SortedDictionary<string, string> sortedNames = model.SortNames(names, fileLocation);

            bool check = expectedOutput.SequenceEqual(sortedNames.Values.ToList());

            Assert.IsTrue(check);

        }
    }
}