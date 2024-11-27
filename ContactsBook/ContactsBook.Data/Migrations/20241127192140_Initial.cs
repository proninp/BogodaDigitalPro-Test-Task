using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContactsBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Company = table.Column<string>(type: "text", nullable: true),
                    Position = table.Column<string>(type: "text", nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "Company", "DateOfBirth", "Email", "FirstName", "LastName", "Notes", "PhoneNumber", "Position" },
                values: new object[,]
                {
                    { new Guid("06491d3e-6456-4922-9985-44a6ab604ede"), "Ap #780-8170 Mi Ave", "Lorem Lorem Luctus Inc.", new DateOnly(1998, 7, 25), "curabitur.vel.lectus@yahoo.org", "Harding", "Blackburn", "blandit congue. In scelerisque scelerisque", "1-861-112-1343", "nascetur ridiculus" },
                    { new Guid("19926d6d-470f-42e9-a1e4-83d53bdbef1d"), "P.O. Box 838, 1281 Metus St.", "Eget Ipsum Suspendisse Associates", new DateOnly(2001, 9, 10), "egestas.urna.justo@hotmail.ca", "Callum", "Crosby", "nunc interdum feugiat. Sed", "1-875-295-6961", "congue turpis." },
                    { new Guid("1e59776a-3bb5-4331-b9c3-4c39651bf652"), "5833 Eleifend Rd.", "Cras Convallis Foundation", new DateOnly(2001, 3, 15), "sed.est.nunc@icloud.ca", "Myles", "Mercer", "Vestibulum accumsan", "1-917-591-8473", "lectus sit" },
                    { new Guid("1ee9fe5b-dd6d-426c-bf78-36056ea96ab9"), "Ap #118-924 Gravida Av.", "Tempor Arcu Limited", new DateOnly(2000, 5, 3), "hendrerit.id@hotmail.edu", "Finn", "Ballard", "Pellentesque habitant morbi tristique senectus", "1-921-473-6738", "orci quis" },
                    { new Guid("39e23901-0744-48f4-9334-6a808b57479e"), "Ap #167-2639 Morbi Rd.", "Pede Institute", new DateOnly(1999, 3, 24), "ut@google.ca", "Alvin", "Alexander", "commodo tincidunt nibh. Phasellus", "1-528-181-3184", "orci, in" },
                    { new Guid("415bf853-f275-42d0-a2d6-32edc65e8c75"), "P.O. Box 461, 9292 Ligula. Avenue", "Amet Corporation", new DateOnly(2001, 8, 29), "cras@outlook.org", "Stephanie", "Mcmahon", "", "1-536-884-1841", "Maecenas ornare" },
                    { new Guid("43bc4204-42f0-4c45-8364-02d0b380b304"), "Ap #696-2201 Enim, Avenue", "Erat Inc.", new DateOnly(2000, 10, 16), "sit@google.org", "Cally", "Tate", "eget ipsum.", "1-896-354-2181", "adipiscing elit." },
                    { new Guid("43f5b51d-1929-441b-8ecf-eb6e9d0196ec"), "Ap #326-9000 Nunc St.", "Velit Justo Foundation", new DateOnly(2001, 4, 28), "vel.faucibus@yahoo.net", "Naomi", "Salazar", "nec, diam. Duis", "1-218-577-7225", "ipsum primis" },
                    { new Guid("52ccf000-c1e7-425c-b8d9-7e99bd5e88b1"), "Ap #753-8911 Cras Av.", "Duis Elementum Dui LLC", new DateOnly(1999, 9, 5), "elit.pede.malesuada@outlook.couk", "Willa", "Burnett", "amet luctus vulputate, nisi sem semper", "1-138-123-6466", "vel lectus." },
                    { new Guid("5e5d1380-a9d8-4639-8590-852b5c31ff44"), "567-6545 Commodo Road", "Mauris Limited", new DateOnly(2001, 10, 22), "lacus.cras@icloud.couk", "Vivien", "Porter", "felis, adipiscing fringilla, porttitor vulputate,", "1-836-468-7621", "vitae sodales" },
                    { new Guid("7e8dd3bc-b7c6-4c2b-b7b1-1dcffe1250de"), "372-9482 Netus Ave", "Et Tristique Pellentesque Incorporated", new DateOnly(2001, 1, 10), "arcu.sed.et@google.edu", "Erich", "Mcmillan", "Pellentesque", "1-895-265-6384", "ultricies ligula." },
                    { new Guid("936f7e86-efc8-4f8f-9a96-393d7bb52ef8"), "P.O. Box 803, 5325 Donec Rd.", "Luctus Associates", new DateOnly(1999, 2, 27), "sapien.imperdiet@icloud.net", "Reese", "Whitehead", "Suspendisse sed", "1-344-461-2974", "hendrerit consectetuer," },
                    { new Guid("979eea45-d033-4434-aaa7-e2d90abfe2f2"), "8640 Gravida Ave", "Curae Donec Tincidunt Ltd", new DateOnly(2000, 7, 24), "magna.malesuada@outlook.edu", "Orlando", "Mejia", "", "1-252-964-3425", "nisi. Cudu" },
                    { new Guid("9f8ae1c3-4ee1-47cb-b185-c4395d198c5c"), "P.O. Box 769, 6456 Ligula. Avenue", "Diam Company", new DateOnly(1999, 7, 24), "vulputate.posuere.vulputate@protonmail.org", "Karen", "Cline", "eu tellus. Phasellus elit pede,", "1-661-839-5511", "eros non" },
                    { new Guid("a3d7d626-4566-4f57-8f26-58d41139bd35"), "9928 Feugiat Street", "Vestibulum Ante Ltd", new DateOnly(2000, 11, 20), "eu.arcu@protonmail.com", "Ishmael", "Baker", "nisl elementum purus, accumsan interdum", "1-664-751-0654", "fringilla, porttitor" },
                    { new Guid("ae158a3e-417b-4597-ab3a-62e82e1680a6"), "P.O. Box 266, 7317 Libero St.", "Eu Ligula Consulting", new DateOnly(1998, 10, 24), "lobortis.quis@google.ca", "Jackson", "Stark", "tellus lorem eu metus. In", "1-114-915-8993", "pellentesque. Sed" },
                    { new Guid("c8996b7f-c405-4d91-b3c6-71ac14d5c1bd"), "Ap #843-3153 Dolor Av.", "Quis Arcu Associates", new DateOnly(2001, 10, 24), "donec.fringilla@outlook.ca", "Callum", "Mcdowell", "non, bibendum", "1-617-273-6498", "lacinia vitae," },
                    { new Guid("d5e80fd9-0eef-4fb1-9830-7fcdc73a3af7"), "2049 Rhoncus St.", "Dignissim Institute", new DateOnly(1998, 7, 30), "taciti.sociosqu@google.edu", "Vance", "Warren", "Etiam vestibulum", "1-485-147-2331", "mollis dui," },
                    { new Guid("ecc488bd-0c78-49ec-8576-e32ac6684c1c"), "572-8982 Quis St.", "Non Consulting", new DateOnly(2001, 9, 30), "felis.nulla@aol.org", "Hyatt", "Walls", "augue ac ipsum.", "1-868-330-7792", "Cum sociis" },
                    { new Guid("ef96116a-82a0-495c-a145-82069dc9a184"), "8996 Nullam Ave", "Vivamus Nibh PC", new DateOnly(2001, 2, 16), "dolor@outlook.ca", "Yen", "Black", "mauris", "1-134-897-6457", "Proin vel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
