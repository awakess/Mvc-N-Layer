using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate  //concrate klasörü içinde somut ögeler tutulur
{
    public class Heading //Başlık Sınıfı
    {
        //Propertyler -> ID,HeadingName,Date,Writer

        [Key]
        public int HeadingID { get; set; }

        [StringLength(50)]
        public string HeadingName { get; set;}

        public DateTime HeadingDate { get; set; }

        public bool HeadingStatus { get; set; }



        //kategori başlık ilişkisi
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; } // virtual ile category sınıfından  category adında bir property oluşturduk

        //yazar başlık ilişkisi
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

        /*virtual bir sınıftan değer almak için kullanılır ana başlıklar ve altındaki 
        o başlığın içeriği için kullanılır  */

        public ICollection<Content> Contents { get; set; }

    }
}
