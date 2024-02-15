namespace CV_Shkvirskii_Stanislav.Server.models
{
    public class ContentModel
    {
        public string? Title{ get; set; }
        public AppellationModel[] Appellations { get; set; }
        public string[]? Descriptions { get; set; }

        public ContentModel(AppellationModel[] appellation, string title , string[] descriptions)
        {
            Title = title;
            Appellations = appellation;  
            Descriptions = descriptions;
        }
    }
}
