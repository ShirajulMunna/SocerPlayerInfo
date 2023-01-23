using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using SocerApi.Context;
using SocerApi.Interfaces.Manager;
using SocerApi.Models;
using SocerApi.Repository;

namespace SocerApi.Manager
{
    public class PostPlayerInfoManager : CommonManager<PostPlayerInfo>, IPostPlayerInfoManager
    {
        public PostPlayerInfoManager(SocerPlayerInfoDbContext _dbContext) : base(new PostPlayerInfoRepository(_dbContext))
        {
        }
    }
}
