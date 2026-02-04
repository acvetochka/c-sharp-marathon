//Завдання 1
//Створіть консольний застосунок.
//Дано масив int[] values = { 10, 123, 56, 39, 67, 188 }
//;.
//Напишіть код, що порахує суму усіх значень масиву values.
//Виведіть суму на екран.

int[] values = { 10, 123, 56, 39, 67, 188 };
int total = 0;

for(int i = 0;  i < values.Length; i++)
{
    //Console.WriteLine(Convert.ToString(total) + "+" + Convert.ToString(values[i]) + "=");
    total += values[i];
    
}
    Console.WriteLine(total);