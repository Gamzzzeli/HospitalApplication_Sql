using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HastaneUygulamasi.Models
{
    public class Katlar
    {
        [Key]
        public int id { get; set; }

        [StringLength(50), Range(1, 10), DisplayName("Hastanın bulunduğu kat:")]
        public string KatNumarası { get; set; }
        public virtual List<Hastalar> Hastalars { get; set; } = new List<Hastalar>();
    }
}
