int[] notas = {18, 20, 15, 12};
Console.WriteLine("Notas del estudiante");
for (int i=0; i<notas.Length; i++)
{
    Console.WriteLine($"NOta {i+1}: {notas[i]}" );
}
//Calcular el promedio de las notas
int suma=0; //Variable para almacenar la suma de las notas
for (int i = 0; i < notas.Length; i++)
{
    suma+=notas[1]; //Suma cada nota a la variable suma
}
double promedio= (double)suma/notas.Length; //calcular el promedioo
Console.WriteLine($"Promedio: {promedio:F2}"); //Mostrar el promedio con dos decimales

//Determinar la nota mas alta y la mas baja
int notaMasAlta = notas[0];
int notaMasBaja = notas[0];
for(int i = 1; i<notas.Length; i++)
{
    if(notas[i]> notaMasAlta)
    {
        notaMasAlta=notas[i]; //Actualizar la nota mas alta si se encuentra una mayor
    }
    if(notas[1] < notaMasBaja)
    {
        notaMasBaja=notas[1]; //Actualizar la nota mas baja si se encuentra una menor

    }

}
Console.WriteLine($"Nota mas alta: {notaMasAlta}");
Console.WriteLine($"Nota mas baja: {notaMasBaja}")