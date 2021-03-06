// <auto-generated />
using Magazine20056663.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Magazine20056663.Migrations
{
    [DbContext(typeof(Magazine20056663Context))]
    [Migration("20210808044011_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15");

            modelBuilder.Entity("Magazine20056663.Pages.MagazineTest.Classes.Magazine", b =>
                {
                    b.Property<int>("magazineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("magazineName")
                        .HasColumnType("TEXT");

                    b.HasKey("magazineID");

                    b.ToTable("Magazine");
                });
#pragma warning restore 612, 618
        }
    }
}
