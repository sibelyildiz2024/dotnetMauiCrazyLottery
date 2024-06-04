using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.Model
{
	public class CrazyNumericLottery
	{
		[PrimaryKey,AutoIncrement]
        public int Id { get; set; }

		[Required(ErrorMessage = "Number 1 is required")]
		[Range(1, 90, ErrorMessage = "Field should be between 1 and 90")]
		public int Number1 { get; set; }

		[Required(ErrorMessage = "Number 2 is required")]
		[Range(1, 90, ErrorMessage = "Field should be between 1 and 90")]
		public int Number2 { get; set; }

		[Required(ErrorMessage = "Number 3 is required")]
		[Range(1, 90, ErrorMessage = "Field should be between 1 and 90")]
		public int Number3 { get; set; }

		[Required(ErrorMessage = "Number 4 is required")]
		[Range(1, 90, ErrorMessage = "Field should be between 1 and 90")]
		public int Number4 { get; set; }

		[Required(ErrorMessage = "Number 5 is required")]
		[Range(1, 90, ErrorMessage = "Field should be between 1 and 90")]
		public int Number5 { get; set; }

		[Required(ErrorMessage = "Number 6 is required")]
		[Range(1, 90, ErrorMessage = "Field should be between 1 and 90")]
		public int Number6 { get; set; }

        [Required(ErrorMessage = "Joker is required")]
        [Range(1, 90, ErrorMessage = "Field should be between 1 and 90")]
        public int Joker { get; set; }

        [Required(ErrorMessage = "Super Star is required")]
		[Range(1, 90, ErrorMessage = "Field should be between 1 and 90")]
		public int SuperStar { get; set; }

		[Required(ErrorMessage = "Enter the date")]
		public DateTime LotteryDate { get; set; }

		public DateTime AddedDateTime { get; set; }

		[Required]
		public DateTime UpdatedTime { get; set; }


	}
}
