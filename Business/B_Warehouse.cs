using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Warehouse
    {
        public static List<WarehouseEntity> WarehouseList()
        {
            using (var db = new InventoryContext())
            {
                return db.Warehouses.ToList();
            }
        }
    }
}
