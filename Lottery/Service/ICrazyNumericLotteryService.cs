using Lottery.Model;

namespace Lottery.Service
{
	public interface ICrazyNumericLotteryService: IGenericService<CrazyNumericLottery>
	{
		Task<CrazyNumericLottery?> GetCrazyNumericLotteryByDate(DateTime dateTime);
		Task DeleteAll();
	}
}
