using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GoLogData.Models;

namespace GoLogData.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GoLogData.Models.Databooks> Databook { get; set; }
        public DbSet<GoLogData.Models.ParentViewModel> ParentViewModels{ get; set; }
        public DbSet<GoLogData.Models.DataModel> DataModels{ get; set; }
        //public DbSet<GoLogData.Models.Datacell> Datacell { get; set; }
        //public virtual Databooks getDatabookFromParent(ParentViewModel parentViewModel) { 
        //  parentViewModel.Databook
        //}
    }
}