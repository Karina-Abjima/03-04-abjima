using System;
using System.Collections;
using System.Collections.Generic;

namespace Test
{
    class A<T>//to test arraylist appending with generic type
    {
        public static int num = 5;
        public static ArrayList ar = new ArrayList();
        public static HashSet<T> values = new HashSet<T>();
        public T appender_HS(T a)
        {
            values.Add(a);
            return a;

        }

        public T appender_AL(T a)
        {
            ar.Add(a);
            return a;

        }
        public void display()//displaying elements
        {
            Console.WriteLine(" All the added values in arraylist are of type " + typeof(T));
            foreach(T t in ar)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("hash set");
            foreach (T t in values)
            {
                Console.WriteLine(t);
            }
        }
    }
    class main
    {
        public static void Main(String[] args)
        {
            int? nullable_test1 = null;//nullable example
            Console.WriteLine("nullable example: {0}",nullable_test1 ?? 20);
            Console.WriteLine("setter getter example");
            DataStore<int, string> store = new DataStore<int, string>();
            store.Data = 55;//setting values using setter
            store.Role = "Department";
            Console.WriteLine(store.Data);//setter getter example
            Console.WriteLine(store.Role);
            //A ob = new A(AddNum);
            A<double> ob = new A<double>();//creation of array list with a type
            ob.appender_AL(20.3);//double arraylist
            ob.appender_AL(34.3);
            ob.appender_AL(55);
            ob.appender_AL(44.55);
            ob.appender_HS(12);//double hashset
            ob.appender_HS(12.45); 
            ob.appender_HS(33);
            ob.appender_HS(56.55); 
           ob.appender_HS(17.44);
            ob.display();

            A<string> ob1 = new A<string>();//of string type
            ob1.appender_AL("i");//arraylist
            ob1.appender_AL("am");
            ob1.appender_AL("of");
            ob1.appender_AL("string type");
            ob1.appender_HS("I");//hashset
            ob1.appender_HS("am");//having no regularity
            ob1.appender_HS("a");
            ob1.appender_HS("hash");
            ob1.appender_HS("set");
            ob1.display();

            Console.WriteLine("overriding example-using virtual and override");
            Parent obj = new Parent();//instance of parent class
            obj.show();
            obj = new Child();//instance of child class
            obj.show();
        }
    }
    
    class Parent//overriding example

    {
        public virtual void show()
        {
            Console.WriteLine("I am parent class!");
        }
    }

   
    class Child : Parent
    {
        public override void show()
        {
            Console.WriteLine("I am child class!");
        }
    }

    class DataStore<T1, T2>
    {
        public T1 data;
        public T2 role;
        public T1 Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        public T2 Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }
    }
}