﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace USParksAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ParkType = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "City", "Description", "Name", "ParkType", "State" },
                values: new object[,]
                {
                    { 1, null, "California's most-visited national park stands out for its bevy of impressive waterfalls, such as Vernal Fall and Bridalveil Fall, as well as unique granite rock formations like the Half Dome and El Capitan.", "Yosemite", "National", "California" },
                    { 18, "Astoria", "Located just outside of coastal charmer Cannon Beach, this vista orgy of a state park stretches nine scenic miles of coastline from Cannon Beach to Seaside, offering secluded coves, lush spruce forest, and grassy bluffs overlooking its seductive beaches. A park so sexy it's a movie star, here you can catch stunning views of The Goonies rally point Haystack Rock or reenact the final scene of Point Break on the beach that doubled for Australia.", "Ecola State Park", "State", "Oregon" },
                    { 17, "Borrego Springs", "Sprawling out across a stark expanse of 600,000 acres about an hour south of Coachella, California's largest state park (and second-largest in the lower 48) is a crown jewel of America's state park system. By day it has 110 miles of hiking trails to explore and 12 designated wildlife areas, and by night the huge desertscape delivers some of the best stargazing in America.", "Anza-Borrego Desert State Park", "State", "California" },
                    { 16, "Homer", "If you're looking for wilderness, this massive 400,000-acre park has your number. You'll need to fly in or travel by boat (most likely from Homer) as there is no road access to much of the park -- which is what preserves this pristine wilderness that is home to whales, sea lions, moose, and an incredibly diverse range of sea birds.", "Kachemak Bay State Park", "State", "Alaska" },
                    { 15, "Millinocket", "Not only is this sprawling 200,000-acre park home to Northern Maine's beloved Mount Katahdin (the state's highest peak and the northern terminus of the Appalachian Trail), it's also the domain of a killer variety of wildlife, from hawks to black bears who make their home amid the park's peaceful lakes and waterfalls.", "Baxter State Park", "State", "Maine" },
                    { 14, "Niagara Falls", "Obvious choice? Of course. Mandatory pick? Absolutely. Hordes of photo-snapping tourists you remember from high school may have sullied your memories of the place, but America's oldest state park remains popular for a reason -- or 750,000 of them, which is the number of gallons of water rushing over the falls every second.", "Niagara Falls State Park", "State", "New York" },
                    { 13, "Eldorado Springs", "In a state as rich in parkland as Colorado (it has four national parks), the state parks pack a hell of a punch. Little Eldorado Canyon State Park, just a short ride from Boulder, is a hotspot for rock-climbing walls: It has over 1,000 technical climbing routes within the park, plus 11 miles of hiking/mountain-biking trails, and fishing opportunities in the scenic South Boulder Creek.", "Eldorado Canyon State Park", "State", "Colorado" },
                    { 12, "Wailuku", "To call this West Maui Mountains park 'lush' is an understatement of epic proportions. Its dense rainforest canopy makes this popular Hawaiian park one of America's more unique, dominated by the Iao Needle -- a 1,200ft vegetation-covered lava remnant that rises from the valley floor to a higher height than the Eiffel Tower.", "Iao Valley State Park", "State", "Hawaii" },
                    { 11, "Silver Bay", "Located about an hour north of the underrated town of Duluth along the magnificent Highway 61, this scenic Midwestern park offers everything from stunning views of jagged cliffs over Lake Superior, to roaring waterfalls, to forested hikes along the 310-mile Superior Hiking Trail.", "Tettegouche State Park", "State", "Minnesota" },
                    { 10, "", "Come to this national park on Maui and you'll be treated to one of the best sunrises in the world. The name of this Hawaiian park actually translates to 'house of the sun,' and it's easy to see why once you've reached the visitors center, where fellow travelers gather to witness the sunrise from more than 10,000 feet above sea level.", "Haleakala National Park", "National", "Hawaii" },
                    { 9, null, "The Rockies earn plenty of points for their convenience. Sitting just 70 miles north of Denver, the area makes for an easy daytrip. However, you could spend days exploring this park. The Rockies' magnificent landscape is one for the books, featuring 355 miles of scenic trails, 147 lakes and 118 peaks taller than 10,000 feet", "Rocky Mountain National Park", "National", "Colorado" },
                    { 8, null, "Established in 1929, Arches National Park covers nearly 77,000 acres in eastern Utah. Oddly shaped sandstone monuments riddle every view, and the formations make the park an excellent place for backpackers, rock climbers and hikers, not to mention photographers.", "Arches National Park", "National", "Utah" },
                    { 7, null, "Hoodoos are odd-shaped pillars of rock left standing from forces of erosion, and Bryce Canyon is home to the most extensive collection of hoodoos in the world. Located in southern Utah, the roughly 35,835-acre park offers an array of hiking opportunities.", "Bryce Canyon National Park", "National", "Utah" },
                    { 6, null, "Jackson Hole's backcountry is a wild wonderland begging to be explored. Once home to ranchers and fur trappers, the park now offers more than 200 miles of trails that weave through prairies, lakes and the park's most remarkable attribute, the jagged, snow-capped peaks of the Grand Teton mountain range", "Grand Teton National Park", "National", "Wyoming" },
                    { 5, null, "This Utah national park is a paradise for thrill-seekers. Hike Angel's Landing, which brings you up through a nearly 1,500-foot natural staircase, or trek The Narrows, a 10-mile hike through the thinnest section of Zion Canyon, which requires hikers to travel upstream through the Virgin River.", "Zion National Park", "National", "Utah" },
                    { 4, null, "The Grand Canyon is so magnificent that even the highest quality photos don't do the park's beauty justice – you just have to see it in person. The 18-by-277-mile UNESCO World Heritage Site offers endless hiking opportunities, as well as the chance to raft the Colorado River", "Grand Canyon", "National", null },
                    { 3, null, "Water and mountains define this national park, which spans two mountain ranges and includes more than 700 lakes across Montana. Take advantage of the park's expansive hiking trails, and be sure to hit traveler favorites like the Trail of the Cedars and Iceberg Lake Trail.", "Glacier National Park", "National", "Montana" },
                    { 2, null, "Even if Yellowstone didn't hold the incredible distinction of being the world's first national park, the 2.2 million-acre park could easily stand on its own for its unique natural attractions and diverse geography.", "Yellowstone", "National", null },
                    { 19, "Glendive", "Montana's largest state park might not be as famous as places like Glacier, but it's still the finest spot in Big Sky Country to mingle with dinosaur fossils. And the best part? You can mingle with said fossils buried within the state's far eastern plains anytime of day, as the park never closes.", "Makoshika State Park", "State", "Montana" },
                    { 20, "Terrebonne", "While it is known as one of the best rock-climbing areas in the West, and regarded as the birthplace of American sport climbing, Smith Rock also delights with low-impact family hikes and eye-popping scenery at every turn. Watch golden eagles soar over the Crooked River stocked with river otters as you try not to burn out your iPhone battery snapping pictures of the jagged rock formations popping up in this Central Oregon high-desert outpost.", "Smith Rock State Park", "State", "Oregon" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
