using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourname = "";
            Start.Welcome();
            Fight Fight = new Fight();
            Fight.fight();
            //Random random = new Random();        
            //int damage = random.Next(0, 10);
            //int accuracy = 75;
            //YourHero spiderman = new YourHero("Питер Паркер", 21, 100, damage,accuracy, "Способность лазать по стенам");
            //Person human = new Person("Дед Пантилимон с соседнего подъезда", 67, 80, damage,accuracy);
            //Person.Fight(human, spiderman);
            //Console.ReadLine();
        }
        class Person
        {
            public float Health;
            public string Name;
            public float Damage;
            public float Accuracy;

            public  Person(float health, float damage, float accuracy)
            {
                health = 100;
                Health = health;
                damage = 10;
                Damage = damage;
                accuracy = 0.7f;
                Accuracy = accuracy;
                
            }

            //public void GetInfo()
            //{
            //    for (int i = 0; i < typeof(Person).GetFields().Length; i++)
            //    {
            //        var Field = typeof(Person).GetFields()[i];
            //        Console.WriteLine($"{Field.Name}:{Field.GetValue(this)}");
            //    }
            //}
            //public void AffectHealth(int hp)
            //{

            //    this.Health -= hp;
            //    if (this.Health < 0)
            //    {
            //        this.Health = 0;
            //    }
            //    Console.WriteLine($"Теперь здоровье нашего персонажа {Name} равно {Health}");
            //}
            //public static void Fight(Person human, YourHero spiderman)
            //{
            //    Console.WriteLine();
            //    while (spiderman.Health != 0 && human.Health != 0)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine("         Атаки");
            //        Console.ResetColor();
            //        //Console.WriteLine("1-Ударить бутылкой " + "\n" + "2-прикрыться дверцой жигуля и контратакавать" + "\n" + "3-Выпить Жигулёвского" + "\n" + "4-Бахнуть Портвей 777" + "\n" + "5-Дыхнуть перегаром" + "\n" + "6-Пойти в рукопашную");
            //        int y = 0;                    
            //        Attacks(y);
            //        spiderman.Health -= human.Damage;

            //        human.Health -= spiderman.Damage;
            //    }
            //    Winner(human, spiderman);
            //}
            //public static void Attacks(int type)
            //{
            //    switch (type)
            //    {


            //        case 1:
            //            {
            //                ATTACKS.bottle();
            //            }
            //            break;
            //        case 2:
            //            {
            //                ATTACKS.contr();
            //            }
            //            break;
            //        case 3:
            //            {
            //                ATTACKS.drinkj();
            //                Console.WriteLine();
            //            }
            //            break;
            //        case 4:
            //            {
            //                ATTACKS.drink777();
            //            }
            //            break;
            //        case 5:
            //            {
            //                ATTACKS.poison();
            //            }
            //            break;
            //        case 6:
            //            {
            //                ATTACKS.simpleAttack();
            //            }
            //            break;
            //        default:
            //            {

            //            }
            //            break;
            //    }
            //}
            //        class ATTACKS
            //    {
            //        public int HEALTH;
            //        public double ENDAMAGE;
            //        public double DAMAGE;

            //        public static void bottle()
            //        {
            //            double damage = 1.5 ;
            //            double endamage = 1.5;
            //        }
            //        public static void contr()
            //        {
            //            double endamage = 0.5;
            //            double damage = 0.5;
            //        }
            //        public static void drinkj()
            //        {
            //            Random random = new Random();
            //            int health = random.Next(5, 15);
            //        }
            //        public static void drink777()
            //        {
            //            double alwdamage = 1.1;

            //        }
            //        public static void poison()
            //        {

            //        }
            //        public static void simpleAttack()
            //        {

            //        }
            //    }


            //    public static void Winner(Person human, YourHero spiderman)
            //    {
            //        if (spiderman.Health == 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine(spiderman.Name + " погиб от рук старого алкоголика");
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine(human.Name + " вспомнил навыки драк с собутыльниками и доказал щенку ,что их поколение не о чём");
            //        }
            //        else if (human.Health == 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("Старый дед пал от рук супергероя,однако он не умер ,если полвека алкоголизма его не убили то и какой-то щегол не убьёт");
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine("Питер после боя с Пантилимоном ,получил пищевое отравление от перегара как он себя называет 'вечно молодого вечно пьяного'");
            //        }

            //    }

        }
        //class YourHero : Person
        //{
        //    public string SuperPower;
        //    public YourHero(string name, int age, int health, int damage,int accuracy, string super_power) : base(name,age,health,damage,accuracy)
        //    {
        //        SuperPower = super_power;
        //    }
        //}
        class Fight
        {
            public float Fdamage;
            public float Fhealth;
            public float Faccuracy;
            public static int Stage = 1;
            public Fight()
            {
                
            }
            public  void fight()
            {
                ENEMIES enemy = new ENEMIES(0,0,0,"","");
                ENEMIES.Enemies(out enemy);
                //Console.WriteLine(enemy.Damage);
                //Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\n"+"Ваш противник ");
                Console.ResetColor();
                Console.Write(enemy.Name+"\n"+"Биография");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(enemy.Definition);
                Console.ResetColor();                             
                while ( enemy.Health!=0 && Fhealth!=0)
                {                                                       
                        Class.Attacks();
                        Fdamage *= Class.Damage;
                        Fhealth += Class.Health;                    
                }
                Stage++;
            }

        }
        class ENEMIES:Person

        {
            public float Health;
            public string Name;
            public string Definition;
            public ENEMIES(float health,float damage,float accuracy,string name,string definition) : base(health,damage,accuracy)
            {
                Health = health;
                Name = name;
                Definition = definition;
            }
        public static void Enemies(out ENEMIES enemy)
        {
            enemy = new ENEMIES(0, 0, 0, "", "");
            int x = Fight.Stage;
            switch (x)
            {
                case 1:
                        enemy = new ENEMIES(0,0,0, "Дед Пантилимон","-старый алкоголик");
                        
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }
    }        
        // Ильич 56 лет-пожилой десантник ,прошёл несколько войн ,один ,без отряда,сам себе командир.Процесс дыхания у него проходит за счёт беломорканала##вечно воскресает
        // Колян Муромец 46 лет-получил своё прозвище не случайно,половину своей жизни провёл в постели , умеет медитировать и ломать волю противника своим взглядом (ну конечно ,ведь этот человек около 20 лет смотрел в одну точку).##медиум и просто вафлист
        // Петрович Хранитель Совка 75 лет- поклоник Иосифа Висарионовича , проводил(до сих пор проводит) репрессии во славу вождя .Нелицеприятные высказывания в адрес Сталина приводят его в буйство,слова про развал Союза ослабляют защиту.Капиталисты помечаются им как враги народа.Имеет множество психических расстройст,местные до сих пор в шоке ,как его ещё не забрали санитары(на самом деле медработники боятся его,впрочем как и все).##берсерк со слабой и легко снижаемой защитой 
        // Саня Штопор 34 лет-быковатый мужик ,в детстве 2 дня занимался боксом и считает себя порядочным спортсменом ,его девиз:"Порхай как перхоть ,жаль как моя жена " .Своё прозвище получил за то ,что может открыть Балтику зубами(глазом). 
        // Зина Джаггернаут 40 лет- очень сильная и почти независимая женщина, обладает необычайной силой ,подрабатывает на стройке в роли подъёмного крана, имеет навыками ближнего и дальнего боя ,которые она приобрела в драках с мужем- Саней Штопором.
        // Гарри Шпроттер (19 лет)- мальчик обладающий навыком сироты ,имеет огромное терпение (на протяжении семи лет безуспешно шипперил друзей,на протяжении всей жизни подвергался домогательствам лысого мужика )
        // Лёлик Еболик 10 лет -невыносимый ребёнок,признан акушерами недоразвитым,его психотерапевт спустя сеанс застрелился
        // Данила Закладчик 16 лет -обладает необычайно ловкостью и скоростью,что впринципе и необходимо для его профессии ,за небывалую продуктивность барыга дал ему кличку Стахановец
        // Джонни Сифилис 27 лет- парень коллекционирующий венерические заболевания ##удар по нему приводит к отравлению и урону.
        class Start
        {
            public static int Class;
            public static string Name;
            public static void Welcome()
            {
                Console.WriteLine("Введите имя вашего персонажа");
                string name = Console.ReadLine();
                Name = name;
                Console.WriteLine("Выберите класс");
                chooseyoursuperpower();
            }
            public static void chooseyoursuperpower()
            {
                
                Console.Write("1-");
                Berzerk();
                Console.WriteLine("");
                Console.Write("2-");
                Healer();
                Console.WriteLine("");
                Console.Write("3-");
                Knight();
                Console.WriteLine("");
                int x = 0;
                Errors.falsesint(x, out x);                               
                Class = x;

                Start.presentation(x);
            }            
            public static void Berzerk()
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Берсерк");
                Console.ResetColor();
            }
            public static void berzerkability()
            {
                
            }
            
            public static void Healer()
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Целитель");
                Console.ResetColor();
            }
            public static void healerAbility()
            {

            }
            public static void Knight()
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Рыцарь");
                Console.ResetColor();
            }
            public static void knightAbility()
            {

            }
            public  static void presentation(int x)
            {

                Console.Write("Ваш персонаж " + Start.Name + " ");

                switch (x)
                {
                    case 1:                                                
                        Berzerk();                        
                        break;
                    case 2:                       
                        Healer();
                        break;
                    case 3:
                        Knight();
                        break;
                }
                
            }
                
        }
        
        class Class
        {
            public static bool Invincibility=false;
            public static bool HolyShield = false;
            public static float Damage=1;
            public static float Health=0;
            public static float Accuracy=1;
            public Class(int x)
            {
                switch (x)
                {
                    case 1:
                            Damage = 1.1f;
                        break;
                    case 2:
                            Health = 5;
                        break;
                    case 3:
                        Invincibility = true;
                        HolyShield = true;
                        break;

                }

            }
            public static void Attacks()
            {
                
                switch (Start.Class)
                {
                    case 1:
                        BerzerkAttack();
                        break;
                    case 2:
                        HealerAttack();
                        break;
                    case 3:
                        KnightAttack();
                        break;
                }
            }
            public static void BerzerkAttack()
            {

            }
            public static void HealerAttack()
            {

            }
            public static void KnightAttack()
            {

            }
        }
        class Errors
        {
            public static void falsesint(int y,out int z)
            {
                Start:
                try
                {
                    y = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Неверное значение");
                    Console.ResetColor();
                    goto Start;
                }
                z = y;
            }
            public static void falsesdouble(double y,out double z)
            {
                Start:
                try
                {
                    y = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Неверное значение");
                    Console.ResetColor();
                    goto Start;
                }
                z = y;
            }
            public static void massive(int[] mass,int x)
            {
                Start:
                try
                {
                    Console.WriteLine(mass[x]);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Указанный член массива не существует");
                    Console.ResetColor();
                    goto Start;
                }
            }
        }
        
    }
}
