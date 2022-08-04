namespace Assigment.Models
{
    public interface ISureMDMDatabaseSettings
    {

        string[] CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }

    }
}
