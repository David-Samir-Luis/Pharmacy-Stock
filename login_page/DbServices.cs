using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using login_page.Models;
using System.Linq.Expressions;
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
            // ensure that the class T is one of the classes in directory Model
            // and NOT class PharmacyStoreContext
            if ((typeof(T).Namespace != "login_page.Models")
                && typeof(T) != typeof(PharmacyStoreContext))
                return;

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

        //public async Task<int> BulkUpdateUsingQueryAsync<T>(List<object> keys, string fieldName, List<object> newValues) where T : class
        //{
        //    if (keys.Count != newValues.Count)
        //        throw new ArgumentException("Keys and values list must have the same length.");

        //    using (var context = new PharmacyStoreContext())
        //    {
        //        var dbSet = context.Set<T>();
        //        int updatedRows = 0;

        //        for (int i = 0; i < keys.Count; i++)
        //        {
        //            updatedRows += await dbSet
        //                .Where(e => EF.Property<object>(e, "Id") == keys[i]) // Replace "Id" with actual PK name if different
        //                .ExecuteUpdateAsync(setters => setters.SetProperty<Medicine>());
        //        }

        //        return updatedRows;
        //    }
        //}

    }
}
