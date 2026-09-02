//En curso con estudiantes que aún se matriculan
// se ha realizado dos examenes de entrada
// se necesita ingresar dichas notas de todos los estudiantes

using System.Runtime.InteropServices;

System.Console.WriteLine("Ingreso de notas de curso");
int x=0;

while (x==0)
{
    for(int i=0;i<3;i++)
    {
        System.Console.WriteLine($"Ingreso de notas {i+1}: "  );
        int nota = int.Parse(Console.ReadLine());
    }


    System.Console.WriteLine("Necesita ingresar nuevo estudiante? (s/n)");
    char estudiante = char.Parse(Console.ReadLine());

    if(estudiante == 's') x= 0;
    else x=1;
}
