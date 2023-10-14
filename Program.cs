int primeiro, segundo, maior;

Console.Write("Digite o primeiro numero aqui..:");
primeiro = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo numero aqui...:");
segundo = Convert.ToInt32(Console.ReadLine());

if (primeiro > segundo)
{
    maior = primeiro;
}
else
{
    maior = segundo;
}

Console.WriteLine($"O maior numero é {maior}");