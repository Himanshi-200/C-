using Himu.ConsoleApp1.first_space;
using Himu.ConsoleApp1.first_space.second_space;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Himu.ConsoleApp1
{
    /*class Rectangle
    {
        double length;
        double width;
        public void Acceptdetails()
        {
            length = 24;
            width = 20;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void display()
        {
            Console.WriteLine("Length: {0} ", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0} ", GetArea());
        }
    }*/
    /*class rectangle
    {
        public double length;
        public double width;
        public double GetArea()
        {
            return length * width;
        }
        public void display()
        {
            Console.WriteLine("Length :{0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area:{0}", GetArea());
        }
    }*/
    /* class manipulator
     {
         public int findmax(int a,int b)
         {
             int result;
             if (a > b)
                 result = a;
             else
                 result = b;
             return result;
         }
     }*/
    /*class factorail
     {
         public int fact(int n)
         {
             int result;
             if (n <= 1)
             {
                 return 1;
             }
             else
             {
                 result = n * fact(n - 1);
                 return result;
             }
         }
     }*/
    /*struct Books
     {
         public string title;
         public string author;
         public string subject;
         public int book_id;
     }
    */

    /*enum Days {Sun,Mon,tue,Wed,Thu,Fri,Sat};
     class shape
     {
         public void setwidth(int w)
         {
             width = w;
         }
         public void setheight(int h)
         {
             height = h;
         }
         protected int width;
         protected int height;
     }
     class Rectangle : shape
     {
         public int getArea()
         {
             return (width * height);
         }
     }*/
    /*class Rectangle
     {
         protected double length;
         protected double width;
         public Rectangle(double l,double w)
         {
             length = l;
             width = w;
         }
         public double GetArea()
         {
             return length * width;
         }
         public void Display()
         {
             Console.WriteLine("Length:{0}", length);
             Console.WriteLine("Width:{0}", width);
             Console.WriteLine("Area:{0}", GetArea());
         }

     }
     class Tabletop : Rectangle
     {
         private double cost;
         public Tabletop(double l,double w): base(l, w) { }
         public double GetCost()
         {
             double cost;
             cost = GetArea() * 70;
             return cost;
         }
         public void Display()
         {
             base.Display();
             Console.WriteLine("Cost:{0}", GetCost());
         }
     }*/
    /*class Shape
     {
         public void setWidth(int w)
         {
             width = w;
         }
         public void setHeight(int h)
         {
             height = h;
         }
         protected int width;
         protected int height;
     }
     public interface PaintCost
     {
         int getCost(int area);
     }
     class Rectangle : Shape, PaintCost
     {
         public int getArea()
         {
             return (width * height);
         }
         public int getCost(int area)
         {
             return area * 70;
         }
     }*/
    /* abstract class Shape
     {
         public abstract int area();
     }
     class Rectangle: Shape
     {
         private int length;
         private int width;
         public Rectangle(int a=0,int b = 0)
         {
             length = a;
             width = b;
         }
         public override int area()
         {
             Console.WriteLine("Rectangle class area :");
             return (length * width);
         }
     }*/
    /*class Shape
    {
        protected int width, height;
        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public virtual int area()
        {
            Console.WriteLine("Parent class area :");
            return 0;
        }
    }
    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * height);
        }
    }
    class Traingle : Shape
    {
        public Traingle(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Traingle class area :");
            return (width * height/2);
        }
    }



    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("Area:{0}", a);
        }
    }*/
    /*class Box
    {
        private double length;
        private double breadth;
        private double height;
        public double getVolume()
        {
            return length * breadth * height;
        }
        public void SetLength(double len)
        {
            length = len;
        }
        public void SetBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }
        public static Box operator+(Box b,Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
    }*/
    /*public interface ITractions
    {
        void showTranscation();
        double getAmount();
    }
    public class Transcation : ITractions
    {
        private string tcode;
        private string date;
        private double amount;
        public Transcation()
        {
            tcode = " ";
            date = " ";
            amount = 0.0;
        }
        public Transcation(string c,string d,double a)
        {
            tcode = c;
            date = d;
            amount = a;
        }
        public double getAmount()
        {
            return amount;
        }
        public void showTranscation()
        {
            Console.WriteLine("Transcation:{0}", tcode);
            Console.WriteLine("Date:{0}", date);
            Console.WriteLine("Amount:{0}", getAmount());
        }
    }*/
    /*namespace first_space
    {
        class abc
        {
            public void func()
            {
                Console.WriteLine("Inside First Space");
            }
        }
        namespace second_space
        {
            class gfg
            {
                public void func()
                {
                    Console.WriteLine("Inside second space");
                }
            }
        }
    }*/


    internal class Program
    {
        //single line comment
        /* this is
         * multiline 
         * comment*/
        //static void Greet(string name)
        //{
        //    Console.WriteLine("Good Morning "+name);
        //}
        //static float Average(int a,int b,int c)
        //{
        //    float sum = a + b + c;
        //    return sum / 3;
        //}
        //static float Average(int a,int b)
        //{
        //    return (a + b) / 2;
        //}
        /*class PrintData
        {
            public void print(int i)
            {
                Console.WriteLine("Pritnitng int: {0}", i);
            }
            void print(double f)
            {
                Console.WriteLine("Printing Float:{0}", f);
            }
            void print(string s)
            {
                Console.WriteLine("Printing string :{0}", s);
            }
        }*/
        /*private static void showMatch(string text,string expr)
        {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach(Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        */




        static void Main(string[] args)
        {
            //int himu = 34;//Integer varaible
            /* Data types in c#
             * Integer -int himu; 4 bytes
             * long --> 8 bytes
             * Floating point number -float that; 4 bytes
             * Double -double harry--> 8 bytes
             * Character - char a='A'; 2 bytes
             * Boolean -bool is Great=true; 1 bit
             * String string inp="Himu"; 2 bytes per character
             * */
            //string inp = Console.ReadLine();
            //Console.WriteLine(inp);
            //Console.WriteLine("First C# Program...Himu!");
            //Console.Write("Hello Himu ");
            //Console.WriteLine("I love C# and the number "+ himu);
            //int a = 34;
            //float b = 34.4F;
            //double c = 34.4D;
            // bool isGreat = true;
            //char d = 'a';
            //string e = "this is a string";
            // Console.WriteLine(a);
            //  Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine(isGreat);
            // Console.WriteLine(d);
            // Console.WriteLine(e);
            //Type -Casting
            // There are two types of type casting
            //1. Implicit Casting
            //char to int to long to float to double
            //2. Explicit Casting
            //int x = (int)3.5;
            //Console.WriteLine(x);
            //double x2 = (double)3.5;
            //Console.WriteLine(x2);
            //int x1 = 3;
            //double y = x;
            //int z = 'y';
            //float varr = Convert.ToInt32(3.55);
            //string sx = "34 is amazing";
            //float sy = 34.3F;
            //Convert.ToDouble
            //Convert.ToString
            // Console.WriteLine(x1);
            // Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(varr);
            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hey Hello " + name);
            //Console.WriteLine("Howmany candiesdo you want ?");
            //string can = Console.ReadLine();
            //Console.WriteLine("You will get 4 more candies " + 
            // (Convert.ToInt32(can)+4));
            /*operatorsin c#
             * 1.Arithemetic opratos
             * 2.Assigment operators
             * 3.Logical operators
             * 4.comparsion operators
             * */
            //int a = 4;
            //int b = 2;
            //Console.WriteLine("The value of a+b is: " + (a + b));
            //Console.WriteLine("The value of a-b is: " + (a - b));
            //Console.WriteLine("The value of a*b is: " + (a * b));
            //Console.WriteLine("The value of a/b is: " + (a / b));
            //Assigment operators
            //int a = 4;
            //int b = a;
            //b += 4;
            //Console.WriteLine(b);
            //logical operators
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);
            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);
            //Console.WriteLine(!true);
            // Comparsion operator
            //Console.WriteLine(324 > 555);
            //Console.WriteLine(324 <= 555);
            //Console.WriteLine(324 >= 555);
            //Console.WriteLine(324 != 555);
            //Console.WriteLine(325 == 555);
            //int a = Math.Max(34, 345);
            //Console.WriteLine(a);
            //int b = Math.Min(34, 345);
            //Console.WriteLine(b);
            //double c = Math.Sqrt(45);
            //Console.WriteLine(c);
            //double a = Math.Abs(-45);
            //Console.WriteLine(a);
            //string hello = "Hello worls this is Himu";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToLower());
            // Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello + " You  are nice");
            //Console.WriteLine(string.Concat(hello, " You are nice"));
            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is {name} You will get {candies}");
            //string hello = "hello World \" this is Harry";
            //Console.WriteLine(hello[0]);
            //Console.WriteLine(hello.IndexOf("hello"));
            // Console.WriteLine(hello.IndexOf("is"));
            //Console.WriteLine(hello.Substring(1));
            //Console.WriteLine(hello.Substring(1,5));
            //Console.WriteLine("Enter  your age");
            //String agestr = Console.ReadLine();
            //int age = Convert.ToInt32(agestr);
            //bool isBanned = true;
            //if (age < 2 || isBanned)
            //{
            //    Console.WriteLine("You just born or banned");
            //}
            //else if (age < 10 || isBanned)
            //{
            //    Console.WriteLine("Pleae finish your high school or may be banned");
            //}
            //else if (age < 18)
            //{
            //    Console.WriteLine("You are below 18 or may be banned");
            //}
            //else if(age < 75){
            //    Console.WriteLine("You can drive");
            //}
            //else
            //{
            //    Console.WriteLine("You can't drive");
            //}
            //int age = 20;
            //switch (age)
            //{
            //    case 18:
            //        Console.WriteLine("Please wait for an year");
            //        break;
            //    case 20:
            //        Console.WriteLine("You are 20");
            //        break;
            //    default:
            //        Console.WriteLine("Enjoy");
            //        break;
            //}
            //Loops in C sharp
            //int n = 0;
            //while (n < 10)
            //{
            //    Console.WriteLine(n+1);
            //    n++;
            //}
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //} while (i < 5);
            //for(int i = 0; i < 5; i++)
            //{
            //    if (i == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i + 1);
            //}
            //Greet("Himu");
            //Greet("Rohit");
            //Console.WriteLine(Average(2, 3, 4));
            //Console.WriteLine(Average(3, 5, 6));
            //Console.WriteLine(Average(3, 3));
            //OOPS-Classes and Objects
            //Player tommy = new Player();
            //Console.WriteLine(tommy.getHealth());
            //Console.WriteLine(tommy.name);
            //tommy.setHealth(100);
            //Console.WriteLine(tommy.getHealth());
            /*Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.display();
            */
            //Console.WriteLine("Size of int :{0} ", sizeof(int));
            /*double d = 5673.74;
            int i;
            i = (int)d;
            Console.WriteLine(i);*/
            /* int i = 75;
             float f = 53.057f;
             double d = 2345.7652;
             bool b = true;
             Console.WriteLine(i.ToString());
             Console.WriteLine(f.ToString());
             Console.WriteLine(d.ToString());
             Console.WriteLine(b.ToString());*/
            //Console.WriteLine("Hello\tWorld\n\n");
            /*const double pi = 3.14159;
            double r;
            Console.WriteLine("Enter radius");
            r = Convert.ToDouble(Console.ReadLine());
            double area = pi * r * r;
            Console.WriteLine("Radius:{0},Area:{1}", r, area);*/
            /*rectangle r = new rectangle();
            r.length = 10;
            r.width = 20;
            r.display();*/
            /*for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Good Morning");
            }*/

            /*int a = 200;
            int b = 100;
            int ret;
            manipulator m = new manipulator();
            ret = m.findmax(a, b);
            Console.WriteLine("Max value is :{0}", ret);
            */
            /*factorail f = new factorail();
            Console.WriteLine("Factorail of 7 is :{0} ", f.fact(7));
            Console.WriteLine("Factorail of 8 is :{0} ", f.fact(8));*/
            /*int? num1 = null;
            int? num2 = 45;
            double? num3=new double?();
            double? num4 = 3.14586;
            bool? boolval = new bool?();
            Console.WriteLine("Nullables at show:{0},{1},{2},{3} ", num1, num2, num3, num4);
            Console.WriteLine("A Nullable boolean value:{0} ",boolval);*/
            /*double? num1 = null;
            double? num2 = 3.14157;
            double? num3;
            num3 = num1 ?? 5.34;
            Console.WriteLine("Value of num3: {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine("Value of num3: {0}", num3);*/
            /*int[] n = new int[10];
            int i, j;
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Elements[{0}]={1}", j, n[j]);
            }
            foreach(int k in n)
            {
                int l = k - 100;
                Console.WriteLine("Elements[{0}]={1}", l, k);
            }*/
            /*string fnamee, lname;
            fnamee = "Himanshi";
            lname = "Aggarwal";
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string[] sarray = { "Hello", "From", "Tutorials", "Points" };
            string fullname = fnamee + lname;
            Console.WriteLine("Full name:{0}", fullname);
            string greetings = new string(letters);
            Console.WriteLine("Greetings :{0}", greetings);
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message:{0}", message);
            */
            /*string str1 = "This is test";
            string str2 = "This is text";
            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + "  are equal ");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal");
            }
            */
            /*string str = "this is test";
            if (str.Contains("test"))
            {
                Console.WriteLine("This seuenece 'test' was found");
            }*/
            /*string str = "Last night I dreamt of San Pedro";
            Console.WriteLine(str);
            string substr = str.Substring(23);
            Console.WriteLine(substr);*/
            /*string[] starray = new string[] {"Down the way nights are dark",
            "And the sun shines Daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"
            };
            string str = String.Join("\n", starray);
            Console.WriteLine(str);*/
            /*Books book1;
            Books book2;
            book1.title = "C Programming";
            book1.author = "Nuha Ali";
            book1.subject = "C Programing Tutorial";
            book1.book_id = 6495407;
            book2.title = "Telecom Billing";
            book2.author = "Zara Ali";
            book2.subject = "Telecom Biling Tutorail";
            book2.book_id = 64955700;
            Console.WriteLine("Book 1 title:{0}", book1.title);
            Console.WriteLine("Book 1 author:{0}", book1.author);
            Console.WriteLine("Book 1 subject:{0}", book1.subject);
            Console.WriteLine("Book 1 book_id : {0}", book1.book_id);
            Console.WriteLine("Book 2 title:{0}", book2.title);
            Console.WriteLine("Book 2 author:{0}", book2.author);
            Console.WriteLine("Book 2 subject:{0}", book2.subject);
            Console.WriteLine("Book 2 book_id : {0}", book2.book_id);*/
            /*int WeekdayStart = (int)Days.Mon;
            int WeekDayEnd = (int)Days.Fri;
            Console.WriteLine("Monday :{0}", WeekdayStart);
            Console.WriteLine("Friday :{0}", WeekDayEnd);*/
            /* Rectangle r = new Rectangle();
             r.setwidth(10);
             r.setheight(20);
             Console.WriteLine("Total area:{0}", r.getArea());*/
            /*Tabletop t = new Tabletop(4.5, 7.5);
            t.Display();*/

            /*Rectangle r = new Rectangle();
            int area;
            r.setWidth(5);
            r.setHeight(7);
            area = r.getArea();
            Console.WriteLine("Total area: {0}", r.getArea());
            Console.WriteLine("Total Paint Cost: ${0}", r.getCost(area));
            */
            /*PrintData p = new PrintData();
            p.print(5);
            p.print(500.263);
            p.print("Hello C++");*/
            /*Rectangle r = new Rectangle(10,7);
            double a = r.area();
            Console.WriteLine("Area :{0}", a);*/
            /*Caller c = new Caller();
            Rectangle r = new Rectangle(10,7);
            Traingle t = new Traingle(10,5);
            c.CallArea(r);
            c.CallArea(t);*/
            /*Box Box1 = new Box();
            Box Box2 = new Box();
            Box Box3 = new Box();
            double volume = 0.0;
            Box1.SetLength(6.0);
            Box1.SetBreadth(7.0);
            Box1.setHeight(5.0);
            Box2.SetLength(12.0);
            Box2.SetBreadth(13.0);
            Box2.setHeight(10.0);
            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1:{0}", volume);
            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2:{0}", volume);
            Box3 = Box1 + Box2;
            volume = Box3.getVolume();
            Console.WriteLine("Volume of Box3 :{0}", volume);*/
            /*Transcation t1 = new Transcation("001", "8/10/2012", 78900.00);
            Transcation t2 = new Transcation("002", "9/10/2012", 451900.00);
            t1.showTranscation();
            t2.showTranscation();*/
            /*abc fc = new abc();
            gfg sc = new gfg();
            fc.func();
            sc.func();*/
            /*#if (PI)
            Console.WriteLine("PI  is defined");
            #else
            Console.WriteLine("PI is not defined");
            #endif*/
            /*string str = "A Thousand Splendid Suns";
            Console.WriteLine("Matching words that start with 'S': ");
            showMatch(str, @"\bS\S*");*/
            /*Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch(TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException:{0}", e.Message);
            }*/
            FileStream f = new FileStream("test.dat", FileMode.OpenOrCreate,
                FileAccess.ReadWrite);
            for (int i = 1; i <= 20; i++)
            {
                f.WriteByte((byte)i);
            }
            f.Position = 0;
            for (int i = 0; i >= 20; i++)
            {
                Console.WriteLine(f.ReadByte() + " ");
            }
            f.Close();

            Console.ReadKey();

        }
    }
}
/*public class TempIsZeroException : Exception
{
    public TempIsZeroException(string message) : base(message)
    {

    }
}
public class Temperature
{
    int temperature = 0;
    public void showTemp()
    {
        if (temperature == 0)
        {
            throw (new TempIsZeroException("Zero Temperature found"));
        }
        else
        {
            Console.WriteLine("Temperature:{0}", temperature);
        }
    }
}*/