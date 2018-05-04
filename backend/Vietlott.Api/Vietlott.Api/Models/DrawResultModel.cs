using System;
using System.Collections.Generic;

namespace Vietlott.Api.Models
{
    public class DrawResultModel : BaseModel
    {
        public int DrawNo { get; set; }
        public DateTime DrawDate { get; set; }
        public decimal PrizeAmount { get; set; }
        public int TotalWinningTickets { get; set; }
        public DrawTypeModel DrawType { get; set; }
        public List<WinningNumberModel> WinningNumbers { get; set; } = new List<WinningNumberModel>();
    }
}
