using task13;

Song song1 = new Song("Ask kac beden giyer", "Hadise",new TimeSpan(00,03,00), Genre.Pop );
Playlist playlist = new Playlist();
playlist.AddSong(song1);
playlist.GetAll();
playlist.GetAllSongsByGenre(Genre.Pop);

