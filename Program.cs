Console.WriteLine("--- Entrada Válida ---");

int n;
Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ");
n = Convert.ToInt32(Console.ReadLine());


while(n != 0 && n >= 9)
{
    Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ");
    n = Convert.ToInt32(Console.ReadLine());
    
}

if(n == 0)
{
    Console.WriteLine("\nOperação cancelada.");
}
else if(n >= 1 && n <= 9)
{
    Console.WriteLine($"\nNúmero selecionado = {n}");
}

Console.WriteLine("\nVolte Sempre!");