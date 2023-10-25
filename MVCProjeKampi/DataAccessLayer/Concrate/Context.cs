using EntityLayer.Concrate; //aboutu kullanabilmek için Concrate katmanını referans olarak ekledik
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
    public class Context:DbContext
    {
        //propertyler
        public DbSet<About> Abouts { get; set; } //about ile abouts farkı ->about proje içindeki sınıfın adı abouts ise sql de veri tabanına yanısyacak olan tablonun adı
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
        //yukarıdakiileri sql e tablo olarak yansıtmak için yazdık
        public DbSet<Message> Messages { get; set; }
        public DbSet<ImageFile> ImageFiles { get; set; }
        public DbSet<Admin> Admins { get; set; }



    }
}
