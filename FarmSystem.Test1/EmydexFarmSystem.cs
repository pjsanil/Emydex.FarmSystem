using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        //TEST 1
        List<string> animalsList = new List<string>();
        Cow cw = new Cow();
        Hen hn = new Hen();
        Horse hs = new Horse();
        Sheep sh = new Sheep();
        public delegate void linktoeventhandler();
        
        
        private string getAnimalType(object animal)
		{
            return animal.GetType().Name;
        }
        public void Enter(object animal)
        {
            string AnimalType = getAnimalType(animal);
            Global.AnimalTypeList(AnimalType);
   


            Console.WriteLine("{0} has entered the farm", AnimalType);
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            cw.Talk();
            hn.Talk();
            hs.Talk();
            sh.Talk();

            
        }

        //TEST 3
        public void MilkAnimals()
        {
            cw.ProduceMilk();
           
        }


        public void eventhandler()
        {
			
			Console.WriteLine("Emydex Farm is now empty");
        }

      

        //TEST 4
        public void ReleaseAllAnimals()
        {
            Global.ReleaseAnimal();
           Console.WriteLine("There are still animals in the farm, farm is not free");
        }
    }
}