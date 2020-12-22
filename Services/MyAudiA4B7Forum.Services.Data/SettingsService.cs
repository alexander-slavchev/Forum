namespace MyAudiA4B7Forum.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using MyAudiA4B7Forum.Data.Common.Repositories;
    using MyAudiA4B7Forum.Data.Models;
    using MyAudiA4B7Forum.Services.Mapping;

    public class SettingsService : ISettingsService
    {
        private readonly IDeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(IDeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
        {
            return this.settingsRepository.AllAsNoTracking().Count();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.settingsRepository.All().To<T>().ToList();
        }
    }
}
