using System;

// Parte 1: Declaración y Uso de Variables
Console.Write("Ingrese un número entero: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
int numeroEntero = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

Console.Write("Ingrese un número decimal: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
double numeroDecimal = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

Console.Write("Ingrese un número decimal: ");
string? inputDecimal = Console.ReadLine();
if (double.TryParse(inputDecimal, out double _))
{
    Console.WriteLine($"Número decimal: {numeroDecimal}");
}
else
{
    Console.WriteLine("Entrada no válida para un número decimal.");
}
Console.Write("Ingrese un texto: ");
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
string texto = Console.ReadLine();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

Console.Write("Ingrese un valor verdadero o falso (true/false): ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
bool valorBooleano = bool.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

Console.WriteLine($"Número entero: {numeroEntero}, Número decimal: {numeroDecimal}, Texto: {texto}, Booleano: {valorBooleano}");

// Parte 2: Operaciones Matemáticas
Console.Write("Ingrese el primer número entero: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
int num1 = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

Console.Write("Ingrese el segundo número entero: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
int num2 = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

Console.WriteLine($"Suma: {num1 + num2}");
Console.WriteLine($"Resta: {num1 - num2}");
Console.WriteLine($"Multiplicación: {num1 * num2}");
Console.WriteLine($"División: {num1 / (double)num2}");

// Parte 3: Operaciones Lógicas
Console.Write("Ingrese el primer valor: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
int valor1 = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

Console.Write("Ingrese el segundo valor: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
int valor2 = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

Console.WriteLine($"{valor1} > {valor2}: {valor1 > valor2}");
Console.WriteLine($"{valor1} < {valor2}: {valor1 < valor2}");
Console.WriteLine($"{valor1} == {valor2}: {valor1 == valor2}");
Console.WriteLine($"AND: {(valor1 > 0 && valor2 > 0)}");
Console.WriteLine($"OR: {(valor1 > 0 || valor2 > 0)}");

// Enunciado 1: Clasificación de edad
Console.Write("Ingrese su edad: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
int edad = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

if (edad < 12)
    Console.WriteLine("Niño");
else if (edad <= 17)
    Console.WriteLine("Adolescente");
else if (edad <= 59)
    Console.WriteLine("Adulto");
else
    Console.WriteLine("Adulto mayor");

// Enunciado 2: Día de la semana
Console.Write("Ingrese un número del 1 al 7: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
int dia = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

switch (dia)
{
    case 1: Console.WriteLine("Lunes"); break;
    case 2: Console.WriteLine("Martes"); break;
    case 3: Console.WriteLine("Miércoles"); break;
    case 4: Console.WriteLine("Jueves"); break;
    case 5: Console.WriteLine("Viernes"); break;
    case 6: Console.WriteLine("Sábado"); break;
    case 7: Console.WriteLine("Domingo"); break;
    default: Console.WriteLine("Número inválido"); break;
}

// Enunciado 3: Verificación de acceso
string usuarioCorrecto = "gabriel";
string contraseñaCorrecta = "1234";

Console.Write("Ingrese el nombre de usuario: ");
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
string usuario = Console.ReadLine();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

Console.Write("Ingrese la contraseña: ");
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
string contraseña = Console.ReadLine();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
    Console.WriteLine("Acceso concedido");
else if (usuario == usuarioCorrecto)
    Console.WriteLine("Contraseña incorrecta");
else
    Console.WriteLine("Usuario no registrado");
