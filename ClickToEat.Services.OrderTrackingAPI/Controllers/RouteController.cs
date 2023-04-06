//using ClickToEat.Services.OrderTrackingAPI.Models;
//using GoogleMapsApi.Entities.Directions.Request;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Rewrite;
//using Google.Apis.Maps.Directions.v1;


//namespace ClickToEat.Services.OrderTrackingAPI.Controllers
//{
//    public class RouteController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }


//        [HttpPost]
//        public async Task<IActionResult> GetRoute([FromBody] RouteRequest request)
//        {
//            var directionsService = new DirectionsService(new BaseClientService.Initializer
//            {
//                ApiKey = "YOUR_API_KEY",
//                ApplicationName = "Your Application Name"
//            });

//            var origin = request.CustomerAddress;
//            var destination = request.RestaurantAddress;
//            var directionRequest = new DirectionsRequest
//            {
//                Origin = origin,
//                Destination = destination,
//                TravelMode = TravelMode.Driving
//            };

//            var directionResponse = await directionsService.Directions.Query(directionRequest).ExecuteAsync();

//            var route = directionResponse.Routes.FirstOrDefault();
//            if (route == null)
//            {
//                return NotFound();
//            }

//            var timeInTraffic = route.Legs.First().DurationInTraffic.Value;
//            var estimatedTimeOfArrival = DateTime.Now.AddSeconds(timeInTraffic);

//            var result = new RouteResult
//            {
//                ShortestPath = route.OverviewPolyline.Points,
//                EstimatedTimeOfArrival = estimatedTimeOfArrival
//            };

//            return Ok(result);
//        }

//    }
//}
