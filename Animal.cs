using System;
using System.Collections.Generic;
namespace humans_and_animals
{
    class Animal
    {
        List<Animal> listOfAnimal = new List<Animal>();
        protected int hungryLevel;
        protected int dayCounter;
        protected string name;
        protected string kindOfAnimal;
        protected string preferedMeal;
        public int meatball = 50;
        public int veggies = 50;


        public void PrintAnimal()
        {
            listOfAnimal.Add(new Elephant("Adam","elefant","växter"));
            listOfAnimal.Add(new Giraf("Bertil","giraff","växter"));
            listOfAnimal.Add(new Coyote("Ceasar","prärievarg","kött"));
            listOfAnimal.Add(new Seal("David","säl","kött"));
            listOfAnimal.Add(new Bear("Erik","björn","kött & växter"));
            
            foreach (Animal animal in listOfAnimal )
            {
                Console.WriteLine(animal);
            }
        }

        public virtual void CheckIfhungry(int day)
        {  
            foreach (Animal animal in listOfAnimal)
            {
                animal.CheckIfhungry(day);
            }
            dayCounter++;
        } 
        
}

    class Giraf:Animal
    {
        public Giraf(string Name, string KindOfAnimal,string PreferedMeal)
        {
            name = Name;
            kindOfAnimal = KindOfAnimal;
            preferedMeal = PreferedMeal;
            hungryLevel = 7;     
        }

        public override string ToString()
        {
            return $"{name} är djurparkens {kindOfAnimal}. Favoritmat: {preferedMeal}";
        }

        public override void CheckIfhungry(int day)
        {
            
            day = dayCounter;
            dayCounter++;
            if (dayCounter == hungryLevel && Program.nrOfVeggiesLeft > 0)
            {
                Console.WriteLine($"{name} behövde äta och matades med {preferedMeal}");
                hungryLevel = 0; 
                Program.nrOfVeggiesLeft--;  
            }
            else if(Program.nrOfVeggiesLeft <= 0)
            {
                Console.WriteLine($"{name} behövde äta men det fanns inga {preferedMeal} kvar.");
            }
            else
            {
                Console.WriteLine($"{name} behövde inte äta idag.");
            }
        }
    }
     class Elephant:Animal
    {
        public Elephant(string Name, string KindOfAnimal,string PreferedMeal)
        {
            name = Name;
            kindOfAnimal = KindOfAnimal;
            preferedMeal = PreferedMeal;   
            hungryLevel = 10;  
        }

        public override string ToString()
        {
            return $"{name} är djurparkens {kindOfAnimal}. Favoritmat: {preferedMeal}";
        }

        public override void CheckIfhungry(int day)
        {
            
            day = dayCounter;
            dayCounter++;
            if (dayCounter == hungryLevel && Program.nrOfVeggiesLeft > 0)
            {
                Console.WriteLine($"{name} behövde äta och matades med {preferedMeal}");
                dayCounter = 0;
                Program.nrOfVeggiesLeft--;    
            }
            else if(Program.nrOfVeggiesLeft <= 0)
            {
                Console.WriteLine($"{name} behövde äta men det fanns inga {preferedMeal} kvar.");
            }
            else
            {
                Console.WriteLine($"{name} behövde inte äta idag.");
            }
        }
    }
     class Coyote:Animal
    {
        public Coyote(string Name, string KindOfAnimal,string PreferedMeal)
        {
            name = Name;
            kindOfAnimal = KindOfAnimal;
            preferedMeal = PreferedMeal;
            hungryLevel = 15;
        }

        public override string ToString()
        {
            return $"{name} är djurparkens {kindOfAnimal}. Favoritmat: {preferedMeal}";
        }

        public override void CheckIfhungry(int day)
        {
            
            day = dayCounter;
            dayCounter++;
            if (dayCounter == hungryLevel && Program.nrOfMeatLeft > 0)
            {
                Console.WriteLine($"{name} behövde äta och matades med {preferedMeal}");
                dayCounter = 0; 
                Program.nrOfMeatLeft--; 
            }
            else if(Program.nrOfMeatLeft <= 0)
            {
                Console.WriteLine($"{name} behövde äta men det fanns inga {preferedMeal} kvar.");
            }
            else
            {
                Console.WriteLine($"{name} behövde inte äta idag.");
            }
        }      
    }
     class Seal:Animal
    {
        public Seal(string Name, string KindOfAnimal,string PreferedMeal)
        {  
            name = Name;
            kindOfAnimal = KindOfAnimal;
            preferedMeal = PreferedMeal;
            hungryLevel = 13;
        }

        public override string ToString()
        {
            return $"{name} är djurparkens {kindOfAnimal}. Favoritmat: {preferedMeal}";
        }

        public override void CheckIfhungry(int day)
        {
            
            day = dayCounter;
            dayCounter++;
            if (dayCounter == hungryLevel && Program.nrOfMeatLeft > 0)
            {
                Console.WriteLine($"{name} behövde äta och matades med {preferedMeal}");
                dayCounter = 0;
                Program.nrOfMeatLeft--;
            }
            else if(Program.nrOfMeatLeft <= 0)
            {
                Console.WriteLine($"{name} behövde äta men det fanns inga {preferedMeal} kvar.");
            }
            else
            {
                Console.WriteLine($"{name} behövde inte äta idag.");
            }
        }
    }
     class Bear:Animal
    {
        public Bear(string Name, string KindOfAnimal,string PreferedMeal)
        {
            name = Name;
            kindOfAnimal = KindOfAnimal;
            preferedMeal = PreferedMeal;
            hungryLevel = 3;
        }

        public override string ToString()
        {
            return $"{name} är djurparkens {kindOfAnimal}. Favoritmat: {preferedMeal}";
        }

        public override void CheckIfhungry(int day)
        {
            
            day = dayCounter;
            dayCounter++;
            if (dayCounter == hungryLevel && Program.nrOfVeggiesLeft > 0 && Program.nrOfMeatLeft > 0)
            {
                Console.WriteLine($"{name} behövde äta och matades med {preferedMeal}");
                dayCounter = 0;
                Program.nrOfMeatLeft--;
                Program.nrOfVeggiesLeft--;
            }
            else if(Program.nrOfVeggiesLeft <= 0 && Program.nrOfMeatLeft <= 0 )
            {
                Console.WriteLine($"{name} behövde äta men det fanns inga {preferedMeal} kvar.");
            }
            else
            {
                Console.WriteLine($"{name} behövde inte äta idag.");
            }               
        }
    }
}