using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KolganenkoRV.Sprint6.Task7.V27.Lib
{
    public class DataService : ISprint6Task7V27
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            // Определяем размеры матрицы
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            // Создаем матрицу
            int[,] matrix = new int[rows, cols];

            // Заполняем матрицу данными из файла
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            // Изменяем в пятой строке отрицательные числа на -1
            // В C# индексация с 0, поэтому пятая строка имеет индекс 4
            for (int j = 0; j < cols; j++)
            {
                if (matrix[4, j] < 0) // Если число отрицательное в пятой строке
                {
                    matrix[4, j] = -1; // Заменяем на -1
                }
            }

            return matrix;
        }
    }
}
