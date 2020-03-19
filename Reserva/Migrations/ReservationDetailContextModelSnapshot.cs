﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reserva.Models;

namespace Reserva.Migrations
{
    [DbContext(typeof(ReservationDetailContext))]
    partial class ReservationDetailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Reserva.Models.ReservationDetail", b =>
                {
                    b.Property<int>("ResID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("varchar (100)");

                    b.Property<string>("DepartureName")
                        .IsRequired()
                        .HasColumnType("varchar (100)");

                    b.Property<string>("DestinationName")
                        .IsRequired()
                        .HasColumnType("varchar (100)");

                    b.Property<string>("TravelDate")
                        .IsRequired()
                        .HasColumnType("varchar (5)");

                    b.HasKey("ResID");

                    b.ToTable("ReservationDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
