Console.WriteLine("Etanol ou Gasolina?");

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Digite o preço do etanol (R$): ");
decimal etanol = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write("Digite o preço da gasolina (R$): ");
decimal gasolina = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine();
Console.ResetColor();

string recomendacao;


if (AbastecerComGasolina(etanol, gasolina))
{
    
    recomendacao = "Gasolina";
    
}
else
{
    
    recomendacao = "Etanol";
    
}

double razao = RazaoEtanolGasolina(etanol, gasolina) * 100;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nO preço do etanol corresponde a {razao:N1}% do preço da gasolina.");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"\nRecomendação: Abasteça com {recomendacao.ToUpper()}.");
Console.ResetColor();

double RazaoEtanolGasolina(decimal precoEtanol, decimal precoGasolina)
{
    return Convert.ToDouble(precoEtanol / precoGasolina);
}

bool AbastecerComGasolina(decimal precoEtanol, decimal precoGasolina)
{
    const double MinRazaoUsoGasolina = 0.73;
    return RazaoEtanolGasolina(precoEtanol, precoGasolina) >= MinRazaoUsoGasolina;
}