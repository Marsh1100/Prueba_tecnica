// Votaciones de la CONFECH

Dictionary<string, List<string>> votosUniversidades = new(); 
Console.ForegroundColor=ConsoleColor.Magenta; 
Console.WriteLine("\n---------------- Votaciones de la CONFECH ------------------------");
Console.ResetColor();


Console.Write("Ingrese número de universidades que participan en el proceso: ");
int n = Int32.Parse(Console.ReadLine());

for (var i= 1; i <= n; i++)
{
    Console.Write($"Ingrese nombre de la universidad {i}: ");
    string nombreUniversidad = Console.ReadLine();

    Console.WriteLine($"Ingrese los votos, que pueden ser: aceptar (A), rechazar (R), nulo (N) o blanco (B). (X) si ya finalizó la votación.");
    
    List<string> votos = new();
    string voto = "A";
    do
    {
        Console.Write($"Voto: ");
        voto = Console.ReadLine(); 

        if(voto.ToUpper()!="A" && voto.ToUpper()!="R" && voto.ToUpper()!="N" && voto.ToUpper()!="B"  && voto.ToUpper()!="X")
        {
            Console.ForegroundColor=ConsoleColor.Red; 
            Console.WriteLine("La opción de marcado es inválida");
            Console.ResetColor();

        }else
        {
            votos.Add(voto.ToUpper());
        }
    }while(voto.ToUpper()!="X");

    votosUniversidades.Add(nombreUniversidad, votos);
};

List<int> resultados = new(){0,0,0};

Console.ForegroundColor=ConsoleColor.Cyan; 
Console.WriteLine("\n---------------- RESULTADOS ------------------------");
Console.ResetColor();
foreach(var uni in votosUniversidades)
{
    List<int> votos = new();
    Console.ForegroundColor=ConsoleColor.Yellow; 
    Console.WriteLine($"Universidad: {uni.Key}");
    Console.ResetColor();

    foreach(var v in uni.Value)
    {
        Console.WriteLine($"Voto:{v}");
    }
    //Aceptan
    votos.Add(uni.Value.Where(a=> a=="A").Count());
    //Rechazan
    votos.Add(uni.Value.Where(a=> a=="R").Count());
    //Blanco
    votos.Add(uni.Value.Where(a=> a=="B").Count());
    //Nulo
    votos.Add(uni.Value.Where(a=> a=="N").Count());  

    Console.ForegroundColor=ConsoleColor; 
    Console.WriteLine($"{votos[0]} aceptan, {votos[1]} rechazan, {votos[2]} blancos, {votos[3]} nulos.\n");  
    Console.ResetColor();

    if(votos[0]> votos[1])
    {
        resultados[0] += 1;
    }else if(votos[0]< votos[1])
    {
        resultados[1] += 1;
    }else if(votos[0]!=0)
    {
        resultados[2] += 1;
    }
}


Console.WriteLine($"Universidades que aceptan: "+resultados[0]);
Console.WriteLine($"Universidades que rechazan: "+resultados[1]);
Console.WriteLine($"Universidades con empate: "+resultados[2]);






