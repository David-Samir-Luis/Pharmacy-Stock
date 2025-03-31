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
        public async Task LoadAllDataAsync()
        {
            await Task.WhenAll(
                  Instance.LoadDataAsync<Medicine>(),
                  Instance.LoadDataAsync<OperationsHistory>(),
                  Instance.LoadDataAsync<OperationsMedicine>(),
                  Instance.LoadDataAsync<DrugDateStock>()
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

        public void ClearOldRecords()
        {
            using (var db = new PharmacyStoreContext())
            {
                DateTime cutoffDate = DateTime.Now.AddDays(-30); // 30 days ago

                try
                {
                    int deletedRows = db.Database.ExecuteSqlRaw(
                                "DELETE FROM Operations_History WHERE Operation_Time < {0}", cutoffDate);

                }
                catch (Exception)
                {
                    MessageBox.Show($"restart server (MSSQL$SQLEXPRESS02) from services ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                //MessageBox.Show($"Deleted {deletedRows} old records.");
            }
        }

        internal void AddData<T>(T medicine) where T : class
        {
            // ensure that the class T is one of the classes in directory Model
            // and NOT class PharmacyStoreContext
            if ((typeof(T).Namespace != "login_page.Models")
                && typeof(T) != typeof(PharmacyStoreContext))
            {
//                MessageBox.Show($"ERROR Type ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            using (var db = new PharmacyStoreContext())
            {
                db.Set<T>().Add(medicine);
                db.SaveChanges();
            }
        }
    }
}
