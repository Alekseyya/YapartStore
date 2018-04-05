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
    public class SectionController : ApiController
    {
        private readonly ISectionService _sectionService;
        public SectionController(ISectionService sectionService)
        {
            _sectionService = sectionService;
        }

        [HttpGet]
        public IEnumerable<SectionDTO> GetSections()
        {
            var sections = _sectionService.GetAll();
            return sections;
        }

        [HttpPost]
        public IHttpActionResult AddSection(SectionDTO section)
        {
            if (ModelState.IsValid)
            {
                _sectionService.AddItem(section);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IHttpActionResult DeleteSection(string sectionName)
        {
            try
            {
                _sectionService.DeleteItem(sectionName);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
