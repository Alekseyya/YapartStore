using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YapartStore.BL.Entities;
using YapartStore.BL.Services.Base;

namespace YapartStore.API.Controllers
{
    public class GroupController : ApiController
    {
        private readonly IGroupService _groupService;
        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }


        [HttpGet]
        public IEnumerable<GroupDTO> GetGroups()
        {
            var groups = _groupService.GetAll();
            return groups;
        }

        [HttpPost]
        public IHttpActionResult AddGroup(GroupDTO group)
        {
            if (ModelState.IsValid)
            {
                _groupService.AddItem(group);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IHttpActionResult DeleteGroup(string groupName)
        {
            try
            {
                _groupService.DeleteItem(groupName);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
