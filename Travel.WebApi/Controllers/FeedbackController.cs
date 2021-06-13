using Microsoft.AspNetCore.Mvc;

namespace Travel.WebApi.Controllers
{
    [Route("api/place/{placeId:int}/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
    }
}
