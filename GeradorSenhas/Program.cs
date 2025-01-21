// Arrays contendo os diferentes tipos de caracteres para a senha
char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
char[] letrasMi = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
char[] letrasMa = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
char[] especiais = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=', '{', '}', '[', ']', '/', '?', '"', ':', ';' };

// Limpa a tela e exibe o título do programa
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green; // Define a cor do texto para verde
Console.WriteLine("=".PadLeft(17, '=')); // Exibe uma linha de '='
Console.WriteLine("Gerador de Senhas");
Console.WriteLine("=".PadLeft(17, '=')); // Exibe outra linha de '='
Console.ResetColor(); // Reseta a cor do texto para a cor padrão

// Solicita ao usuário a quantidade de caracteres para a senha
Console.Write("Sua senha deve conter quantos caracteres?: ");
int qtdCaracteres;
while (!int.TryParse(Console.ReadLine(), out qtdCaracteres) || qtdCaracteres <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Resposta inválida. Por favor, insira um número inteiro maior que 0: ");
    Console.ResetColor();
}

// Solicita ao usuário se a senha deve conter letras
Console.Write("Sua senha deve conter letras? (S/N): ");
string temLetras = Console.ReadLine().ToUpper(); // Converte a entrada do usuário para maiúscula
while (temLetras != "S" && temLetras != "N") // Verifica se a entrada é válida ('S' ou 'N') 
{
    Console.ForegroundColor = ConsoleColor.Red; // Define a cor do texto para vermelho
    Console.Write("Resposta inválida. Por favor, insira 'S' para Sim e 'N' para Não: ");
    Console.ResetColor(); // Reseta a cor do texto para a cor padrão
    temLetras = Console.ReadLine().ToUpper();
}

// Solicita ao usuário se a senha deve conter caracteres especiais
Console.Write("Sua senha deve conter caracteres especiais? (S/N): ");
string temEspeciais = Console.ReadLine().ToUpper(); // Lê a resposta do usuário e converte para maiúscula
while (temEspeciais != "S" && temEspeciais != "N") // Verifica se a entrada é válida ('S' ou 'N')
{
    Console.ForegroundColor = ConsoleColor.Red; // Define a cor do texto para vermelho
    Console.Write("Resposta inválida. Por favor, insira 'S' para Sim e 'N' para Não: ");
    Console.ResetColor(); // Reseta a cor do texto para a cor padrão
    temEspeciais = Console.ReadLine().ToUpper();
}

int qtdNumeros, qtdLetrasMi, qtdLetrasMa, qtdEspeciais; // Variáveis para armazenar a quantidade de caracteres de cada tipo
Random aleatorio = new Random(); // Objeto para gerar números aleatórios

// Determina a quantidade de caracteres de cada tipo com base nas escolhas do usuário
if (temLetras == "S" && temEspeciais == "S")
{
    qtdNumeros = (int)Math.Round(qtdCaracteres * .5, 0); // 50% números
    qtdLetrasMi = qtdLetrasMa = (int)Math.Round(qtdCaracteres * .15, 0); // 15% letras minúsculas e maiúsculas
    qtdEspeciais = (int)Math.Round(qtdCaracteres * .2, 0); // 20% caracteres especiais
}
else if (temLetras == "S" && temEspeciais == "N")
{
    qtdNumeros = (int)Math.Round(qtdCaracteres * .6, 0); // 60% números
    qtdLetrasMi = qtdLetrasMa = (int)Math.Round(qtdCaracteres * .2, 0); // 20% letras minúsculas e maiúsculas
    qtdEspeciais = 0; // Sem caracteres especiais
}
else if (temLetras == "N" && temEspeciais == "S")
{
    qtdNumeros = (int)Math.Round(qtdCaracteres * .7, 0); // 70% números
    qtdLetrasMi = qtdLetrasMa = 0; // Sem letras
    qtdEspeciais = (int)Math.Round(qtdCaracteres * .3, 0); // 30% caracteres especiais
}
else
{
    qtdNumeros = qtdCaracteres; // 100% números
    qtdLetrasMi = qtdLetrasMa = qtdEspeciais = 0; // Sem letras e caracteres especiais
}

// Distribui a diferença, se necessário, entre as letras e caracteres especiais
int qtdTotal = qtdNumeros + qtdLetrasMi + qtdLetrasMa + qtdEspeciais;
int diferenca = qtdCaracteres - qtdTotal;

if (diferenca > 0)
{
    if (temLetras == "S" && temEspeciais == "S")
    {
        qtdLetrasMi += diferenca / 2; // Divide igualmente entre minúsculas...
        qtdLetrasMa += diferenca / 2; // ...e maiúsculas
    }
    else if (temLetras == "S")
    {
        qtdLetrasMi += diferenca; // Adiciona a diferença nas letras minúsculas
    }
    else if (temEspeciais == "S")
    {
        qtdEspeciais += diferenca; // Adiciona a diferença nos caracteres especiais
    }
    else
    {
        qtdNumeros += diferenca; // Adiciona a diferença nos números
    }
}

// Cria arrays para armazenar os caracteres da senha gerada
char[] numerosSenha = new char[qtdNumeros];
char[] letrasMiSenha = new char[qtdLetrasMi];
char[] letrasMaSenha = new char[qtdLetrasMa];
char[] especiaisSenha = new char[qtdEspeciais];

// Atribui números aleatórios ao array até atingir a quantidade definida
for (int q = 0; q <= qtdNumeros - 1; q++)
{
    int caractereAleatorio = aleatorio.Next(numeros.Length);
    numerosSenha[q] = numeros[caractereAleatorio];
}
// Atribui letras maiúsculas aleatórias ao array até atingir a quantidade definida
for (int q = 0; q <= qtdLetrasMi - 1; q++)
{
    int caractereAleatorio = aleatorio.Next(letrasMi.Length);
    letrasMiSenha[q] = letrasMi[caractereAleatorio];
}
// Atribui letras minúsculas aleatórias ao array até atingir a quantidade definida
for (int q = 0; q <= qtdLetrasMa - 1; q++)
{
    int caractereAleatorio = aleatorio.Next(letrasMa.Length);
    letrasMaSenha[q] = letrasMa[caractereAleatorio];
}
// Atribui caracteres especiais aleatórios ao array até atingir a quantidade definida
for (int q = 0; q <= qtdEspeciais - 1; q++)
{
    int caractereAleatorio = aleatorio.Next(especiais.Length);
    especiaisSenha[q] = especiais[caractereAleatorio];
}

char[] senha = numerosSenha.Concat(letrasMiSenha).Concat(letrasMaSenha).Concat(especiaisSenha).ToArray(); // Concatena todos os arrays em um único array
senha = senha.OrderBy(x => aleatorio.Next()).ToArray(); // Embaralha a senha gerada

// Exibe a senha final gerada
Console.Write("Sua senha: ");
Console.WriteLine(new string(senha));