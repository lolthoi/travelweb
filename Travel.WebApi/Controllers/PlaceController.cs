using Microsoft.AspNetCore.Mvc;

namespace Travel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        //private readonly IPlaceService _placeService;

        //public PlaceController(IPlaceService placeService)
        //{
        //    _placeService = placeService;
        //}

        //[HttpGet]
        //public ActionResult<List<PlaceClient>> GetAllPlace()
        //{
        //    return _placeService.GetAll();
        //}

        //[HttpGet("{id}")]
        //public ActionResult<PlaceClient> GetPlaceById(int id)
        //{
        //    return _placeService.GetPlaceById(id);
        //}

        //[HttpGet("search/{key}")]
        //public ActionResult<List<PlaceClient>> SearchPlace(string key)
        //{
        //    return _placeService.Search(key);
        //}

        //[HttpPut]
        //public async Task<bool> PutPlace([FromForm] PlaceClient model)
        //{
        //    return _placeService.Update(model);
        //}

        //[HttpPost]
        //public async Task<bool> PostPlace([FromForm] PlaceClient model)
        //{
        //    return _placeService.Create(model);
        //}

        //[HttpDelete("{id}")]
        //public ActionResult<bool> DeletePlace(int id)
        //{
        //    return _placeService.Delete(id);
        //}
    }
}
