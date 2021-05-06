using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreRazorUI.Models
{
    public class MusicStoreListContext: DbContext
    {
        //DbContextOptions- Database le alakalı işlemleri yapacağımız ana classımız
        //Oluşturuduğum contexti base de options üzerinden tanıyacak
        public MusicStoreListContext(DbContextOptions<MusicStoreListContext> options) : base (options)
        {

        }
        public DbSet<Music> Musics { get; set; }
    }
}
