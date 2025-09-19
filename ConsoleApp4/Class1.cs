using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Person
    {
        public string Name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 2
            #region Q1
            //Console.Write("Enter A Number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Number: {n}");
            #endregion

            #region Q2
            //String s = "Abdelaziz";
            //int.TryParse(s, out int p);
            //Console.WriteLine(s); // Since The String S Doesn't Contain A Number,
            // It Won't Convert It To Int And Will Display The Original Value Of The String.
            #endregion

            #region Q3
            //float n1 = 100.320f;
            //float n2 = 320.100f;
            //Console.WriteLine(n1 + n2); // Rounds To The Nearest If Large Number 
            #endregion

            #region Q4
            //Console.Write("Enter A String: ");
            //string str = Console.ReadLine();
            //Console.Write("Enter Number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(str.Substring(0, n));
            //Console.WriteLine(str.Substring(n));
            #endregion

            #region Q5
            //int x = 5;
            //int y = x;
            //Console.WriteLine($"X Before Modification : {x}");
            //Console.WriteLine($"Y Before Modification : {y}");
            //x = 10;
            //Console.WriteLine($"\nX After Modification : {x}"); // X Will Be Modified To 10
            //Console.WriteLine($"Y After Modfiication : {y}"); // Y Will Stay AS It Is 
            #endregion

            #region Q6
            //Person p1 = new Person();
            //p1.Name = "Abdelaziz";
            //Person p2 = p1;
            //Console.WriteLine($"P1 Before Modification : {p1.Name}");
            //Console.WriteLine($"P2 Before Modification : {p2.Name}");
            //p2.Name = "Tarek";
            //Console.WriteLine($"\nP1 After Modification : {p1.Name}");
            //Console.WriteLine($"P2 After Modfiication : {p2.Name}"); // Since It's A Reference, Both WIll Change Together.
            #endregion

            #region Q7
            //string s1 = "Abdelaziz";
            //string s2 = "Tarek";
            //Console.WriteLine($"String : {s1} {s2}");
            #endregion

            #region Q8
            //Console.Write("Enter Principal: ");
            //double principal = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter Rate: ");
            //Double rate = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter Time: ");
            //Double time = Convert.ToDouble(Console.ReadLine());
            //int Interest = (principal * rate * time) / 100;
            //Console.WriteLine($"Interest = {Interest}");
            #endregion

            #region Q9
            //Console.Write("Enter Weight: ");
            //Double weight = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter Height: ");
            //Double height = Convert.ToDouble(Console.ReadLine());
            //Double BMI = (weight) / (height * height);
            //Console.WriteLine($"BMI = {BMI}");
            #endregion

            #region Q10
            //Console.Write("Enter Temperature: ");
            //int temp = Convert.ToInt32(Console.ReadLine());
            //string res = " ";
            //if (temp < 10)
            //{
            //    res = "Just Cold";
            //}
            //else if (temp > 30)
            //{
            //    res = "Just Hot";
            //}
            //else
            //{
            //    res = "Just Good";
            //}
            //Console.WriteLine(res);
            #endregion

            #region Q11
            //Console.Write("Enter Day: ");
            //string d = Console.ReadLine();
            //Console.Write("Enter Month: ");
            //string m = Console.ReadLine();
            //Console.Write("Enter Year: ");
            //string y = Console.ReadLine();
            //Console.WriteLine($"Today's Date : {d} , {m} , {y}");
            //Console.WriteLine($"Today's Date : {d} / {m} / {y}");
            //Console.WriteLine($"Today's Date : {d} - {m} - {y}");
            #endregion

            #region Q12
            // Answer : a) 14/06/2024
            #endregion

            #region Q13
            // Answer :  f) A value 1 will be assigned to d.
            #endregion

            #region Q14
            // Answer : d) 6 1
            #endregion

            #region Q15
            // Answer : d) 7 7
            #endregion
        }
    }
}
