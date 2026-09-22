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