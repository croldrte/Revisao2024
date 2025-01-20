Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("=".PadLeft(17, '='));
Console.WriteLine("Gerador de Senhas");
Console.WriteLine("=".PadLeft(17, '='));
Console.ResetColor();

Console.Write("Sua senha deve conter quantos caracteres?: ");
int qtdCaracteres;
while (!int.TryParse(Console.ReadLine(), out qtdCaracteres) || qtdCaracteres <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Resposta inválida. Por favor, insira um número inteiro maior que 0: ");
    Console.ResetColor();
}

Console.Write("Sua senha deve conter letras? (S/N): ");
string temLetras = Console.ReadLine().ToUpper();
while (temLetras != "S" && temLetras != "N")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Resposta inválida. Por favor, insira 'S' para Sim e 'N' para Não: ");
    Console.ResetColor();
    temLetras = Console.ReadLine().ToUpper();
}

Console.Write("Sua senha deve conter caracteres especiais? (S/N): ");
string temEspeciais = Console.ReadLine().ToUpper();
while (temEspeciais != "S" && temEspeciais != "N")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Resposta inválida. Por favor, insira 'S' para Sim e 'N' para Não: ");
    Console.ResetColor();
    temEspeciais = Console.ReadLine().ToUpper();
}