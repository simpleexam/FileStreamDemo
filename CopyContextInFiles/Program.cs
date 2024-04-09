namespace CopyContextInFiles
{
    internal class Program
    {
        const string path = "alltext.txt"; //статическая константа - имя файла для записи данных
        static void Main(string[] args)
        {
            File.Create(path).Close(); //создается новый файл alltext.txt - при каждом перезапуске заново

            Console.WriteLine("введите путь к файлу, содержимое которого нужно считать");
            
            //считывание в цикле содержимого файла (пока не пользователь не введет пустую строку)
            string tempPath;
            
            while((tempPath = Console.ReadLine())!="")
            {
                WriteToFile(File.ReadAllText(tempPath)); //вызоы метода для записи в файл
            }
        }

        internal static void WriteToFile(string text)
        {
            using (FileStream fs = new FileStream("alltext.txt", FileMode.Append, FileAccess.Write)) //открытие файлового потока
            {
                using(StreamWriter writer = new StreamWriter(fs)) //открытие потокового писателя
                {
                    //запись в формате:
                    //-------------------------
                    //какой то текст из файла
                    writer.Write($"-------------------------\n{text}\n\n") ;
                }
            }
        }
    }
}
