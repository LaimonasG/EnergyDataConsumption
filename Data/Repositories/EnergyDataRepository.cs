using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnergyDataConsumption.Data.Repositories
{
    public interface IEnergyDataRepository
    {
        Task<IEnumerable<string>> GetAllAsync();
        Task<string> GetByIdAsync(int id);
        Task AddAsync(string data);
        Task UpdateAsync(int id, string newData);
        Task DeleteAsync(int id);
    }
    
    public class EnergyDataRepository
    {
        // This is a placeholder for your data source, e.g., a database context
        private readonly List<string> _dataSource;

        public EnergyDataRepository()
        {
            _dataSource = new List<string>();
        }

        public async Task<IEnumerable<string>> GetAllAsync()
        {
            // Simulate async operation
            return await Task.FromResult(_dataSource);
        }

        public async Task<string> GetByIdAsync(int id)
        {
            // Simulate async operation
            return await Task.FromResult(_dataSource[id]);
        }

        public async Task AddAsync(string data)
        {
            // Simulate async operation
            await Task.Run(() => _dataSource.Add(data));
        }

        public async Task UpdateAsync(int id, string newData)
        {
            // Simulate async operation
            await Task.Run(() => _dataSource[id] = newData);
        }

        public async Task DeleteAsync(int id)
        {
            // Simulate async operation
            await Task.Run(() => _dataSource.RemoveAt(id));
        }
    }
}