using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHD.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        // Replace T with model
        //DbSet<T> Products { get; set; }
        Task<int> SaveChanges();
    }
}
