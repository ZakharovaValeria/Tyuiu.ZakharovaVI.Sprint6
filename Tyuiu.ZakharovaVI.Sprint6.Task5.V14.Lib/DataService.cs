using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZakharovaVI.Sprint6.Task5.V14.Lib
{
    public class DataService : ISprint6Task5V14
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            string allText = File.ReadAllText(path);
            allText = allText.Replace('.', ',');
            string[] numberStrings = allText.Split(new char[] { ' ', '\t', '\n', '\r' },
                                                StringSplitOptions.RemoveEmptyEntries);


            int len = numberStrings.Length;

            double[] numsArray = new double[len]; 

            int index = 0;

            foreach (string numStr in numberStrings)
            {
                double num = Convert.ToDouble(numStr);

                numsArray[index] = Math.Round(num, 3);
                index++;
            }

            numsArray = numsArray.Where(val => val >= 10).ToArray();

            return numsArray;
        }

    }

}
