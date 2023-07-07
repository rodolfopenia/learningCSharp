// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Programa que calcula el área de un rectángulo.
double sideA;
double sideB;
double result;
Console.WriteLine("Calcula el área de un rectángulo!!");
Console.WriteLine("Ingrese el valor del lado A");
sideA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el valor del lado B");
sideB = Convert.ToDouble(Console.ReadLine());
result = sideA * sideB;
Console.WriteLine("El resultado es: " + result);

// Declarar var
// Necesita inicializar
var sideC = 15.2;


// Operadores ariméticos
sideA++; // Incremento
sideA--; // Disminución
result = sideA - sideB; // resta
result = sideA * sideB; // multiplicación
result = sideA / sideB; // división
result = sideA % sideB; // residuo