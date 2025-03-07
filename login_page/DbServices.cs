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

        //public async Task BulkUpdateUsingQueryAsync<Ttable, Tvalue>(List<Ttable> table ,Func<Ttable,bool> condition,Func<Ttable,Tvalue> setprop) where Ttable : class
        //{
        //    if ((typeof(Ttable).Namespace != "login_page.Models")
        //        && typeof(Ttable) != typeof(PharmacyStoreContext))
        //        throw new Exception("Ttable must be database entity classes");
        
        //    using (var context = new PharmacyStoreContext())
        //    {
        //        var dbSet = context.Set<Ttable>();

        //        for (int i = 0; i < table.Count; i++)
        //        {
        //            await dbSet.Where(e => condition.Invoke(table[i]) == true)
        //            .ExecuteUpdateAsync(setters => setters.SetProperty(e => EF.Property<Tvalue>(e, fieldName), newValue));

        //        }
        //    }
        //}

    }
}
