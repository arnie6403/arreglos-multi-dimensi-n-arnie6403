using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 3, 7, 1, 9, 4, 2 };

        // --- INICIO DE LÓGICA DEL ALUMNO ---
        if (numeros.Length == 0)
        {
            Console.WriteLine("El arreglo está vacío");
        }
        else
        {
            int maximo = numeros[0]; // asumimos el primer valor como máximo
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }
            }
            Console.WriteLine($"El número máximo es: {maximo}");
        }
        // --- FIN DE LÓGICA DEL ALUMNO ---
    }
}