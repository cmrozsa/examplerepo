using System;
namespace oop_dogs

{
    public class DogReport
    {
        private Dog[] myDogs;


        public DogReport(Dog[] myDogs)
        {
            this.myDogs = myDogs;
        }

        
        public void PrintCombinationWeight()
        {
            for (int i = 0; i< Dog.GetCount()-1; i++)
            {
                for (int j = i+1; j< Dog.GetCount(); j++)
                {
                    int sum = myDogs[i].GetWeight() + myDogs[j].GetWeight();
                    if (sum > 75)
                    {
                        Console.WriteLine($"{myDogs[i].GetName()} and {myDogs[j].GetName()} have a combined weight of {sum} pounds");
                    }
                }
            }
        }
        public void PrintDogAvgWeight()
        {
            int sum = 0;
            for (int i = 0; i < Dog.GetCount(); i++)
            {
                sum += myDogs[i].GetWeight();
                // 0;
                // int weight = 0;
                // weight = ;
                
                // sum += weight;
            }
            Console.WriteLine("The average weight is " + (sum/Dog.GetCount()));
        }
        public void PrintAllDogs()
        {
            for (int i=0;i < Dog.GetCount(); i++)
            {
                Console.WriteLine(myDogs[i].ToString());
            }
        }
        
    }
}