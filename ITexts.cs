namespace smartphoneInterface_dotnet
{
    interface Itexts
    {
        int NumberOfTexts { get; set; }
        string TextSubject { get; set; }
        string TextContent { get; set; }

        void ReadText();
        void SendText();
        void Notification();
    }
}