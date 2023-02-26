float rubbleInWallet;
float dollarInWallt;
int rubToDollar = 64,
    dollarToRub = 66;
float exchangeCount;
int needOperation;
Console.WriteLine("Добро подаловать в обменник валют");
Console.WriteLine("Сколько у вас рублей?");
rubbleInWallet = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Сколько у вас долларов?");
dollarInWallt = Convert.ToSingle(Console.ReadLine());
Console.WriteLine($"У вас на счету {rubbleInWallet} рублей и {dollarInWallt} долларов");
Console.WriteLine("Какую операцию вы хотите выполнить?");
Console.WriteLine("1 - перевести все рубли в доллары");
Console.WriteLine("2 - перевести все доллары в рубли");
needOperation = Convert.ToInt32(Console.ReadLine());
Console.Write($"{needOperation}");
switch (needOperation)
{
    case 1:
        Console.WriteLine($" Вы хотите поменять доллары на рубли");
        Console.WriteLine("Сколько рублей вы хотите обменять?");
        exchangeCount= Convert.ToSingle(Console.ReadLine());
        if (rubbleInWallet>= exchangeCount)
        {
            rubbleInWallet -= exchangeCount;
            dollarInWallt += exchangeCount / rubToDollar;
            Console.WriteLine($" У вас на счету {rubbleInWallet} рублей и {dollarInWallt} долларов");
        }
        else
        {
            Console.WriteLine("У вас не достаточно денег");
        }
        break;
    case 2:
        Console.WriteLine("Обмен долларов на рубли");
        Console.WriteLine("Сколько хотите поменять");
        exchangeCount = Convert.ToSingle(Console.ReadLine());
        
        if (dollarInWallt >= exchangeCount)
        {
            dollarInWallt -= exchangeCount;
            rubbleInWallet += exchangeCount * dollarToRub;
            Console.WriteLine($" У вас на счету {rubbleInWallet} рублей и {dollarInWallt} долларов");
        }
        else
        {
            Console.WriteLine("У вас не достаточно денег");
        }
        break;
    default:
        Console.WriteLine("");
        break;

}