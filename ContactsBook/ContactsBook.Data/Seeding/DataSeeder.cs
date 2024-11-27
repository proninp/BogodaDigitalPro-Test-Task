using ContactsBook.Core.Models;

namespace ContactsBook.Data.Seeding;
public static class DataSeeder
{
    public static Contact[] GetContactsSeeding()
    {
        return [
            new Contact {
                Id = Guid.Parse("979eea45-d033-4434-aaa7-e2d90abfe2f2"),
                PhoneNumber = "1-252-964-3425",
                FirstName = "Orlando",
                LastName = "Mejia",
                Email = "magna.malesuada@outlook.edu",
                DateOfBirth = DateOnly.Parse("24.07.00"),
                Address = "8640 Gravida Ave",
                Company = "Curae Donec Tincidunt Ltd",
                Position = "nisi. Cudu",
                Notes = ""
            },
            new Contact {
                Id = Guid.Parse("06491d3e-6456-4922-9985-44a6ab604ede"),
                PhoneNumber = "1-861-112-1343",
                FirstName = "Harding",
                LastName = "Blackburn",
                Email = "curabitur.vel.lectus@yahoo.org",
                DateOfBirth = DateOnly.Parse("25.07.98"),
                Address = "Ap #780-8170 Mi Ave",
                Company = "Lorem Lorem Luctus Inc.",
                Position = "nascetur ridiculus",
                Notes = "blandit congue. In scelerisque scelerisque"
            },
            new Contact {
                Id = Guid.Parse("43f5b51d-1929-441b-8ecf-eb6e9d0196ec"),
                PhoneNumber = "1-218-577-7225",
                FirstName = "Naomi",
                LastName = "Salazar",
                Email = "vel.faucibus@yahoo.net",
                DateOfBirth = DateOnly.Parse("28.04.01"),
                Address = "Ap #326-9000 Nunc St.",
                Company = "Velit Justo Foundation",
                Position = "ipsum primis",
                Notes = "nec, diam. Duis"
            },
            new Contact {
                Id = Guid.Parse("936f7e86-efc8-4f8f-9a96-393d7bb52ef8"),
                PhoneNumber = "1-344-461-2974",
                FirstName = "Reese",
                LastName = "Whitehead",
                Email = "sapien.imperdiet@icloud.net",
                DateOfBirth = DateOnly.Parse("27.02.99"),
                Address = "P.O. Box 803, 5325 Donec Rd.",
                Company = "Luctus Associates",
                Position = "hendrerit consectetuer,",
                Notes = "Suspendisse sed"
            },
            new Contact {
                Id = Guid.Parse("5e5d1380-a9d8-4639-8590-852b5c31ff44"),
                PhoneNumber = "1-836-468-7621",
                FirstName = "Vivien",
                LastName = "Porter",
                Email = "lacus.cras@icloud.couk",
                DateOfBirth = DateOnly.Parse("22.10.01"),
                Address = "567-6545 Commodo Road",
                Company = "Mauris Limited",
                Position = "vitae sodales",
                Notes = "felis, adipiscing fringilla, porttitor vulputate,"
            },
            new Contact {
                Id = Guid.Parse("a3d7d626-4566-4f57-8f26-58d41139bd35"),
                PhoneNumber = "1-664-751-0654",
                FirstName = "Ishmael",
                LastName = "Baker",
                Email = "eu.arcu@protonmail.com",
                DateOfBirth = DateOnly.Parse("20.11.00"),
                Address = "9928 Feugiat Street",
                Company = "Vestibulum Ante Ltd",
                Position = "fringilla, porttitor",
                Notes = "nisl elementum purus, accumsan interdum"
            },
            new Contact {
                Id = Guid.Parse("ae158a3e-417b-4597-ab3a-62e82e1680a6"),
                PhoneNumber = "1-114-915-8993",
                FirstName = "Jackson",
                LastName = "Stark",
                Email = "lobortis.quis@google.ca",
                DateOfBirth = DateOnly.Parse("24.10.98"),
                Address = "P.O. Box 266, 7317 Libero St.",
                Company = "Eu Ligula Consulting",
                Position = "pellentesque. Sed",
                Notes = "tellus lorem eu metus. In"
            },
            new Contact {
                Id = Guid.Parse("19926d6d-470f-42e9-a1e4-83d53bdbef1d"),
                PhoneNumber = "1-875-295-6961",
                FirstName = "Callum",
                LastName = "Crosby",
                Email = "egestas.urna.justo@hotmail.ca",
                DateOfBirth = DateOnly.Parse("10.09.01"),
                Address = "P.O. Box 838, 1281 Metus St.",
                Company = "Eget Ipsum Suspendisse Associates",
                Position = "congue turpis.",
                Notes = "nunc interdum feugiat. Sed"
            },
            new Contact {
                Id = Guid.Parse("52ccf000-c1e7-425c-b8d9-7e99bd5e88b1"),
                PhoneNumber = "1-138-123-6466",
                FirstName = "Willa",
                LastName = "Burnett",
                Email = "elit.pede.malesuada@outlook.couk",
                DateOfBirth = DateOnly.Parse("05.09.99"),
                Address = "Ap #753-8911 Cras Av.",
                Company = "Duis Elementum Dui LLC",
                Position = "vel lectus.",
                Notes = "amet luctus vulputate, nisi sem semper"
            },
            new Contact {
                Id = Guid.Parse("9f8ae1c3-4ee1-47cb-b185-c4395d198c5c"),
                PhoneNumber = "1-661-839-5511",
                FirstName = "Karen",
                LastName = "Cline",
                Email = "vulputate.posuere.vulputate@protonmail.org",
                DateOfBirth = DateOnly.Parse("24.07.99"),
                Address = "P.O. Box 769, 6456 Ligula. Avenue",
                Company = "Diam Company",
                Position = "eros non",
                Notes = "eu tellus. Phasellus elit pede,"
            },
            new Contact {
                Id = Guid.Parse("d5e80fd9-0eef-4fb1-9830-7fcdc73a3af7"),
                PhoneNumber = "1-485-147-2331",
                FirstName = "Vance",
                LastName = "Warren",
                Email = "taciti.sociosqu@google.edu",
                DateOfBirth = DateOnly.Parse("30.07.98"),
                Address = "2049 Rhoncus St.",
                Company = "Dignissim Institute",
                Position = "mollis dui,",
                Notes = "Etiam vestibulum"
            },
            new Contact {
                Id = Guid.Parse("43bc4204-42f0-4c45-8364-02d0b380b304"),
                PhoneNumber = "1-896-354-2181",
                FirstName = "Cally",
                LastName = "Tate",
                Email = "sit@google.org",
                DateOfBirth = DateOnly.Parse("16.10.00"),
                Address = "Ap #696-2201 Enim, Avenue",
                Company = "Erat Inc.",
                Position = "adipiscing elit.",
                Notes = "eget ipsum."
            },
            new Contact {
                Id = Guid.Parse("39e23901-0744-48f4-9334-6a808b57479e"),
                PhoneNumber = "1-528-181-3184",
                FirstName = "Alvin",
                LastName = "Alexander",
                Email = "ut@google.ca",
                DateOfBirth = DateOnly.Parse("24.03.99"),
                Address = "Ap #167-2639 Morbi Rd.",
                Company = "Pede Institute",
                Position = "orci, in",
                Notes = "commodo tincidunt nibh. Phasellus"
            },
            new Contact {
                Id = Guid.Parse("1ee9fe5b-dd6d-426c-bf78-36056ea96ab9"),
                PhoneNumber = "1-921-473-6738",
                FirstName = "Finn",
                LastName = "Ballard",
                Email = "hendrerit.id@hotmail.edu",
                DateOfBirth = DateOnly.Parse("03.05.00"),
                Address = "Ap #118-924 Gravida Av.",
                Company = "Tempor Arcu Limited",
                Position = "orci quis",
                Notes = "Pellentesque habitant morbi tristique senectus"
            },
            new Contact {
                Id = Guid.Parse("415bf853-f275-42d0-a2d6-32edc65e8c75"),
                PhoneNumber = "1-536-884-1841",
                FirstName = "Stephanie",
                LastName = "Mcmahon",
                Email = "cras@outlook.org",
                DateOfBirth = DateOnly.Parse("29.08.01"),
                Address = "P.O. Box 461, 9292 Ligula. Avenue",
                Company = "Amet Corporation",
                Position = "Maecenas ornare",
                Notes = ""
            },
            new Contact {
                Id = Guid.Parse("c8996b7f-c405-4d91-b3c6-71ac14d5c1bd"),
                PhoneNumber = "1-617-273-6498",
                FirstName = "Callum",
                LastName = "Mcdowell",
                Email = "donec.fringilla@outlook.ca",
                DateOfBirth = DateOnly.Parse("24.10.01"),
                Address = "Ap #843-3153 Dolor Av.",
                Company = "Quis Arcu Associates",
                Position = "lacinia vitae,",
                Notes = "non, bibendum"
            },
            new Contact {
                Id = Guid.Parse("ef96116a-82a0-495c-a145-82069dc9a184"),
                PhoneNumber = "1-134-897-6457",
                FirstName = "Yen",
                LastName = "Black",
                Email = "dolor@outlook.ca",
                DateOfBirth = DateOnly.Parse("16.02.01"),
                Address = "8996 Nullam Ave",
                Company = "Vivamus Nibh PC",
                Position = "Proin vel",
                Notes = "mauris"
            },
            new Contact {
                Id = Guid.Parse("7e8dd3bc-b7c6-4c2b-b7b1-1dcffe1250de"),
                PhoneNumber = "1-895-265-6384",
                FirstName = "Erich",
                LastName = "Mcmillan",
                Email = "arcu.sed.et@google.edu",
                DateOfBirth = DateOnly.Parse("10.01.01"),
                Address = "372-9482 Netus Ave",
                Company = "Et Tristique Pellentesque Incorporated",
                Position = "ultricies ligula.",
                Notes = "Pellentesque"
            },
            new Contact {
                Id = Guid.Parse("1e59776a-3bb5-4331-b9c3-4c39651bf652"),
                PhoneNumber = "1-917-591-8473",
                FirstName = "Myles",
                LastName = "Mercer",
                Email = "sed.est.nunc@icloud.ca",
                DateOfBirth = DateOnly.Parse("15.03.01"),
                Address = "5833 Eleifend Rd.",
                Company = "Cras Convallis Foundation",
                Position = "lectus sit",
                Notes = "Vestibulum accumsan"
            },
            new Contact {
                Id = Guid.Parse("ecc488bd-0c78-49ec-8576-e32ac6684c1c"),
                PhoneNumber = "1-868-330-7792",
                FirstName = "Hyatt",
                LastName = "Walls",
                Email = "felis.nulla@aol.org",
                DateOfBirth = DateOnly.Parse("30.09.01"),
                Address = "572-8982 Quis St.",
                Company = "Non Consulting",
                Position = "Cum sociis",
                Notes = "augue ac ipsum."
            }
        ];
    }
}
