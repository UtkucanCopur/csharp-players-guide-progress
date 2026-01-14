int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue;
foreach(int index in array)
{
    if (index < currentSmallest)
    {
        currentSmallest = array[index];
    }
        
}
    
    
Console.WriteLine(currentSmallest);


int total = 0;
foreach (var index in array)
{
    total += index;
}
float average = (float)total / array.Length;
Console.WriteLine(average);