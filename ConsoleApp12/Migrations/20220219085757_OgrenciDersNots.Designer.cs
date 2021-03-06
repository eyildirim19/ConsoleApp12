// <auto-generated />
using System;
using ConsoleApp12;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp12.Migrations
{
    [DbContext(typeof(OkulDbContext))]
    [Migration("20220219085757_OgrenciDersNots")]
    partial class OgrenciDersNots
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp12.Ders", b =>
                {
                    b.Property<string>("DersID")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DersAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DonemID")
                        .HasColumnType("int");

                    b.HasKey("DersID");

                    b.HasIndex("DonemID");

                    b.ToTable("Ders");
                });

            modelBuilder.Entity("ConsoleApp12.Donem", b =>
                {
                    b.Property<int>("DonemID")
                        .HasColumnType("int");

                    b.Property<string>("DonemAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DonemID");

                    b.ToTable("Donem");
                });

            modelBuilder.Entity("ConsoleApp12.Not", b =>
                {
                    b.Property<int>("NotID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Final")
                        .HasColumnType("int");

                    b.Property<int>("OgrenciDersId")
                        .HasColumnType("int");

                    b.Property<int>("Ortalama")
                        .HasColumnType("int");

                    b.Property<int>("Vize")
                        .HasColumnType("int");

                    b.HasKey("NotID");

                    b.ToTable("Not");
                });

            modelBuilder.Entity("ConsoleApp12.Ogrenci", b =>
                {
                    b.Property<int>("No")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdiSoyAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("No");

                    b.ToTable("Ogrencis");
                });

            modelBuilder.Entity("ConsoleApp12.OgrenciDers", b =>
                {
                    b.Property<int>("OgrenciDersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DersID")
                        .HasColumnType("nvarchar(4)");

                    b.Property<int>("OgrenciID")
                        .HasColumnType("int");

                    b.Property<int>("YariYilID")
                        .HasColumnType("int");

                    b.HasKey("OgrenciDersID");

                    b.HasIndex("DersID");

                    b.HasIndex("OgrenciID");

                    b.HasIndex("YariYilID");

                    b.ToTable("OgrenciDers");
                });

            modelBuilder.Entity("ConsoleApp12.YariYil", b =>
                {
                    b.Property<int>("YariYilID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YariYilID");

                    b.ToTable("YariYil");
                });

            modelBuilder.Entity("ConsoleApp12.Ders", b =>
                {
                    b.HasOne("ConsoleApp12.Donem", "Donem")
                        .WithMany("Derss")
                        .HasForeignKey("DonemID");

                    b.Navigation("Donem");
                });

            modelBuilder.Entity("ConsoleApp12.OgrenciDers", b =>
                {
                    b.HasOne("ConsoleApp12.Ders", "Ders")
                        .WithMany()
                        .HasForeignKey("DersID");

                    b.HasOne("ConsoleApp12.Ogrenci", "Ogrenci")
                        .WithMany()
                        .HasForeignKey("OgrenciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp12.YariYil", "YariYil")
                        .WithMany()
                        .HasForeignKey("YariYilID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");

                    b.Navigation("Ogrenci");

                    b.Navigation("YariYil");
                });

            modelBuilder.Entity("ConsoleApp12.Donem", b =>
                {
                    b.Navigation("Derss");
                });
#pragma warning restore 612, 618
        }
    }
}
