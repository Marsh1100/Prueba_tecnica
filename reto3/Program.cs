
//Numeros amistosos
using System.Diagnostics.CodeAnalysis;
Console.WriteLine("Números amistosos entre 1000 y 1500:");

for(var i = 1000; i<1500; i++)
{
    for(var j=1500; j>1000; j--)
    {
        if(i!=j)
        {
            int sum1 = 0;
            int sum2 = 0;

            int temp1 = i/2;
            int temp2 = j/2;
           
            for(var k=1; k<=temp1; k++)
            {
                if(i%k == 0)
                {
                    sum1 +=k;
                }
            }
            for(var l=1; l<=temp2; l++)
            {
                if(j%l == 0)
                {
                    sum2 +=l;
                }
            }
            if(sum1==j && sum2==i)
            {
                Console.Write($"{sum1} y {sum2}");
                return;
            }

        }
    }
}

