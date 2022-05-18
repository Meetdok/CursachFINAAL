using Cursach.Tools;
using Cursach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursach.DTO
{
    [Table("users")]
    public class Users : BaseDTO
    {

        [Column("lastname")]
        public string LastName { get; set; }

        [Column("phonenumber")]
        public string PhoneNumber { get; set; }
    }
}
