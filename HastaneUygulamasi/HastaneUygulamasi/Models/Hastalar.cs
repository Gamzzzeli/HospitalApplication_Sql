using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaneUygulamasi.Models
{
    public class Hastalar
    {
        [Key]
        public int id { get; set; }

        [StringLength(50,ErrorMessage ="Bu alanı boş geçemezsiniz.")]
        public string HastaAdi { get; set; }

        [StringLength(11, ErrorMessage = "Hastanın Tc'sini değiştiremezsiniz.")]
        public string Tc { get; set; }

        [StringLength(10)]
        public string DogumTarihi { get; set; }

        [ForeignKey("Katlar")]
        public int Katid { get; set; }
        public virtual Katlar Katlar { get; set; }
        // Bir oda sayısının sadece bir katta bulunabileceği şeklinde bağlama.


        [ForeignKey("Odalar")]
        public int Odaid { get; set; }
        public virtual Odalar Odalar { get; set; }
    }
}
