1)
	Este código permite al usuario teclear teclas y modificarlas con Shift, Ctrl o Alt, y muestra la información de la tecla presionada, incluidos los modificadores, en la consola.
	
2)
		void ImprimirMatriz(double[,] matriz)
	{
    	for (int i = 0; i < matriz.GetLength(0); i++)
    	{
        	for (int j = 0; j < matriz.GetLength(1); j++)
        	{
            	Console.Write(matriz[i, j] + " ");
        	}
        	Console.WriteLine(); // Agrega una nueva línea después de cada fila
    	}
	}

	Al llamar al método GetLength(i) en una matriz bidimensional, el parámetro i especifica cuál dimensión 		 	quieres obtener la longitud. En una matriz bidimensional, el primer índice (i = 0) corresponde a las filas 	y el segundo índice (i = 1) corresponde a las columnas.
	
3)

	 static void ImprimirMatrizConFormato(double[,] matriz, string formatString)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                string valorFormateado = matriz[i, j].ToString(formatString);
                Console.Write(valorFormateado + " ");
            }
            Console.WriteLine(); // Nueva línea después de cada fila
        }
    }
    Utilizamos ToString(formatString) para formatear cada valor de la matriz de acuerdo con la plantilla de 		 formato proporcionada.
4)
	static double[] GetDiagonalPrincipal(double[,] matriz)
	{
    	int filas = matriz.GetLength(0);
    	int columnas = matriz.GetLength(1);

    	if (filas != columnas)
    	{
        	throw new ArgumentException("La matriz no es cuadrada.");
    	}

    	double[] diagonalPrincipal = new double[filas];
    	for (int i = 0; i < filas; i++)
    	{
        	diagonalPrincipal[i] = matriz[i, i];
    	}

    	return diagonalPrincipal;
	}

	static double[] GetDiagonalSecundaria(double[,] matriz)
	{
    	int filas = matriz.GetLength(0);
    	int columnas = matriz.GetLength(1);

    	if (filas != columnas)
    	{
        	throw new ArgumentException("La matriz no es cuadrada.");
    	}	
    
    	double[] diagonalSecundaria = new double[filas];
    	for (int i = 0; i < filas; i++)
    	{
        	diagonalSecundaria[i] = matriz[i, filas - 1 - i];
    	}
        
    	return diagonalSecundaria;
	}
5)
	double[][] GetArregloDeArreglo(double [,] matriz){
    	int filas=matriz.GetLength(0);
	    int columnas=matriz.GetLength(1);

	    double [][] vector= new double[filas][];

    	for (int i = 0; i < filas; i++)
    	{
        	vector[i]=new double[columnas];
        	for (int j = 0; j < columnas; j++)
        	{
            	vector[i][j]=matriz[i,j];
        	}   
    	}
    	return vector;
	}
6)
	double[,]? Suma(double[,] A, double[,] B){
    	int fA=A.GetLength(0);
    	int cA=A.GetLength(1);
	
    	if(( fA == B.GetLength(0)) && ( cA == B.GetLength(1))){
        	double [,] resultado= new double [fA,cA];
        	for (int i = 0; i < fA; i++)
        	{
            	for (int j = 0; j < cA; j++)
            	{
                	resultado[i,j]=A[i,j]+B[i,j];
            	}
        	}
        	return resultado;
    	}
    	else return null;
	}
	
	double[,]? Resta(double[,] A, double[,] B){
    	int fA=A.GetLength(0);
    	int cA=A.GetLength(1);
	
    	if(( fA == B.GetLength(0)) && ( cA == B.GetLength(1))){
        	double [,] resultado= new double [fA,cA];
        	for (int i = 0; i < fA; i++)
        	{
            	for (int j = 0; j < cA; j++)
            	{
                	resultado[i,j]=A[i,j]-B[i,j];
            	}
        	}
        	return resultado;
    	}
    	else return null;
	}
	
	double[,] Multiplicacion(double[,] A, double[,] B){
    	
    	int fA = A.GetLength(0);
    	int cA = A.GetLength(1);
    	int fB = B.GetLength(0);
    	int cB = B.GetLength(1);
	
    	if (cA != fB)
    	{
        	throw new ArgumentException("El número de columnas de A no es igual al número de filas de B.");
    	}
	
    	double[,] resultado = new double[fA, cB];
	
    	for (int i = 0; i < fA; i++)
    	{
        	for (int j = 0; j < cB; j++)
        	{
            	double sum = 0;
            	for (int k = 0; k < cA; k++)
            	{
                	sum += A[i, k] * B[k, j];
            	}
            	resultado[i, j] = sum;
        	}
    	}
	
    	return resultado;
	}
	
7)
	    La variable x quedará definida como double, ya que 1.0 es un literal de punto flotante (double) y al 	multiplicarlo por i se promoverá a double.

    La variable y quedará definida como float, ya que 1f es un literal de punto flotante (float).

    La variable z quedará definida como float, porque en la expresión i * y, ambos operandos son enteros (int y float respectivamente), y en este caso, el operador binario (*) realizará la operación utilizando el tipo del operando que tenga una mayor precisión (en este caso float), y el resultado será de ese tipo.
    
