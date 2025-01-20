char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
char[] letrasMi = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
char[] letrasMa = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
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

int qtdNumeros, qtdLetrasMi, qtdLetrasMa, qtdEspeciais;
Random aleatorio = new Random();

if (temLetras == "S" && temEspeciais == "S")
{
    qtdNumeros = (int)Math.Round(qtdCaracteres * .5, 0);
    qtdLetrasMi = qtdLetrasMa = (int)Math.Round(qtdCaracteres * .15, 0);
    qtdEspeciais = (int)Math.Round(qtdCaracteres * .2, 0);
}
else if (temLetras == "S" && temEspeciais == "N")
{
    qtdNumeros = (int)Math.Round(qtdCaracteres * .6, 0);
    qtdLetrasMi = qtdLetrasMa = (int)Math.Round(qtdCaracteres * .2, 0);
    qtdEspeciais = 0;
}
else if (temLetras == "N" && temEspeciais == "S")
{
    qtdNumeros = (int)Math.Round(qtdCaracteres * .7, 0);
    qtdLetrasMi = qtdLetrasMa = 0;
    qtdEspeciais = (int)Math.Round(qtdCaracteres * .3, 0);
}
else
{
    qtdNumeros = qtdCaracteres;
    qtdLetrasMi = qtdLetrasMa = qtdEspeciais = 0;
}

char[] numerosSenha = new char[qtdNumeros];
char[] letrasMiSenha = new char[qtdLetrasMi];
char[] letrasMaSenha = new char[qtdLetrasMa];
char[] especiaisSenha = new char[qtdEspeciais];

for (int q = 0; q <= qtdNumeros - 1; q++)
{
    int caractereAleatorio = aleatorio.Next(numeros.Length);
    numerosSenha[q] = numeros[caractereAleatorio];
}
for (int q = 0; q <= qtdLetrasMi - 1; q++)
{
    int caractereAleatorio = aleatorio.Next(letrasMi.Length);
    letrasMiSenha[q] = letrasMi[caractereAleatorio];
}
for (int q = 0; q <= qtdLetrasMa - 1; q++)
{
    int caractereAleatorio = aleatorio.Next(letrasMa.Length);
    letrasMaSenha[q] = letrasMa[caractereAleatorio];
}
for (int q = 0; q <= qtdEspeciais - 1; q++)
{
    int caractereAleatorio = aleatorio.Next(especiais.Length);
    especiaisSenha[q] = especiais[caractereAleatorio];
}

char[] senha = numerosSenha.Concat(letrasMiSenha).Concat(letrasMaSenha).Concat(especiaisSenha).ToArray();

Console.Write("Sua senha: ");

for (int q = 0; q <= qtdCaracteres - 1; q++)
{
    int caractereAleatorio = aleatorio.Next(senha.Length);
    Console.Write(senha[caractereAleatorio]);
}