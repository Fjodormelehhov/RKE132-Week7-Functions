Console.WriteLine("What you want to convert: Celcius or Fahrenheit - F/C :");
char userChoice = Char.Parse(Console.ReadLine());


int userInput = Int32.Parse(Console.ReadLine());

switch (userChoice)
{
    case 'F':
        ConvertToCelcius(userInput);
        break;
    case 'C':
        ConvertToFahrenheit(userInput);
        break;
}


static void ConvertToCelcius(int celsius)
{
    Console.WriteLine($"{(celsius * 9) / 5 + 32}");
}

static void ConvertToFahrenheit(int fahrenheit)
{
    Console.WriteLine($"{((fahrenheit - 32) * 5 / 9)}");
}