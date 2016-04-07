using Website.DataTransferObjects.Models;

namespace Website.BusinessLogic.Interfaces
{
    public interface IAuctionService
    {
        CarAuctionDto GetCarAuctionById(int auctionNumber);
        void AddCarAuction(CarAuctionDto item);
    }
}
