using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Kursobaya.Storage.Models
{
    public class Reliability
    {
        [Key]
        public int ResultID { get; set; }

        public Guid UnitCode { get; set; }

        public Guid DetailCode { get; set; }

        public string dost { get; set; }
    }
}
