using System.Collections.Generic;

namespace Vietlott.Api.DataAccess.Entities
{
    public class DrawGame : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<DrawType> DrawTypes { get; set; }
    }
}
