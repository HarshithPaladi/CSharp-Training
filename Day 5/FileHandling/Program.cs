using System.Text;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // 1
            FileStream file = new FileStream("D:\\source\\repos\\C# - Training\\Day 5\\filename.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //file.Write(Convert.FromBase64String("This is some text
            file.WriteByte(66);
            Stream stream = new MemoryStream();
            String strtext = "String test test";
            byte[] byteArray = Encoding.UTF8.GetBytes(strtext);
            file.Write(byteArray, 0, byteArray.Length);
            file.Close();

            // 2
            var p = "D:\\source\\repos\\C# - Training\\Day 5\\new.txt";
            File.WriteAllText(p, "This is Harshith");

            // 3
            FileStream file1 = new FileStream("D:\\source\\repos\\C# - Training\\Day 5\\filename.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file1);
            writer.WriteLine("\nHi How are you ~~");
            writer.Close();
            file1.Close();

            // 4
            FileStream file2 = new FileStream("D:\\source\\repos\\C# - Training\\Day 5\\filename.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file2);
            // Print to Console
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            file2.Close();

            // Text Writer
            const string path = "D:\\source\\repos\\C# - Training\\Day 5\\test1.txt";
            using (TextWriter writer1 = File.CreateText(path)) 
            {
                char[] charArray = { 'h', 'e', 'l', 'l', 'o' };
                writer1.WriteLine(charArray,2,3);

                // File info
                Info();
                DirInfo();
            }


        }

        public static void Info()
        {
            string path = "D:\\source\\repos\\C# - Training\\Day 5\\info.txt";
            FileInfo fi = new(path);
            fi.Create();
        }

        public static void DirInfo()
        {
            string dirpath = "D:\\source\\repos\\C# - Training\\Day 5\\dirtest\\";
            DirectoryInfo dr = new(dirpath);
            dr.Create();
        }
    }
}