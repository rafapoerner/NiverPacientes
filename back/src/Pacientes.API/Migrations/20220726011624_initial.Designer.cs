// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace src.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220726011624_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Pacientes.API.Models.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PacienteId"), 1L, 1);

                    b.Property<int>("DataNasc")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int>("Telefone")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.HasKey("PacienteId");

                    b.ToTable("Pacientes");
                });
#pragma warning restore 612, 618
        }
    }
}
