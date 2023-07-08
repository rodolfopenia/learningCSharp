// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Blackjack
// Reglas:
// 1. Debes juntar naipes e ir sumando sus valores.
// 2. No puedes pasaste del valor 21, automáticamente pierdes.
// 3. Si sacas un valor menor al de 21, debes ganarle al valor que haya juntado el bot.

int totalPlayer = 0;
int totalBot = 0;
int number = 0;
int coins;
string message = string.Empty;
string switchControl = "menu";
Random rnd = new Random();

while(true)
{
    Console.WriteLine("Bienvenido al C a s i n o");
    Console.WriteLine("¿Cuántas monedas quieres? (Necesitas una por juego): ");
    //coins = Console.ReadLine();
    int.TryParse(Console.ReadLine(), out coins);
    totalPlayer = 0;
    totalBot = 0;

    for(int i=0; i < coins; i++)
    {
        switch (switchControl)
        {
            case "menu":
                Console.WriteLine("Escriba Black '21' para jugar al 21");
                switchControl = Console.ReadLine();
                i--;
                break;
            case "21":
                do
                {
                    number = rnd.Next(1, 13);
                    totalPlayer = totalPlayer + number;
                    Console.WriteLine("Toma tu primera carta, jugador. Te salió la carta: " + number);
                    Console.WriteLine("¿Deseas otra carta?: ");
                } while (Console.ReadLine() == "Si");

                totalBot = rnd.Next(14, 23);
                Console.WriteLine("El bot tiene: " + totalBot);

                if (totalPlayer > totalBot && totalPlayer < 22)
                {
                    message = "Venciste al bot, felicidades!";
                    switchControl = "menu";
                }
                else if (totalPlayer >= 22)
                {
                    message = "Perdiste contra el bot, te pasaste del 21";
                    switchControl = "menu";
                }
                else if (totalPlayer <= totalBot)
                {
                    message = "Perdiste contra el bot, lo sentimos";
                    switchControl = "menu";
                }
                else
                {
                    message = "Condición no válida.";
                }
                Console.WriteLine(message);
                break;
            default:
                Console.WriteLine("Valor ingresado no válido en el casino");
                break;
        }
    }
}





