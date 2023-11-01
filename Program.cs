// Jogo de adivinhar número

void exibeMensagemBoasVindas() {
    Console.WriteLine("Seja Bem Vindo!");
}

int geraNumeroAleatorio() {
    Random randObj = new();
    return randObj.Next(100);
}

int numero         = geraNumeroAleatorio();
int opcaoEscolhida = 0;
int tentativa      = 0;
exibeMensagemBoasVindas();

do
{
    tentativa++;

    if(tentativa == 1) {
        Console.Write("\nDigite um numero de 0 a 100 para adivinhar ou -1 para sair ");
    } else {
        Console.WriteLine("Não acertou, tente novamente!");
        Console.Write("\nDigite um numero de 0 a 100 para adivinhar ou -1 para sair ");
    }
    
    opcaoEscolhida = int.Parse(Console.ReadLine()!);
    

} while ((numero != opcaoEscolhida) && (opcaoEscolhida != -1));

if(numero == opcaoEscolhida) {
    Console.WriteLine("Você Acertou!");
}

Console.WriteLine("Thau!");