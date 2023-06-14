class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome} \nArtista: {artista} \nDuração: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Disponível no plano. \n");
        } else
        {
            Console.WriteLine("Adquirir o plano Plus+ \n");
        }
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {nome} - {artista}");
    }
}