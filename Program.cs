using System;


namespace humans_and_animals
{
    class Program
    {
            public static int nrOfVeggiesLeft = 50;
            public static int nrOfMeatLeft = 50;
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.PrintAnimal();
            int day = 0;

            while (true) 
            {
                Console.Clear();
                day++;
                Console.WriteLine("Det är dag " + day + ":");
                Console.WriteLine("-------");
                
                // LÄGG TILL DIN NYA KOD HÄR
                animal.CheckIfhungry(day);

                //nrOfVeggiesLeft = animal.FeedWithVegs(nrOfVeggiesLeft);
                // nrOfMeatLeft = animal.FeedWithVegs(nrOfMeatLeft);

                if (nrOfMeatLeft < 0 ){
                    nrOfMeatLeft = 0;
                }
                if (nrOfVeggiesLeft < 0 ){
                    nrOfVeggiesLeft = 0;
                }

                Console.WriteLine("Mat kvar");
                Console.WriteLine("------------");
                Console.Write("Kött :" + nrOfMeatLeft);
                Console.Write("\nVäxter :" + nrOfVeggiesLeft);

                
                if (nrOfMeatLeft <= 0 && nrOfVeggiesLeft <= 0)
                {
                    Console.WriteLine("\nMaten tog slut. Tryck på valfri tangent för att fortsätta...");
                    return;
                }
                
                
                // Wait for the next day
                Console.ReadKey();
            }
        }
         
    }
    
}
