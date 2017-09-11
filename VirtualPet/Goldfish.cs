using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Goldfish
    {
        //put menu in method
        //put method for status
        
            
        //FIELDS
        private string name;
        private int hunger;
        private int length;
        private int happiness;
        private int tiredness;

        //PROPERTIES
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
        }

        public int Length
        {
            get { return this.length; }
        }

        public int Happiness
        {
            get { return this.happiness; }
        }

        public int Tiredness
        {
            get { return this.tiredness; }
        }

        //DEFAULT CONSTRUCTOR
        public Goldfish (string name)
        {
            this.name = name;
            this.hunger = 90;
            this.length = 5;
            this.happiness = 10;
            this.tiredness = 85;
        }

        //BEHAVIORS

        public void Status()
        {
            Console.WriteLine(this.name.ToUpper() + " THE GOLDFISH");
            Console.WriteLine("Length: {0} cm", this.length);
            Console.WriteLine("Hunger: " + this.hunger);
            Console.WriteLine("Tiredness: " + this.tiredness);
            Console.WriteLine("Happiness: " + this.happiness);
            Console.WriteLine(" ");
            Console.WriteLine("What do you want to do? Choose a number.");
            Console.WriteLine("1. Feed " + this.name);
            Console.WriteLine("2. Clean the water for " + this.name);
            Console.WriteLine("3. Watch " + this.name);
            Console.WriteLine("4. Try to catch " + this.name);
            Console.WriteLine("5. Nothing. I'm done hanging out with {0} for now.", this.name);
            Console.WriteLine(" ");
        }


        public void Feed()
        {
            if (this.hunger >= 10)
            {
                this.hunger -= 10;
                if (this.tiredness <= 80)
                {
                    this.tiredness += 20;
                }

                else
                {
                    this.tiredness = 100;
                }
                Console.WriteLine("Yum, that was delicious! Eating makes me sleepy though.");
            }

            else
            {
                Console.WriteLine("I'm too full!");
            }
            Console.WriteLine(" ");
        }

        public void CleanWater()
        {
            if(this.happiness <= 90)
            {
                this.happiness += 10;
            }

            else
            {
                this.happiness = 100;
            }

            Console.WriteLine("Yay, thank you! I feel much better.");
            Console.WriteLine(" ");
        }

        public void Watch()
        {
            if(tiredness <= 70)
            {
                this.tiredness += 10;

                Console.WriteLine("Isn't {0} a beautiful swimmer?", this.name);

                if(this.hunger <= 90)
                {
                    this.hunger += 10;
                }

            }

            else
            {
                Console.WriteLine("{0} is resting peacefully.", this.name);
                this.tiredness -= 20;

                if (this.happiness <= 90)
                {
                    this.happiness += 10;
                }
               
            }
            Console.WriteLine(" ");
        }

        public void Catch()
        {
            if (this.happiness >= 10)
            {
                this.happiness -= 10;
            }
            else
            {
                this.happiness = 0;
            }
            Console.WriteLine("Ouch! What are you doing??");
            Console.WriteLine(" ");
        }

    }
}
