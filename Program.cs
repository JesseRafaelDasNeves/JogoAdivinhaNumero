// Jogo de adivinhar número

void exibeMensagemBoasVindas() {
    Console.WriteLine("Seja Bem Vindo!");
}

int geraNumeroAleatorio() {
    Random randObj = new Random();
    return randObj.Next(100);
}

int numero         = geraNumeroAleatorio();
int opcaoEscolhida = 0;

do
{
    exibeMensagemBoasVindas();

    Console.Write("\nDigite uma opção ");
    opcaoEscolhida = int.Parse(Console.ReadLine()!);
    

} while ((numero != opcaoEscolhida) && (opcaoEscolhida != -1));

Console.WriteLine("Thau!");