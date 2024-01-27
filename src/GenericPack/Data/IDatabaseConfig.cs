namespace GenericPack.Data
{
    public interface IDatabaseConfig
    {
        string DatabaseName { get; set; }

        string ConnectionString { get; set; }

        public string CollectionName { get; set; }
    }
}