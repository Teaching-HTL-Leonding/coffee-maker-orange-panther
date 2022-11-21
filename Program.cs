Console.OutputEncoding = System.Text.Encoding.Default;

const decimal CAPPUCCINO = 3.5m, TEA = 1.5m, CACAO = 2.5m;
int product = 0;
decimal money = 0m, twoEuro = 0m, oneEuro = 0m, fiftyCent = 0m;
bool multiplier = true;

Console.Clear();
do
{
    if (multiplier == false) { System.Console.WriteLine("Invalid Input, please retry"); }
    Console.Write("Please enter the amount of money 💰 you put into the machine (e.g. 4,5) (smallest coin = 0,5c): ");
    money = decimal.Parse(Console.ReadLine()!);
    multiplier = money % 0.5m == 0;
} 
while (multiplier == false);

Console.WriteLine();

if (money < 1.5m)
{
    Console.WriteLine("Sorry, you don't have enough money 😞");
}
else
{
    while (money > 1.5m && product != 4)
    {        
        Console.Write("Do you want [1] a Cappuccino☕, [2] a Tea🍵, [3] a Cacao 🫘 or [4] nothing else? ");
        product = int.Parse(Console.ReadLine()!);

        switch (product)
        {
            case 1: money -= CAPPUCCINO; break;
            case 2: money -= TEA; break;
            case 3: money -= CACAO; break;
            case 4: break;
        }
    }

    if (money >= 0)
    {
        Console.WriteLine($"\nYou get {money} Euro 💶 back.");
        System.Console.WriteLine();

        if (money >= 2)
        {
            twoEuro = money / 2;
            twoEuro = Math.Floor(twoEuro);
            Console.WriteLine($"You get {twoEuro}x2 euro 🪙🪙 coins back.");
            money -= twoEuro * 2;
        }

        if (money >= 1)
        {
            oneEuro = money / 1;
            oneEuro = Math.Floor(oneEuro);
            Console.WriteLine($"You get {oneEuro}x1 euro 🪙 coins back");
            money -= oneEuro * 1;
        }

        if (money >= 0.5m)
        {
            fiftyCent = money / 0.5m;
            fiftyCent = Math.Floor(fiftyCent);
            Console.WriteLine($"You get {fiftyCent}x50 cent 🪙 coins back.");
        }
    }
    else { System.Console.WriteLine("\nSorry, you didn't have enough money 😞. Please restart."); }

}
