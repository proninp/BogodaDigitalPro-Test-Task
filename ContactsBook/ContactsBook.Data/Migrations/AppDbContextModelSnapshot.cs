﻿// <auto-generated />
using System;
using ContactsBook.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ContactsBook.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ContactsBook.Core.Models.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Company")
                        .HasColumnType("text");

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("979eea45-d033-4434-aaa7-e2d90abfe2f2"),
                            Address = "8640 Gravida Ave",
                            Company = "Curae Donec Tincidunt Ltd",
                            DateOfBirth = new DateOnly(2000, 7, 24),
                            Email = "magna.malesuada@outlook.edu",
                            FirstName = "Orlando",
                            LastName = "Mejia",
                            Notes = "",
                            PhoneNumber = "1-252-964-3425",
                            Position = "nisi. Cudu"
                        },
                        new
                        {
                            Id = new Guid("06491d3e-6456-4922-9985-44a6ab604ede"),
                            Address = "Ap #780-8170 Mi Ave",
                            Company = "Lorem Lorem Luctus Inc.",
                            DateOfBirth = new DateOnly(1998, 7, 25),
                            Email = "curabitur.vel.lectus@yahoo.org",
                            FirstName = "Harding",
                            LastName = "Blackburn",
                            Notes = "blandit congue. In scelerisque scelerisque",
                            PhoneNumber = "1-861-112-1343",
                            Position = "nascetur ridiculus"
                        },
                        new
                        {
                            Id = new Guid("43f5b51d-1929-441b-8ecf-eb6e9d0196ec"),
                            Address = "Ap #326-9000 Nunc St.",
                            Company = "Velit Justo Foundation",
                            DateOfBirth = new DateOnly(2001, 4, 28),
                            Email = "vel.faucibus@yahoo.net",
                            FirstName = "Naomi",
                            LastName = "Salazar",
                            Notes = "nec, diam. Duis",
                            PhoneNumber = "1-218-577-7225",
                            Position = "ipsum primis"
                        },
                        new
                        {
                            Id = new Guid("936f7e86-efc8-4f8f-9a96-393d7bb52ef8"),
                            Address = "P.O. Box 803, 5325 Donec Rd.",
                            Company = "Luctus Associates",
                            DateOfBirth = new DateOnly(1999, 2, 27),
                            Email = "sapien.imperdiet@icloud.net",
                            FirstName = "Reese",
                            LastName = "Whitehead",
                            Notes = "Suspendisse sed",
                            PhoneNumber = "1-344-461-2974",
                            Position = "hendrerit consectetuer,"
                        },
                        new
                        {
                            Id = new Guid("5e5d1380-a9d8-4639-8590-852b5c31ff44"),
                            Address = "567-6545 Commodo Road",
                            Company = "Mauris Limited",
                            DateOfBirth = new DateOnly(2001, 10, 22),
                            Email = "lacus.cras@icloud.couk",
                            FirstName = "Vivien",
                            LastName = "Porter",
                            Notes = "felis, adipiscing fringilla, porttitor vulputate,",
                            PhoneNumber = "1-836-468-7621",
                            Position = "vitae sodales"
                        },
                        new
                        {
                            Id = new Guid("a3d7d626-4566-4f57-8f26-58d41139bd35"),
                            Address = "9928 Feugiat Street",
                            Company = "Vestibulum Ante Ltd",
                            DateOfBirth = new DateOnly(2000, 11, 20),
                            Email = "eu.arcu@protonmail.com",
                            FirstName = "Ishmael",
                            LastName = "Baker",
                            Notes = "nisl elementum purus, accumsan interdum",
                            PhoneNumber = "1-664-751-0654",
                            Position = "fringilla, porttitor"
                        },
                        new
                        {
                            Id = new Guid("ae158a3e-417b-4597-ab3a-62e82e1680a6"),
                            Address = "P.O. Box 266, 7317 Libero St.",
                            Company = "Eu Ligula Consulting",
                            DateOfBirth = new DateOnly(1998, 10, 24),
                            Email = "lobortis.quis@google.ca",
                            FirstName = "Jackson",
                            LastName = "Stark",
                            Notes = "tellus lorem eu metus. In",
                            PhoneNumber = "1-114-915-8993",
                            Position = "pellentesque. Sed"
                        },
                        new
                        {
                            Id = new Guid("19926d6d-470f-42e9-a1e4-83d53bdbef1d"),
                            Address = "P.O. Box 838, 1281 Metus St.",
                            Company = "Eget Ipsum Suspendisse Associates",
                            DateOfBirth = new DateOnly(2001, 9, 10),
                            Email = "egestas.urna.justo@hotmail.ca",
                            FirstName = "Callum",
                            LastName = "Crosby",
                            Notes = "nunc interdum feugiat. Sed",
                            PhoneNumber = "1-875-295-6961",
                            Position = "congue turpis."
                        },
                        new
                        {
                            Id = new Guid("52ccf000-c1e7-425c-b8d9-7e99bd5e88b1"),
                            Address = "Ap #753-8911 Cras Av.",
                            Company = "Duis Elementum Dui LLC",
                            DateOfBirth = new DateOnly(1999, 9, 5),
                            Email = "elit.pede.malesuada@outlook.couk",
                            FirstName = "Willa",
                            LastName = "Burnett",
                            Notes = "amet luctus vulputate, nisi sem semper",
                            PhoneNumber = "1-138-123-6466",
                            Position = "vel lectus."
                        },
                        new
                        {
                            Id = new Guid("9f8ae1c3-4ee1-47cb-b185-c4395d198c5c"),
                            Address = "P.O. Box 769, 6456 Ligula. Avenue",
                            Company = "Diam Company",
                            DateOfBirth = new DateOnly(1999, 7, 24),
                            Email = "vulputate.posuere.vulputate@protonmail.org",
                            FirstName = "Karen",
                            LastName = "Cline",
                            Notes = "eu tellus. Phasellus elit pede,",
                            PhoneNumber = "1-661-839-5511",
                            Position = "eros non"
                        },
                        new
                        {
                            Id = new Guid("d5e80fd9-0eef-4fb1-9830-7fcdc73a3af7"),
                            Address = "2049 Rhoncus St.",
                            Company = "Dignissim Institute",
                            DateOfBirth = new DateOnly(1998, 7, 30),
                            Email = "taciti.sociosqu@google.edu",
                            FirstName = "Vance",
                            LastName = "Warren",
                            Notes = "Etiam vestibulum",
                            PhoneNumber = "1-485-147-2331",
                            Position = "mollis dui,"
                        },
                        new
                        {
                            Id = new Guid("43bc4204-42f0-4c45-8364-02d0b380b304"),
                            Address = "Ap #696-2201 Enim, Avenue",
                            Company = "Erat Inc.",
                            DateOfBirth = new DateOnly(2000, 10, 16),
                            Email = "sit@google.org",
                            FirstName = "Cally",
                            LastName = "Tate",
                            Notes = "eget ipsum.",
                            PhoneNumber = "1-896-354-2181",
                            Position = "adipiscing elit."
                        },
                        new
                        {
                            Id = new Guid("39e23901-0744-48f4-9334-6a808b57479e"),
                            Address = "Ap #167-2639 Morbi Rd.",
                            Company = "Pede Institute",
                            DateOfBirth = new DateOnly(1999, 3, 24),
                            Email = "ut@google.ca",
                            FirstName = "Alvin",
                            LastName = "Alexander",
                            Notes = "commodo tincidunt nibh. Phasellus",
                            PhoneNumber = "1-528-181-3184",
                            Position = "orci, in"
                        },
                        new
                        {
                            Id = new Guid("1ee9fe5b-dd6d-426c-bf78-36056ea96ab9"),
                            Address = "Ap #118-924 Gravida Av.",
                            Company = "Tempor Arcu Limited",
                            DateOfBirth = new DateOnly(2000, 5, 3),
                            Email = "hendrerit.id@hotmail.edu",
                            FirstName = "Finn",
                            LastName = "Ballard",
                            Notes = "Pellentesque habitant morbi tristique senectus",
                            PhoneNumber = "1-921-473-6738",
                            Position = "orci quis"
                        },
                        new
                        {
                            Id = new Guid("415bf853-f275-42d0-a2d6-32edc65e8c75"),
                            Address = "P.O. Box 461, 9292 Ligula. Avenue",
                            Company = "Amet Corporation",
                            DateOfBirth = new DateOnly(2001, 8, 29),
                            Email = "cras@outlook.org",
                            FirstName = "Stephanie",
                            LastName = "Mcmahon",
                            Notes = "",
                            PhoneNumber = "1-536-884-1841",
                            Position = "Maecenas ornare"
                        },
                        new
                        {
                            Id = new Guid("c8996b7f-c405-4d91-b3c6-71ac14d5c1bd"),
                            Address = "Ap #843-3153 Dolor Av.",
                            Company = "Quis Arcu Associates",
                            DateOfBirth = new DateOnly(2001, 10, 24),
                            Email = "donec.fringilla@outlook.ca",
                            FirstName = "Callum",
                            LastName = "Mcdowell",
                            Notes = "non, bibendum",
                            PhoneNumber = "1-617-273-6498",
                            Position = "lacinia vitae,"
                        },
                        new
                        {
                            Id = new Guid("ef96116a-82a0-495c-a145-82069dc9a184"),
                            Address = "8996 Nullam Ave",
                            Company = "Vivamus Nibh PC",
                            DateOfBirth = new DateOnly(2001, 2, 16),
                            Email = "dolor@outlook.ca",
                            FirstName = "Yen",
                            LastName = "Black",
                            Notes = "mauris",
                            PhoneNumber = "1-134-897-6457",
                            Position = "Proin vel"
                        },
                        new
                        {
                            Id = new Guid("7e8dd3bc-b7c6-4c2b-b7b1-1dcffe1250de"),
                            Address = "372-9482 Netus Ave",
                            Company = "Et Tristique Pellentesque Incorporated",
                            DateOfBirth = new DateOnly(2001, 1, 10),
                            Email = "arcu.sed.et@google.edu",
                            FirstName = "Erich",
                            LastName = "Mcmillan",
                            Notes = "Pellentesque",
                            PhoneNumber = "1-895-265-6384",
                            Position = "ultricies ligula."
                        },
                        new
                        {
                            Id = new Guid("1e59776a-3bb5-4331-b9c3-4c39651bf652"),
                            Address = "5833 Eleifend Rd.",
                            Company = "Cras Convallis Foundation",
                            DateOfBirth = new DateOnly(2001, 3, 15),
                            Email = "sed.est.nunc@icloud.ca",
                            FirstName = "Myles",
                            LastName = "Mercer",
                            Notes = "Vestibulum accumsan",
                            PhoneNumber = "1-917-591-8473",
                            Position = "lectus sit"
                        },
                        new
                        {
                            Id = new Guid("ecc488bd-0c78-49ec-8576-e32ac6684c1c"),
                            Address = "572-8982 Quis St.",
                            Company = "Non Consulting",
                            DateOfBirth = new DateOnly(2001, 9, 30),
                            Email = "felis.nulla@aol.org",
                            FirstName = "Hyatt",
                            LastName = "Walls",
                            Notes = "augue ac ipsum.",
                            PhoneNumber = "1-868-330-7792",
                            Position = "Cum sociis"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
