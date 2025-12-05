using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KolganenkoRV.Sprint6.Task6.V1.Lib
{
    public class DataService : ISprint6Task6V1
    {
        public string CollectTextFromFile(string path)
        {
            StringBuilder result = new StringBuilder();

            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                // Пропускаем пустые строки
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                // Разделяем строку на слова (по пробелам)
                string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Если в строке есть хотя бы одно слово
                if (words.Length > 0)
                {
                    // Добавляем первое слово в результат
                    result.Append(words[0]);

                    // Добавляем пробел между словами (кроме последнего)
                    result.Append(" ");
                }
            }

            // Убираем последний пробел и возвращаем результат
            return result.ToString().Trim();
        }
    }
}
