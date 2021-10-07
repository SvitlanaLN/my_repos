using System;
namespace Person_namespace
{
    public class Working_person : Person, IAdult
    {
        private double experience;
        private string job;
        private string passport;

        public string Expirience
        {
            get { return experience.ToString(); }
            set { experience = Double.Parse(value); }
        }

        public string Job { get; set; }

        public string Passport { get; set; }

        public Working_person(string name, DateTime birth_date, double exp, string job_place, string passp): base(name, birth_date)
        {
            Expirience = exp.ToString();
            Job = job_place;
            Passport = passp;
        }

        public override string ToString()
        { return base.ToString() + "\nExperience: " + Expirience + " years" + "\nJob_place: " + Job +PrintPassport(Passport); }

        public override void SetNewInfo()
        {
            Console.Write("Enter properties Working_person:\nExperience: ");
            Expirience = Double.Parse(Console.ReadLine()).ToString();
            Console.Write("Job_place: ");
            Job = Console.ReadLine();
            Console.Write("Passport: ");
            Passport = Console.ReadLine();
        }

        public static Working_person ConvertToWorking_person(Person person)
        {
            Working_person obj_working_person = new Working_person(person.name, DateTime.Parse(person.Birth_date), 10, "SoftServe", "SN 000000");
            return obj_working_person;
        }

        public string PrintPassport(string serial_passport)
        {
             return "\nPassport: " + serial_passport;
        }

}
}
