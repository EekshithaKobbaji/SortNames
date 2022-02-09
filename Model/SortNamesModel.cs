namespace Model
{
    public class SortNamesModel
    {
        /*
         A method to sort the names by taking unsorted names from the text file 
              and gives sorted names as output
         */
        public SortedDictionary<string, string> SortNames(List<string> unsortedNames, string fileLocation)
        {
            
            SortedDictionary<string, string> sortedNames = new SortedDictionary<string, string>();

            foreach (string name in unsortedNames)
            {
                sortedNames.Add(GenerateKey(name.Trim()), name);
            }

            // Write the sorted names by creating a new file.

            var newFile = File.Create(fileLocation);

            newFile.Close();

            File.WriteAllLines(fileLocation, sortedNames.Values);

            return sortedNames;

        }

        /*
          A method that takes input as a value  to generate key 
        that helps to store in SortedDictionary
        */
        public static string GenerateKey(string value)
        {
            string[] names = value.Split(' ');
            string key = "";

            for (int i = names.Length - 1; i >= 0; i--)
            {
                key = key + names[i].ToString();
            }

            return key;
        }



    }
}