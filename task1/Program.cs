Console.WriteLine("input count numbers");
int countNumbers = int.Parse(Console.ReadLine());
int[] array = new int[countNumbers];
int count = 0;

for (int i = 0; i <array.Length; i++)
{
    Console.WriteLine("input your number");
    array[i] = int.Parse(Console.ReadLine());
}


for (int i = 0; i <array.Length; i++)
{
Console.Write(array[i] + ",");
}
 
for (int i = 0; i <array.Length; i++)
{
    if(array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"count of positive numbers = {count}");