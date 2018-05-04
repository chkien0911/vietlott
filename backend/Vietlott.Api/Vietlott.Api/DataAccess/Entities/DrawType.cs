using System.Collections.Generic;

namespace Vietlott.Api.DataAccess.Entities
{
    public class DrawType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DrawGame DrawGame { get; set; }
        public virtual List<DrawResult> DrawResults { get; set; }
    }
}
