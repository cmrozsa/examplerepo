using System;

namespace oop_dogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] myDogs = new Dog[50];
            DogFile myFile = new DogFile("dogs.txt");
            myDogs = myFile.GetAllDogs();

            //Console.WriteLine(myDogs[0].ToString());

            DogReport myReport = new DogReport(myDogs);
            myReport.PrintAllDogs();
            //myReport.PrintDogAvgWeight();
            //myReport.PrintCombinationWeight();
            Console.WriteLine("\n\n");
            DogUtility myUtility = new DogUtility(myDogs);
            myUtility.SortByBreed();
            myReport.PrintAllDogs();
        }
        
    }
}
