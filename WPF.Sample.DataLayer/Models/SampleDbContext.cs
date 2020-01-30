using System.Data.Entity;
using System.Diagnostics;

namespace WPF.Sample.DataLayer
{
  public partial class SampleDbContext : DbContext
  {
    public SampleDbContext() : base("name=Samples")
    {
            Debug.WriteLine($"SampleDbContext()");
                
    }

    public virtual DbSet<User> Users { get; set; }
  }
}
