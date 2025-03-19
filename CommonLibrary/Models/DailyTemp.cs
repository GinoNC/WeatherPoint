using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommonLibrary.Models
{
    public class DailyTemp
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; } = 0;

        public DateTime TheDate { get; set; } = DateTime.Today;
        public decimal Morning { get; set; } = 0;
        public decimal Afternoon { get; set; } = 0;
        public decimal Evening { get; set; } = 0;
        public decimal Night { get; set; } = 0;
        public decimal TheMin { get; set; } = 0;
        public decimal TheMax { get; set; } = 0;
    }
}