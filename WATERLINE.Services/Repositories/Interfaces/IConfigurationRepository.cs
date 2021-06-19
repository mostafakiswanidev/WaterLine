using System;
using System.Collections.Generic;
using System.Text;
using WATERLINE.Entities;

namespace WATERLINE.Services.Repositories.Interfaces
{
    public interface IConfigurationRepository
    {
        List<Configuration> GetCachedConfigurations();
    }
}
