using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thefashionproject.Models
{
    public class StoreContext: DbContext
    {
        public DbSet<Store> Stores { get; set; }
    }
}
