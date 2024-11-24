
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kursobaya.Storage.Models
{
    [Index(nameof(UnitCode))]
    public class Detail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]

        public Guid DetailCode { get; set; }

        public string DetailType { get; set; }

        public Guid UnitCode { get; set; }
        public double dm1 { get; set; }
        public double U { get; set; }

        public double Zh { get; set; }
        public double Zm { get; set; }
        public double Khl { get; set; }

        public double sigma { get; set; }
        public double delta_h { get; set; }
        public double Vm { get; set; }


    }
}
