using System.Linq;
using System.Text;
using System.Threading.Tasks;


using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZakharovaVI.Sprint6.Task3.V8.Lib
{
    public class DataService : ISprint6Task3V8
    {
        public int[,] Calculate(int[,] matrix) 
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] res = (int[,])matrix.Clone();

            int rowIndex = 3;
            for (int j = 0; j < columns; j++)
            {
                if (res[rowIndex, j] % 2 == 0)
                {
                    res[rowIndex, j] = 0;
                }
            }
            return res;
        }
    }
}
