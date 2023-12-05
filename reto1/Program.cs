
int seguir=1;
do
{
    Console.ForegroundColor=ConsoleColor.Magenta; 
    Console.WriteLine("\n------------------------------------- MENU --------------------------------------");
    Console.ResetColor(); 

    Console.WriteLine("1.N-ésimo número de Fibonacci");
    Console.WriteLine("2.Ingrese número entero (n) para indicar si es o no un número de Fibonacci:");
    Console.WriteLine("3.Ingrese número entero (m) para mostrar los primeros (m) números de Fibonacci:");
    Console.WriteLine("0.Salir");
    
    Console.Write("Seleccion:");
    seguir = Int32.Parse(Console.ReadLine());

    switch(seguir)
    {
        case 1:
            Console.ForegroundColor=ConsoleColor.DarkYellow; 
            Console.WriteLine("\n\nEjercicio 1");
            Console.ResetColor(); 

            Console.Write("Ingrese número entero n para calcular el n-ésimo número de Fibonacci:");
            int n = Int32.Parse(Console.ReadLine());

            if(n<2)
            {
                Console.Write(n);
            }else
            {
                int f0_1 = 0;
                int f1_1 = 1;
                int fn_1 = 0;
                for(var i = 2; i <= n; i++)
                {
                    fn_1 = f0_1 + f1_1;
                    f0_1 = f1_1;
                    f1_1 = fn_1; 
                }
                Console.WriteLine($"Numéro de fibonnaci: {fn_1}");
            }
            break;
        case 2:
            Console.ForegroundColor=ConsoleColor.DarkYellow; 
            Console.WriteLine("\n\nEjercicio 2");
            Console.ResetColor(); 

            Console.Write("Ingrese número entero n para indicar si es o no un número de Fibonacci:");
            int n2 = Int32.Parse(Console.ReadLine());

            if(n2>=0 && n2<4)
            {
                Console.Write($"{n2} SI es un número Fibonacci.");
            }else
            {
                
                int f0 = 0;
                int f1 = 1;
                int fn = 0;

                bool fib = false;
                for(var i = 2; i <= n2; i++)
                {
                    if(fn==n2)
                    {
                        Console.Write($"{n2} SI es un número Fibonacci.\n");
                        fib = true;
                        break;
                    }
                    fn = f0 + f1;
                    f0 = f1;
                    f1 = fn; 

                }
                if(!fib)
                {
                    Console.Write($"{n2} NO es un número Fibonacci.\n");
                }                
            }
            break;
        case 3:
            Console.ForegroundColor=ConsoleColor.DarkYellow; 
            Console.WriteLine("\n\nEjercicio 3");
            Console.ResetColor(); 
            Console.Write("Ingrese número entero para mostrar los primeros m números de Fibonacci:");
            int n3 = Int32.Parse(Console.ReadLine());


                int f0_3 = 0;
                int f1_3 = 1;
                int fn_3 = 0;
                for(var i = 0; i <= n3-1; i++)
                {
                    if(i<2)
                    {
                        Console.Write(i+" ");
                    }else{
                        fn_3 = f0_3 + f1_3;
                        f0_3 = f1_3;
                        f1_3 = fn_3; 
                        Console.Write(fn_3+" ");
                    }
                    
                }
            break;
        case 0:
            break;
        default:
            Console.WriteLine("No es un valor válido!");
            break;
    }
    Console.WriteLine("");

}while(seguir!=0);
