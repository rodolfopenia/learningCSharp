// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Blackjack
// Reglas:
// 1. Debes juntar naipes e ir sumando sus valores.
// 2. No puedes pasaste del valor 21, automáticamente pierdes.
// 3. Si sacas un valor menor al de 21, debes ganarle al valor que haya juntado el bot.

int totalPlayer = 25;
int totalBot = 15;
string message = string.Empty;

if (totalPlayer > totalBot && totalPlayer < 22)
{
    message = "Venciste al bot, felicidades!";
}
else if(totalPlayer >= 22)
{
    message = "Perdiste contra el bot, te pasaste del 21";
}
else if (totalPlayer <= totalBot)
{
    message = "Perdiste contra el bot, lo sentimos";
}
else
{
    message = "Condición no válida.";
}

Console.WriteLine(message);