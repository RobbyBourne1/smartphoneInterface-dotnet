namespace smartphoneInterface_dotnet
{
    public class Smartphone : IPhoneCall, Itexts, IMediaPlayer
    {
        public int IncomingCalls { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int MadeCalls { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string VoiceMail { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string TextSubject { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string TextContent { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int NumberOfSongs { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int NumberOfMovies { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Titles { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int NumberOfTexts { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Calling()
        {
            throw new System.NotImplementedException();
        }

        public void Notification()
        {
            throw new System.NotImplementedException();
        }

        public void PlayMovie()
        {
            throw new System.NotImplementedException();
        }

        public void PlaySong()
        {
            throw new System.NotImplementedException();
        }

        public void ReadText()
        {
            throw new System.NotImplementedException();
        }

        public void ReadTitle()
        {
            throw new System.NotImplementedException();
        }

        public void RecieveCalls()
        {
            throw new System.NotImplementedException();
        }

        public void RecieveVM()
        {
            throw new System.NotImplementedException();
        }

        public void SendText()
        {
            throw new System.NotImplementedException();
        }
    }
}