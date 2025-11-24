using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class CampContext : DbContext
    {

        DbSet<Category> Categories {  get; set; }
        DbSet<Product>  Products { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Admin> Admins { get; set; }

    }
}
