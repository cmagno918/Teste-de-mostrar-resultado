// See https://aka.ms/new-console-template for more information


int v1, v2, soma, numero;
string nome, rua, bairro, estado;
char escolha;

inicio:

Console.WriteLine("Digite o seu nome");
nome = Console.ReadLine();

Console.WriteLine("Digite a sua rua");
rua = Console.ReadLine();

Console.WriteLine("Digite o seu bairro");
bairro = Console.ReadLine();

Console.WriteLine("Digite o seu estado");
estado = Console.ReadLine();

Console.WriteLine("Digite o número da sua casa");
numero = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o primeiro valor a ser calculado");
v1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor a ser calculado");
v2 = int.Parse(Console.ReadLine());
soma = v1 + v2;

Console.WriteLine("Seu nome é: " + nome);
Console.WriteLine("Seu endereço é rua: "  + rua + " , " + "Bairro: " + " "+ bairro + " , " + "Estado: " +" " + estado + " , " + "Número: " + " " + numero);
Console.WriteLine("Sua soma é igual a " + soma);

Console.WriteLine("Os seus dados estão corretos? Digite (S) para sim e (N) para não");
escolha=char.Parse(Console.ReadLine());
if (escolha == 's' || escolha == 'S')
{
    goto inicio;
}
else
{
    Console.Clear();
    Console.WriteLine("Fim do programa");
}


