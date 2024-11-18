1)

	Write():Escribe la representación de texto del valor o valores 				  			especificados en el flujo de salida estándar.

	WriteLine(): Escribe los datos especificados, seguidos del terminador de 				 línea actual, en el flujo de salida estándar.
	
	ReadKey():Obtiene la siguiente tecla de carácter o de función presionada 			  por el usuario. 
	
	-----------------------------------------------------------------------
	        Console.Write("Hola");
        Console.ReadKey();
        Console.Write("Mundo");
    ----------------------------------------------------------------------
2)

 Secuencia de escape:

	Las combinaciones de caracteres que constan de una barra diagonal inv		ersa (\) seguidas de una letra o de una combinación de dígitos se 			denominan "secuencias de escape". Para representar un carácter de 			nueva línea, comillas simples u otros caracteres en una constante de 		caracteres, debe usar secuencias de escape. Una secuencia de escape se 	considera un carácter individual y por tanto es válida como constante 		de caracteres.
	
	\t: tabulador. Produce el mismo efecto que pulsar la tecla del 					Tabulador
	
	\n:	Nueva línea
	
	\":	Comillas dobles
	
	\\: Barra diagonal inversa
--------------------------------------------------------------------------
	Console.WriteLine("\thola");
	Console.WriteLine("\nlola");
	Console.WriteLine("\"trola");
	Console.WriteLine("\\rola");
--------------------------------------------------------------------------
9)

	String str;
	int medio,i;
	bool aux = true;
	i=1;
	str=Console.ReadLine();
	medio=(str.Length)/2;
	while(aux && i<=medio)
	{ 
    	Console.WriteLine("Comparando '{0}' y '{1}'",str[medio - i], str[medio + i]);
    	if(str[medio - i]!=str[medio + i]){
        	aux=false;
        	Console.WriteLine("Asimetrica");
    	}
    	else 
    	{
        	i+=1;
    	}
	}
	if(i == medio)Console.WriteLine("Simetrica");

10)

	for (int i = 0; i < 1000; i++)
	{
    	if(i % 17 == 0 ) Console.WriteLine("Multiplo de 17= {0}", i);
    	if(i % 29 == 0 ) Console.WriteLine("Multiplo de 29= {0}", i);
	}	

11)

	Console.WriteLine("10/3 " + 10/3);
	Console.WriteLine("10.0/3 " + 10.0/3);
	Console.WriteLine("10/3.0 " + 10 / 3.0);
	int a= 10, b=3;
	Console.WriteLine("si a y b son variables enteras, si a=10 y b=3");
	Console.WriteLine("entonces a/b = " + a/b);
	double c=3;
	Console.WriteLine("si c es una variable double, c=3");
	Console.WriteLine("entonces a/c = " + a/c);
	
	a)La division devuelve un resultado real si cualquiera de los dos involucrados es un real
	b)conecta el valor al string, quizas lo vuelve parte del string
	
12)

	int st=int.Parse(Console.ReadLine());
	for (int i = 0; i < 1000; i++)
	{
    	if(i % st  == 0)Console.WriteLine(i + " es multiplo de "+st);
	}
	
13)

	Cuando b es 0 ocurre una excepcion ya que la segunda condicion hace una division por 0,
	para evitarlo es necesario usar && en vez de & ya que el primer operador evita leer el
	segundo si la primera condicion es falsa, se llama "cortocircuito"

14)

	int a;
	int b=2;
	int c=3;
	
	a = (b < c) ? b : c;
	Console.WriteLine(a);
	
15)

	Se esta declarando dos veces la variable i, se tiene eliminar una de las dos declaraciones
	
16)
	Imprime cero, 1
