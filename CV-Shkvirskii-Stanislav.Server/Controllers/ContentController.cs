using CV_Shkvirskii_Stanislav.Server.models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Shkvirskii_Stanislav.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContentController : Controller
    {
        [HttpGet]
        [Route("GetContent")]
        public IEnumerable<ContentModel> GetContent()
        {
            return DateBaseMoq.GetContent();
        }

        [HttpGet]
        [Route("GetSkills")]
        public IEnumerable<SkillModel> GetSkills()
        {
            return DateBaseMoq.GetSkills();
        }
    }
}
