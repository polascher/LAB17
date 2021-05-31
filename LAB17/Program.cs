using System;

namespace LAB17
{
    class MainClass
    {
        struct Student
        {
            public string name;
            public int history;
            public int philosophy;
            public int physics;
        }


        static void Main(string[] args)
        {
            int c = 0;
            const int M = 10;
            Student[] array = new Student[M];
            while (true)
            {
                Console.Write("0. Выход\n" +
                    "1. Ввод студента\n" +
                    "2. Вывод информации о всех студентах\n" +
                    "3. Вывод отличников\n" +
                    "4. Вывод двоечников\n");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                case 0:
                    {
                        return;
                    }
                    case 1:
                        {
                            Student s = new Student();
                            Console.WriteLine("Введите фамилию студента");
                            s.name = Console.ReadLine();
                            Console.WriteLine("Введите оценку по истории");
                            s.history = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите оценку по философии");
                            s.philosophy = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите оценку по физике");
                            s.physics = Convert.ToInt32(Console.ReadLine());
                            array[c] = s;
                            c++;
                            break;

                        }
                    case 2:
                        {
                            for (int i = 0; i < c; i++)
                            {
                                Student s = array[i];
                                Console.WriteLine("Фамилия: {0}", s.name);
                                Console.WriteLine("Оценка по истории: {0}", s.history);
                                Console.WriteLine("Оценка по философии: {0}", s.history);
                                Console.WriteLine("Оценка по физике: {0}", s.physics);
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 3:
                        {
                            for (int i = 0; i < c; i++)
                            {
                                Student s = array[i];
                                if (s.history != 5 || s.philosophy != 5 || s.physics != 5)
                                    continue;

                                Console.WriteLine("Фамилия: {0}", s.name);
                                Console.WriteLine("Оценка по истории: {0}", s.history);
                                Console.WriteLine("Оценка по философии: {0}", s.history);
                                Console.WriteLine("Оценка по физике: {0}", s.physics);
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 4:
                        {
                            for (int i = 0; i < c; i++)
                            {
                                Student s = array[i];
                                if (s.history != 2 || s.philosophy != 2 || s.physics != 2)
                                    continue;

                                Console.WriteLine("Фамилия: {0}", s.name);
                                Console.WriteLine("Оценка по истории: {0}", s.history);
                                Console.WriteLine("Оценка по философии: {0}", s.history);
                                Console.WriteLine("Оценка по физике: {0}", s.history);
                                Console.WriteLine();
                            }
                            break;

                        }
                }
            }
        }
    }
}
