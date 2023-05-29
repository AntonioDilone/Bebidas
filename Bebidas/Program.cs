using Bebidas;

class Program
{
    static void Main(string[] args)
    {
        List<Bebida> bebidas= new List<Bebida>();
        Console.WriteLine("Cuantas bebida desea agregar?");
        int cant = int.Parse(Console.ReadLine());
        int sumCant = 0;
        //Este diccionario permite almacenar un valor por medio de una llave 
        Dictionary<string, int> sumatoriasPorTipo = new Dictionary<string, int>();

        for (int i = 0; i < cant; i++)
        {
            Bebida Alcohol = new Bebida();
            Console.WriteLine("Introduzca el nombre de la bebida");
            Alcohol.Nombre = Console.ReadLine();
            Console.WriteLine("Cual es el tipo de esta bebida?");
            Alcohol.Tipo = Console.ReadLine();
            Console.WriteLine("Cual es el porcentaje de alchol de esta bebida?");
            Alcohol.PorcentajeAlchol = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el color de la bebida");
            Alcohol.Color = Console.ReadLine();
            Console.WriteLine("Introduzca el volumen de la bebida");
            Alcohol.Volumen = double.Parse(Console.ReadLine());
            Console.WriteLine("Que cantidad de esta bebida tiene?");
            Alcohol.cantidad = int.Parse(Console.ReadLine());
            bebidas.Add(Alcohol);
            Console.Clear();
        }
        
        foreach (Bebida bebida in bebidas)
        {   
            //Si este diccionario contiene un tipo de bebida dentro de una llave se sumara la cantidad de la bebida como valor a esa llave
            if (sumatoriasPorTipo.ContainsKey(bebida.Tipo))
            {
                sumatoriasPorTipo[bebida.Tipo] += bebida.cantidad;
            }
            //Si no, entonces a la llave se le asignara la cantidad que tenga la bebida.
            else
            {
                sumatoriasPorTipo[bebida.Tipo] = bebida.cantidad;
            }
        }
        //Loop en cada instancia de objetos de la lista bebidas
        foreach (var i in bebidas)
        {
            i.Descrip();
        }
        //Loop en cada elemento dentro del diccionario
        foreach (var i in sumatoriasPorTipo) {
            Console.WriteLine("La cantidad para el tipo " + i.Key + " es de " + i.Value);
        }



    }







}