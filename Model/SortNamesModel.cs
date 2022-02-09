namespace Model
{
    public class SortNamesModel
    {
        /*
         
         */
        public SortedDictionary<string, string> SortNames(List<string> unsortedNames, string fileLocation)
        {
            
            SortedDictionary<string, string> sortedNames = new SortedDictionary<string, string>();

            foreach (string name in unsortedNames)
            {
                sortedNames.Add(GenerateKey(name.Trim()), name);
            }

            var newFile = File.Create(fileLocation);

            newFile.Close();

            File.WriteAllLines(fileLocation, sortedNames.Values);

            return sortedNames;

        }

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