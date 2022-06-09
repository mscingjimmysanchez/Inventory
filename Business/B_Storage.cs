using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Storage
    {
        public static void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }

        public static bool IsProductInWarehouse(string storageId)
        {
            using (var db = new InventoryContext())
            {
                var product = db.Storages.ToList().Where(s => s.StorageId == storageId);

                return product.Any();
            }
        }

        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.ToList();
            }
        }

        public static List<StorageEntity> StorageProductsByWarehouse(string warehouseId)
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.Include(s => s.Product).Include(s => s.Warehouse).Where(s => s.WarehouseId == warehouseId).ToList();
            }
        }

        public static void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }
    }
}
