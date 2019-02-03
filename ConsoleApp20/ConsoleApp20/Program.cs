using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
          public static int XP = 0;
          public static int Lvl = 1;
          public static int Coins = 0;
          public static int Shava;
          public static int Portvein777;
        public static int Stage = 1;
        static void Main(string[] args)
        {                       
            string yourname = "";
            Start.Welcome();
            Adventure adventure = new Adventure();
            //Fight Fight = new Fight();
            //Fight.fight();

            //Random random = new Random();        
            //int damage = random.Next(0, 10);
            //int accuracy = 75;
            //YourHero spiderman = new YourHero("Питер Паркер", 21, 100, damage,accuracy, "Способность лазать по стенам");
            //Person human = new Person("Дед Пантилимон с соседнего подъезда", 67, 80, damage,accuracy);
            //Person.Fight(human, spiderman);
            //Console.ReadLine();
        }
        //class Person
        //{
        //    public int Health = 100;
        //    public string Name;
        //    public float Damage = 10;
        //    public float Accuracy = 7;

        //    public Person(//int health, int damage, int accuracy
        //        )
        //    {
        //        CharacteristicsAndUpgrades CurrentCharacteristic = new CharacteristicsAndUpgrades(0);
        //        Damage=
        //        // health = 100;
        //        //Person.Health = health;
        //        //int damage = 10;
        //        //Damage = damage;
        //        //float accuracy = 0.7f;
        //        //Accuracy = accuracy;

        //    }

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
            public int Fhealth;
            public float Faccuracy;
           
            public Fight()
            {
                CharacteristicsAndUpgrades You = new CharacteristicsAndUpgrades(0);
                Fdamage = You.Damage;
                Fhealth = You.Health;
                Faccuracy = You.Accuracy;
            }
            public void fight()
            {
                
                ENEMIES enemy = new ENEMIES(0, 0, 0, "", "",0);
                ENEMIES.Enemies(out enemy,Stage);                
                Class YourClass = new Class(Start.Class);                              
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\n" + "Ваш противник ");
                Console.ResetColor();
                Console.Write(enemy.Name + "\n" + "Биография");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(enemy.Definition + "\n" + "Жизни-"+enemy.Health + "\n"+"Урон-"+enemy.Damage+"\n"+"Точность-"+enemy.Accuracy*10+"%");
                Console.ResetColor();
                //f@cking_test Console.WriteLine("как оно "+Fdamage+" "+enemy.Health);
                while (enemy.Health != 0 && Fhealth != 0)
                {                    
                    Console.WriteLine("\n"+Start.Name + Fhealth + "-жизни  " + "\n" + enemy.Health + " жизни противника" + "\n" + Fdamage + " дамаг на старте");
                    Console.ReadLine();

                    float Xdamage = 0;
                    float Xaccuracy = 0;
                    Class.Attacks(out Xdamage, out Xaccuracy);
                    // Console.WriteLine(Xdamage+" "+Xaccuracy);
                    //Console.ReadLine();
                    Fdamage *= Class.Damage;
                    // Console.WriteLine(Fdamage);
                    //Console.ReadKey();
                    Fhealth += Class.Health;
                    Random probability = new Random();
                    int probabilityMy = probability.Next(1, 10);
                    if (probabilityMy < Faccuracy * Xaccuracy)
                    {
                        enemy.Health -= (int)(Xdamage * Fdamage);
                        enemy.Health = CheckHP(enemy.Health);
                        Console.WriteLine(Start.Name + " наносит " + (int)(Xdamage * Fdamage) + " единиц урона");                      
                    }
                    else
                    {
                        Console.WriteLine("Вы промахнулись...");
                    }
                    int probabilityEnemy = probability.Next(1, 10);
                    if (probabilityEnemy < enemy.Accuracy)
                    {
                        Fhealth -= enemy.Damage;
                        Fhealth = CheckHP(Fhealth);
                        Console.WriteLine(enemy.Name + " нанёс вам " + enemy.Damage + " единиц урона");
                        
                    }
                    else
                    {
                        Console.WriteLine(enemy.Name + " промахнулся...");
                    }                   
                }
                if (Fhealth==0)
                {
                    GameOver();
                }                

                CharacteristicsAndUpgrades XpForWinner= new CharacteristicsAndUpgrades (enemy.GainedXp);               
                //Console.WriteLine(""+XP);
                Stage++;
                Console.ReadKey();
            }
            public static void FightMechanic()
            {
                while (true)
                {

                }
            }
            public static int CheckHP(int Hp)
            {
                if (Hp <= 0)
                {
                    Hp = 0;
                }
                return Hp;
            }
        }
        class ENEMIES 

        {
            public int Health;
            public int Damage;
            public int Accuracy;
            public string Name;
            public string Definition;
            public int GainedXp;
            public ENEMIES(int health, int damage, int accuracy, string name, string definition,int gainedXP)// : base(health, damage, accuracy)
            {
                Health = health;
                Damage = damage;
                Accuracy = accuracy;
                Name = name;
                Definition = definition;
                GainedXp = gainedXP;

            }
            public static void Enemies(out ENEMIES enemy,int i)
            {
                enemy = new ENEMIES(0, 0, 0, "", "",0);
                int x = i;
                switch (x)
                {
                    case 1:
                        enemy = new ENEMIES(100, 10, 5, "Дед Пантилимон", "-старый алкоголик",5);
                        break;
                    case 2:
                        enemy = new ENEMIES(100,10,6, "Данила Закладчик 16 лет", "-обладает необычайно ловкостью и скоростью, " +
                            "что впринципе и необходимо для его профессии ,за небывалую продуктивность барыга дал ему кличку Стахановец", 10);
                        break;
                    case 3:
                        enemy = new ENEMIES(130,14,6, "Саня Штопор 34 года", "-быковатый мужик ,в детстве 2 дня занимался боксом и считает себя порядочным спортсменом ," +
                            "его девиз:'Порхай как перхоть, жаль как моя жена' .Своё прозвище получил за то ,что может открыть Балтику зубами(глазом). ", 15);
                        break;
                    case 4:
                        enemy = new ENEMIES(150,20,6, "Зина Джаггернаут 40 лет", "- очень сильная и почти независимая женщина, обладает необычайной силой ," +
                            "подрабатывает на стройке в роли подъёмного крана, имеет навыками ближнего и дальнего боя ,которые она приобрела в драках с мужем- Саней Штопором.",25);
                        break;
                    case 5:
                        enemy = new ENEMIES(150,20,7, "Лёлик Еболик 10 лет", "-невыносимый ребёнок,признан акушерами недоразвитым,его психотерапевт спустя сеанс застрелился", 35);
                        break;
                    case 6:
                        enemy = new ENEMIES(50,25,10, "Гарри Шпроттер 19 лет", ")- мальчик обладающий навыком сироты ,имеет огромное терпение (на протяжении семи лет безуспешно шипперил друзей," +
                            "на протяжении всей жизни подвергался домогательствам лысого мужика )",50);
                        break;
                }
            }
            public static void description()
            {

            }
        }        
        // Ильич 56 лет-пожилой десантник ,прошёл несколько войн ,один ,без отряда,сам себе командир.Процесс дыхания у него проходит за счёт беломорканала##вечно воскресает
        // Колян Муромец 46 лет-получил своё прозвище не случайно,половину своей жизни провёл в постели , умеет медитировать и ломать волю противника своим взглядом (ну конечно ,ведь этот человек около 20 лет смотрел в одну точку).##медиум и просто вафлист
        // Петрович Хранитель Совка 75 лет- поклоник Иосифа Висарионовича , проводил(до сих пор проводит) репрессии во славу вождя .Нелицеприятные высказывания в адрес Сталина приводят его в буйство,слова про развал Союза ослабляют защиту.Капиталисты помечаются им как враги народа.Имеет множество психических расстройст,местные до сих пор в шоке ,как его ещё не забрали санитары(на самом деле медработники боятся его,впрочем как и все).##берсерк со слабой и легко снижаемой защитой 
        // Саня Штопор 34 года-быковатый мужик ,в детстве 2 дня занимался боксом и считает себя порядочным спортсменом ,его девиз:"Порхай как перхоть ,жаль как моя жена " .Своё прозвище получил за то ,что может открыть Балтику зубами(глазом). 
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
                //Console.WriteLine("sin");
                //Console.ReadLine();
                Class = x;
                //Console.WriteLine("sin");
                //Console.ReadLine();
                presentation(x);
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
            public static void presentation(int x)
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
                Console.WriteLine();
            }

        }

        class Class
        {
            public static bool Invincibility = false;
            public static bool HolyShield = false;
            public static float Damage = 1;
            public static int Health = 0;
            public static float Accuracy = 1;
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
            public static void Attacks(out float Xdamaage, out float Xaccuracy)
            {


                float trashXdamage = 0; float trashXaccuracy = 0;
                switch (Start.Class)
                {
                    case 1:
                        BerzerkAttack(out trashXdamage, out trashXaccuracy);
                        break;
                    case 2:
                        HealerAttack();
                        break;
                    case 3:
                        KnightAttack();
                        break;

                }
                Xdamaage = trashXdamage; Xaccuracy = trashXaccuracy;

            }
            public static void BerzerkAttack(out float Xdamage, out float Xaccuracy)
            {
                Xdamage = 0; Xaccuracy = 0;
                Console.WriteLine("Выберите атаку \n 1-Опрометчивый удар(сильный ,но не точный удар) \n 2-Серия(пару ударов но с пониженной точностью и дамагом) \n 3-Точный удар");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Xdamage = 1.5f;
                        Xaccuracy = 0.75f;
                        break;
                    case 2:
                        //!!!!! допилить механику
                        break;
                    case 3:
                        Xaccuracy = 1.25f;
                        Xdamage = 1.1f;
                        break;

                }

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
            public static void falsesint(int y, out int z)
            {
                Start:
                string x = Console.ReadLine();
                try
                {
                    y = Convert.ToInt16(x);
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
            public static void falsesdouble(double y, out double z)
            {
                Start:
                string x = Console.ReadLine();

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
            public static void massive(int[] mass, int x)
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
           
            public static void QuickAccess(string commands)
            {
                switch (commands)
                {
                    case "buy":
                    case "b":
                        Market market = new Market();                       
                        break;

                }
            }
            public static void HotKey(string commands)
            {
                switch (commands)
                {
                    case "s":
                        break;
                    case "p":
                        break;
                }
            }

        }
        class CharacteristicsAndUpgrades
        {
            public int Damage=10;
            public int Health = 100;
            public int Accuracy = 7;
            
            
            public CharacteristicsAndUpgrades(int xp)
            {
                XP += xp;
                Levelups();
            }
            public  void Levelups()
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                if (XP>=10&&Lvl==1)
                {
                    Console.WriteLine("Повышение уровня!");
                    XP =XP- 10;
                    Lvl = 2;
                    Upgrades();
                }
                else if(XP>=25&&Lvl==2)
                {
                    Console.WriteLine("Повышение уровня!"); 
                    Lvl = 3;
                    XP =XP- 25;
                    Upgrades();
                }
                else if (XP>=50&&Lvl==3)
                {
                    Console.WriteLine("Повышение уровня!");
                    Lvl = 4;
                    XP = XP - 50;
                    Upgrades();
                }
                else if (XP>=100&&Lvl==4)
                {
                    Console.WriteLine("Повышение уровня!");
                    Lvl = 5;
                    XP = XP - 100;
                    Upgrades();
                }
                else if (XP>=200 && Lvl==5)
                {
                    Console.WriteLine("");
                    Lvl = 6;
                    XP = XP - 200;
                    Upgrades();
                }
                else
                {

                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ваш уровень "+Lvl);
                Console.ResetColor();
               
            }
            public void Upgrades()
            {
               
                switch(Lvl)
                {
                    case 1:
                        
                        break;
                    case 2:
                        Health += 10;
                        Console.WriteLine("Ваше здоровье выросло на 10 елиниц");                        
                        break;
                    case 3:                        
                        Damage += 1;
                        Console.WriteLine("Ваш урон выросл на 1 единицу");                        
                        break;
                    case 4:
                        Health += 15;
                        Console.WriteLine("Ваше здоровье выросло на 15 единиц");
                        break;
                    case 5:
                        Damage += 2;
                        Console.WriteLine("Ваш урон вырос на 2 единицы");
                        break;
                    case 6:
                        Accuracy += 1;
                        Console.WriteLine("Ваша точность выросла на 10% ");
                        break;
                      
                }                                            
            }

        }
             
        class Adventure
        {
            public string AdventureLogs;
            public Adventure()
            {
                while (true)
                {
                    Console.WriteLine("");
                    Random random = new Random();
                    int OneOfAdventures=random.Next(0,3);                
                    switch (OneOfAdventures)
                    {
                        case 0:
                            GetLoot();
                            break;
                        case 1:
                            GetCoins();
                            break;
                        case 2:
                            Fight GoToFight = new Fight();
                            GoToFight.fight();
                            break;
                        case 3:
                            GetXp();
                            break;
                    }
                    Console.ResetColor();
                }
            }
            private static void GetCoins()
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Coins += 2;
                Console.WriteLine("Ограбив ларёк ,вы получили две монеты ");
                
            }
            private static void GetXp()
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Вы размотали пару местных синяков и получили "+(2*Stage)+" единиц опыта");
                XP += 2 * Stage;
            }
            private static void GetLoot()
            {
                Console.WriteLine("Вы решили порыться в мусорке");
                Random random = new Random();
                int probability = random.Next(0,4);
                switch (probability)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Вы нашли шаву ... почти свежую");
                        Shava += 1;
                        break;
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine("Вы ничего не нашли");
                        break;
                    case 4:
                        Portvein777 += 1;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Портвейн ,который с годами проведёнными в мусорке , стал только лучше");
                        break;
                }
               
            }
       
        }


            public static void GameOver()

            {
                Adventure End = new Adventure();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Вы погибли ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("События " + End.AdventureLogs);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Вы прошли " + Stage + " боёв и победили таких противнико как");
                for (int i = 0; i < Stage; i++)
                {

                    ENEMIES DefeatedEnemy = new ENEMIES(0, 0, 0, "", "", 1);
                    ENEMIES.Enemies(out DefeatedEnemy, i);
                    Console.WriteLine(DefeatedEnemy.Name + DefeatedEnemy.Definition);
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.ReadKey();
                Environment.Exit(0);
            }           
        public static void CoinsTest()
        {


                Loot loot = new Loot(10, 1, 1);
                Loot testloot = new Loot(0, 0, 0);
                Console.WriteLine(Coins+ " "+Shava+" "+Portvein777);
                Console.ReadLine();
            
        }
        class Loot
        {
            
            public string Runs;
           
            public Loot(int coins,int shava,int portvein)
            {
                //Coins += coins;
                //Shava += shava;
                //Portvein777 += portvein;
            }
            public static void OpenBackpack()
            {
                
               

            }
        }
        class Armor
        {
            public static int Helmet=0;
            public  static int BodyArmor=0;
            public static int Pants=0;
            public static void YourArmor()
            {
                //Armor ArmorNow = new Armor();
                Console.WriteLine("Твоя броня");
                switch(Helmet)
                {
                    case 0:
                        Console.WriteLine("Без головного убора");
                        break;
                    case 1:
                        Console.WriteLine("Рваная ушанка");
                        break;
                    case 2:
                        Console.WriteLine("Будёновка");
                        break;
                    case 3:
                        Console.WriteLine("Будёновка с серпом и молотом");
                        break;
                }
                switch (BodyArmor)
                {
                   case 0:
                        Console.WriteLine("Деловитый пиджак");
                        break;
                   case 1:
                        Console.WriteLine("Порванное пальто");
                        break;
                    case 2:
                        Console.WriteLine("Спортивная кофта");
                        break; 
                    case 3:
                        Console.WriteLine("Моднявая коженка");
                        break;
                }
                switch(Pants)
                {
                    case 0:
                        Console.WriteLine("Семейники");
                        break;
                    case 1:
                        Console.WriteLine("Спортивные штаны");
                        break;
                    case 2:
                        Console.WriteLine("Джинсы");
                        break;
                    case 3:
                        Console.WriteLine(" 'Тупо тема бунтаря' ");
                        break;
                }
            }
        }
        class Market
        {
            //public int HelmetCondition;
            //public int BodyArmorCondition;
            //public int PantsCondition;
            public Market()
            {
                //Armor armor = new Armor();
                //HelmetCondition = Armor.Helmet;
                //BodyArmorCondition = Armor.BodyArmor;
                //PantsCondition = Armor.Pants;
               
            }
            public static void Buying()
            {
               // Market market = new Market();
                Start:
                Console.WriteLine("Что хотите приобрести? \n 1-Апгрейд ушанки \n 2-Апгрейд делового пиджака \n 3-Апгрейд спортивок \n 4-Покупка расходников \n 5-Продажа расходников ");
                int entering = Convert.ToInt32(Console.ReadLine());
                switch (entering)

                {
                    case 1:
                        switch (Armor.Helmet)
                        {
                            case 0:
                                Console.WriteLine("Прикупить дедовскую ушанку");
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("");
                                Console.ResetColor();
                                string buy = Console.ReadLine();
                                switch (buy)
                                {
                                    //case "y":
                                    //    if (Coins<)
                                }
                                break;
                            case 1:
                                Console.WriteLine("Вместо старой ушанки купить будёновку");
                                break;
                            case 2:
                                Console.WriteLine("Купить серп и молот для  будёновки ");
                                break;
                            case 3:
                                Console.WriteLine("У вас самый модный головной убор");
                                break;
                        }
                        break;
                    case 2:
                        switch (Armor.BodyArmor)
                        {
                            case 0:
                                Console.WriteLine("Купить ,пальто вместо этого буржуйского пиджака ");
                                break;
                            case 1:
                                Console.WriteLine("Приобрести кофтан Abibas");
                                break;
                            case 2:
                                Console.WriteLine("Купить воненепробиваемую броню( коженку )");
                                break;
                            case 3:
                                Console.WriteLine("Лучше вашей коженки нет ничего (в этом микрорайоне)");
                                break;
                        }
                        break;
                    case 3:
                        switch (Armor.Pants)
                        {
                            case 0:
                                Console.WriteLine("Купить спортивки и получить увагу пацанов");
                                break;
                            case 1:
                                Console.WriteLine("Стать элитой и прикупить джинсовок");
                                break;
                            case 2:
                                Console.WriteLine("Приобрести 'Чисто пацанская тема'(они реально так называются) ");
                                break;
                            case 3:
                                Console.WriteLine("Это лучшее ,что здесь можно приобрести ");
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Неверное значение.Уйти в меню покупок[b] или выйти из магазина[любая другая кнопка]");
                        string y = Console.ReadLine();
                        if (y=="b")
                        {
                            goto Start;
                        }
                        break;
                }                                       
            }
            
            
        }
        public static void Debug()
        {
            CharacteristicsAndUpgrades characteristics = new CharacteristicsAndUpgrades(11);
            Console.WriteLine("Опыт равен "+XP);
            CharacteristicsAndUpgrades characteristicsAndUpgrades = new CharacteristicsAndUpgrades(50);
            Console.WriteLine("Опыт равен "+XP);
            Console.ReadKey();
        }
        class Entering
        {
            public void EnterFight()
            {

            }
            public void EnterAdventure(string choice)
            {
                if (choice == "b") Market.Buying();
                else if (choice == "a") Armor.YourArmor();
                else if (choice=="i")
                {
                    Console.WriteLine("Содержимое рюкзака:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Шаверма из местной фауны " + Shava +" штук");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Портвейн Мгновения Ярость ,а также шевенизм ,рассизм ,коммунизм ,что-то из этого . " + Portvein777 + "штук(и)");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(Coins + " деревянных");
                }
                



            }
        }

    }
}

