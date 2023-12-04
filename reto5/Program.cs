
//Ejercicio 1
Console.Write("Ingrese número de ejercicios diarios que hace Sam: ");
int samDaily = Int32.Parse(Console.ReadLine());
Console.Write("Ingrese número de ejercicios diarios que hace Kelly: ");
int kellyDaily = Int32.Parse(Console.ReadLine());
Console.Write("Diferencia: ");
int difference = Int32.Parse(Console.ReadLine());

if(samDaily>=kellyDaily)
{
    Console.WriteLine("-1");
}
int samSolved = difference;
int kellySolved =0;

for(var i=1; i<=100; i++)
{
    samSolved += samDaily;
    kellySolved += kellyDaily;

    if(kellySolved>samSolved)
    {
        Console.WriteLine(i);
        return;
    }
}

//Ejercicio 2
Console.Write("Ingrese el tamaño del arreglo: ");
int s = Int32.Parse(Console.ReadLine());

List<int> list = new();
for(var i=1; i<=s; i++)
{
    Console.Write($"Ingrese valor de la lista {i}: ");
    int n = Int32.Parse(Console.ReadLine());

    list.Add(n);
}
Console.WriteLine(FindLongestSubsequence(list) ==0 ? "Algo salió mall":FindLongestSubsequence(list));


static int FindLongestSubsequence(List<int> lista)
{
    lista.Sort();
    List<int> listaTemp = lista;

    int s = lista.Count;
    while(s!=0)
    {
        for(var i=lista.Count; i>1; i--)
        {
            int sum = 0;
            if(i!=lista.Count)
            {
                listaTemp.RemoveAt(i);
            }
            for(var j=0; j< listaTemp.Count - 1; j++)
            {
                sum += listaTemp[j+1] - listaTemp[j];
            }
            if(sum%2 == 0)
            {
                return listaTemp.Count;
            }else{
                listaTemp = lista;
            }
        }
        s = 0;
    }
    return 0;
}