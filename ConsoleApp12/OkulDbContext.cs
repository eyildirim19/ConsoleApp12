using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class OkulDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =.\mssqlexpress; Database = BTOKULDB; uid = sa; pwd = 123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenci>().HasKey(c => c.No); // No Ogrencinin pk'sıdır..
            modelBuilder.Entity<Ders>().HasKey(c => c.DersID);
            modelBuilder.Entity<Ders>().Property(c => c.DersID).HasMaxLength(4);
            modelBuilder.Entity<Donem>().HasKey(c => c.DonemID);
            modelBuilder.Entity<Donem>().Property(c => c.DonemID).ValueGeneratedNever(); // identity olmasın....
            modelBuilder.Entity<Not>().Property(c => c.Ortalama).HasComputedColumnSql("((Vize + Final) / 2)");
            modelBuilder.Entity<Ogrenci>().Property(c => c.FullAd).HasComputedColumnSql("(Concat(Adi,' ',SoyAdi))");
            modelBuilder.Entity<Ogrenci>().Property(c => c.CreDate).HasDefaultValueSql("getdate()");
        }

        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Ders> Ders { get; set; }
        public DbSet<Not> Not { get; set; }
        public DbSet<Donem> Donem { get; set; }
        public DbSet<YariYil> YariYil { get; set; }
        public DbSet<OgrenciDers> OgrenciDers { get; set; }
    }




    // Single Responsibility => Tek sorumluluk

    // Navigation Property => Relational datayı çekmek için kullanlır
    public class Donem
    {
        // DonemID pk olarak algılanır
        // ID pk olarak algılanır
        public int DonemID { get; set; }
        public string DonemAdi { get; set; }
        public List<Ders> Derss { get; set; }
    }

    public class Ders
    {
        public string DersID { get; set; }
        public string DersAdi { get; set; }

        [ForeignKey("Donem")]
        public Nullable<int> DonemID { get; set; }
        public Donem Donem { get; set; } // navigation property
    }

    public class Ogrenci
    {
        //  [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.None)] // Identity Değil..
        public int No { get; set; }

        [Column(Order = 2)]
        public string Adi { get; set; }
        [Column(Order = 3)]
        public string SoyAdi { get; set; }
        public string FullAd { get; set; }
        public DateTime CreDate { get; set; }
    }

    public class YariYil
    {
        public int YariYilID { get; set; }

        public string Adi { get; set; }
    }

    public class OgrenciDers
    {
        public int OgrenciDersID { get; set; } // PK

        [ForeignKey("Ders")]
        public string DersID { get; set; } // FK

        public Ders Ders { get; set; } // navgitayion property

        [ForeignKey("Ogrenci")]
        public int OgrenciID { get; set; } // FK

        public Ogrenci Ogrenci { get; set; } // navigation property

        [ForeignKey("YariYil")]
        public int YariYilID { get; set; } // FK

        public YariYil YariYil { get; set; } // navigation property
    }

    public class Not
    {
        public int NotID { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }


        public int Ortalama { get; set; }

        [ForeignKey("OgrenciDers")]
        public int OgrenciDersId { get; set; }


    }
}