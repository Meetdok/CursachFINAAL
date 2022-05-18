using Cursach.DTO;
using Cursach.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursach.Данные
{
    [Table("kind")]
    public class Kind : BaseDTO
    {
        [Column("title")]
        public string Title { get; set; }
    }
}
