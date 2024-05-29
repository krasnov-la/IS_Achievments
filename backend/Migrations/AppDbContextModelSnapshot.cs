﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Models.Achievement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AdminLogin")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<Guid>("RequestId")
                        .HasColumnType("uuid");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.Property<DateTime>("VerificationDatetime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AdminLogin");

                    b.HasIndex("RequestId");

                    b.ToTable("Achievements");

                    b.HasData(
                        new
                        {
                            Id = new Guid("73a6e51d-f4fd-484e-8dde-d79d8a1123ca"),
                            AdminLogin = "admin",
                            RequestId = new Guid("3857816b-5444-4bb2-876b-00683dc65877"),
                            Score = 95.5f,
                            VerificationDatetime = new DateTime(2024, 5, 29, 13, 19, 9, 395, DateTimeKind.Utc).AddTicks(2290)
                        },
                        new
                        {
                            Id = new Guid("031217c5-ab1e-475c-a150-8422d2750ebf"),
                            AdminLogin = "admin",
                            RequestId = new Guid("dbfbfe2a-17e9-4803-9332-f507beba1924"),
                            Score = 88f,
                            VerificationDatetime = new DateTime(2024, 5, 29, 12, 19, 9, 395, DateTimeKind.Utc).AddTicks(2292)
                        },
                        new
                        {
                            Id = new Guid("19ce4a6f-cae3-46b1-8879-47138b101e81"),
                            AdminLogin = "admin",
                            RequestId = new Guid("60dc0ea3-4d07-4934-9884-91da12bbf5a8"),
                            Score = 92.3f,
                            VerificationDatetime = new DateTime(2024, 5, 29, 11, 19, 9, 395, DateTimeKind.Utc).AddTicks(2295)
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AdminLogin")
                        .IsRequired()
                        .HasColumnType("character varying(256)");

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(2100)
                        .HasColumnType("character varying(2100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("AdminLogin");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f4331d3f-e269-405a-9157-2f5bea848b42"),
                            AdminLogin = "admin",
                            Datetime = new DateTime(2024, 5, 29, 13, 19, 9, 395, DateTimeKind.Utc).AddTicks(2330),
                            Link = "http://example.com/activity1",
                            Name = "Sample Activity 1"
                        },
                        new
                        {
                            Id = new Guid("25d80a44-5afa-4ad8-9f93-e36b89ab971a"),
                            AdminLogin = "admin",
                            Datetime = new DateTime(2024, 5, 29, 12, 19, 9, 395, DateTimeKind.Utc).AddTicks(2332),
                            Link = "http://example.com/activity2",
                            Name = "Sample Activity 2"
                        },
                        new
                        {
                            Id = new Guid("5d30cde9-00a6-4634-8a9c-d95e56ddbbba"),
                            AdminLogin = "admin",
                            Datetime = new DateTime(2024, 5, 29, 11, 19, 9, 395, DateTimeKind.Utc).AddTicks(2335),
                            Link = "http://example.com/activity3",
                            Name = "Sample Activity 3"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("RequestId")
                        .HasColumnType("uuid");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1acb23c1-8a1e-4aab-9ba2-a3231b372f8d"),
                            Datetime = new DateTime(2024, 5, 29, 13, 19, 9, 395, DateTimeKind.Utc).AddTicks(2371),
                            RequestId = new Guid("3857816b-5444-4bb2-876b-00683dc65877"),
                            Text = "This is a sample comment 1."
                        },
                        new
                        {
                            Id = new Guid("5faf6808-4b6d-4ef5-966b-84773db9c396"),
                            Datetime = new DateTime(2024, 5, 29, 12, 19, 9, 395, DateTimeKind.Utc).AddTicks(2374),
                            RequestId = new Guid("dbfbfe2a-17e9-4803-9332-f507beba1924"),
                            Text = "This is a sample comment 2."
                        },
                        new
                        {
                            Id = new Guid("6117600f-bff8-4dd9-bdfa-08235138342b"),
                            Datetime = new DateTime(2024, 5, 29, 11, 19, 9, 395, DateTimeKind.Utc).AddTicks(2377),
                            RequestId = new Guid("60dc0ea3-4d07-4934-9884-91da12bbf5a8"),
                            Text = "This is a sample comment 3."
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("RequestId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9550fb91-62af-4520-8164-a6f285555247"),
                            RequestId = new Guid("3857816b-5444-4bb2-876b-00683dc65877")
                        },
                        new
                        {
                            Id = new Guid("67b53daf-0afb-4460-88a3-6f9fc491637e"),
                            RequestId = new Guid("dbfbfe2a-17e9-4803-9332-f507beba1924")
                        },
                        new
                        {
                            Id = new Guid("36cb2e13-17f6-4118-bb15-c65bc58f863e"),
                            RequestId = new Guid("60dc0ea3-4d07-4934-9884-91da12bbf5a8")
                        });
                });

            modelBuilder.Entity("DataAccess.Models.User", b =>
                {
                    b.Property<string>("Login")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Refresh")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<DateTime>("RefreshExpire")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.HasKey("Login");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Login = "admin",
                            Nickname = "Administrator",
                            Password = "AQAAAAIAAYagAAAAEETyaxS08KjbEL4Dbbk7nacWglX1RF/HtPfY9t+t/SCREycaUxAKYgdtcfaOfLhzMg==",
                            Refresh = "42af99f8-7c91-4fdb-8b72-0e12b7e6b74b",
                            RefreshExpire = new DateTime(2024, 6, 28, 13, 19, 9, 395, DateTimeKind.Utc).AddTicks(1996),
                            Role = "Admin"
                        },
                        new
                        {
                            Login = "user1",
                            Nickname = "User One",
                            Password = "AQAAAAIAAYagAAAAEETyaxS08KjbEL4Dbbk7nacWglX1RF/HtPfY9t+t/SCREycaUxAKYgdtcfaOfLhzMg==",
                            Refresh = "42af99f8-7c91-4fdb-8b72-0e12b7e6b74b",
                            RefreshExpire = new DateTime(2024, 6, 28, 13, 19, 9, 395, DateTimeKind.Utc).AddTicks(2003),
                            Role = "User"
                        },
                        new
                        {
                            Login = "user2",
                            Nickname = "User Two",
                            Password = "AQAAAAIAAYagAAAAEETyaxS08KjbEL4Dbbk7nacWglX1RF/HtPfY9t+t/SCREycaUxAKYgdtcfaOfLhzMg==",
                            Refresh = "42af99f8-7c91-4fdb-8b72-0e12b7e6b74b",
                            RefreshExpire = new DateTime(2024, 6, 28, 13, 19, 9, 395, DateTimeKind.Utc).AddTicks(2004),
                            Role = "User"
                        },
                        new
                        {
                            Login = "user3",
                            Nickname = "User Three",
                            Password = "AQAAAAIAAYagAAAAEETyaxS08KjbEL4Dbbk7nacWglX1RF/HtPfY9t+t/SCREycaUxAKYgdtcfaOfLhzMg==",
                            Refresh = "42af99f8-7c91-4fdb-8b72-0e12b7e6b74b",
                            RefreshExpire = new DateTime(2024, 6, 28, 13, 19, 9, 395, DateTimeKind.Utc).AddTicks(2006),
                            Role = "User"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.VerificationRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("boolean");

                    b.Property<string>("OwnerLogin")
                        .IsRequired()
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerLogin");

                    b.ToTable("VerificationRequests");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3857816b-5444-4bb2-876b-00683dc65877"),
                            DateTime = new DateTime(2024, 5, 29, 13, 19, 9, 395, DateTimeKind.Utc).AddTicks(2226),
                            Description = "Sample verification request description 1",
                            EventName = "Sample Event 1",
                            IsOpen = false,
                            OwnerLogin = "user1"
                        },
                        new
                        {
                            Id = new Guid("dbfbfe2a-17e9-4803-9332-f507beba1924"),
                            DateTime = new DateTime(2024, 5, 29, 11, 19, 9, 395, DateTimeKind.Utc).AddTicks(2230),
                            Description = "Sample verification request description 2",
                            EventName = "Sample Event 2",
                            IsOpen = false,
                            OwnerLogin = "user2"
                        },
                        new
                        {
                            Id = new Guid("60dc0ea3-4d07-4934-9884-91da12bbf5a8"),
                            DateTime = new DateTime(2024, 5, 29, 9, 19, 9, 395, DateTimeKind.Utc).AddTicks(2251),
                            Description = "Sample verification request description 3",
                            EventName = "Sample Event 3",
                            IsOpen = false,
                            OwnerLogin = "user2"
                        },
                        new
                        {
                            Id = new Guid("5f3d1276-1e7c-4da4-bebf-0b45aeb62e53"),
                            DateTime = new DateTime(2024, 5, 29, 9, 19, 9, 395, DateTimeKind.Utc).AddTicks(2254),
                            Description = "Sample verification request description 4",
                            EventName = "Sample Event 4",
                            IsOpen = false,
                            OwnerLogin = "user3"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Achievement", b =>
                {
                    b.HasOne("DataAccess.Models.User", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminLogin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.VerificationRequest", "Request")
                        .WithMany()
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("DataAccess.Models.Activity", b =>
                {
                    b.HasOne("DataAccess.Models.User", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminLogin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("DataAccess.Models.Comment", b =>
                {
                    b.HasOne("DataAccess.Models.VerificationRequest", "Request")
                        .WithMany()
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Request");
                });

            modelBuilder.Entity("DataAccess.Models.Image", b =>
                {
                    b.HasOne("DataAccess.Models.VerificationRequest", "Request")
                        .WithMany()
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Request");
                });

            modelBuilder.Entity("DataAccess.Models.VerificationRequest", b =>
                {
                    b.HasOne("DataAccess.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerLogin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });
#pragma warning restore 612, 618
        }
    }
}
