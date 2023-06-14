class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string NomeCompleto { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine(  $"Nome: {Nome}" +
                            $"\nArtista: {Artista}" +
                            $"\nDuração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano. \n");
        } else
        {
            Console.WriteLine("Adquirir o plano Plus+ \n");
        }
    }
}