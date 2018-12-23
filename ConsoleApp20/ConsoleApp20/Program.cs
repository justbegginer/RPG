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
            Random random = new Random();
            int damage = random.Next(0, 10);
            int accuracy = 75;
            SuperHero spiderman = new SuperHero("Питер Паркер", 21, 100, damage,accuracy, "Способность лазать по стенам");
            Person human = new Person("Дед Пантилимон с соседнего подъезда", 67, 80, damage,accuracy);
            Person.Fight(human, spiderman);
            Console.ReadLine();
        }
        class Person
        {
            public int Age;
            public int Health;
            public string Name;
            public int Damage;
            public int Accuracy;
            public Person(string name, int age, int health, int damage,int accuracy)
            {
                Name = name;
                Age = age;
                Health = health;
                Damage = damage;
                Accuracy = accuracy;
            }
            public void GetInfo()
            {
                for (int i = 0; i < typeof(Person).GetFields().Length; i++)
                {
                    var Field = typeof(Person).GetFields()[i];
                    Console.WriteLine($"{Field.Name}:{Field.GetValue(this)}");
                }
            }
            public void AffectHealth(int hp)
            {

                this.Health -= hp;
                if (this.Health < 0)
                {
                    this.Health = 0;
                }
                Console.WriteLine($"Теперь здоровье нашего персонажа {Name} равно {Health}");
            }
            public static void Fight(Person human, SuperHero spiderman)
            {
                Console.WriteLine("Вы играете за Пантилимона");
                while (spiderman.Health != 0 && human.Health != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("         Атаки");
                    Console.ResetColor();
                    Console.WriteLine("1-Ударить бутылкой " + "\n" + "2-прикрыться дверцой жигуля и контратакавать" + "\n" + "3-Выпить Жигулёвского" + "\n" + "4-Бахнуть Портвей 777" + "\n" + "5-Дыхнуть перегаром" + "\n" + "6-Пойти в рукопашную");
                    int y = 0;
                    try
                    {
                        y = Convert.ToInt16(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.WriteLine("error 404");
                        Console.ResetColor();
                    }
                    Attacks(y);
                    spiderman.Health -= human.Damage;

                    human.Health -= spiderman.Damage;
                }
                Winner(human, spiderman);
            }
            public static void Attacks(int type)
            {
                switch (type)
                {


                    case 1:
                        {
                            ATTACKS.bottle();
                        }
                        break;
                    case 2:
                        {
                            ATTACKS.contr();
                        }
                        break;
                    case 3:
                        {
                            ATTACKS.drinkj();
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        {
                            ATTACKS.drink777();
                        }
                        break;
                    case 5:
                        {
                            ATTACKS.poison();
                        }
                        break;
                    case 6:
                        {
                            ATTACKS.simpleAttack();
                        }
                        break;
                    default:
                        {

                        }
                        break;
                }
            }
                class ATTACKS
            {
                public int HEALTH;
                public double ENDAMAGE;
                public double DAMAGE;

                public static void bottle()
                {
                    double damage = 1.5 ;
                    double endamage = 1.5;
                }
                public static void contr()
                {
                    double endamage = 0.5;
                    double damage = 0.5;
                }
                public static void drinkj()
                {
                    Random random = new Random();
                    int health = random.Next(5, 15);
                }
                public static void drink777()
                {
                    double alwdamage = 1.1;

                }
                public static void poison()
                {

                }
                public static void simpleAttack()
                {

                }
            }


            public static void Winner(Person human, SuperHero spiderman)
            {
                if (spiderman.Health == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(spiderman.Name + " погиб от рук старого алкоголика");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(human.Name + " вспомнил навыки драк с собутыльниками и доказал щенку ,что их поколение не о чём");
                }
                else if (human.Health == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Старый дед пал от рук супергероя,однако он не умер ,если полвека алкоголизма его не убили то и какой-то щегол не убьёт");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Питер после боя с Пантилимоном ,получил пищевое отравление от перегара как он себя называет 'вечно молодого вечно пьяного'");
                }

            }

        }
        class SuperHero : Person
        {
            public string SuperPower;
            public SuperHero(string name, int age, int health, int damage,int accuracy, string super_power) : base(name,age,health,damage,accuracy)
            {
                SuperPower = super_power;
            }
        }
        class Constant
        {

        }
        // Ильич 56 лет-пожилой десантник ,прошёл несколько войн ,один ,без отряда,сам себе командир.Процесс дыхания у него проходит за счёт беломорканала##вечно воскресает
        // Колян Муромец 46 лет-получил своё прозвище не случайно,половину своей жизни провёл в постели , умеет медитировать и ломать волю противника своим взглядом (ну конечно ,ведь этот человек около 20 лет смотрел в одну точку).##медиум и просто вафлист
        // Петрович Хранитель Совка 75 лет- поклоник Иосифа Висарионовича , проводил(до сих пор проводит) репрессии во славу вождя .Нелицеприятные высказывания в адрес Сталина приводят его в буйство,слова про развал Союза ослабляют защиту.Капиталисты помечаются им как враги народа.Имеет множество психических расстройст,местные до сих пор в шоке ,как его ещё не забрали санитары(на самом деле медработники боятся его,впрочем как и все).##берсерк со слабой и легко снижаемой защитой 
        // Саня Штопор 34 лет-быковатый мужик ,в детстве 2 дня занимался боксом и считает себя порядочным спортсменом ,его девиз:"Порхай как перхоть ,жаль как моя жена " .Своё прозвище получил за то ,что может открыть Балтику зубами. 
        // Зина Джаггернаут 40 лет- очень сильная и почти независимая женщина, обладает необычайной силой ,подрабатывает на стройке в роли подъёмного крана, имеет навыками ближнего и дальнего боя ,которые она приобрела в драках с мужем- Саней Штопором.
        // Гарри Шпроттер (19 лет)- мальчик обладающий навыком сироты ,имеет огромное терпение (на протяжении семи лет безуспешно шипперил друзей,на протяжении всей жизни подвергался домогательствам лысого мужика )
        // Лёлик Еболик 10 лет -невыносимый ребёнок,признан акушерами недоразвитым,его психотерапевт спустя сеанс застрелился
        // Данила Закладчик 16 лет -обладает необычайно ловкостью и скоростью,что впринципе и необходимо для его профессии ,за небывалую продуктивность барыга дал ему кличку Стахановец
        // Джонни Сифилис 27 лет- парень коллекционирующий венерические заболевания ##удар по нему приводит к отравлению и урону.
    }
}
