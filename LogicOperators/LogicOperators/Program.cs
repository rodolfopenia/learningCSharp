// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

bool valueOne = true;
bool valueTwo = false;
bool valueThree = true;

// Otra manera de declarar
var (valueFour, valueFive, valueSix) = (true, true, false);

// Si el valor 1 es verdadero y el valor 2 es verdadero, entonces el resultado es verdadero.
// Todos los valores deben ser vedaderos para que el resultado sea verdadero
bool resultAnd = valueOne && valueTwo;
Console.WriteLine(resultAnd);

// Solo basta que uno debe ser verdadero para que el resultado sea verdadero
bool resultOr = valueOne || valueTwo || valueThree;
Console.WriteLine(resultOr);

bool resultAndOr = (valueOne && valueTwo) || valueThree;
Console.WriteLine(resultAndOr);

bool resultNot = !valueOne;
Console.WriteLine(resultNot);

// Validamos si los valores son diferentes entre si
bool resultXor = valueOne ^ valueTwo;
Console.WriteLine(resultXor);