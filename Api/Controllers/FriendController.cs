using BLL.InterfaceGeneric;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Friend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class FriendController : Controller
    {
        private readonly IFriend _IFriend;

        public FriendController(IFriend iFriend)
        {
            _IFriend = iFriend;
        }

        [HttpGet("AllFriend")]
        public async Task<IActionResult> AllFriend()
        {
            return  Json(await _IFriend.List());
        }

        [HttpGet("GetByIdFriend")]
        public async Task<IActionResult> GetByIdFriend(int Id)
        {
            return Json(await _IFriend.GetById(Id));
        }



        [HttpPost("CreateFriend")]
        public async Task CreateFriend(Friend friend)
        {
            await _IFriend.Create(friend);
        }

        [HttpPut("UpdateFriend")]
        public async Task UpdateFriend(Friend friend)
        {
            await _IFriend.Update(friend);
        }

        [HttpDelete("RemoveFriend")]
        public async Task RemoveFriend(Friend friend)
        {
            await _IFriend.Delete(friend);
        }


    }
}
