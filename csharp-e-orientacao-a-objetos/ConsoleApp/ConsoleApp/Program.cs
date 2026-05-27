Console.WriteLine("Mensagem que vai para o terminal");

using (TextReader leitor = Console.In) {

    string linha = leitor.ReadLine();

    while (linha != null)
    {
        Console.WriteLine(linha);
        linha = leitor.ReadLine();
    }
}
