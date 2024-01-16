namespace ejercicio.array1
{
    class program
    {
        public static void Main(String[] args)
        {
            int[] numerosEnteros = { 10, 45, 60, 6, 7, 3, 2, 10 };

            Console.WriteLine("################################");
            Console.WriteLine("Longitud");
            Console.WriteLine("################################");
            int posicion = numerosEnteros.Length;

            int primeraPosicion = numerosEnteros[0];

            Console.WriteLine("################################");
            Console.WriteLine("Valor primera posicion");
            Console.WriteLine("################################");
            Console.WriteLine(primeraPosicion);

            int penultimaPosicion = numerosEnteros[6];

            Console.WriteLine("################################");
            Console.WriteLine("Valor penultima posicion");
            Console.WriteLine("################################");
            Console.WriteLine(penultimaPosicion);

            int ultimaPosicion = numerosEnteros[7];
            
            Console.WriteLine("################################");
            Console.WriteLine("Valor ultima posicion");
            Console.WriteLine("################################");

            Console.WriteLine(ultimaPosicion);

            Console.WriteLine("################################");
            Console.WriteLine("Array ordenado de forma ascendente");
            Console.WriteLine("################################");
            Array.Sort(numerosEnteros);
           
            for(int i = 0; i < numerosEnteros.Length; i++)
            {
                Console.WriteLine(numerosEnteros[i]);
            }

            Console.WriteLine("################################");
            Console.WriteLine("Modificacion de la ultima posicion por 100");
            Console.WriteLine("################################");
            numerosEnteros[7] = 100;
            for(int i = 0;i < numerosEnteros.Length;i++)
            {
                Console.WriteLine(numerosEnteros[i]);
            }


            int[] arrayEnteros = { 45, 56,2 , -1, 98, 34 };

            int longitud = arrayEnteros.Length;

            Console.WriteLine("################################");
            Console.WriteLine("Longitud");
            Console.WriteLine("################################");

            Console.WriteLine(longitud);

            Console.WriteLine("################################");
            Console.WriteLine("Valor penultima posicion");
            Console.WriteLine("################################");

            int penultimaPosicionE = arrayEnteros[4];

            Console.WriteLine(penultimaPosicionE);

            Console.WriteLine("################################");
            Console.WriteLine("Valor primera posicion");
            Console.WriteLine("################################");

            int primeraPosicionE = arrayEnteros[0];
            Console.WriteLine(primeraPosicionE);

            Console.WriteLine("################################");
            Console.WriteLine("Valor ultima posicion");
            Console.WriteLine("################################");

            int ultimaPosicionE = arrayEnteros[5];
            Console.WriteLine(ultimaPosicionE);
        }
    }
}
