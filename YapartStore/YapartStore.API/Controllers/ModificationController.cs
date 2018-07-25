using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using YapartStore.BL.Entities;
using YapartStore.BL.Services.Base;

namespace YapartStore.API.Controllers
{
    [EnableCors(origins: "http://localhost:58823", headers: "*", methods: "*")]
    public class ModificationController : ApiController
    {
        private readonly IModificationService _modificationService;
        public ModificationController(IModificationService modificationService)
        {
            _modificationService = modificationService;
        }

        [HttpGet]
        public async Task<List<ModificationDTO>> GetAllModifications()
        {
            return await _modificationService.GetAllAsync();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetModificationsByModelName(string modelName)
        {
            var modifications = await _modificationService.GetAllModificationByModelName(modelName);
            if (modifications.Count == 0 || modifications == null)
            {
                ModelState.AddModelError("Error", "Не найдено ничего по запросу");
                return BadRequest(ModelState);
            }
           return Ok(modifications);
        }
    }
}
