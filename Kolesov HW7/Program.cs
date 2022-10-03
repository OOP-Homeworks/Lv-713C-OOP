using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace TASKS7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK1

            string readPath = @"D:\SoftServe\FileWorks\TASK7\data.txt";
            string writePath = @"D:\SoftServe\FileWorks\TASK7\rez.txt";

            string text = "";


            try
            {
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    text = sr.ReadToEnd();

                }

                File.WriteAllText(writePath, text);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //TASK2

            string pathsave = @"D:\SoftServe\FileWorks\TASK7\DirectoryD.txt";
            string path = @"D:\";





            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] dirs = dir.GetDirectories();



            try
            {
                using (StreamWriter sw = new StreamWriter(pathsave, false, System.Text.Encoding.Default))
                {
                    foreach (DirectoryInfo d in dirs)
                    {
                        sw.WriteLine($"Name: {d.Name}\nFull Name: {d.FullName}\nRoot: {d.Root}\n\n");
                    }
                    foreach (FileInfo f in files)
                    {
                        sw.WriteLine($"Name: {f.Name}\nFull Name: {f.FullName}\nSize: {f.Length}");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //TASK3

            string pathRead = @"D:\";

            DirectoryInfo direct = new DirectoryInfo(pathRead);
            FileInfo[] files1 = dir.GetFiles();


            try
            {
                foreach (FileInfo file in files1)
                {
                    if (file.Extension == ".txt")
                    {
                        using (StreamReader sr = new StreamReader(file.FullName))
                        {
                            Console.WriteLine(file.Name);
                            Console.WriteLine(sr.ReadToEnd());
                        }
                    }

                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //HW1

            string readpath = @"D:\SoftServe\FileWorks\TASK7\phones.txt";
            string writepath = @"D:\SoftServe\FileWorks\TASK7\PhonesNumbers.txt";
            string newPath = @"D:\SoftServe\FileWorks\TASK7\NewPhones.txt";

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            try
            {
                phoneBook = File.ReadAllLines(readpath)
                    .Take(9)
                    .Select(x => x.Split(' '))
                    .ToDictionary(x => x[0], x => x[1]);

                File.WriteAllLines(writepath, phoneBook.Values);
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }

            a1:
            try
            {
                Console.WriteLine("Enter a search name");
                string name = Console.ReadLine();
                Console.WriteLine(phoneBook[name]);
            }
            catch(KeyNotFoundException)
            {
                Console.Clear();
                Console.WriteLine("Name not found, try again");
                goto a1;
            }

            
            using (StreamWriter sw = new StreamWriter(newPath, false, System.Text.Encoding.Default))
            foreach (string dict in phoneBook.Values)
            {
                string pattern1 = (@"[\+][0-9]{12}");
                string pattern2 = (@"[0-9]{11}");
                if (!Regex.IsMatch(dict, pattern1))
                {
                    if(Regex.IsMatch(dict, pattern2))
                    {
                        sw.WriteLine("+3" + dict);
                    }

                }
                else
                    {
                        sw.WriteLine(dict);
                    }

            }







        }
    }
}
