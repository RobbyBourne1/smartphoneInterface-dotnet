namespace smartphoneInterface_dotnet
{
    interface IPhoneCall
    {
        int IncomingCalls { get; set; }
        int MadeCalls { get; set; }
        string VoiceMail { get; set; }

        public void Calling();
        void RecieveCalls();
        void RecieveVM();
    }
}