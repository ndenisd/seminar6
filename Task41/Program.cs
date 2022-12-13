// Task 41

Console.Clear();

Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
    if (Convert.ToInt32(Console.ReadLine()) > 0)
        count++;
}
Console.WriteLine(count);

