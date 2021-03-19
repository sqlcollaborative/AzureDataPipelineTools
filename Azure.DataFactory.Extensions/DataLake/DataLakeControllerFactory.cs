﻿using Azure.Storage.Files.DataLake;
using Microsoft.Extensions.Logging;

namespace Azure.Datafactory.Extensions.DataLake
{
    public class DataLakeControllerFactory
    {
        private readonly ILogger _logger;
        public DataLakeControllerFactory(ILogger<DataLakeControllerFactory> logger)
        {
            _logger = logger;
        }

        public DataLakeController CreateDataLakeController(DataLakeFileSystemClient client)
        {
            return new DataLakeController(_logger, client);
        }
    }
}
