class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool Disponivel { get; set; }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome} \nArtista: {artista} \nDuração: {duracao}");
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