using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class Population
    {
        protected int n;
        protected MFC[] M;

        public Population(int K)
        {
            switch (K)
            {
                case 1:
                    Console.Write("Задайте количество семей ");
                    n = Convert.ToInt32(Console.ReadLine());
                    M = new MFC[n];
                    string m1, f1, c1;
                    for (int i = 0; i < n; i++)

                    {
                        Console.WriteLine("Члены семьи{0}: ", i + 1);
                        Console.Write("Ребенок: ");
                        c1 = Console.ReadLine();
                        Console.Write("Мать: ");
                        m1 = Console.ReadLine();
                        Console.Write("Отец: ");
                        f1 = Console.ReadLine();

                        M[i] = new MFC(m1, f1, c1);

                    }
                    break;

                case 2:
                    Console.Write("Зайдате имя текстового файла данных без расширения: ");
                    string file_name = Console.ReadLine() + ".txt";
                    StreamReader sr;
                    try
                    {
                        sr = new StreamReader(file_name, UTF8Encoding.Default);
                        string t = sr.ReadLine();
                        n = Convert.ToInt32(t);
                        M = new MFC[n];
                        string m2, f2, c2;
                        int k = -1;
                        int i = 0;
                        while ((t != null) && (i < n))
                        {
                            t = sr.ReadLine(); // чтение строк
                                               // разбор строки
                            k = t.IndexOf(" ");
                            c2 = t.Substring(0, k);
                            t = t.Remove(0, k + 1);
                            k = t.IndexOf(" ");
                            m2 = t.Substring(0, k);
                            f2 = t.Remove(0, k + 1);
                            M[i] = new MFC(m2, f2, c2);
                            i++;
                        }
                        sr.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ОШИБКА: " + ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Данный вариант ввода не предусмотрен!");
                    break;
            }
        }
        // Вывод результата
        public void OutputResult(string name)
        {
            if (n == 0)
                Console.WriteLine("База данных пуста!");
            else
            {
                if (name == "все")
                {
                    for (int i = 0; i < n; i++)
                        M[i].Print();
                }
                else 
                {
                    bool b = false;
                    for (int i = 0; i < n; i++)
                        if (M[i].GetChild().Equals(name))
                        {
                            b = true;
                            M[i].Print();
                        }
                    if (!b)
                        Console.WriteLine("Ребенка с именем '" + name + "' нет в базе данных");
                }
            }
        }
    }
}
                    