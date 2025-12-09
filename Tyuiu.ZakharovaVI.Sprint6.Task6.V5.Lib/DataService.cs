using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZakharovaVI.Sprint6.Task6.V5.Lib
{
    public class DataService : ISprint6Task6V5
    {
        public string CollectTextFromFile(string path) 
        {
            if (path == null)
            {
                return "Сначала выберите файл";
            }

            string result = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', '\t');

                    foreach (string word in words)
                    {
                        if (!string.IsNullOrEmpty(word))
                        {
                            if (word.Contains("l"))
                            {
                                result += word + " ";
                            }
                        }
                    }
                }
            }

            return result.Trim();
        }
    }
}
