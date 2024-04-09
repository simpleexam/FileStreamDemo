namespace FileStreamDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // запись строки "hello" в файл, чтение файла и вывод содержимого на консоль
            
            using (FileStream fs = new FileStream(@"D:\test.txt", 
                FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write("hello");
                }
 
            }

            using (FileStream fs = new FileStream(@"D:\test.txt",
              FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
        }
    }
}
