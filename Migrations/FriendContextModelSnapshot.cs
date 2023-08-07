﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcFriends.Data;

#nullable disable

namespace MvcFriends.Migrations
{
    [DbContext(typeof(FriendContext))]
    partial class FriendContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MvcFriends.Models.Friend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Friends");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "mary@gmail.com",
                            Mobile = "0922-355822",
                            Name = "Mary"
                        },
                        new
                        {
                            Id = 2,
                            Email = "david@gmail.com",
                            Mobile = "0933-123456",
                            Name = "David"
                        },
                        new
                        {
                            Id = 3,
                            Email = "rose@gmail.com",
                            Mobile = "0955-888-163",
                            Name = "Rose"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
