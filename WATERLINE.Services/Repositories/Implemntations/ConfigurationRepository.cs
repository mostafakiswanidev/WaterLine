using System;
using System.Collections.Generic;
using System.Text;
using WATERLINE.DataAccess.Repositories.Interfaces;
using WATERLINE.Entities;
using WATERLINE.Services.Repositories.Interfaces;

namespace WATERLINE.Services.Repositories.Implemntations
{
    public class ConfigurationRepository : IConfigurationRepository
    {
        private readonly IRepository<Configuration> _repository;
        public ConfigurationRepository(IRepository<Configuration> repository)
        {
            _repository = repository;
        }

        public List<Configuration> GetCachedConfigurations() => _repository.FindAllByCondition(x => !x.Deleted && !x.EditableByNormals && !x.EditableBySupers);
    }
}
