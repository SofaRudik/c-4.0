
void numbers(int [] array);
{
    for (int i=0;i<array.Length;i++)
    Console.WriteLine($"Введите {i}-ое число: ");
    array[i]=Convert.ToInt32(Console.ReadLine());
}
Console.Clear();
int [] array= new int [8];
numbers(array);
Console.WriteLine($"[{string.Join(",",array)}]");


