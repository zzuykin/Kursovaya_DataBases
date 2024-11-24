

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kursobaya.Storage.Models
{
    public class Unit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid UnitCode { get; set; }

        public double Kh { get; set; }

        public double Kha { get; set;}

        public double Khb { get; set;}

        public double Khv { get; set;}
        
        public double Ft { get; set;}

        public double Ea { get; set;}

        public double b { get; set; }
        public double g0 { get; set; }
        public double Re { get; set; }

        public double SigmaH { get; set; }
        public double SigmaHP { get; set; }


    }
}
