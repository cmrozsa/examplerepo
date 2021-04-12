namespace oop_dogs
{
    public class DogUtility
    {
        private Dog[] myDogs;
        public DogUtility(Dog[] myDogs)
        {
            this.myDogs = myDogs;
        }

        public void SortByBreed()
        {
            for (int i = 0; i < Dog.GetCount(); i++)
            {
                int min = i;

                for (int j = i+1; j < Dog.GetCount(); j++)
                {
                    if (myDogs[j].CompareTo(myDogs[min]) <0)
                    {
                        min = j;
                    }
                }
                if (min!= i)
                {
                    Swap(min, i);
                }
            }
        }
        public void Swap(int x,int y)
        {
            Dog temp = myDogs[x];
            myDogs[x] = myDogs[y];
            myDogs[y] = temp;
        }
    }
}