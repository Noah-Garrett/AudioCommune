﻿// <auto-generated />
using AudioCommune2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AudioCommune2.Migrations
{
    [DbContext(typeof(AudioCommuneDbContext))]
    partial class AudioCommuneDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("AudioCommune2.Models.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Servers");
                });

            modelBuilder.Entity("AudioCommune2.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AudioCommune2.Models.UserServer", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ServerID")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserID", "ServerID");

                    b.ToTable("UserServers");
                });

            modelBuilder.Entity("AudioCommune2.Models.message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ServerID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("AudioCommune2.Models.playlist", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ServerID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Position")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VideoID")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserID", "ServerID");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("AudioCommune2.Models.video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Videos");
                });
#pragma warning restore 612, 618
        }
    }
}