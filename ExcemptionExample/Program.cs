using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcemptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 4;
            //int b = 0;

            // using exemptions

            //try
            //{
            //    Console.WriteLine("a divided by b is:" + a / b);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Error as occured "  +  e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("finally has executed");
            //}



            //stringBuilder examples

            //string s1 = "This is an example of ";
            //s1 = s1 + "string concatenation";
            //Console.WriteLine(s1);


            //StringBuilder sb2 = new StringBuilder("This is an example of");
            //sb2.Append(" string concatenation");

            //sb2.AppendLine();
            //sb2.Append(" using StringBuilder.....");

            //Console.WriteLine(sb2);

            //sb2.Replace("StringBuilder", "the StringBuilder class....");
            //Console.WriteLine(sb2);


            // Examples of StringWriter and StringReader

            //StringReaderWrite swr = new StringReaderWrite();


            //Using Properties and Filds

            //Person person = new Person();
            //person.Age = 55;
            //Console.WriteLine("Age is " + person.Age);

            // Using Constructor

            //DefConstructor dc = new DefConstructor();
            //dc.DoThis();
            //AddConstructor ad = new AddConstructor();
            
        }
        #region - String write from User
        public class StringReaderWrite
        {
            StringBuilder sb = new StringBuilder();

            public StringReaderWrite()
            {
                WriteData();
                ReadData();
            }
            public void WriteData()
            {
                StringWriter sw = new StringWriter(sb);
                Console.WriteLine("Please Enter first and last name....");
                string name = Console.ReadLine();
                sw.WriteLine("Name: " + name);

                sw.Flush();
                sw.Close();
            }
            #endregion

            #region - String read Data from user
            public void ReadData()
            {
                StringReader sr = new StringReader(sb.ToString());
                Console.WriteLine("Reading the information....");

                while (sr.Peek() > -1)
                {
                    Console.WriteLine(sr.ReadLine());
                }
                Console.WriteLine();
                Console.WriteLine("Thank you!");

                sr.Close();
            }
            #endregion

        }

        #region - Using Property and Fields

        //Properties and Fields


    }
    public class Person
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if ((value > 0) && (value < 65))
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Age cannot be over 65!");
                }
            }
        }
    }
    #endregion

    #region - using Constructors
    // Using Constructors

    public class DefConstructor
    {
        public void DoThis()
        {
            Console.WriteLine("DoThis as run....");
        }
    }
    public class AddConstructor
    {
        public AddConstructor()
        {
            Console.WriteLine("The constructor has been called....");
            DoThat();
        }
        public void DoThat()
        {
            Console.WriteLine("DoThat has executed...");
        }
    }
    #endregion
}
