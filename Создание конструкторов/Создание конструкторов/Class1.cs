using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesInDirectory
{
    class GameFolder
    {
        private string folderPath;
        public GameFolder(string folderPath)
        {
            this.folderPath = folderPath;
        }

        // Метод для подсчета количества игр в папке
        public int CountGames()
        {
            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("Папка не найдена!");
                return 0;
            }

            // Получаем список всех файлов с расширением .exe в указанной папке
            string[] gameFiles = Directory.GetFiles(folderPath, "*.exe", SearchOption.TopDirectoryOnly);

            // Возвращаем количество игр
            return gameFiles.Length;
        }

        // Метод для отображения количества игр
        public void ShowGameCount()
        {
            int gameCount = CountGames();
            Console.WriteLine($"Количество игр в папке: {gameCount}");
        }
    }