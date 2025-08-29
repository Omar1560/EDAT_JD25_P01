internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Complejidad de Algoritmos\n");
        //Console.WriteLine("Complejidad de Algoritmos Big O(1)");

        //var nombres = new List<string>() {"Omar","Javier","Helena","Ana","Rita"};
        //var primero = (List<string> arreglo) => arreglo != null && arreglo.Count > 0? arreglo[2] : "Lista vacia";
        //Console.WriteLine("El primer nombre es: " + primero(nombres));



        Console.WriteLine("Complejidad de Algoritmos Big O(n)");

        var numeros = new List<int>() { 1,2,3,4,5,6,7,8,9};
        var numeroMayor = (List<int> arreglo) =>
        {
            if (arreglo == null || arreglo.Count == 0)
            {
                return 0;
            }
            else
            {
                int mayor = arreglo[0];
                for (int i = 1; i < arreglo.Count; i++)
                {
                    if (arreglo[i] > mayor)
                    {
                        mayor = arreglo[i];
                    }
                }
                return mayor;
            };
        };
        int mayorNumero = numeroMayor(numeros);
        Console.WriteLine("El primer nombre es: " + numeroMayor(numeros));

        Console.ReadKey();
    }
}