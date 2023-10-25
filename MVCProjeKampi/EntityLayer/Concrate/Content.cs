using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate //içerisinde somut ögeler tutulur
{
    public class Content
    {
        //İçerik propertyleri
        [Key]
        public int ContentID { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }

        public DateTime ContentDate { get; set; }

        public bool ContentStatus { get; set; }


        //Content Başlık ilişkisini eklediğimiz yer
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        //content yazar ilişkisi
        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
