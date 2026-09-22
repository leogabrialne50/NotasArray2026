static void ImprimirNotas(int[] notasx)
{
    Console.WriteLine("Notas del estudiante:");
    for (int i = 0; i < notasx.Length; i++)
    {
        Console.WriteLine($"Nota {i+1}: {notasx[i]}");
    }
}

double CalcularPromedio(int[] notasx)
{
    int suma = 0;
    for (int i = 0; i < notasx.Length; i++)
    {
        suma += notasx[i];
    }
    return (double)suma / notasx.Length;
}

static int NotaMasAlta(int[] notasx)
{
    int notaMasAlta = notasx[0];
    for (int i = 1; i < notasx.Length; i++)
    {
        if (notasx[i] > notaMasAlta)
        {
            notaMasAlta = notasx[i];
        }
    }
    return notaMasAlta;
}  

static int NotaMasBaja(int[] notasx)
{
    int notaMasBaja = notasx[0];
    for (int i = 1; i < notasx.Length; i++)
    {
        if (notasx[i] < notaMasBaja)
        {
            notaMasBaja = notasx[i];
        }
    }
    return notaMasBaja;
}           

int[] notas = { 18, 20, 15, 12};

//Impresión de las notas del estudiante
ImprimirNotas(notas);

// Calcular el promedio de las notas
double promedio = CalcularPromedio(notas);
Console.WriteLine($"Promedio: {promedio:F2}");  // Mostrar el promedio con dos decimales

int notaMasAlta = NotaMasAlta(notas);
Console.WriteLine($"Nota más alta: {notaMasAlta}");

int notaMasBaja = NotaMasBaja(notas);
Console.WriteLine($"Nota más baja: {notaMasBaja}"); 


