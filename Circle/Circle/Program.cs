// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var radio = 0d;
var result = 0d;

// Constantes
const double Pi = 3.14;
// Nomenclatura de constantes
const string ConstanteDeEjemplo = "nombre de ejemplo";

Console.WriteLine("Bienvenido, calculemos círculos!");
// PI * radio^2
Console.WriteLine("Ingrese el valor del radio: ");
radio = Convert.ToDouble(Console.ReadLine());

result = Pi * radio * radio;

Console.WriteLine("El área de tu círculo es de: " + result);
