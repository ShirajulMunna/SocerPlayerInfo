using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using SocerApi.Context;
using SocerApi.Interfaces.Repository;
using SocerApi.Models;

namespace SocerApi.Repository
{
    public class PostPlayerInfoRepository : CommonRepository<PostPlayerInfo>, IPostPlayerInfoRepository
    {
        public PostPlayerInfoRepository(SocerPlayerInfoDbContext dbContext) : base(dbContext)
        {
        }
    }
}
