using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Duvidas
    {
        [Key]
        public int _id { get; set; }
        public string _descricao { get; set; }
        public DateTime _dataDuvida { get; set; }
    }
}
