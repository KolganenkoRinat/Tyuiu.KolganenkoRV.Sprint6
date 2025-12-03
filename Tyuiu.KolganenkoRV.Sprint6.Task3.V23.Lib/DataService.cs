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

            // Создаем массив значений второго столбца
            int[] secondColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                secondColumn[i] = result[i, 1];
            }

            // Сортируем значения второго столбца по возрастанию
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (secondColumn[j] > secondColumn[j + 1])
                    {
                        // Меняем местами значения во втором столбце
                        int temp = secondColumn[j];
                        secondColumn[j] = secondColumn[j + 1];
                        secondColumn[j + 1] = temp;
                    }
                }
            }

            // Записываем отсортированные значения обратно во второй столбец
            for (int i = 0; i < rows; i++)
            {
                result[i, 1] = secondColumn[i];
            }

            return result;
        }

    }
}
