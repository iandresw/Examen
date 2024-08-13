using Examen;
try
{
    string? strNota1, strNota2, strNota3;
    Asignatura asignatura = new Asignatura();
    Console.WriteLine("\n");
    Console.WriteLine("############# EXAMEN 1, PROGRAMACION 2 ##############");
    Console.WriteLine("\n");
    Console.WriteLine("Ingreese el nombre del Estudiante: ");
    asignatura.NombreAlumno = Console.ReadLine();
    Console.WriteLine("Ingrese el Numero de cuenta: ");
    asignatura.NumeroCuenta = Console.ReadLine();
    Console.WriteLine("Ingrese el correo electronico: ");
    asignatura.Email = Console.ReadLine();
    Console.WriteLine("Ingrese el Nombre de la Clase");
    asignatura.NombreAsignatura = Console.ReadLine();
    Console.WriteLine("Ingrese el Horario de la Clase");
    asignatura.Horario = Console.ReadLine();
    Console.WriteLine("Ingrese el Nombre del Docente");
    asignatura.NombreDocente = Console.ReadLine();
    Console.WriteLine("Ingrese la nota del primer parcial: ");
    strNota1 = Console.ReadLine();
    Console.WriteLine("Ingrese la nota del seundo parcial: ");
    strNota2 = Console.ReadLine();
    Console.WriteLine("Ingrese la nota del tercer parcial: ");
    strNota3 = Console.ReadLine();  

    if ((strNota1=="") || (strNota1 is null))
    {
        Console.WriteLine("La Nota del Primer Parcial no es valida!, Ingrese de nuevo");
        strNota1 = Console.ReadLine() ;
    }
    else if ((strNota2=="")||( strNota2 is null))
    {
        Console.WriteLine("La Nota del Segundo Parcial no es valida!, Ingrese de nuevo");
        strNota2 = Console.ReadLine();
    }
    else if ((strNota3 == "") || (strNota3 is null))
    {
        Console.WriteLine("La Nota del Tercer Parcial no es valida!, Ingrese de nuevo");
        strNota2 = Console.ReadLine();
    }

    bool valNota1, valNota2, valNota3, valRango;
    valNota1 = int.TryParse(strNota1, out asignatura.Nota1);
    valNota2 = int.TryParse(strNota2, out asignatura.Nota2);
    valNota3 = int.TryParse(strNota3, out asignatura.Nota3);

    if ((asignatura.Nota1>30) || (asignatura.Nota2>30))
    {
        Console.WriteLine("La Nota del Primer O segundo Parcial no es valida! Sobrepasa el Limite");
        valRango = false;
    }else if (asignatura.Nota1 > 40)
    {
        Console.WriteLine("La Nota del Tercer Parcial no es valida! Sobrepasa el Limite");
        valRango = false;
    }
    else
    {
        valRango=true;
    }

    if (valNota1 && valNota2 && valNota3&&valRango)
    {
        asignatura.Imprimir();
    }
    else if (valNota1 is not true)
    {
        Console.WriteLine("La Nota del Primer Parcial no es VALIDA!");
    }
    else if (valNota2 is not true)
    {
        Console.WriteLine("La Nota del Primer Parcial no es VALIDA!");
    }
    else if (!valNota3)
    {
        Console.WriteLine("La Nota del Primer Parcial no es VALIDA!");
    }
    else
    {
        Console.WriteLine("No se pudo completar");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}
