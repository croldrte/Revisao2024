char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
char[] letras = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
char[] especiais = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=', '{', '}', '[', ']', '/', '?', '"', ':', ';' };

Console.WriteLine("Gerador de Senhas");
Console.Write("Sua senha deve conter quantos caracteres?: ");
int qtdCaracteres = int.Parse(Console.ReadLine());
Console.Write("Sua senha deve conter letras? (S/N): ");
string temLetras = Console.ReadLine().ToUpper();
Console.Write("Sua senha deve conter caracteres especiais? (S/N): ");
string temEspeciais = Console.ReadLine().ToUpper();

double qtdNumeros, qtdLetras, qtdEspeciais;
char[] numerosSenha = new char[qtdNumeros - 1];
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

for (int n = 0; n <= qtdNumeros; n++)
{  
    for (int s = 0; s <= qtdNumeros; s++)
    { 
        int numeroAleatorio = aleatorio.Next(numeros.Length);
        numerosSenha[s] = letras[numeroAleatorio];       
    }
}   

foreach (char n in numerosSenha)
{
    Console.WriteLine(n);
}