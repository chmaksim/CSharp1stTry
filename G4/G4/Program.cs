using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassTesting
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите имя ");
            string x = Console.ReadLine();
            Man H1 = new Man(x);
            Console.WriteLine("Немного информации: ");
            H1.Info();
            H1.Go();
            H1.Talk();

            Console.ReadKey();
        }
    }

    public class Man
    {


        public Man(string _name)
        {
            Random rnd = new Random();
            Name = _name;
            isLife = true;
            Age = (uint)rnd.Next(15, 50);
            Health = (uint)rnd.Next(10, 100);
        }
        private string Name;

        private uint Age;

        private uint Health;

        private bool isLife;

        public void Info()
        {
            Console.WriteLine(Name);
            Console.WriteLine("{0} лет", Age);
            Console.WriteLine("Процент здоровья {0}", Health);
        }

        public void Talk()
        {
            Random rnd = new Random();
            int random_talk = rnd.Next(1, 3);


            string tmp_str = "";

            switch (random_talk)
            {
                case 1:
                    {

                        tmp_str = "Привет, меня зовут " + Name + ", рад познакомиться";

                        break;
                    }
                case 2:
                    {
                        tmp_str = "Мне " + Age + ". А тебе?";

                        break;
                    }
                case 3:
                    {
                        if (Health > 50)
                            tmp_str = "Да я зводоров как бык!";
                        else
                            tmp_str = "Со здоровьем у меня все плохо, дожить бы до " + (Age + 10).ToString();

                        break;
                    }
            }

            System.Console.WriteLine(tmp_str);

        }

        public void Go()
        {
            if (isLife == true)
            {
                if (Health > 40)
                {
                    string outString = Name + " мирно прогуливается по городу";
                    System.Console.WriteLine(outString);
                }
                else
                {
                    string outString = Name + " болен и не может гулять по городу";
                    System.Console.WriteLine(outString);
                }
            }
            else
            {
                string outString = Name + " не может идти, он умер";
                System.Console.WriteLine(outString);
            }

        }

        public bool IsAlive()
        {
            return isLife;
        }

    }

}
