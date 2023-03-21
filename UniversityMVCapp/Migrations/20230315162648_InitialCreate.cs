﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniversityMVCapp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses_CourseId", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups_GroupId", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_Groups_Courses",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students_StudentId", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Groups",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Bachelor in Geography programs are structured to provide specialized training in many geography centric areas", "Geography" },
                    { 2, "Bachelor of Geology is a program that focuses on the study of the solid earth and it’s processes of evolution", "Geology" },
                    { 3, "The bachelor’s programme ‘Hydrometeorology’ makes it possible for students to master both general basic courses in geography and hydrometeorology, and obtain knowledge in a particular area", "Hydrometeorology" },
                    { 4, "Pursuit of a bachelor’s degree provides the opportunity for advanced instruction at the university level with emphasis in a selected field", "Real Estate Management" },
                    { 5, "A bachelor’s degree is an undergraduate degree that is offered by universities and colleges when students complete a program of study", "Cartography" },
                    { 6, "A bachelor’s degree is widely considered to be the first degree in a series of possible higher education pursuits", "Oil and Gas" },
                    { 7, "The Bachelor of Tourism degree will provide students with the fundamental knowledge of the tourism industry, preparing for exciting jobs in the field of tourism", "Tourism" },
                    { 8, "A bachelor’s degree is awarded to individuals who have completed their undergraduate studies in a chosen field", "Soil science" },
                    { 9, "The field of ecology involves the study of living organisms, their interactions with each other, as well as the environment", "Ecology and nature management" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "CourseId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "SD-09" },
                    { 2, 2, "SH-23" },
                    { 3, 1, "SX-22" },
                    { 4, 5, "SA-33" },
                    { 5, 6, "SG-11" },
                    { 6, 1, "SR-01" },
                    { 7, 8, "SC-06" },
                    { 8, 9, "SH-01" },
                    { 9, 5, "SQ-06" },
                    { 10, 6, "SW-95" },
                    { 11, 7, "SJ-06" },
                    { 12, 8, "GR-03" },
                    { 13, 6, "VR-05" },
                    { 14, 7, "HR-06" },
                    { 15, 2, "MR-63" },
                    { 16, 6, "LR-42" },
                    { 17, 8, "AR-13" },
                    { 18, 5, "ZR-25" },
                    { 19, 6, "BR-46" },
                    { 20, 4, "MR-35" },
                    { 21, 4, "OG-14" },
                    { 22, 9, "SD-23" },
                    { 23, 6, "VB-11" },
                    { 24, 4, "BS-11" },
                    { 25, 2, "MD-06" },
                    { 26, 6, "AS-09" },
                    { 27, 8, "ZB-08" },
                    { 28, 6, "JT-03" },
                    { 29, 7, "SD-08" },
                    { 30, 9, "DJ-13" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1, "Emmy", 13, "Scrammage" },
                    { 2, "Cherice", 19, "Champkin" },
                    { 3, "Leonhard", 14, "Petchey" },
                    { 4, "Margo", 26, "Brister" },
                    { 5, "Kearney", 24, "Sauvain" },
                    { 6, "Mora", 15, "Spawforth" },
                    { 7, "Ernesto", 11, "Prester" },
                    { 8, "Denise", 1, "Mundow" },
                    { 9, "Cary", 27, "Bohey" },
                    { 10, "Guido", 7, "Overstreet" },
                    { 11, "Gusti", 30, "Croisdall" },
                    { 12, "Samuele", 13, "Pashenkov" },
                    { 13, "Esme", 5, "Stoggles" },
                    { 14, "Nady", 12, "Yegorkin" },
                    { 15, "Glenden", 27, "Donnel" },
                    { 16, "Joey", 3, "Potebury" },
                    { 17, "Silas", 21, "Rowth" },
                    { 18, "Jaimie", 19, "Vicioso" },
                    { 19, "Dougy", 3, "Carnduff" },
                    { 20, "Von", 20, "Lindermann" },
                    { 21, "Gaylor", 25, "Softley" },
                    { 22, "Elisa", 18, "Birdsey" },
                    { 23, "Laurella", 26, "Andrzejak" },
                    { 24, "Barton", 18, "Kopmann" },
                    { 25, "Serge", 19, "Sidebottom" },
                    { 26, "Nessy", 8, "Imeson" },
                    { 27, "Evvie", 7, "Dziwisz" },
                    { 28, "Robbert", 21, "Hinchon" },
                    { 29, "Jerome", 4, "Tremathack" },
                    { 30, "Jamey", 4, "Rouse" },
                    { 31, "Lina", 19, "Storer" },
                    { 32, "Dasha", 12, "Pimme" },
                    { 33, "Austin", 19, "Manjot" },
                    { 34, "Lissy", 11, "Skune" },
                    { 35, "Ciel", 11, "Laidlow" },
                    { 36, "Phineas", 6, "Wealthall" },
                    { 37, "Ferris", 8, "Kenney" },
                    { 38, "Kerwinn", 2, "Emblen" },
                    { 39, "Bili", 10, "Sandcroft" },
                    { 40, "Reamonn", 24, "Ganter" },
                    { 41, "Tadeo", 19, "Bispham" },
                    { 42, "Karin", 26, "Hoodlass" },
                    { 43, "Archy", 11, "Wawer" },
                    { 44, "Melitta", 14, "Dilston" },
                    { 45, "Averil", 11, "Norton" },
                    { 46, "Robbie", 26, "Mapowder" },
                    { 47, "Paulie", 2, "Abbets" },
                    { 48, "Dallis", 25, "Sneden" },
                    { 49, "Brittne", 15, "Jarrel" },
                    { 50, "Hettie", 29, "Tranfield" },
                    { 51, "Asher", 20, "Tickle" },
                    { 52, "Pasquale", 30, "Novello" },
                    { 53, "Hy", 6, "Wrightson" },
                    { 54, "Pepillo", 2, "Gernier" },
                    { 55, "Myca", 21, "Strainge" },
                    { 56, "Aleece", 17, "Allsup" },
                    { 57, "Vassili", 27, "Goslin" },
                    { 58, "Dede", 5, "Ambler" },
                    { 59, "Jessika", 17, "Fawckner" },
                    { 60, "Eimile", 23, "Perrott" },
                    { 61, "Lottie", 21, "Cutriss" },
                    { 62, "Angelica", 9, "Dalton" },
                    { 63, "Skip", 22, "Sandcroft" },
                    { 64, "Davidson", 3, "Chapleo" },
                    { 65, "Sheila", 10, "Rosenbaum" },
                    { 66, "Cynde", 6, "Boobier" },
                    { 67, "Bernadette", 26, "Fothergill" },
                    { 68, "Bernardo", 17, "Jansema" },
                    { 69, "Abbye", 27, "McCrachen" },
                    { 70, "Reuven", 29, "Ginner" },
                    { 71, "Kikelia", 5, "Mertgen" },
                    { 72, "Tammie", 8, "Iiannone" },
                    { 73, "Haley", 5, "Giraldez" },
                    { 74, "Bill", 25, "Ickowicz" },
                    { 75, "Storm", 25, "Dodson" },
                    { 76, "Evy", 20, "Hamnet" },
                    { 77, "Gerick", 20, "Tracy" },
                    { 78, "Wayland", 16, "Annon" },
                    { 79, "Penrod", 23, "Iron" },
                    { 80, "Janet", 5, "Delahunty" },
                    { 81, "Jarrad", 9, "Sissons" },
                    { 82, "Maure", 16, "Yurivtsev" },
                    { 83, "Giselle", 23, "Camus" },
                    { 84, "Ivette", 13, "Tissell" },
                    { 85, "Armando", 27, "Savege" },
                    { 86, "Cameron", 28, "Bandt" },
                    { 87, "Si", 13, "Giller" },
                    { 88, "Corrine", 28, "De Matteis" },
                    { 89, "Katheryn", 11, "Gelder" },
                    { 90, "Hatty", 11, "Knappe" },
                    { 91, "Nadya", 20, "Vedishchev" },
                    { 92, "Carmencita", 30, "Gaskin" },
                    { 93, "Leone", 19, "Gullick" },
                    { 94, "Roseann", 19, "Fanstone" },
                    { 95, "Tucker", 21, "Tuison" },
                    { 96, "Cornie", 21, "Kristoffersen" },
                    { 97, "Corty", 20, "Hay" },
                    { 98, "Michail", 24, "Hemerijk" },
                    { 99, "Luz", 15, "Leynton" },
                    { 100, "Nanine", 2, "Fulop" },
                    { 101, "Jerrine", 2, "Dunnet" },
                    { 102, "Aleta", 29, "Spurryer" },
                    { 103, "Kariotta", 13, "Fratson" },
                    { 104, "Jason", 3, "Francescoccio" },
                    { 105, "Bethena", 10, "McInulty" },
                    { 106, "Lucia", 7, "Bemlott" },
                    { 107, "Maryellen", 24, "Belfit" },
                    { 108, "Janette", 17, "Beetham" },
                    { 109, "Arley", 3, "Barber" },
                    { 110, "Maxwell", 14, "Elgee" },
                    { 111, "Denna", 11, "Ind" },
                    { 112, "Slade", 6, "Lording" },
                    { 113, "Lyndell", 25, "Terzo" },
                    { 114, "Harold", 4, "Trahair" },
                    { 115, "Karlik", 4, "Nudd" },
                    { 116, "Ilaire", 20, "Skoggings" },
                    { 117, "Phaidra", 4, "Kroll" },
                    { 118, "Jarid", 19, "Beckensall" },
                    { 119, "Hewett", 9, "Grewcock" },
                    { 120, "Gipsy", 18, "Reiach" },
                    { 121, "Isis", 24, "Nelligan" },
                    { 122, "Burgess", 11, "Petken" },
                    { 123, "Richard", 25, "Emmens" },
                    { 124, "Lemar", 22, "Bartrum" },
                    { 125, "Gui", 15, "Lathee" },
                    { 126, "Elbertine", 3, "Scuse" },
                    { 127, "Oliy", 26, "Yukhtin" },
                    { 128, "Kaela", 24, "Mollnar" },
                    { 129, "Neel", 4, "Hynard" },
                    { 130, "Fransisco", 21, "MacAskie" },
                    { 131, "Tibold", 7, "Sorro" },
                    { 132, "Noell", 4, "Kear" },
                    { 133, "Marlow", 6, "Farriar" },
                    { 134, "Brigham", 28, "Alvis" },
                    { 135, "Creigh", 5, "McGilleghole" },
                    { 136, "Law", 25, "Wearing" },
                    { 137, "Cora", 19, "Whorall" },
                    { 138, "Humfrey", 6, "Glanfield" },
                    { 139, "Sydney", 23, "Abramin" },
                    { 140, "Cyril", 14, "Hargreaves" },
                    { 141, "Wanids", 3, "Brine" },
                    { 142, "Coralyn", 11, "Jury" },
                    { 143, "Caralie", 20, "Dunkersley" },
                    { 144, "Merill", 7, "Gianni" },
                    { 145, "Adrianne", 1, "Cholwell" },
                    { 146, "Hedwig", 7, "Lattos" },
                    { 147, "Elna", 8, "Tiley" },
                    { 148, "Bronnie", 29, "Blainey" },
                    { 149, "Quent", 1, "Crevan" },
                    { 150, "Blanca", 25, "Olech" },
                    { 151, "Marmaduke", 22, "Lambart" },
                    { 152, "Tamiko", 3, "Archambault" },
                    { 153, "Egor", 6, "Florez" },
                    { 154, "Aldwin", 4, "Linch" },
                    { 155, "Keane", 3, "Hazzard" },
                    { 156, "Allard", 23, "McAuslene" },
                    { 157, "Veda", 7, "Wastling" },
                    { 158, "Leona", 23, "Petruk" },
                    { 159, "Margeaux", 25, "Pressman" },
                    { 160, "Giorgio", 22, "Shaul" },
                    { 161, "Reinaldo", 25, "Ceschini" },
                    { 162, "Deidre", 24, "Folli" },
                    { 163, "Wait", 3, "Domesday" },
                    { 164, "Cami", 2, "Luparti" },
                    { 165, "Maria", 16, "Gerardet" },
                    { 166, "Berni", 23, "Antonich" },
                    { 167, "Happy", 30, "Leagas" },
                    { 168, "Stacee", 9, "Mounfield" },
                    { 169, "Kennan", 15, "Flowerden" },
                    { 170, "Elva", 20, "Vicarey" },
                    { 171, "Karlene", 22, "Jolland" },
                    { 172, "Goran", 13, "McKeller" },
                    { 173, "Reinhard", 30, "Sheavills" },
                    { 174, "Dorelle", 3, "Baber" },
                    { 175, "Vi", 5, "Leed" },
                    { 176, "Tracey", 22, "Eingerfield" },
                    { 177, "Cory", 6, "Cutill" },
                    { 178, "Nevil", 28, "Hearnshaw" },
                    { 179, "Ortensia", 28, "Leese" },
                    { 180, "Mildred", 8, "Currer" },
                    { 181, "Ephrayim", 23, "Korfmann" },
                    { 182, "Berky", 25, "Tapply" },
                    { 183, "Cyndia", 30, "Wrankling" },
                    { 184, "Tammy", 17, "Bleasdille" },
                    { 185, "Esra", 1, "Brient" },
                    { 186, "Elena", 2, "Sargant" },
                    { 187, "Flem", 8, "McSherry" },
                    { 188, "Merrick", 30, "Gideon" },
                    { 189, "Monti", 25, "Scollee" },
                    { 190, "Jarrett", 4, "Froud" },
                    { 191, "Violette", 29, "Durden" },
                    { 192, "Morlee", 26, "Kellog" },
                    { 193, "Rutger", 19, "Spurgeon" },
                    { 194, "Kakalina", 5, "Vashchenko" },
                    { 195, "Jeni", 20, "Peaker" },
                    { 196, "Tannie", 17, "Gabriel" },
                    { 197, "Brewer", 27, "Bartholomew" },
                    { 198, "Martie", 22, "Strand" },
                    { 199, "Arlana", 27, "Paulin" },
                    { 200, "Kameko", 1, "Dayne" },
                    { 201, "Vaughn", 25, "Finci" },
                    { 202, "Maitilde", 3, "Torrese" },
                    { 203, "Renata", 7, "Kopelman" },
                    { 204, "Irvine", 6, "Schoolfield" },
                    { 205, "Zechariah", 25, "Headly" },
                    { 206, "Bart", 14, "Taaffe" },
                    { 207, "Tallie", 24, "Hargraves" },
                    { 208, "Venita", 6, "Liebrecht" },
                    { 209, "Cordey", 19, "Kerbler" },
                    { 210, "Staci", 2, "Pellissier" },
                    { 211, "Tybie", 4, "Stonard" },
                    { 212, "Cozmo", 4, "Lugton" },
                    { 213, "Cynthy", 14, "Crosseland" },
                    { 214, "Clifford", 27, "Kildea" },
                    { 215, "Garrard", 28, "Mum" },
                    { 216, "Lynn", 10, "Cockshoot" },
                    { 217, "Kerwin", 28, "Mullins" },
                    { 218, "Corrinne", 23, "Dominicacci" },
                    { 219, "Georgie", 1, "Bamforth" },
                    { 220, "Emmery", 3, "Miell" },
                    { 221, "Pincas", 8, "Sailer" },
                    { 222, "Elyssa", 10, "Craghead" },
                    { 223, "Melissa", 25, "Mallam" },
                    { 224, "Pippo", 23, "Claxson" },
                    { 225, "Dyanne", 3, "Hambelton" },
                    { 226, "Sebastiano", 9, "Krugmann" },
                    { 227, "Nadiya", 2, "Bofield" },
                    { 228, "Herculie", 3, "Edmonston" },
                    { 229, "Ronnie", 27, "Janos" },
                    { 230, "Lothario", 16, "Kiddie" },
                    { 231, "Arlinda", 8, "Richford" },
                    { 232, "Brig", 24, "Skiggs" },
                    { 233, "Almire", 17, "Crother" },
                    { 234, "Mathias", 20, "Prestland" },
                    { 235, "Fredia", 27, "Duck" },
                    { 236, "Ameline", 13, "Labrone" },
                    { 237, "Shannan", 10, "Methringham" },
                    { 238, "Giacomo", 4, "Chafney" },
                    { 239, "Bucky", 4, "Halson" },
                    { 240, "Heriberto", 1, "Krink" },
                    { 241, "Raimundo", 22, "Oxtarby" },
                    { 242, "Chelsie", 16, "Sappell" },
                    { 243, "Wash", 25, "Orriss" },
                    { 244, "April", 3, "Kinnerley" },
                    { 245, "Kissiah", 20, "Pither" },
                    { 246, "Astra", 21, "Oxterby" },
                    { 247, "Bill", 23, "Knowlys" },
                    { 248, "Balduin", 30, "Fidal" },
                    { 249, "Shepard", 10, "Settle" },
                    { 250, "Arlena", 11, "Guerola" },
                    { 251, "Cherry", 27, "Kilmaster" },
                    { 252, "Paige", 9, "Mityashin" },
                    { 253, "Graehme", 29, "Heskin" },
                    { 254, "Tess", 19, "Mariaud" },
                    { 255, "Loydie", 3, "Bruntjen" },
                    { 256, "Mattie", 5, "Abbots" },
                    { 257, "Bary", 8, "Laxtonne" },
                    { 258, "Sheri", 13, "Schanke" },
                    { 259, "Enid", 28, "Smoughton" },
                    { 260, "Radcliffe", 7, "Geare" },
                    { 261, "Adrianne", 30, "Rennock" },
                    { 262, "Basile", 14, "Portman" },
                    { 263, "Vittorio", 5, "Hadigate" },
                    { 264, "Honor", 6, "Isakovitch" },
                    { 265, "Bil", 1, "Heather" },
                    { 266, "Al", 29, "Huriche" },
                    { 267, "Sly", 20, "Race" },
                    { 268, "Alis", 26, "Joyes" },
                    { 269, "Cleopatra", 8, "Mathissen" },
                    { 270, "Cyrus", 2, "Tow" },
                    { 271, "Yancey", 8, "Barthrup" },
                    { 272, "Bendite", 12, "Schulze" },
                    { 273, "Minette", 3, "Ferrao" },
                    { 274, "Peder", 4, "Michie" },
                    { 275, "Gianni", 17, "Crathorne" },
                    { 276, "Donny", 28, "Disney" },
                    { 277, "Letty", 21, "Whates" },
                    { 278, "Noami", 27, "Coole" },
                    { 279, "Sarene", 28, "Jori" },
                    { 280, "Putnem", 5, "Bodycomb" },
                    { 281, "Emmery", 5, "Kubu" },
                    { 282, "Dulcie", 27, "Girardin" },
                    { 283, "Nels", 5, "Suggate" },
                    { 284, "Stacey", 23, "Truesdale" },
                    { 285, "Danyette", 14, "Chattoe" },
                    { 286, "Lynett", 1, "Tamblingson" },
                    { 287, "Hamlin", 2, "Morffew" },
                    { 288, "Hamish", 13, "Chamberlen" },
                    { 289, "Abbott", 16, "Darrel" },
                    { 290, "Willi", 14, "Tinan" },
                    { 291, "Jill", 9, "Horick" },
                    { 292, "Lara", 21, "Matzl" },
                    { 293, "Asher", 21, "Keppel" },
                    { 294, "Tiebout", 16, "Gandrich" },
                    { 295, "Minette", 17, "Wims" },
                    { 296, "Sheelagh", 13, "Greim" },
                    { 297, "Hamilton", 11, "Lippingwell" },
                    { 298, "Will", 29, "Akrigg" },
                    { 299, "Bendite", 4, "Sadat" },
                    { 300, "Suzie", 7, "Hallam" },
                    { 301, "Gustaf", 24, "Pammenter" },
                    { 302, "Allsun", 22, "Mantz" },
                    { 303, "Garth", 3, "Powrie" },
                    { 304, "Joey", 9, "Couthard" },
                    { 305, "Sileas", 12, "Egarr" },
                    { 306, "Timmie", 30, "Dantesia" },
                    { 307, "Cathryn", 20, "Trivett" },
                    { 308, "Hamnet", 29, "Alger" },
                    { 309, "Vaclav", 29, "Wilcocke" },
                    { 310, "Inigo", 12, "Pascoe" },
                    { 311, "Wendall", 22, "Over" },
                    { 312, "Myra", 5, "Tidbold" },
                    { 313, "Ave", 6, "Nollet" },
                    { 314, "Paule", 1, "Senior" },
                    { 315, "Tabbitha", 7, "Filippozzi" },
                    { 316, "Kathye", 20, "Strewther" },
                    { 317, "Falito", 5, "Grimley" },
                    { 318, "Camellia", 27, "Derry" },
                    { 319, "Jenni", 7, "Buffey" },
                    { 320, "Shandeigh", 9, "Bignall" },
                    { 321, "Jedd", 6, "MacVicar" },
                    { 322, "Editha", 18, "Perche" },
                    { 323, "Felicdad", 14, "Foker" },
                    { 324, "Grace", 12, "Looby" },
                    { 325, "Melisse", 9, "Inglesent" },
                    { 326, "Valeda", 18, "McJerrow" },
                    { 327, "Vick", 1, "Craise" },
                    { 328, "Kori", 1, "Ferrettini" },
                    { 329, "Madelle", 17, "Barensky" },
                    { 330, "Christina", 14, "Janaszewski" },
                    { 331, "Konstanze", 4, "Bradneck" },
                    { 332, "Franny", 16, "Stell" },
                    { 333, "Raphaela", 3, "Klemke" },
                    { 334, "Bartie", 11, "Creggan" },
                    { 335, "Leo", 30, "Lunney" },
                    { 336, "Abbe", 6, "Farge" },
                    { 337, "Ralina", 6, "Harfoot" },
                    { 338, "Kristine", 16, "Longain" },
                    { 339, "Yalonda", 5, "Ratlee" },
                    { 340, "Mable", 15, "Kullmann" },
                    { 341, "Tye", 5, "Cheson" },
                    { 342, "Rickie", 25, "Dallyn" },
                    { 343, "Averyl", 6, "Rook" },
                    { 344, "Ferdinand", 14, "Jerrand" },
                    { 345, "Donovan", 19, "Jensen" },
                    { 346, "Wash", 19, "Edgeley" },
                    { 347, "Mamie", 30, "Nezey" },
                    { 348, "Brigitte", 12, "Midghall" },
                    { 349, "Ruthie", 24, "Baildon" },
                    { 350, "Paton", 2, "Tims" },
                    { 351, "Elia", 21, "Itzkovwitch" },
                    { 352, "Rhiamon", 24, "Rotte" },
                    { 353, "Flint", 25, "Cardoo" },
                    { 354, "Reginauld", 9, "Cheesworth" },
                    { 355, "Mead", 6, "Jones" },
                    { 356, "Clark", 6, "Ambroise" },
                    { 357, "Finley", 10, "Yoseloff" },
                    { 358, "Benson", 10, "Claricoats" },
                    { 359, "Correna", 9, "Roon" },
                    { 360, "Ellis", 5, "Lindhe" },
                    { 361, "Juliana", 19, "Maryott" },
                    { 362, "Leopold", 19, "Hassell" },
                    { 363, "Philippe", 18, "Skully" },
                    { 364, "Merell", 8, "Vidgeon" },
                    { 365, "Vitoria", 25, "Antonikov" },
                    { 366, "Gwyneth", 27, "Fane" },
                    { 367, "Lainey", 16, "Itzkovwitch" },
                    { 368, "Thorstein", 3, "Agar" },
                    { 369, "Selma", 7, "Rafter" },
                    { 370, "Cecil", 11, "Planke" },
                    { 371, "Tressa", 6, "De Paepe" },
                    { 372, "Ruthi", 23, "Pawling" },
                    { 373, "Bradford", 1, "Renn" },
                    { 374, "Town", 29, "Fass" },
                    { 375, "Ardisj", 21, "Habbon" },
                    { 376, "Frederigo", 28, "Parbrook" },
                    { 377, "Emyle", 15, "Oloshkin" },
                    { 378, "Emile", 9, "Rosini" },
                    { 379, "Harald", 16, "McAneny" },
                    { 380, "Deeann", 8, "Easter" },
                    { 381, "Yasmin", 29, "Felton" },
                    { 382, "Suzi", 26, "Bart" },
                    { 383, "Ashleigh", 14, "McCandless" },
                    { 384, "Genni", 20, "Bealing" },
                    { 385, "Kalie", 15, "Crowcroft" },
                    { 386, "Rutter", 20, "Karlqvist" },
                    { 387, "Cinda", 27, "Twyning" },
                    { 388, "Abram", 19, "Wickmann" },
                    { 389, "Kessiah", 16, "Matresse" },
                    { 390, "Bartlett", 24, "Beveridge" },
                    { 391, "Aimil", 12, "Dudenie" },
                    { 392, "Brittani", 7, "Wyldbore" },
                    { 393, "Aleksandr", 1, "Staggs" },
                    { 394, "Whit", 9, "Skedge" },
                    { 395, "Inez", 9, "Bees" },
                    { 396, "Irwin", 17, "Perillo" },
                    { 397, "Gardie", 12, "Kopec" },
                    { 398, "Greg", 16, "Dunkerly" },
                    { 399, "Dwayne", 28, "Sangra" },
                    { 400, "Evangelina", 9, "Morrid" }
                });

            migrationBuilder.CreateIndex(
                name: "UQ_Courses_Name",
                table: "Courses",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CourseId",
                table: "Groups",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "UQ_Groups_Name",
                table: "Groups",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                column: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
