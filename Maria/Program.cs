using System;
namespace Task1
{
    public class Phone
    {
        private int number;
        private string model = "";
        private int weight;
        public void printArgs()
        {
            Console.Write(number);
            Console.Write(model);
            Console.Write(weight);
        }
        public void sendMessage(params string[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
        public int getNumber()
        {
            return number;
        }
        public void recieveCall(string name)
        {
            Console.WriteLine("\n Звонит ");
            Console.Write(name);
        }
        public void recieveCall(string name, int number)
        {
            Console.WriteLine("\n Звонит ");
            Console.Write(name);
            Console.Write(number);
        }
        public Phone(int e, string m, int b) : this(e, m)
        {
            weight = b;
        }
        public Phone(int e, string m)
        {
            number = e;
            model = m;
            weight = 0;
        }
        public Phone()
        {
            number = 0;
            model = "";
            weight = 0;
        }
    }
    public static class Globals
    {
        public static int averageTemp(Seasons season)
        {
            switch (season)
            {
                case Seasons.spring:
                    return 10;
                case Seasons.summer:
                    return 20;
                case Seasons.autumn:
                    return 5;
                case Seasons.winter:
                    return -41;
            }
            return 0;
        }
        public static string returnString(Seasons season)
        {
            switch (season)
            {
                case Seasons.spring:
                    return "Весна - время когда тает снег, распускаются цветы.";
                case Seasons.summer:
                    return "Лето - это самое прелестное время года.";
                case Seasons.autumn:
                    return "Осень - это время, когда природа готовиться к зиме.";
                case Seasons.winter:
                    return "Зима — это замечательное время года, когда все начинают верить в чудеса.";
            }
            return "";
        }
        public static string returnString(Seasons season, Seasons temperature)
        {
            switch (season)
            {
                case Seasons.spring:
                    return "Я люблю весну";
                case Seasons.summer:
                    return "Я люблю лето";
                case Seasons.autumn:
                    return "Я люблю осень";
                case Seasons.winter:
                    return "Я люблю зиму";
            }
            return "";
        }
        public static string getDescription(Seasons season)
        {
            if (season == Seasons.summer)
            {
                return "Тёплое время года";
            }
            return "Холодное время года";
        }
        static void Main(string[] args)
        {
            Phone firstPhone = new Phone();
            Phone secondPhone = new Phone();
            Phone otherPhone = new Phone();
            Console.WriteLine(firstPhone.getNumber());
            firstPhone.recieveCall("\nВиктор ");
            firstPhone.sendMessage("89885410271", "89012546107");
            Console.WriteLine(secondPhone.getNumber());
            secondPhone.recieveCall("\nВиктор ");
            secondPhone.sendMessage("44", "89004175832");
            Console.WriteLine(otherPhone.getNumber());
            otherPhone.recieveCall("\nВиктор ");
            otherPhone.sendMessage("78014571203", "89005885014");
            firstPhone.printArgs();
            secondPhone.printArgs();
            otherPhone.printArgs();
            firstPhone.recieveCall("Виктор ", 247801773);
            Person firstPerson = new Person();
            Person secondPerson = new Person(44, " Алексей");
            firstPerson.move();
            firstPerson.talk();
            secondPerson.move();
            secondPerson.talk();
            Console.Write(getDescription(Seasons.spring));
            Console.Write(getDescription(Seasons.summer));
            Console.Write(getDescription(Seasons.autumn));
            Console.Write(getDescription(Seasons.winter));
            Console.Write(averageTemp(Seasons.spring));
            Console.Write(averageTemp(Seasons.summer));
            Console.Write(averageTemp(Seasons.autumn));
            Console.Write(averageTemp(Seasons.winter));
            Console.Write(returnString(Seasons.spring));
            Console.Write(returnString(Seasons.summer));
            Console.Write(returnString(Seasons.autumn));
            Console.Write(returnString(Seasons.winter));
        }
    }


    public class Person
    {
        private string fullName = "";
        private int age;
        public Person()
        {
            fullName = " Кто-то";
            age = 0;
        }
        public Person(int l, string m)
        {
            fullName = m;
            age = l;
        }
        public void move()
        {
            Console.Write(fullName);
            Console.Write(" двигается");
        }
        public void talk()
        {
            Console.Write(fullName);
            Console.Write(" говорит ");
        }
    }
    public enum Seasons
    {
        spring = 0,
        summer = 1,
        autumn = 2,
        winter = 3,
        springTemperature = 10,
        summerTemperature = 20,
        autumnTemperature = 5,
        winterTemperature = -41,
    }

}

