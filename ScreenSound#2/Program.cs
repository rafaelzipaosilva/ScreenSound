Banda legiaoUrbana = new Banda("Legião Urbana");

Album albumDoLegiaoUrbana = new Album("As quatro estações");

Musica musica1 = new Musica(legiaoUrbana, "Monte castelo")
{
    Duracao = 231,
    Disponivel = true,
};

Musica musica2 = new Musica(legiaoUrbana, "Meninos e meninas")
{
    Duracao = 204,
    Disponivel = false,
};


albumDoLegiaoUrbana.AdicionarMusica(musica1);
albumDoLegiaoUrbana.AdicionarMusica(musica2);
legiaoUrbana.AdicionarAlbum(albumDoLegiaoUrbana);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumDoLegiaoUrbana.ExibirMusicasDoAlbum();

legiaoUrbana.ExibirDiscografia();

/*Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();*/