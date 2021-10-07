using System;
namespace Person_namespace
{
    public class Child : Person
    {
        private double weight;
        private double height;
        public string Weight 
        { 
            get {return weight.ToString();}
            set { weight = Double.Parse(value); }
        }

        public string Height 
        { 
            get {return height.ToString();}
            set { height = Double.Parse(value); }
        }
        
        public Child(string name, DateTime birth_date, double W, double H) : base(name, birth_date)
        {
            Weight = W.ToString();
            Height = H.ToString();
        }
        
        public override string ToString() 
           { return base.ToString()+"\nWeigth: " + Weight + " kg"+ "\nHeight: "+ Height+ " sm";}


        public void SetNewInfo()
        {
                Console.Write("Enter properties of a child:\nWeight: ");
                Weight = Double.Parse(Console.ReadLine()).ToString();
                Console.Write("Height: ");
                Height =Double.Parse(Console.ReadLine()).ToString();
        }
      
        public static Child ConvertToChild(Person person)
        {
            Child obj_child = new Child(person.name, DateTime.Parse(person.Birth_date), 10,10);
            return obj_child;
        }

    }
}