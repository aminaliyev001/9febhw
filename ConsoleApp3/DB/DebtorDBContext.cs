using Microsoft.EntityFrameworkCore;
namespace ConsoleApp3.DB;
public class DebtorDBContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string str = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=feb10;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;";
        optionsBuilder.UseSqlServer(str);
        base.OnConfiguring(optionsBuilder);
    }
    public virtual DbSet<DebtorsEntity>? Debtors { get; set; }
}
