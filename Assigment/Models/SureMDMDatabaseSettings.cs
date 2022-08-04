namespace Assigment.Models
{
    public class SureMDMDatabaseSettings : ISureMDMDatabaseSettings
    {
        public string[] CollectionName { get; set; }
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;

    }
}
