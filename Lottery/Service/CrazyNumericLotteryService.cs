using Lottery.Model;
using SQLite;
using SQLiteNetExtensionsAsync.Extensions;

namespace Lottery.Service
{
	public class CrazyNumericLotteryService : ICrazyNumericLotteryService
	{
		string? _dbPath;
		private SQLiteAsyncConnection conn;

		public CrazyNumericLotteryService(string? dbPath)
		{
			_dbPath = dbPath;
			InitAsync();
		}

		private async void InitAsync()
		{
			if (conn != null)
			{
				return;
			}
			else
			{
				conn = new SQLiteAsyncConnection(_dbPath);
				await conn.CreateTableAsync<CrazyNumericLottery>();
			}
		}
		public async Task<int> Delete(CrazyNumericLottery crazyNumericLottery)
		{
			return await conn.DeleteAsync(crazyNumericLottery);
		}

		public async Task<List<CrazyNumericLottery>> GetAll()
		{
			List<CrazyNumericLottery> crazyNumericLotteries = new();
			crazyNumericLotteries = await conn.GetAllWithChildrenAsync<CrazyNumericLottery>();

			return crazyNumericLotteries;
		}

		public async Task<CrazyNumericLottery> GetById(int id)
		{
			return await conn.Table<CrazyNumericLottery>().Where(x => x.Id == id).FirstOrDefaultAsync();
		}

		public async Task<int> Insert(CrazyNumericLottery crazyNumericLottery)
		{
			crazyNumericLottery.AddedDateTime = DateTime.Now;
			crazyNumericLottery.UpdatedTime = DateTime.Now;

			return await conn.InsertAsync(crazyNumericLottery);
		}

		public async Task<int> Update(CrazyNumericLottery crazyNumericLottery)
		{
			crazyNumericLottery.UpdatedTime = DateTime.Now;
			return await conn.UpdateAsync(crazyNumericLottery);
		}

		public async Task<CrazyNumericLottery?> GetCrazyNumericLotteryByDate(DateTime dateTime)
		{
			return await conn.Table<CrazyNumericLottery>().Where(x => x.LotteryDate == dateTime).FirstOrDefaultAsync();
		}
		public async Task DeleteAll()
		{
			await conn.DeleteAllAsync<CrazyNumericLottery>();
		}
	}
}
