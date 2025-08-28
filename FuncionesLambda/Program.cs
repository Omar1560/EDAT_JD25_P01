using FuncionesLambda;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Expresion lambda como funcion");
        //Func<int , int> b = (a) => a * 2;
        //int resultado = b(4);     
        //Console.WriteLine("El resultado es: "+ resultado);
        //Func<int, int, int> mayor = (a, b) => {
        //    if (a > b)
        //    {
        //        return a;
        //    }
        //    else
        //    {
        //        return b;
        //    }


        //};
        //int resultado = mayor(45, 20);
        //Console.WriteLine("El resultado es: "+ resultado);

        var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Func<int, bool> esPar = (n) => n % 2 == 0;
        var pares = numeros.Where(esPar);
        Console.WriteLine("Hola");








        //Console.WriteLine("Funciones Lambda");
        //Persona pers = new Persona();


        //int edad = 18;
        //edad++;
        //edad++;
        //Console.WriteLine("La direccion de memoria es: ");
        //Console.WriteLine("El valor de la variable edad es: " + edad);





        Console.ReadKey();
    }
}