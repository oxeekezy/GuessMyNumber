using System;
using GuessTheNumber;

NumberManager nm;
Random random;
int randomNumber;
            
while (true)
{
    Console.WriteLine("\nУгадайте случайное число!\nУ вас 5 попыток!");

    random = new Random();
    randomNumber= random.Next(1, 20);

    //Console.WriteLine(randomNumber);

    nm = new NumberManager(200);

    for (var i=0; i<5;i++)
    {
        Console.Write($"Попытка[{i+1}]:");
        if (int.TryParse(Console.ReadLine(), out int input))
        {
            var result = nm.TryToGuess(input).GetResult();
            Console.WriteLine(result.Item2);

            if (!result.Item1) continue;
            Console.WriteLine("\n\nОтлично, попробуйте еще с одним числом!");
            break;
        }
                    
        Console.WriteLine("Не число!");
    }
}