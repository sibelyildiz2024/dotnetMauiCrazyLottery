using Lottery.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.Service
{
    public class AnalizeService : IAnalizeService
    {

		/// <summary>
		/// This method calculate for win 6 numbers 
		/// </summary>
		/// <param name="crazyNumericLotteries"></param>
		/// <returns></returns>
		public async Task<List<List<int>>> GetAllNumberFrequencyFor6Numbers(List<CrazyNumericLottery> crazyNumericLotteries)
        {
            List<List<int>> result = new List<List<int>>();

            int counter = 0;

            for (int i = 1; i < 91; i++)
            {
                foreach (var item in crazyNumericLotteries)
                {
                    if (item.Number1 == i)
                    {
                        counter++;
                    }
                    else if (item.Number2 == i)
                    {
                        counter++;
                    }
                    else if (item.Number3 == i)
                    {
                        counter++;
                    }
                    else if (item.Number4 == i)
                    {
                        counter++;
                    }
                    else if (item.Number5 == i)
                    {
                        counter++;
                    }
                    else if (item.Number6 == i)
                    {
                        counter++;
                    }
                }
                List<int> frequencyItem = new List<int> { i, counter };
                result.Add(frequencyItem);
                counter = 0;
            }

            return await Task.FromResult(result);
        }

        public async Task<List<List<int>>> GetAllNumberFrequency(List<CrazyNumericLottery> crazyNumericLotteries)
        {
            List<List<int>> result = new List<List<int>>();

            int counter = 0;

            for (int i = 1; i < 91; i++)
            {
                foreach (var item in crazyNumericLotteries)
                {
                    if (item.Number1 == i)
                    {
                        counter++;
                    }
                    else if (item.Number2 == i)
                    {
                        counter++;
                    }
                    else if (item.Number3 == i)
                    {
                        counter++;
                    }
                    else if (item.Number4 == i)
                    {
                        counter++;
                    }
                    else if (item.Number5 == i)
                    {
                        counter++;
                    }
                    else if (item.Number6 == i)
                    {
                        counter++;
                    }
                    else if (item.Joker == i)
                    {
                        counter++;
                    }
                    if (item.SuperStar == i)
                    {
                        counter++;
                    }
                }
                List<int> frequencyItem = new List<int> { i, counter };
                result.Add(frequencyItem);
                counter = 0;
            }

            return await Task.FromResult(result);
        }

        public async Task<List<List<int>>> GetAllNumberFrequencyForJoker(List<CrazyNumericLottery> crazyNumericLotteries)
        {
            List<List<int>> result = new List<List<int>>();

            int counter = 0;

            for (int i = 1; i < 91; i++)
            {
                foreach (var item in crazyNumericLotteries)
                {
                    if (item.Joker == i)
                    {
                        counter++;
                    }
                }
                List<int> frequencyItem = new List<int> { i, counter };
                result.Add(frequencyItem);
                counter = 0;
            }

            return await Task.FromResult(result);
        }

        public async Task<List<List<int>>> GetAllNumberFrequencyForSuperStar(List<CrazyNumericLottery> crazyNumericLotteries)
        {
            List<List<int>> result = new List<List<int>>();

            int counter = 0;

            for (int i = 1; i < 91; i++)
            {
                foreach (var item in crazyNumericLotteries)
                {
                    if (item.SuperStar == i)
                    {
                        counter++;
                    }
                }
                List<int> frequencyItem = new List<int> { i, counter };
                result.Add(frequencyItem);
                counter = 0;
            }

            return await Task.FromResult(result);
        }

        public async Task<int> GetByNumberFrequency(int number, List<CrazyNumericLottery> crazyNumericLotteries)
        {
            int counter = 0;
            crazyNumericLotteries.ForEach(c =>
            {
                if (c.Number1 == number)
                {
                    counter++;
                }
                else if (c.Number2 == number)
                {
                    counter++;
                }
                else if (c.Number3 == number)
                {
                    counter++;
                }
                else if (c.Number4 == number)
                {
                    counter++;
                }
                else if (c.Number5 == number)
                {
                    counter++;
                }
                else if (c.Number6 == number)
                {
                    counter++;
                }
                else if (c.Joker == number)
                {
                    counter++;
                }
                if (c.SuperStar == number)
                {
                    counter++;
                }
            });

            return await Task.FromResult(counter);
        }

        public async Task<int> GetByNumberFrequencyForJoker(int number, List<CrazyNumericLottery> crazyNumericLotteries)
        {
            int counter = 0;
            crazyNumericLotteries.ForEach(x =>
            {
                if (x.Joker == number)
                {
                    counter++;
                }
            });
            return await Task.FromResult(counter);
        }

        public async Task<int> GetByNumberFrequencyForSuperStar(int number, List<CrazyNumericLottery> crazyNumericLotteries)
        {
            int counter = 0;
            crazyNumericLotteries.ForEach(x =>
            {
                if (x.SuperStar == number)
                {
                    counter++;
                }
            });
            return await Task.FromResult(counter);
        }

        public async Task<int> GetByNumberFrequencyFor6Number(int number, List<CrazyNumericLottery> crazyNumericLotteries)
        {
            int counter = 0;
            crazyNumericLotteries.ForEach(c =>
            {
                if (c.Number1 == number)
                {
                    counter++;
                }
                else if (c.Number2 == number)
                {
                    counter++;
                }
                else if (c.Number3 == number)
                {
                    counter++;
                }
                else if (c.Number4 == number)
                {
                    counter++;
                }
                else if (c.Number5 == number)
                {
                    counter++;
                }
                else if (c.Number6 == number)
                {
                    counter++;
                }
            });

            return await Task.FromResult(counter);
        }

        public async Task<List<DateTime>> GetByNumberFrequencyWithDate(int number, List<CrazyNumericLottery> crazyNumericLotteries)
        {
            List<DateTime> lotteryDateList = new List<DateTime>();
            crazyNumericLotteries.ForEach(c =>
            {
                if (c.Number1 == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
                else if (c.Number2 == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
                else if (c.Number3 == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
                else if (c.Number4 == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
                else if (c.Number5 == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
                else if (c.Number6 == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
                else if (c.Joker == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
                if (c.SuperStar == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
            });

            return await Task.FromResult(lotteryDateList);
        }

        public async Task<List<DateTime>> GetByNumberFrequencyWithDateFor6Number(int number, List<CrazyNumericLottery> crazyNumericLotteries)
        {
            List<DateTime> lotteryDateList = new List<DateTime>();
            crazyNumericLotteries.ForEach(c =>
            {
                if (c.Number1 == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
                else if (c.Number2 == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
                else if (c.Number3 == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
                else if (c.Number4 == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
                else if (c.Number5 == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
                else if (c.Number6 == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
            });

            return await Task.FromResult(lotteryDateList);
        }

        public async Task<List<DateTime>> GetByNumberFrequencyWithDateForJoker(int number, List<CrazyNumericLottery> crazyNumericLotteries)
        {
            List<DateTime> lotteryDateList = new List<DateTime>();
            crazyNumericLotteries.ForEach(c =>
            {
                if (c.Joker == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
            });

            return await Task.FromResult(lotteryDateList);
        }

        public async Task<List<DateTime>> GetByNumberFrequencyWithDateForSuperStar(int number, List<CrazyNumericLottery> crazyNumericLotteries)
        {
            List<DateTime> lotteryDateList = new List<DateTime>();
            crazyNumericLotteries.ForEach(c =>
            {
                if (c.SuperStar == number)
                {
                    lotteryDateList.Add(c.LotteryDate);
                }
            });

            return await Task.FromResult(lotteryDateList);
        }
    }
}
