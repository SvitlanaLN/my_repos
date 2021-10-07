using System;
using System.Globalization;
namespace Person_namespace
{
    public class Person
    {
        public string name;
        private DateTime birth_date;
        private string nationality;
        public string Nationality { get; set; }
        public string Birth_date
        {
            get => birth_date.ToShortDateString();
            set
            {
                birth_date = DateTime.Parse(value);
                GetAge(DateTime.Today);
            }
        }
        public  Person(string name, DateTime birth_date, string nationality)
        {
            try
            {
                this.name = name;
                Nationality = nationality;
                this.birth_date = birth_date;
                Birth_date = birth_date.ToShortDateString();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("{0} {1}", ex.Message, birth_date);
            }
            finally
            {
                GetAge(DateTime.Today);
            }
        }

        public Person(string name, DateTime birth_date) : this(name, birth_date, "Ukrainian") { }

        public Person() : this("Ivanov Ivan Ivanovich", DateTime.Parse("01/01/1981")) { }

        public double GetAge(DateTime date1)
        {
            if (DateTime.Parse(Birth_date) < date1)
                return Math.Round(date1.Subtract(DateTime.Parse(Birth_date)).Days / 365.25,1);
            else if (DateTime.Parse(Birth_date) > date1)
                return Math.Round(-DateTime.Parse(Birth_date).Subtract(date1).Days / 365.25,1);
            else return 0;

        }

        public virtual void SetNewInfo()
        {
        }
        public override string ToString() { return "\nName: "+ name+
                                            "\nBirthday date: "+ Birth_date+
                                            "\nAge: " + GetAge(DateTime.Today) + " years" +
                                            "\nNationality: " + Nationality ;}
        
    }
}