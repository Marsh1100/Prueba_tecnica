
//Multiplicacion Rusa
//Desarrolle un programa que reciba como entrada el multiplicador y el multiplicando, y entregue como resultado el producto de ambos, calculado mediante el método de multiplicación rusa.

string seguir="Y";
do
{
    Console.ForegroundColor=ConsoleColor.Magenta; 
    Console.WriteLine("\n------------------------------------- MULTIPLICACIÓN RUSA --------------------------------------");
    Console.ResetColor();
    Console.Write("Ingrese el número del multiplicador: ");
    int m1 = Int32.Parse(Console.ReadLine());
    Console.Write("Ingrese el número del multiplicando:");
    int m2 = Int32.Parse(Console.ReadLine());

    int suma = 0;
    while (m1 != 0)
    {
        if (m1%2 != 0)
        {        
            suma +=m2;
            m2 *=2;
        }else{
            m2 *=2;
        }
        m1 /=2;
    }
    Console.WriteLine($"Resultado: {suma}");


    Console.Write("\n¿Desea agregar nuevos valores? (Y/N): ");
    seguir = Console.ReadLine();
}while(seguir.ToUpper()!="N");

