using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocerApi.Context;
using SocerApi.Interfaces.Manager;
using SocerApi.Manager;
using SocerApi.Models;

namespace SocerApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SocerPlayerInfoController : ControllerBase
    {
       
        IPostPlayerInfoManager _postManager;


        public SocerPlayerInfoController(IPostPlayerInfoManager postmanager) 
        {
            _postManager = postmanager;
        }

       

        [HttpGet]
        public List<PostPlayerInfo> GetPlayerName() 
        {
            
            var posts = _postManager.GetAll().ToList();
            return posts;
        }

        [HttpPost]

        public PostPlayerInfo AddPlayerIntoDB(PostPlayerInfo postPlayer)  
        {
           
            bool isSaved = _postManager.Add(postPlayer);
            if (isSaved) 
            {
                return postPlayer;
            }
            return null;
        
        
        }
         
    }
}
