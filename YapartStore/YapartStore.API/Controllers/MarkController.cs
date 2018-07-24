using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using YapartStore.BL.Entities;
using YapartStore.BL.Services.Base;

namespace YapartStore.API.Controllers
{
    [EnableCors(origins: "http://localhost:58823", headers: "*", methods: "*")]
    public class MarkController : ApiController
    {
        private readonly IMarkService _markService;
        private readonly IModelService _modelService;

        public MarkController(IMarkService markService, IModelService modelService)
        {
            _markService = markService;
            _modelService = modelService;
        }

        [HttpGet]
        public async Task<List<MarkDTO>> GetAllMarks()
        {
          return await _markService.GetAllAsync();
        }
    }
}
