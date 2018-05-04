using System;
using System.Collections.Generic;

namespace Vietlott.Api.DataAccess.Entities
{
    public class DrawResult : BaseEntity
    {
        public int DrawNo { get; set; }
        public DateTime DrawDate { get; set; }
        public decimal PrizeAmount { get; set; }
        public int TotalWinningTickets { get; set; }
        public DrawType DrawType { get; set; }
        public List<WinningNumber> WinningNumbers { get; set; } = new List<WinningNumber>();
    }
}
