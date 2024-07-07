using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace HastaneUygulamasi.Models
{
    public class Odalar
    {
        [Key]
        public int id { get; set; }

        [StringLength(50), Range(1, 100), DisplayName("Hastanın bulunduğu oda no:")]
        public string OdaNumarası { get; set; }

        public virtual List<Hastalar> Hastalars { get; set; } = new List<Hastalar>();
    }
}
