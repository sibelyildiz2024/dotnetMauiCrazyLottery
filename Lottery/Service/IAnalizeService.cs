using Lottery.Model;

namespace Lottery.Service
{
    public interface IAnalizeService
    {
        Task<List<List<int>>> GetAllNumberFrequencyFor6Numbers(List<CrazyNumericLottery> crazyNumericLotteries);
        Task<List<List<int>>> GetAllNumberFrequencyForJoker(List<CrazyNumericLottery> crazyNumericLotteries);
        Task<List<List<int>>> GetAllNumberFrequencyForSuperStar(List<CrazyNumericLottery> crazyNumericLotteries);
        Task<List<List<int>>> GetAllNumberFrequency(List<CrazyNumericLottery> crazyNumericLotteries);
        Task<int> GetByNumberFrequency(int number, List<CrazyNumericLottery> crazyNumericLotteries);
        Task<int> GetByNumberFrequencyForJoker(int number, List<CrazyNumericLottery> crazyNumericLotteries);
        Task<int> GetByNumberFrequencyForSuperStar(int number, List<CrazyNumericLottery> crazyNumericLotteries);
        Task<int> GetByNumberFrequencyFor6Number(int number, List<CrazyNumericLottery> crazyNumericLotteries);
        Task<List<DateTime>> GetByNumberFrequencyWithDate(int number, List<CrazyNumericLottery> crazyNumericLotteries);
        Task<List<DateTime>> GetByNumberFrequencyWithDateFor6Number(int number, List<CrazyNumericLottery> crazyNumericLotteries);
        Task<List<DateTime>> GetByNumberFrequencyWithDateForJoker(int number, List<CrazyNumericLottery> crazyNumericLotteries);
        Task<List<DateTime>> GetByNumberFrequencyWithDateForSuperStar(int number, List<CrazyNumericLottery> crazyNumericLotteries);
    }
}
