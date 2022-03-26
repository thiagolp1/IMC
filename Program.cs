double peso, altura, imc;

Console.WriteLine("Altura (m)..: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Peso (kg)...: ");
peso = Convert.ToDouble(Console.ReadLine());

imc = peso / Math.Pow(altura, 2);

Console.WriteLine($"\nIMC: {imc:N1} kg/m²");