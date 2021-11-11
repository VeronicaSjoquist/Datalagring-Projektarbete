using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data;

namespace DataLayer.Backend
{
    public class AdminBackend
    {
        public void CreateAndSeedDb()
        {
            using (var ctx = new FoodResQCtx())
            {
                ctx.Database.EnsureDeleted();
                ctx.SaveChanges();
                ctx.Database.EnsureCreated();
            }
        }
    }
}
