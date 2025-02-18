using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using login_page.Models;
namespace login_page
{
    internal class DbServices
    {

        private static DbServices _instance;
        private static readonly object _lock = new();
        private readonly Dictionary<Type, object> _dataCache = [];

        private DbServices() { }

        public static DbServices Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new DbServices();
                }
            }
        }
        public async void LoadAllDataAsync()
        {
            await Task.WhenAll(
                  Instance.LoadDataAsync<Medicine>(),
                  Instance.LoadDataAsync<OperationsHistory>(),
                  Instance.LoadDataAsync<OperationsMedicine>()
            );
        }
        public async Task LoadDataAsync<T>() where T : class
        {
            using (var context = new PharmacyStoreContext())
            {
                var data = await context.Set<T>().ToListAsync();
                _dataCache[typeof(T)] = data;
            }
        }
        public List<T> GetData<T>() where T : class
        {
            return _dataCache.TryGetValue(typeof(T), out var data) ? (List<T>)data : new List<T>();
        }
    }
}
