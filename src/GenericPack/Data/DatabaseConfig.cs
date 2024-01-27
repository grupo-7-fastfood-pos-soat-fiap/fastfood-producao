namespace GenericPack.Data
{
public class StoreDatabaseConfig : IDatabaseConfig
    {
        public string DatabaseName { get;  set; } = null!;
        public string ConnectionString { get; set; }= null!;
        public string CollectionName { get; set; }= null!;
    }
}