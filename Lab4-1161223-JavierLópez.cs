using System;

Console.Write("Ingrese el modelo de su nave:");
string modelo = Console.ReadLine();

Console.WriteLine("Ingrese la capacidad de carga de la nave:");
int capacidad = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el nivel de combustible de la nave:");
Decimal combustible = Convert.ToDecimal(Console.ReadLine());

Console.Write("El motor está activo?");
bool motor = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("El modelo de su nave es: " +modelo + "  " + "tiene una capacidad de carga de "+ capacidad + "  " + "Su nivel de combustible es: "+combustible + "  " + "¿El motor está activo?" + motor);