int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
         array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray( int[] array)
{
    for( int i = 0; i < array.Length; i++)
    {
        Console.Write(array [i] + " ");
    }
    Console.WriteLine();
}

/*
//Задача 1.

int[] NegativeArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

Console.Write("Input a number elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

Console.WriteLine();

int[] result = NegativeArray(myArray);
ShowArray(result);
*/

/*
// Задача 2.

int CountNumInDiap(int[]array, int a, int b)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if(array[i] >= a && array[i] <= b)
            count++;

    return count;
}
Console.Write("Input a number elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min bound of diapazone: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max bound of diapazone: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);


int amount = CountNumInDiap(myArray, numberA, numberB);
Console.WriteLine($"Amount numbers which is in diapazone - {amount}");
*/

/*
int[] MultiplicationPairs(int[] array)
{
    int size = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;
    int[] newArray = new int[size];

    // for (int i = 0; i < newArray.Length; i++)
    //     newArray[i] = array[i] * array[array.Length - 1 - i]; // первый способ
    
    for (int i = 0, j = array.Length - 1; i < newArray.Length; i++, j--) // второй способ
        newArray[i] = array[i] * array[j];
    
    return newArray;
}

Console.Write("Input a number elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

Console.WriteLine();

int[] result = MultiplicationPairs(myArray);
ShowArray(result);
*/