namespace on_data_server_dotnet.config;

public sealed class ConfigurationManager
{
    private static readonly Lazy<ConfigurationManager> _instance = new Lazy<ConfigurationManager>(() => new ConfigurationManager());
    public IConfiguration Configuration { get; }

    private ConfigurationManager()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        Configuration = builder.Build();
    }

    public static ConfigurationManager Instance => _instance.Value;
}