8)
	    Error de compilación:
        En la línea object obj = new int[10];, estás creando un array de enteros (int) y tratando de asignarlo a una variable de tipo object. Esto generará un error de compilación porque un array de enteros no se puede convertir implícitamente a un objeto. Para corregirlo, puedes hacer un cast explícito: object obj = (object)new int[10];.
        En la línea Console.WriteLine(dyna.Length);, estás intentando acceder a la propiedad Length de un objeto dynamic. Esto generará un error de compilación porque la propiedad Length no está definida para el tipo dynamic.

    Error de ejecución:
        Después de corregir los errores de compilación, en la línea Console.WriteLine(obj.Length);, intentas acceder a la propiedad Length de un objeto obj, que es un array de enteros. Esto generará una excepción de tiempo de ejecución (System.NullReferenceException) porque la propiedad Length solo está disponible para arrays, pero obj es tratado como un objeto genérico (object) y no como un array. Para corregir esto, necesitas convertir obj de nuevo a un array antes de acceder a su propiedad Length: Console.WriteLine(((int[])obj).Length);.
        
9)

	En el código proporcionado, las líneas que provocarían errores de compilación son las siguientes:

    a = a * 2.0;
        Error: No se puede convertir implícitamente el tipo 'double' en 'long'. Se necesita una conversión explícita.
        Explicación: La variable 'a' es de tipo long, y al intentar multiplicarla por un valor double, se produce un error de tipo de datos.
    b = b * 2.0;
        Error: No se puede aplicar el operador '*' a operandos de tipo 'dynamic' y 'double'.
        Explicación: Al ser 'b' de tipo dynamic, no se puede realizar una operación matemática directa con un valor double sin una conversión explícita.
    b = b + 11;
        Error: No se puede aplicar el operador '+' a operandos de tipo 'dynamic' y 'int'.
        Explicación: Al intentar sumar un valor entero a 'b', que es de tipo dynamic, se produce un error de tipo de datos.
    obj = obj + 11;
        Error: El operador '+' no se puede aplicar a operandos de tipo 'object' y 'int'.
        Explicación: Al intentar sumar un valor entero a 'obj', que es de tipo object, se produce un error de tipo de datos.
    f.Edad = 22;
        Error: No se puede asignar un valor al resultado de esta expresión.
        Explicación: Al intentar modificar el valor de 'Edad' en un objeto anónimo (f), se produce un error ya que los objetos anónimos son de solo lectura.
 
10)
	Ejemplo con formato compuesto:
	
	double number = 3.1459;

	// Redondeo utilizando formatos compuestos
	string roundedFormatted = string.Format("Número redondeado: {0:F2}", number);
	Console.WriteLine(roundedFormatted);
	
	// Truncamiento utilizando formatos compuestos
	string truncatedFormatted = string.Format("Número truncado: {0:0.00}", number);
	Console.WriteLine(truncatedFormatted);
	
	Ejemplo con cadenas interpoladas:
	
	double number = 3.1459;

	// Redondeo utilizando cadenas interpoladas
	string roundedInterpolated = $"Número redondeado: {number:F2}";
	Console.WriteLine(roundedInterpolated);
	
	// Truncamiento utilizando cadenas interpoladas
	string truncatedInterpolated = $"Número truncado: {number:0.00}";
	Console.WriteLine(truncatedInterpolated);
	
	En estos ejemplos, al utilizar el formato compuesto "{0:F2}", se redondeará el número a 2 decimales, 			mientras que con el formato "{0:0.00}" se truncará el número a 2 decimales.
	
11)
	Se usa new List<int> { ... } para inicializar la lista a con los valores proporcionados.
	a.Remove(5); intenta eliminar el valor 5 de la lista, pero como no está presente, no tiene ningún efecto 		en la lista.
12)
	public static bool IsParenthesesBalanced(string input)
	{
    	Stack<char> stack = new Stack<char>();
	
    	foreach (char c in input)
    	{
        	if (c == '(')
        	{
            	stack.Push(c);
        	}
        	else if (c == ')')
        	{
            	if (stack.Count == 0)
            	{
                	return false;
            	}
            	stack.Pop();
        	}
    	}
	
    	return stack.Count == 0;
	}
	
13)
		public static int cambioBase(int num, int base)
	{
    	Stack<int> stack = new Stack<int>();
        int resto;
        string concatenacion="";
    	while(num >= base)
        	{
                resto= num % base;
                num= num / base;
            	stack.Push(resto);
            }
        	while(stack.Count<>0)
            {
                concatenacion = concatenacion + stack.Pop().toString();
            }
            int resultado = int.Parse(concatenacion);
        return resultado;

    }
	
	 este método solo convierte el número a la nueva base y lo devuelve como un número entero en base 10. Si deseas una representación de cadena del número en la nueva base, necesitarías realizar una conversión adicional.
	 
15)
	el código produciría una excepción de tipo DivideByZeroException en la primera línea del bloque try cuando intenta dividir 1.0 entre 0.
	Que se puede inferir? No se divide por 0
16)
	static void Main()
    {
        double sum = 0;
        string input;

        Console.WriteLine("Ingrese números uno por línea. Presione Enter para ingresar cada número.");
        Console.WriteLine("Ingrese una línea vacía para finalizar.");

        while (true)
        {
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }

            try
            {
                double number = double.Parse(input);
                sum += number;
                Console.WriteLine($"Suma acumulada: {sum}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            }
        }

        Console.WriteLine($"Suma total: {sum}");
    	}
	}
	
17)
	Bloque finally en Metodo1
	Overflow
	Excepción InvalidCast en Metodo3
	Método 3 propagó una excepción
