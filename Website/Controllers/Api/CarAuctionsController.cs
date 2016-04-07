using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Website.BusinessLogic.Interfaces;

namespace Website.Controllers.Api
{
    public class CarAuctionsController : ApiController
    {
        private IAuctionService auctionService;

        public CarAuctionsController(IAuctionService auctionService)
        {
            this.auctionService = auctionService;
        }

        public IHttpActionResult GetCarAuctionById(int id)
        {
            return Json(auctionService.GetCarAuctionById(id));
        }

    }
}
