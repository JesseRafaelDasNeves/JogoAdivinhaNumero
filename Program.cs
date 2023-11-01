// Jogo de adivinhar número

void exibeMensagemBoasVindas() {
    Console.WriteLine("Seja Bem Vindo!");
}

int geraNumeroAleatorio() {
    return 10;
}

do
{
    exibeMensagemBoasVindas();
    int numero = geraNumeroAleatorio();
    Console.WriteLine($"Numero {numero}");
} while (false);

Console.WriteLine("Thau!");