1)
	Los objetos de tipo string son inmutables en C#, lo que significa que una vez creados, no se pueden cambiar. 	Cuando modificas una cadena en realidad estás creando una nueva cadena en memoria.
	
	En C#, cuando asignas un valor literal a una variable de tipo object, el compilador realiza una conversión 	implícita de ese valor literal a un objeto del tipo adecuado. En este caso, al hacer o2 = "Z";, el valor literal "Z" se convierte implícitamente en un objeto de tipo string.

Por lo tanto, cuando asignas "Z" a o2, no estás creando un nuevo objeto, sino que estás asignando un objeto string que contiene la cadena "Z" a la variable o2.

Es importante entender que en C#, las cadenas (strings) son inmutables. Entonces, cuando cambias el valor de o2 asignándole una nueva cadena, no estás modificando la cadena original "A", sino que estás creando una nueva cadena "Z" y asignándola a o2.

2)

	char c1 = 'A';
	string st1 = "A";
	object o1 = c1; 			//Boxing entre de char a object
	object  o2 = st1;			//asignacion entre dos objetos
	char c2= (char)o1;			//unboxing de objecto a char
	string st2= (string)o2;		//asignacion entre dos objetos

3)
	Las conversiones implicitas se dan cuando el compilador automaticamente cambia el tipo de un valor para poder realizar una asignacion entre variables, por ejemplo de int a double.
	Las conversiones explicitas se dan cuando el programador necesita especificar el valor en el que se va a asignar el valor de una variable a otra, esto es necesario en ciertos casos en que los tipos no son compatibles, como el short y el int. Queda en responsabilidad del programador que la conversion no cause errores.
	
4)

	object o = "Hola Mundo!";
	string st = o as string; // No es necesario usar 'as', pero no es un error
	int i = 12;
	byte b = (byte)i; // Conversión explícita de int a byte
	double d = (double)i; // Conversión explícita de int a double
	float f = (float)d; // Conversión explícita de double a float
	o = i; // No se requiere conversión, se asigna directamente
	i = (int)o + 1; // Conversión explícita de object a int

	El operador as en C# se utiliza para realizar conversiones seguras entre tipos de referencia. Su principal 	ventaja es que, en lugar de lanzar una excepción si la conversión no es posible, devuelve null.
6)
	Necesita ser inicializada
	
7)
	Porque la primera comparacion es entre variables de tipo valor, por lo que comparan el valor que almacenan directamente, pero la segunda comparacion se da entre variables de tipo referencia, las cuales almacenan referencias a valores.Aunque los valores podrian ser los mismos, las referencias que contienen no necesariamente lo son, o estarian apuntando al mismo valor.
	
8)

	La clase StringBuilder se utiliza para construir y manipular cadenas de manera eficiente. A diferencia de las cadenas (string), que son inmutables (no se pueden cambiar una vez creadas), StringBuilder proporciona métodos para modificar el contenido de una cadena sin tener que crear una nueva cadena en cada modificación, lo que puede mejorar el rendimiento en situaciones donde necesitas realizar muchas operaciones de concatenación o modificación de cadenas.
	
	>Ejemplo pro StringBuilder
	
		StringBuilder sb = new StringBuilder();
	for (int i = 0; i < 1000; i++)
	{
	    sb.Append(i.ToString());
	}
	string resultado = sb.ToString();
   
   >Ejemplo pro String
   
   private String stringConstante;


11)

	Console.WriteLine("Ingrese una oracion");
	string str=Console.ReadLine();
	string[] cortada= str.Split(',');
	foreach (string mitad in cortada)
	{
    	Console.WriteLine(mitad);
	}
	
	
12)

	enum Meses
	{
    	Enero,
    	Febrero,
    	Marzo,
    	Abril,
    	Mayo,
    	Junio,
    	Julio,
    	Agosto,
    	Septiembre,
    	Octubre,
    	Noviembre,
    	Diciembre
	}
	class Program
	{
    	static void Main(string[] args)
    	{
        	string[] mesesList = Enum.GetNames(typeof(Meses));
        	Array.Reverse(mesesList);
        	foreach (string item in mesesList)
        	{
            	Console.WriteLine(item);
        	}
            	Console.WriteLine("Ingrese un mes");
            	string str= Console.ReadLine();
            	foreach (string item in mesesList)
            	{
                	if(str == item){
                    	Console.WriteLine("Existe");
                    	break;
                	}
    	}
    	}
	
	}
	
13)

	La primera línea imprimirá False, indicando que args no es null. La segunda línea imprimirá 0, indicando que la longitud del arreglo args es 0, lo que significa que no se pasaron argumentos al programa al ejecutarlo.
	
14)

Estás asignando un nuevo arreglo de enteros con longitud cero a vector. Esto significa que vector no es nulo en este punto, ya que contiene una referencia válida a un arreglo de enteros vacío.


15)
	intenta imprimir un mensaje de saludo utilizando el primer argumento pasado al programa a través de la línea de comandos. La expresión {0} en la cadena de formato indica que se insertará el valor del primer argumento en ese lugar.
	
	puede generar una excepción si no se pasan argumentos al programa o si el primer argumento no está presente. Esto se debe a que args[0] accede al primer elemento del arreglo args, y si args está vacío o nulo, o si no hay un argumento en la posición 0, se lanzará una excepción IndexOutOfRangeException.
	
16)
		class Program
	{
    	static void Main(string[] args)
    	{
            if(args.Length != 0)
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Hola " + args[i]);   
            }

            foreach (string item in args)
            {
                Console.WriteLine("Hola " + item);
            }
        }
	}
17)

	
	class Program
	{
    	static void Main(string[] args)
    	{
            if (int.TryParse(args[0], out int num))
            {
                esPrimo(num);
                
            }
        }

        static bool esPrimo(int num){
            if(num == 1)return false;
            else
            {
                for (int i = 2; i < Math.Sqrt(num); i++)
                {
                    if((num % i)== 0 ) return false;
                }
                return true;
            }
        }
	}


18)

	
	class Program
	{
    	static void Main(string[] args)
    	{
            if (int.TryParse(args[0], out int num))
            {
                Fac(num);
            }
        }

        static int Fac(int n)
        {
            int resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

	}
	
	b)
	
		  static int Fac(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * Fac(n - 1);
    }
    
   c)
   
   	 static int Fac(int n) => n == 0 ? 1 : n * Fac(n - 1);

19)

	
	class Program
	{
    	static void Main(string[] args)
    	{
            int f;
            if (int.TryParse(args[0], out int num))
            {
                Fac(num,out f);
                Console.WriteLine(f);
            }
        }

     //static int Fac(int n,out int f) => n == 0 ? 1 : n * Fac(n - 1,out f);
     static int Fac(int n, out int f) => n == 0 ? f = 1 : f = n * Fac(n - 1, out f);
    }
    
20)
   class Program
	{
    	static void Main(string[] args)
    	{
        	int a = 5;
        	int b = 10;
	
        	Console.WriteLine($"Antes del intercambio: a = {a}, b = {b}");
	
        	Swap(ref a, ref b);
	
        	Console.WriteLine($"Después del intercambio: a = {a}, b = {b}");
    	}
	
    	static void Swap(ref int x, ref int y)
    	{
        	int temp = x;
        	x = y;
        	y = temp;
    	}
	}
   
   Lo unico de interes aca es el uso de las ref, que son basicamente parametros por referencia
