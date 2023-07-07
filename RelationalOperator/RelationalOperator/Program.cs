// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Runtime.InteropServices;

var (valueOne, valueTwo, valueThree) = (10, 1, 2);

Console.WriteLine("Los valores son: " + valueOne + valueTwo + valueThree);
bool resultOne = valueOne == valueTwo;
Console.WriteLine("El resultado de la comparación valueOne == valueTwo: " + resultOne);

bool resultTwo = valueOne != valueTwo;
Console.WriteLine("El resultado de la comparación valueOne != valueTwo: " + resultTwo);

bool resultThree = valueOne > valueTwo;
Console.WriteLine("El resultado de la comparación valueOne > valueTwo: " + resultThree);

bool resultFour = valueOne < valueTwo;
Console.WriteLine("El resultado de la comparación valueOne < valueTwo: " + resultFour);

bool resultFive = valueOne >= valueTwo;
Console.WriteLine("El resultado de la comparación valueOne >= valueTwo: " + resultFive);

bool resultSix = valueOne <= valueTwo;
Console.WriteLine("El resultado de la comparación valueOne <= valueTwo: " + resultSix);