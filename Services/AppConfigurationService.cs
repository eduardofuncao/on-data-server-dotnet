using System;
using Microsoft.Extensions.Configuration;

namespace OnData.Services
{
    public class AppConfigurationService
    {
        private static AppConfigurationService _instance;
        private static readonly object _lock = new object();
        private readonly IConfiguration _configuration;

        // Construtor privado para evitar instanciação direta
        private AppConfigurationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Método para obter a instância única
        public static AppConfigurationService GetInstance(IConfiguration configuration)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new AppConfigurationService(configuration);
                    }
                }
            }
            return _instance;
        }

        // Métodos para acessar configurações específicas
        public string GetDatabaseConnectionString()
        {
            return _configuration.GetConnectionString("OracleDbConnection");
        }

        public string GetAppSetting(string key)
        {
            return _configuration[key];
        }

        public bool IsProduction()
        {
            return _configuration["Environment"] == "Production";
        }

        public int GetDefaultPageSize()
        {
            string pageSizeStr = _configuration["DefaultPageSize"];
            return int.TryParse(pageSizeStr, out int pageSize) ? pageSize : 10;
        }
    }
}