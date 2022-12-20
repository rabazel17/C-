// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите числа  ");
string num = Console.ReadLine();

string[] Numbers = num.Split(' ');
int[] Array = new int[Numbers.Length];

for (int i = 0; i < Numbers.Length; i++)

   
    {
        Array[i] = int.Parse(Numbers[i]);
    }
void CountNumb( int[] array)
{
    int count = 0;
    for(int i=0; i < array.Length; i++)
  { 
    if (array [i]>0)
    {
        count+=1;
    }
  } 
    Console.WriteLine($"Количество чисел больше 0 -> {count}");
  
}
CountNumb(Array);