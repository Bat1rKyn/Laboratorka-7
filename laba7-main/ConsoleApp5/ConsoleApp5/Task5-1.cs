using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp5
{
    public static class Task5_1
    {
        private static string _urlFileName;
        private static int _len;


        public static int RadnomSymbvol(int minVal, int maxVal)
        {
            Random rnd = new Random();
            return rnd.Next(minVal, maxVal+1);

        }

        public static void Createfile(string urlFileName, int count, 
            int minVal,int maxVal, bool flag)
        {
            _len = count;
            StreamWriter sw = new StreamWriter(urlFileName);
            Console.WriteLine($"Файл создан: {urlFileName}");
            int random = RadnomSymbvol(minVal, maxVal);
            for (int i = 0; i < count; i++)
            {
                if (flag)
                {
                    sw.WriteLine($"{random} ");
                }
                else
                {
                    sw.Write($"{random} ");
                }
                    random = RadnomSymbvol(minVal, maxVal);
            }
            sw.Close();
        }

        public static void Reserchfile(string urlFileName, int Quest)
        {
            StreamReader sr = new StreamReader(urlFileName);

            {
                if (Quest == 1)
                {
                    string[] numbers = sr.ReadToEnd().Split(' ');
                    int pr = 0;
                    int num = int.Parse(numbers[1]);
                    int minElement = num;
                    int maxElement = num;
                    for (int i = 0; i < _len; i++)
                    {
                        num = int.Parse(numbers[i]);
                        if (num < minElement)
                        {
                            minElement = num;
                        }
                        if (num > maxElement) 
                        { 
                            maxElement = num; 
                        }

                    }
                    Console.WriteLine($"Произведение: {maxElement * minElement}");
                    Console.WriteLine($"min: {minElement}");
                    Console.WriteLine($"max: {maxElement}");
                }
                else if (Quest == 2)
                {
                    string[] numbers = sr.ReadToEnd().Split(' ');
                    int colNotEven = 0;
                    int num = int.Parse(numbers[1]);
                    for (int i = 0; i < _len; i++)
                    {
                        num = int.Parse(numbers[i]);
                        if (num % 2 != 0)
                        {
                            colNotEven++;
                        }

                    }
                    Console.WriteLine($"col not even: {colNotEven}");

                }
                else if (Quest == 3)
                {
                    string[] lines = File.ReadAllLines(urlFileName);
                    StreamWriter sw = new StreamWriter($"C:\\Users\\boxer\\" +
                        $"Desktop\\YP\\laba7" +
                        $"\\ConsoleApp5\\Quest3_1.txt");

                    for (int i = 0; i < lines.Length; i++)
                    {
                        int length = lines[i].Length;
                        sw.WriteLine(length);
                    }

                    sw.Close();
                    Console.WriteLine($"\nФайл с длинами строк : {$"C:\\Users\\boxer\\" +
                        $"Desktop\\YP" +
                        $"\\laba7\\ConsoleApp5\\Quest3_1.txt"}");
                }
                else if (Quest == 4)
                {
                    string[] numbers = File.ReadAllText(urlFileName)
                                          .Split(' ', StringSplitOptions.
                                          RemoveEmptyEntries);

                    StreamWriter sw = new StreamWriter($"C:\\Users\\boxer\\" +
                        $"Desktop\\YP\\laba7" +
                        $"\\ConsoleApp5\\Quest4_1.txt");

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        string line = "";
                        for (int j = 0; j <= i; j++)
                        {
                            if (j > 0) line += " ";
                            line += numbers[j];
                        }
                        sw.WriteLine(line);
                    }
                    sw.Close();
                    Console.WriteLine($"\nФайл создан: Quest4_1.txt");
                }
            }
        }

    }
}


