namespace smartphoneInterface_dotnet
{
    interface IMediaPlayer
    {
        int NumberOfSongs { get; set; }
        int NumberOfMovies { get; set; }
        string Titles { get; set; }

        void PlaySong();

        void PlayMovie();
        void ReadTitle();
    }
}