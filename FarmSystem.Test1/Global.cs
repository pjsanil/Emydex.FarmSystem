using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
	public static class Global
	{
		

		private static List<string> animals = new List<string>();
        static string animaltype;
        public static void AnimalTypeList(string AnimalType)
        {
            if (!(animals.Contains(AnimalType)))
                {
                animals.Add(AnimalType);

               }

              
        }

        public static void ReleaseAnimal()
		{
            int i = 0;
            if (animals.Count >0)
			{
                while(!(animals.Count==0))
                {
                    animaltype = animals[i];
                    
                    animals.Remove(animaltype);
                    Console.WriteLine("{0} has left the farm", animaltype);
                    
                }
             }
		}
        public static List<string> AnimalsReturn
        {
            get { return animals; }
        }
    }
}
