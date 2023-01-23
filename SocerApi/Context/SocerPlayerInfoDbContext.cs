using Microsoft.EntityFrameworkCore;
using SocerApi.Models;

namespace SocerApi.Context
{
    public class SocerPlayerInfoDbContext:DbContext
    {
        public SocerPlayerInfoDbContext(DbContextOptions<SocerPlayerInfoDbContext> options) : base(options) 
        {
        
        }

        public DbSet<PostPlayerInfo> postPlayerInfos { get; set; } 
    }
}
