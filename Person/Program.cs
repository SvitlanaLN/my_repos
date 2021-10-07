using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Person_namespace
{
    class Program
    {
        public  static void Main()
        {
                  List<Person> list_person = new List<Person>();
                  DateTime date = DateTime.Parse("02/02/2011");


                  //person0
                  Console.WriteLine("\nUnvisible creating new person0(name,birth_date,nationality)...\n");
                  Person person0 = new Person("", DateTime.Parse("01/02/1960"), "British");
                  list_person.Add(person0);

                  //person1
                  Console.WriteLine("\nUnvisible creating new person1(name,birth_date)...\n");        
                  Person person1 = new Person("Petro", DateTime.Parse("19/02/2011"));
                  list_person.Add(person1);

                  //person2
                  Console.WriteLine("\nUnvisible creating new person2()...\n");
                  Person person2 = new Person();
                  list_person.Add(person2);


                  //child3 (from person1)
                  Console.WriteLine("\nConverting existing person1 to a child3:");
                  Child child3 = Child.ConvertToChild(person1);
                  child3.SetNewInfo();
                  list_person.Add(child3);

                 //working_penson4 (from person2)
                 Console.WriteLine("\nConverting existing person2 to a working_person4:");
                // Working_person working_person4 = new Working_person("hfhfd", DateTime.Parse("01/02/1961"), "British");
             Working_person working_person4 = Working_person.ConvertToWorking_person(person2);
            // working_person4.SetNewInfo();
            list_person.Add(working_person4);


            Random ran = new Random();

            //random create Persons 
            foreach (int k in Enumerable.Range(0, 3))
            {
                list_person.Add(new Person("Person_"+k, new DateTime(ran.Next(DateTime.Today.Year - 100, DateTime.Today.Year), ran.Next(1, DateTime.Today.Month), ran.Next(1, DateTime.Today.Day))));
            }

            //random create Childs
            foreach (int k in Enumerable.Range(0, 3))
            {
                list_person.Add(new Child("Child_"+k, new DateTime(ran.Next(DateTime.Today.Year-17, DateTime.Today.Year), ran.Next(1, DateTime.Today.Month), ran.Next(1, DateTime.Today.Day)), 20, ran.Next(1, 20)));
            }

            Console.WriteLine("\n----------Original Collection----------");

            for (int k = 0; k < list_person.Count; k++)
            {
                 Console.Write("\n{0} ¹ {1}",list_person[k].GetType().Name,k+1);
                 Console.WriteLine(list_person[k]);
            } 

            Console.WriteLine(SortByHeight(list_person));
            Console.ReadKey();
        }

        public static string SortByHeight(List<Person> list_person)
        {
            StringBuilder result = new StringBuilder();
            var list_sorted_child = list_person.OfType<Child>().OrderBy(it => Double.Parse(it.Height)).ToList();
            result.Append("\n\n----------Childs sorted by heights----------\n");
            foreach (var it in list_sorted_child.Select((x, i) => new { item = x, index = i }))
            {
                result.Append($"\n\n{it.item.GetType().Name} ¹ {it.index}");
                result.Append(it.item.ToString());
            }
            return result.ToString();
        }
    }
}