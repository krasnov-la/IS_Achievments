﻿// <auto-generated />
using System;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ISDBContext))]
    [Migration("20240918235032_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Admin")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<DateTime>("Finish")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<Guid>("Preview")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("activities", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Student")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.HasKey("Id");

                    b.ToTable("verification_requests", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<string>("EmailAddress")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("AvatarImgLink")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("BannedBy")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Course")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("LastName")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("Nickname")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("EmailAddress");

                    b.ToTable("users_info", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Request", b =>
                {
                    b.OwnsMany("Domain.Entities.Image", "Images", b1 =>
                        {
                            b1.Property<Guid>("Guid")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uuid");

                            b1.Property<Guid>("RequestId")
                                .HasColumnType("uuid");

                            b1.HasKey("Guid");

                            b1.HasIndex("RequestId");

                            b1.ToTable("images", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("RequestId");
                        });

                    b.OwnsOne("Domain.Entities.Achievement", "Achievement", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uuid");

                            b1.Property<string>("Admin")
                                .IsRequired()
                                .HasMaxLength(128)
                                .HasColumnType("character varying(128)");

                            b1.Property<float>("Score")
                                .HasColumnType("real");

                            b1.Property<Guid>("requestId")
                                .HasColumnType("uuid");

                            b1.HasKey("Id");

                            b1.HasIndex("requestId")
                                .IsUnique();

                            b1.ToTable("achievements", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("requestId");
                        });

                    b.OwnsOne("Domain.Entities.Comment", "Comment", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uuid");

                            b1.Property<string>("Admin")
                                .IsRequired()
                                .HasMaxLength(128)
                                .HasColumnType("character varying(128)");

                            b1.Property<string>("Message")
                                .IsRequired()
                                .HasMaxLength(512)
                                .HasColumnType("character varying(512)");

                            b1.Property<Guid>("requestId")
                                .HasColumnType("uuid");

                            b1.HasKey("Id");

                            b1.HasIndex("requestId")
                                .IsUnique();

                            b1.ToTable("comments", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("requestId");
                        });

                    b.Navigation("Achievement");

                    b.Navigation("Comment");

                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
