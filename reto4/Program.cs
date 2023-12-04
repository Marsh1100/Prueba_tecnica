// Votaciones de la CONFECH

Dictionary<string, List<string>> votosUniversidades = new(); 
Console.WriteLine("\nVotaciones de la CONFECH");

Console.Write("Ingrese número de universidades que participan en el proceso: ");
int n = Int32.Parse(Console.ReadLine());

for (var i= 1; i <= n; i++)
{
    Console.Write($"Ingrese nombre de la universidad {i}: ");
    string nombreUniversidad = Console.ReadLine();

    Console.WriteLine($"Ingrese los votos, que pueden ser: aceptar (A), rechazar (R), nulo (N) o blanco (B). (X) si ya finalizó la votación.");
    
    List<string> votos = new();
    string voto = "A";
    while(voto!="X")
    {
        Console.Write($"Voto: ");
        voto = Console.ReadLine(); 

        if(voto.ToUpper()!="A" && voto.ToUpper()!="R" && voto.ToUpper()!="N" && voto.ToUpper()!="B"  && voto.ToUpper()!="X")
        {
            Console.Write("Las opciones de marcado es inválida");
        }else
        {
            votos.Add(voto);
        }
    }

    votosUniversidades.Add(nombreUniversidad, votos);
};

List<int> resultados = new(){0,0,0};

foreach(var uni in votosUniversidades)
{
    List<int> votos = new();
    Console.WriteLine($"Universidad: {uni.Key}");
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

    Console.WriteLine($"{votos[0]} aceptan, {votos[1]} rechazan, {votos[2]} blancos, {votos[3]} nulos.\n");  

    if(votos[0]> votos[1])
    {
        resultados[0] += 1;
    }else if(votos[0]< votos[1])
    {
        resultados[1] += 1;
    }else
    {
        resultados[2] += 1;
    }
}

Console.WriteLine($"Universidades que aceptan: "+resultados[0]);
Console.WriteLine($"Universidades que rechazan: "+resultados[1]);
Console.WriteLine($"Universidades con empate: "+resultados[2]);






