using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KolganenkoRV.Sprint6.Task3.V23.Lib
{
    public class DataService : ISprint6Task3V23
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = (int[,])matrix.Clone();

            // Пузырьковая сортировка строк по второму столбцу
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    // Сравниваем значения во втором столбце
                    if (result[j, 1] > result[j + 1, 1])
                    {
                        // Меняем строки местами
                        SwapRows(result, j, j + 1, cols);
                    }
                }
            }

            return result;
        }

        private void SwapRows(int[,] array, int row1, int row2, int cols)
        {
            for (int k = 0; k < cols; k++)
            {
                int temp = array[row1, k];
                array[row1, k] = array[row2, k];
                array[row2, k] = temp;
            }
        }
    
    }
}
