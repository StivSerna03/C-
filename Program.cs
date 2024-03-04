        //calculadora
        Console.WriteLine("Ingrese el primer numero: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el operador (+, -, *, /):");
        char operador = char.Parse(Console.ReadLine());
        switch (operador)
        {
        case '+':
        double suma = x+y;
        Console.WriteLine($"La suma de los valores es: " {suma});
        break;
        case'-':
        double resta = x-y;
        Console.WriteLine($"La resta de los valores es: " {resta});
        break;
        case '/':
        double div = x/y;
        if (x==0 || y==0) Console.WriteLine("No se puede dividir por cero");
        else if (x!=0 && y!=0) Console.WriteLine($"La division entre los valores es: " {div});
        break;
        case '*':
        double mult = x*y;
        Console.WriteLine($"La multiplicacion entre valores es: " {mult});
        break;
        }

        //numero especial
        Console.WriteLine("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 5 == 0 && numero % 3 != 0 && numero % 2 != 0)
        {
            Console.WriteLine($"{numero} es un número especial.");
        }
        else
        {
            Console.WriteLine($"{numero} no es un número especial.");
        }

        
        //verificar tiempo sin bisiesto
        Console.WriteLine("Ingrese su edad:");
        int edad = int.Parse(Console.ReadLine());

        int dias = edad * 365;
        int semanas = edad * 52;

        Console.WriteLine($"Han pasado {dias} días desde que naciste.");
        Console.WriteLine($"Han pasado {semanas} semanas desde que naciste.");

        //Inicio de sesion
        string user = "admin";
        string pass = "rappi";
        int intentos = 3;

        while (intentos > 0)
        {
            Console.WriteLine("Ingrese el usuario: ");
            string User = Console.ReadLine();

            Console.WriteLine("Ingrese contraseña: ");
            string Pass = Console.ReadLine();

            if (User == user && Pass == pass)
            {
                Console.WriteLine("¡Acceso permitido!");
                break;
            }
            else
            {
                intentos--;
                if (intentos > 0)
                {
                    Console.WriteLine($"Acceso denegado. Te quedan {intentos} intentos.");
                }
                else
                {
                    Console.WriteLine("Acceso denegado. Se han agotado los intentos.");
                }
            }
        }