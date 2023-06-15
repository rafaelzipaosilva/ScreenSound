class Musica
{
    public Musica(Banda artista)
    {
        Artista = artista;
    }

    public string Nome { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    
    //manipulando a prop get através de uma Função Lambda (Arrow Function)
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}" +
                            $"\nArtista: {Artista}" +
                            $"\nDuração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano. \n");
        }
        else
        {
            Console.WriteLine("Adquirir o plano Plus+ \n");
        }
    }
}