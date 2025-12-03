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

            // Создаем массив для хранения значений второго столбца и индексов строк
            int[] secondColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                secondColumn[i] = matrix[i, 1];
            }

            // Сортируем индексы строк по значениям второго столбца
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (secondColumn[j] > secondColumn[j + 1])
                    {
                        // Меняем значения во вспомогательном массиве
                        int temp = secondColumn[j];
                        secondColumn[j] = secondColumn[j + 1];
                        secondColumn[j + 1] = temp;

                        // Меняем строки в результирующем массиве
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
