using System;
namespace Person_namespace
{
    public class Working_person : Person
    {
        private double experience;
        private string job;
     //   private static string SoftServe;

        public string Expirience
        {
            get { return experience.ToString(); }
            set { experience = Double.Parse(value); }
        }

        public string Job { get; set; }

        public Working_person(string name, DateTime birth_date, double E, string G) : base(name, birth_date)
        {
            Expirience = E.ToString();
            Job = G.ToString();
        }

        public override string ToString()
        { return base.ToString() + "\nExperience: " + Expirience + " years" + "\nJob_place: " + Job; }


        public override void SetNewInfo()
        {
            Console.Write("Enter properties Working_person:\nExperience: ");
            Expirience = Double.Parse(Console.ReadLine()).ToString();
            Console.Write("Job_place: ");
            Job = Console.ReadLine();
        }

        public static Working_person ConvertToWorking_person(Person person)
        {
            Working_person obj_working_person = new Working_person(person.name, DateTime.Parse(person.Birth_date), 10, "SoftServe");
            return obj_working_person;
        }

    }
}
