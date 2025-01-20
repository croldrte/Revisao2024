char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
char[] letras = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
char[] especiais = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=', '{', '}', '[', ']', '/', '?', '"', ':', ';' };

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

double qtdNumeros = 0, qtdLetras, qtdEspeciais;
char[] numerosSenha = new char[qtdCaracteres - 1];
Random aleatorio = new Random();

if (temLetras == "S" && temEspeciais == "S")
{
    qtdNumeros = Math.Round(qtdCaracteres * .5, 0);
    qtdLetras = Math.Round(qtdCaracteres * .3, 0);
    qtdEspeciais = Math.Round(qtdCaracteres * .2, 0);
}
else if (temLetras == "S" && temEspeciais == "N")
{
    qtdNumeros = Math.Round(qtdCaracteres * .6, 0);
    qtdLetras = Math.Round(qtdCaracteres * .4, 0);
    qtdEspeciais = 0;
}
else if (temLetras == "N" && temEspeciais == "S")
{
    qtdNumeros = Math.Round(qtdCaracteres * .7, 0);
    qtdLetras = 0;
    qtdEspeciais = Math.Round(qtdCaracteres * .3, 0);
}
else
{
    qtdNumeros = qtdCaracteres;
    qtdLetras = 0;
    qtdEspeciais = 0;
}

for (int s = 0; s <= qtdNumeros - 1; s++)
{
    int numeroAleatorio = aleatorio.Next(numeros.Length);
    numerosSenha[s] = letras[numeroAleatorio];
}

foreach (char n in numerosSenha)
{
    Console.WriteLine(n);
}