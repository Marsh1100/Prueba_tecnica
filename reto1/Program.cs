

//1.Escriba un programa que reciba como entrada un número entero n, y entregue como salida el n-ésimo número de Fibonacci:
Console.WriteLine("********* Ejercicio 1 *********");
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

//2.Escriba un programa que reciba como entrada un número entero e indique si es o no un número de Fibonacci:
Console.WriteLine("********* Ejercicio 2 *********");
Console.Write("Ingrese número entero n para indicar si es o no un número de Fibonacci:");
int n2 = Int32.Parse(Console.ReadLine());

if(n>0 && n<2)
{
    Console.Write($"{n2} SI es un número Fibonacci.");
}else
{
    
    int f0 = 0;
    int f1 = 1;
    int fn = 0;
    for(var i = 2; i <= n2; i++)
    {
        if(fn==n2)
        {
            Console.Write($"{n2} SI es un número Fibonacci.\n");
            return;
        }
        fn = f0 + f1;
        f0 = f1;
        f1 = fn; 

    }
    
    Console.Write($"{n2} NO es un número Fibonacci.\n");
}

//3.Escriba un programa que muestres los m primeros números de Fibonacci, donde m es un número ingresado por el usuario:
Console.WriteLine("********* Ejercicio 3 *********");
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
