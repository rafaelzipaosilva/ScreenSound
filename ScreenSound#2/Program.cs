﻿Banda legiaoUrbana = new Banda();
legiaoUrbana.Nome = "Legião Urbana";

Album albumDoLegiaoUrbana = new Album();
albumDoLegiaoUrbana.Nome = "As quatro estações";

Musica musica1 = new Musica(legiaoUrbana);
musica1.Nome = "Monte castelo";
musica1.Duracao = 231;

Musica musica2 = new Musica(legiaoUrbana);
musica2.Nome = "Meninos e meninas";
musica2.Duracao = 204;

albumDoLegiaoUrbana.AdicionarMusica(musica1);
albumDoLegiaoUrbana.AdicionarMusica(musica2);

albumDoLegiaoUrbana.ExibirMusicasDoAlbum();

legiaoUrbana.AdicionarAlbum(albumDoLegiaoUrbana);
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