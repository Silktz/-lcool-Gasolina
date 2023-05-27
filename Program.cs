// By Silktz 
Console.WriteLine("--- Etanol ou Gasolina? ---");

decimal Etanol, Gasolina, Resultado;

Console.WriteLine("Digite o preço do etanol (R$" );
Etanol = decimal.Parse(Console.ReadLine()!); 

Console.WriteLine("Digite o preço da gasolina (R$" );
Gasolina = decimal.Parse(Console.ReadLine()!); 

Calculo();

bool valores = Gasolina < Etanol; 
if (valores)
{
Console.WriteLine("Recomendação: Abasteça com ETANOL");
}
else
{
Console.WriteLine ("Recomendação: Abasteça com GASOLINA.");
}

void Calculo()
{
Resultado = Etanol / Gasolina * 100;
Console.WriteLine ($"O preço do etanol corresponde a {Resultado:n2}% ao preço da gasolina.");
}
