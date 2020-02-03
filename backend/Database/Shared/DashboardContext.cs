using Microsoft.EntityFrameworkCore;
using Backend.Database.Models;

namespace Backend.Database.Shared
{
  public class DashboardContext : DbContext
  {
    public DbSet<Account> Accounts { get; set; }

  }
}
