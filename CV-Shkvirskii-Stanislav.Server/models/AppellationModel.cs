namespace CV_Shkvirskii_Stanislav.Server.models
{
    public class AppellationModel
    {
        public string Date { get; set; } 
        public string Appellation { get; set; }
        public AppellationModel(string date, string appellation)
        {
            Date = date;
            Appellation = appellation;  
        }
    }
}
