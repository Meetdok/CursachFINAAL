﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cursach.DTO;
using Cursach.Tools;

namespace Cursach.Данные
{
    [Table("zayavka")]
    public class Zayavka : BaseDTO
    {
        

        [Column("data")]
        public DateTime Data { get; set; } = DateTime.Now;

        [Column("statuszayavki")]
        public string StatusZayavki { get; set; }

        [Column("discription")]
        public string Discription { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("employer_id")]
        public int EmployerId { get; set; }
        [Column("kind_id")]
        public int KindId { get; set; }
    }
}
