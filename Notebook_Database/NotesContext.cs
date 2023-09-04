using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace Notebook_Database
{
  public class NotesContext : DbContext
  {
    public DbSet<Note> Notes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=Database_Fundamentals_Notebook;Trusted_Connection=True;TrustServerCertificate=true;");
    }
  }
}
