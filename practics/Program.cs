using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace practics
{
  

    #region delegate
    public delegate int summ(int a, int b);
    public delegate double pi(double r);
    public delegate void show1();
    public delegate void show();

    enum Gender
    {Male=0,female=1, other=3

    }
    #endregion



    class Program
    {
        #region fun
        public static int addition(int a, int b)
        {
            Console.WriteLine("this is value of addition method");
            return a + b;
        }
        public static int subtraction(int a, int b)
        {
            Console.WriteLine("this is value of subtraction method");
            return a - b;
        }
        public static int div(int a, int b)
        {
            Console.WriteLine("this is value of diving method");
            return a / b;
        }
        public static int mul(int a, int b)
        {
            Console.WriteLine("this is value of multiply method");
            return a * b;
        }


        class person
        {   /// <summary>
        /// use pascal case
        /// </summary>
            public int id { get; set; }
            public string name { get; set; }
          public  void get(Int16 h)
            {


               Int16 p=(Int16) Gender.Male;
                Gender k = (Gender)h;

                Console.WriteLine($"hello from get==={h} and {k}  bbb {p}");

            }
           

        }
        //use the dictionary instead of use the switch statement

       




        class Employee
        { 
            public string city { get; set; }
            public float salary { get; set; }
            public string name { get; set; }
            public string lastname { get; set; }
            public string country { get; set; }
            public  double circle(double u)
            {
                return u * u * 3.14;
            }
        
            public static int add(int a ,int b)
            {
                return a + b;

            }
            public static int sub(int a, int b)
            {
                return a - b;

            }
            public static int mul(int a, int b)
            {
                return a * b;

            }
            public static int div(int a, int b)
            {
                return a /b;

            }
            public static int dub(int a, int b)
            {
                return a *2* b;

            }
            public   (string a, string b) Full(string ab, string bs)
            {
                string aa = ab;
                string bb = bs;
                return (aa, bb);
            }

            //public Employee(string city, float salary, string name, string lastname, string county)
            //{
            //    this.city = city;
            //    this.country = country; this.lastname = lastname; this.salary = salary; this.name = name;
            //}
            public  static Dictionary<string,Employee> Det()
            {
                var st = new Dictionary<string, Employee>();

            //    var stat = new Employee("Lahore", 22, "taimoor", "safdarali", "Pakistan");
           //     st.Add("123", stat);

                return st;
                


            }
        }
        interface IEmployee
        {
            void show( int a);

        }
        interface IEmployee1
        {
            int add();

        }
        interface IEmployee2:IEmployee,IEmployee1
        {
            void Get(int b, int a);

        }
        class Person : IEmployee2
        {
            private int width;
            private int length;

            public int add()
            {
                return width + length;
                
            }

            public void Get(int a, int b)
            {
                width = a; length = b;
            }

            public void show(int a)
            {
                Console.WriteLine(a);
            }
        }

        public abstract class A
        {
            public abstract void show();
            public void another()
            {

                Console.WriteLine("this is another merthod");
            }
        }
        public class B : A
        {
            public override void show()
            {
                Console.WriteLine("this is another show methodd");
            }
        }
        public   abstract   class Ab
        {
        public     abstract int Add( int a);
        }
        public class sum : Ab
        {
           
           public   override int Add(int a)
            {
                Console.WriteLine(a);
                return a;

            }
        }

        public  class depart
        {
            //p len;


            //    public  depart(p len)
            //{
            //    this.len = len;
            //}
            //public p fun()
            //{
            //    return this.len;

            //}
            //public static  void Func(int [] arr)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
                
            //}

            public static void Func<f>(f[] str)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    Console.WriteLine(str[i]);
                }
            }
        }


        // delegate double pi(double e);
        //static  pi df = PI;
        //delegate double squr(double r);
        //static squr fg = Sqr;

        
        public static  void He()
        {
           // await Task.Run(new Action(he));
            Thread s = new Thread(he);
            s.Start();
            //6
            Console.WriteLine("main he 6");
        }
        public static void he()
        {
            Thread.Sleep(20000);
            //5
            
            Console.WriteLine("he thread 5");
        }
        public static  void get()
        {
        //  await Task.Run(new Action(fun));
            Thread gh = new Thread(fun);
            gh.Start();

            //4
            Console.WriteLine("another thread  4");
        }
        public static  void fun()
        {
           Thread.Sleep(20000);
            //3
            Console.WriteLine("sleep thread 3");
        }

        #endregion

        static void Main(string[] args) {

             Socket sk;
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1244));
            sck.Listen(0);
            Socket skerver = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            new Thread(() =>
            {

               
                sk=sck.Accept();
                Console.WriteLine("Connected");
            });

            skerver.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1244));

            //get();
            ////1
            //Console.WriteLine("main thread 1");
            //He();
            ////2
            //Console.WriteLine("main another thread  2");
            //Console.ReadLine();

            //person p = new person();
            //p.get(0);



            ///asynic and non asynic



            //   multi cast delegate show1 gh = show();
            //summ fun = new summ(addition);


            //fun =fun+ subtraction;

            //fun =fun+div;
            //fun =fun+ mul;
            //fun.Invoke(3, 4);
            #region comment


            LinkedList<string> link = new LinkedList<string>();
            link.AddFirst("hello last ");
            link.AddLast("shahzaib");
            link.AddFirst("CZZ");
            link.AddFirst("alifirst");
            link.AddLast("after shahzaib");
            
            LinkedListNode<string> node = link.Find("shahzaib");
            link.AddBefore(node, "newshah");
            link.AddAfter(node, "after shah");
            int sd = link.Count(s => s == "shahzaib");
            int gh = link.Count(ss => ss == "CZZ");
            
            //node = link.FindLast("CZZ");
            //Console.WriteLine($"this is value of  and the {link.Count} and  ssnsns {node.Value} and {node.Next} adn pree" +
            //    $"prevous {node.ValueRef} and {node.List} and {node.Value}");

            foreach (var item in link)
            {
                Console.WriteLine(item);
                

            }


            Hashtable hash = new Hashtable();
            hash.Add(1, "shah");
            hash.Add(2, "safdar");
            hash.Add(3, "ali");
            hash.Add(4, "hassan");
            foreach (DictionaryEntry item in hash)
            {
 Console.WriteLine($"this is value of {item.Key} ans {item.Value}");
            }
            SortedList sortedList = new SortedList();
            sortedList.Add(2, "ali");
            sortedList.Add(3, "hassan");
            sortedList.Add(4, "ali");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"this is value of {item.Key} and {sortedList.Capacity} and {sortedList.Count} and {item.Value}");
            }
            //  double er= df.Invoke(34);
            // double rt = fg(29);
            // Console.WriteLine($"hello this is the value of {rt}");


            Func<int, int, int> jj = delegate (int w, int r)
            {
                return w + r;
            };
           int ass= jj(2, 4);
            Console.WriteLine($"hello id this is the id of {ass}");
            //int Add(int s, int g) { 
                
            //    return (s + g); 
            //}

            Predicate<int> pre = delegate (int f) { return f > 23; };
            Predicate<int> er = delegate (int g) { return g < 23; };
           bool t= er(23);
            Console.WriteLine($" value of t=={t}");
            #endregion
            //bool tt=    pre(12);
            //    Console.WriteLine($" value of t=={tt}");
            //    //  pre(12);
            //    Action<int> fg = Sum;
            //    int? s= null;
            //    Console.WriteLine($" value{s}");

            //    fg(23);
            //    Action action = AB;
            //    //  Predicate<int> pri = new Predicate<int>(T);
            //    Action act = delegate ()
            //    {
            //        Console.WriteLine($"hello is vlue ");
            //    };
            //    act();
            //    action();
            //      int sum (int a,int b )=>  (a + b);

            //    Console.WriteLine($"helllo {fgh}");
            //  double Sum(double r) => r * 3.14; 


            //show1 sd = new show1(show);

            //Console.WriteLine(sd.GetHashCode());
            //Console.WriteLine(sd.GetInvocationList());
            //sd.Invoke();


            // linklist, stack, queue; 
            //  LinkedList sd = new LinkedList();

            #region queue
            Queue q = new Queue();
            q.Enqueue(123);
            q.Enqueue(345);
            q.Dequeue();
            q.Peek();
            q.TrimToSize();
            q.Clear();
            Console.WriteLine($" thuis the value {q.Count}");
            #endregion
            #region stack
            Stack ts =new  Stack();
            ts.Push("hello start");
            ts.Push(123);
            ts.Push(345);
            ts.Push(456);
            ts.Push("end");
            ts.Peek();
            ts.Pop();
            
           
       
            
            Console.WriteLine($"helllp { ts.Contains(123)} and {ts.Pop()}");

            #endregion


          //static void show()=>Console.WriteLine("this is value of =={0} and the value of {1} and value of third{2}", Math.Sqrt(2),Math.Pow(2,3), Math.Sin(23));
          
            
            
            
            sum a = new sum();

            Employee emp = new Employee();

            Employee g = new Employee();
        //    (string kl, string b)=g.Full("shahzaib", "safdar ali");
            #region    comment
            //  Console.WriteLine("value is {0} and {1}", kl, b);
            //  Employee mn = new Employee();

            //  pi jk = new pi(mn.circle);
            //  double er = jk(22);
            //  Console.WriteLine("Thus is vlaur  ==  {0}", er);
            //double io=  jk.Invoke(5);
            //  Console.WriteLine("this is value of anaother variable=={0}", io);
            //  summ del = new summ(Employee.add);

            // int  u= del.Invoke(23, 67);


            //  Console.WriteLine("female=={0}  ",u);
            //  summ dl = new summ(Employee.div);

            //  int v = del.Invoke(23, 67);


            //  Console.WriteLine("female=={0}  ", v);
            //  summ l = new summ(Employee.dub);

            //  int uo = del.Invoke(23, 67);


            //  Console.WriteLine("female=={0}  ", uo);
            //  summ sl = new summ(Employee.mul);
            //  sl = Employee.add;
            //  int d = sl.Invoke(3, 1);


            //  Console.WriteLine("female=  add   {0} ", d);
            //  summ ddel = new summ(Employee.dub);

            //  int ud = ddel.Invoke(23, 67);


            //  Console.WriteLine("female=={0}  ", ud);


            //  a.Add(32);
            //  Person per = new Person();
            //  per.Get(133, 234);
            //  int ab = per.add();
            //  per.show(ab);

            //   Dictionary<string, string> dic = new Dictionary<string, string>();
            //   dic.Add("Name", "SHAHZAIB");
            //   dic.Add("last", "safdar");
            //   dic.Add("salary", "123");
            //   dic.Add("id", "32");
            //   dic.Add("gender", "male");
            //   dic.Add("city", "lahore");
            //   dic.Add("country", "Pak");
            //   Console.WriteLine(dic.GetHashCode());
            //   Console.WriteLine(dic["salary"]);
            //   Dictionary<int, Employee> Detail = new Dictionary<int, Employee>();
            //   Employee emp= new Employee("Lahore", 22, "Shahzaib", "safdar", "Pakistan");
            //   Employee emp1 = new Employee("Lahore", 22, "azeem", "safdar", "Pakistan");
            // //  Employee emp = new Employee("Lahore", 22, "Shahzaib", "safdar", "Pakistan");
            //   Employee emp2 = new Employee("Lahore", 22, "azeem", "safdar", "Pakistan");
            ///*  Dictionary<string,Employee>*/
            //  var ii= Employee.Det();
            //   Console.WriteLine(ii["123"].lastname);

            //   Detail.Add(1, emp);
            //   Detail.Add(2, emp1);
            //   Detail.Add(3, emp2);
            //   Detail.Add(4, emp);
            //   Detail.Add(5, emp2);
            //   Detail.Add(6, emp1);
            //   Detail.Add(7, emp);
            //   for (int i = 1; i < Detail.Count; i++)
            //   {
            //       Console.WriteLine(Detail[i].name);
            //   }



            //{ int[]a = new int[3];
            //    a[0] = 23;
            //    a[1] = 24;
            //    a[2] = 25;
            //depart.Func(a);
            //string[] str = { "ss", "gg", "fgj" };
            //char[] chr = { 'a', 'b', 'j' };
            //depart.Func(str);
            //depart.Func(chr);

            //            StringBuilder sb = new StringBuilder("ali");

            //            sb.Append("hello");
            //            sb.Replace("ali", "hassan");
            //            sb.AppendFormat("hell");

            //            for (int i = 0; i < sb.Length; i++)
            //            {
            //Console.WriteLine(sb[i]);
            //            }


            //Employee<string> emp = new Employee<string>("213sdfghjk\r");
            //Console.WriteLine(emp.get());

            //depart<string> em = new depart<string>("dddd");
            //em.Func("12", "22");
            //Console.WriteLine(em.fun());


            //byte[] bytes = Convert.FromBase64String("QUJDMTIz");
            //Console.WriteLine("Byte Array is: " + String.Join(" ", bytes));
            //string str = Convert.ToBase64String(bytes);
            //Console.WriteLine("The String is: " + str);

            //Console.WriteLine("Hello World!");
            //const string input = "hell";
            //byte[] array = Encoding.ASCII.GetBytes(input);
            //foreach (byte i in array)
            //{ Console.WriteLine("{0}==={1}", (char)i, i);

            //}


            //IPAddress ipv6Addr = IPAddress.Parse("ff00:0:0:0:0:0:e000:1");

            //Console.WriteLine(ipv6Addr.ToString());

            //IPAddress ipv4Addr = IPAddress.Parse("224.0.0.1");
            //Console.WriteLine(ipv4Addr.ToString());
            //byte[] b = ipv4Addr.GetAddressBytes();
            //ipv4Addr = new IPAddress(b);
            //Console.WriteLine(ipv4Addr.ToString());

            //b = ipv6Addr.GetAddressBytes();
            //ipv6Addr = new IPAddress(b);


            //Console.WriteLine(ipv6Addr.ToString());
            #endregion
        }

       

        static bool ER(int  g) => g>34;
        
            
        static bool Pre(int obj) =>

           
            obj > 123;
       

        //static void AB() => Console.WriteLine($"hi fghj fhh");
        //static void EHHH() => Console.WriteLine($"hi fghj fhh ehhh");
        //static void Sum(int y) => Console.WriteLine($"hi shsjs value of sum{y}");

        //static double PI(double i) => i * 3.13 * i;
        //static double Sqr(double r) => r;
        //static void Sho(int r) => Console.WriteLine($"this is value of {r}");


    }
    
}
