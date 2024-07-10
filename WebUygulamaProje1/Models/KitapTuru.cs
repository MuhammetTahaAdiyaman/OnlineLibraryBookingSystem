using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebUygulamaProje1.Models
{
    public class KitapTuru
    {
        //primary key yapmamız için [Key] anotasyonu kullanmalıyız.
        [Key]
        public int Id { get; set; }

        
        [Required(ErrorMessage = "Kitap Tür Adı Boş Bırakılamaz!")] //not null
        [MaxLength(25)]
        [DisplayName("Kitap Türü Adı")]
        public string Ad { get; set; }
        
    }
}
