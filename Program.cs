class BinarySearch
{
    static void Main()
    {
        //int[] array = {30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60};
        int[] array = RandomSortedArray();
        int leftBorder = 0;
        int rightBorder = array.Length - 1;
        int tempMid = 0;
        Console.Write("\nEnter the element which need to be found:\t");
        int inputNumber = int.Parse(Console.ReadLine());

        while (array[tempMid]!=inputNumber)
        {
            tempMid = (leftBorder + rightBorder)/2;
            
            if (inputNumber < array[tempMid])
            {
                rightBorder = tempMid - 1;
            }
            
            else if (inputNumber > array[tempMid])
            {
                leftBorder = tempMid + 1;
            }          
        }
        Console.WriteLine($"\nElement position: {tempMid}, element value: {inputNumber}");    
    }

    static int[] RandomSortedArray()
    {
        Console.Write("Enter amount of the array elements:\t");
        int arrayAmount = int.Parse(Console.ReadLine());
        int[] randomArray = new int[arrayAmount];
        Random rnd = new Random();

        for (int i = 0; i <= randomArray.Length - 1; i++)
        {
            randomArray[i] = rnd.Next(-100, 100);
        }

        for (int i = 0; i < randomArray.Length; i++)
        {
            for (int k = 0; k < randomArray.Length - 1 - i; k++)
            {
                if (randomArray[k] > randomArray[k + 1])
                {
                    int replacingNum = randomArray[k];
                    randomArray[k] = randomArray[k + 1];
                    randomArray[k + 1] = replacingNum;
                }
            }
        }
        Console.WriteLine($"\nArray: {String.Join(", ", randomArray)}");
        return randomArray;
    }
}