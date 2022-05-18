using Cursach.Данные;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursach.DTO
{
    public class UserZayavka
    {
        public User User { get; set; }
        public Zayavka Zayavka { get; set; }

        public Employ Employ { get; set; }
    }
}
