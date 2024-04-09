namespace ReadLineFromText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //построчно вводится текст в консоли
            //текст считывается и построчно записывается в файл
            Console.WriteLine("введите построчно текст, введенный пробел - окончание ввода");

            using (FileStream fs = new FileStream("data.txt",
                FileMode.OpenOrCreate, FileAccess.Write))
            {
                string line;
                StreamWriter sw = new StreamWriter(fs);
                do
                {
                    line = Console.ReadLine();
                    sw.WriteLine(line);

                }
                while (line!=" ");
                sw.Close();
            }
             
        }
    }
}
