namespace GenericPack.Data
{
public class DatabaseConfig : IDatabaseConfig
    {
        public string DatabaseName { get;  set; }
        public string ConnectionString { get; set; }
    }
}