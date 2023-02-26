float money;
int years;
int percent;
Console.WriteLine("Сколько хотите внести денег на свой вклад?");
money = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("На сколько лет будет данных вклад?");
years = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Под какой процент?");
percent = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < years; i++)
{
    money += money / 100 * percent;
    Console.WriteLine($" В этом году у вас прибавилось :{money}");
    Console.ReadKey();
}
Console.WriteLine($"Теперь у вас {money}");
