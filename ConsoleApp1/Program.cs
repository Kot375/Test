using System;

namespace ConsoleApp1
{
    class Warrior
    {
        private string name;
        private int health;
        private int strenth;

        static string[] nume = { "Авраам", "Буриман", "Сидевший", "Голосок", "Мертвый", "Старый", "Живой", "Кожанный", "Молюск", "Мина" };
        static Random rnd = new Random();


        public Warrior()
        {
            this.name = nume[rnd.Next(0, 9)];
            this.health = rnd.Next(0, 100);
            this.strenth = rnd.Next(0, 100);
        }
        public Warrior(string name) : this()
        {
            this.name = name;
        }
        public Warrior(string name, int health, int strenth)
        {
            this.name = name;
            this.health = health;
            this.strenth = strenth;
        }
        public string GetName()
        {
            return name;
        }
        public int GetStrenth()
        {
            return strenth;
        }
        public int Health
        {
            get { return health; }
            set
            {
                if (value > 0) Health = value;
                else health = 0;
            }
        }
        public void Passport()
        {
            Console.WriteLine("Воин {0} \n Здоровье {1} \n Сила {2}", name, health, strenth);
          
        }
    }
    class Fight : Warrior
    {
        private int hit = 0;
        private int krit = 0;
        Warrior a = new Warrior();
        Warrior b = new Warrior();
        private int Healtha { get; set; }
        private int Healthb { get; set; }
        private int Strentha { get; set; }
        private int Strenthb { get; set; }
        private string Namea { get; set; }
        private string Nameb { get; set; }
        public string GetNamea()
        {
            return Namea = a.GetName();
        }

        public Fight()
        {
            this.hit = rnd.Next(0, 20);
            this.krit = rnd.Next(0, 60);
        }
        static Random rnd = new Random();
        public int GetHealtha()
        {
            return Healtha = a.Health;
        }
        public int GetStrentha()
        {
            return Strentha = a.GetStrenth() + hit + krit;
        }
        public int GetHealthb()
        {
            return Healthb = b.Health;
        }
        public int GetStrenthb()
        {
            return Strenthb = b.GetStrenth() + hit + krit;
        }
        public string GetNameb()
        {
            return Nameb = b.GetName();
        }

        public int Attak()
        {
            while (Healtha > 1 && Healthb > 0)
            {
                Healtha -= Strenthb;
            }
            return Healtha;
        }
        public void Result()
        {
            
            
            

            
            if (Healtha > Healthb)
            {
                Console.WriteLine("Воин {0} победил Воина {1}", Namea, Nameb);
            }
            if (Healthb > Healtha)
            {
                Console.WriteLine("Воин {0} победил Воина {1}", Nameb, Namea);
            }
            if (Healtha == Healthb)
            {
                Console.WriteLine("Ничья");
            }
            if (Healtha != Healthb)
            {
                Console.WriteLine("Чья");
            }
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {

            Warrior a = new Warrior();
            a.Passport();
            Warrior b = new Warrior();
            b.Passport();
            Fight c = new Fight();
            c.Result();
            Console.ReadLine();
        }
    }   
}

