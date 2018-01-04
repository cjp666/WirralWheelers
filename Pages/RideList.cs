using System;
using System.Collections.Generic;
using System.Linq;

namespace WirralWheelers.Pages
{
    public static class RideList
    {
        public static Ride Ride(int id)
        {
            return All().Single(r => r.Id == id);
        }

        public static IEnumerable<Ride> Proposed()
        {
            return new List<Ride>();
        }
        
        public static IEnumerable<Ride> Current()
        {
            return All()
                .Where(r => r.Date >= DateTime.Now.Date)
                .OrderBy(r => r.Date);
        }

        public static IEnumerable<Ride> Archived()
        {
            return All()
                .Where(r => r.Date < DateTime.Now.Date)
                .OrderByDescending(r => r.Date);
        }

        public static IEnumerable<Ride> All()
        {
            var rides = new List<Ride> {
                new Ride
                {
                    Title = "Hollywell",
                    Date = new DateTime(2017, 11, 5),
                    StartLocation = "Eureka",
                    RideLeader = "Mike",
                    Level = "B",
                    Description = "This is a B level ride, leaving Eureka Café for Hollywell",
                    Comments1 = "Club run today was to Hollywell. Met at Eureka Café, ride to Hollywell, 4 of us going over the Holkyns, rest going round and then all meeting for lunch in Hollywell. Three of us returning to Eureka, rest we think went to Nets, a bit of confusion at the end" + 
                        "<br>"+
                        "<br>Weather wasn't very nice today, lot of rain and hail, temperature dropped quite a lot on way home",
                    Comments1By = "Chris",
                    Comment1Photos = new List<string> {"23316592_479269262459507_8610295377980888031_n.jpg", "23172886_479269282459505_3325978675071000666_n.jpg", "23131833_479269315792835_4883607496712501039_n.jpg"},
                    Comments2 = "Not sure who was actually leading this ride today! The good news is that we came back into England with one more rider than we left to go to Wales." + 
                        "<br>Despite a mechanical problem and a bit of repair performed by Gordon we were under way again. On the way home as we crossed the new bridge over the Dee, Graham punctured and we regrouped to assist in a very windy, cold spot. As Chris mentioned there was some confusion and the group obviously split into 3 separate entities. Perhaps it’s a ploy to show the Wirral Wheelers were out in force!" + 
                        "<br>"+
                        "<br>Cold heavy showers and the daylight disappeared rapidly today. Winter is on its way.",
                    Comments2By = "Mike",
                    Comment2Photos = new List<string> {"23132079_308072233008855_2273640646178294374_n.jpg", "23316546_308072256342186_1665587329030460573_n.jpg", "23131868_308072239675521_8204248102181926748_n.jpg", "23316641_308072249675520_5613686715852285280_n.jpg"},
                },
                new Ride
                {
                    Title = "Hollywell",
                    Date = new DateTime(2017, 12, 3),
                    StartLocation = "Nets",
                    RideLeader = "Alan",
                    Level = "B",
                    Description = "This is a B level ride, leaving Net's Café for Hollywell"
                },
                new Ride
                {
                    Title = "Christmas Lunch - 107 Dining Room, Heswall",
                    Date = new DateTime(2017, 12, 11),
                    StartLocation = "Nets",
                    RideLeader = "Alan",
                    Level = "D",
                    Description = "This is a D- level ride, leaving Net's Café for Xmas lunch"
                },
                new Ride
                {
                    Title = "Christmas Eve - Cheshire Lanes",
                    Date = new DateTime(2017, 12, 24),
                    StartLocation = "Eureka",
                    RideLeader = "Mark",
                    Level = "C",
                    Description = "This is a C level ride, leaving Eureka Café taking in the lanes of Cheshire"
                },
                new Ride
                {
                    Title = "New Year's Eve - Dee View",
                    Date = new DateTime(2017, 12, 31),
                    StartLocation = "New Brighton",
                    RideLeader = "Mike",
                    Level = "C",
                    Description = "This is a C level ride, with a unusual start at New Brighton Station, heading for West Kirby where we will have lunch before heading back"
                },
                new Ride
                {
                    Title = "George's House",
                    Date = new DateTime(2018, 1, 7),
                    StartLocation = "Eureka",
                    RideLeader = "Gordon",
                    Level = "D",
                    Description = "This is a D- level ride, starting at Eureka Café taking in the Wirral lanes and stopping at George's house for lunch"
                },
                new Ride
                {
                    Title = "Cheshire Lanes, Meadow Lane Farm",
                    Date = new DateTime(2018, 1, 14),
                    StartLocation = "Nets",
                    RideLeader = "Alan",
                    Level = "C",
                    Description = "This is a C level ride, leaving Nets Café, taking in the lanes of Cheshire before stopping for lunch at Meadow Lane Farm"
                },
                new Ride
                {
                    Title = "Delamere Forest",
                    Date = new DateTime(2018, 1, 21),
                    StartLocation = "Eureka",
                    RideLeader = "Gordon",
                    Level = "C",
                    Description = "This is a C level ride, leaving Eureka Café, heading for Delamere Forest, stopping for lunch at the Station Café"
                },
                new Ride
                {
                    Title = "Plemstall Church",
                    Date = new DateTime(2018, 1, 28),
                    StartLocation = "Nets",
                    RideLeader = "Mike",
                    Level = "C",
                    Description = "This is a C level ride, leaving Nets Café, heading for Dunham on The Hill"
                },
                new Ride
                {
                    Title = "Holt",
                    Date = new DateTime(2018, 2, 4),
                    StartLocation = "Eureka",
                    RideLeader = "Mark",
                    Level = "B",
                    Description = "This is a B level ride, leaving Eureka Café, taking in the lanes of Cheshire before stopping for lunch in Holt"
                },
                new Ride
                {
                    Title = "Charity Event - Church Hill Challenge",
                    Date = new DateTime(2018, 4, 29),
                    StartLocation = "Waverton",
                    RideLeader = "TBC",
                    Level = "A",
                    Description = "This is an A level ride, taking in the Wales / Cheshire borders before turning up the Ceiriog Valley and climbing out up Church Hill"
                }
            };
            return rides;
        }
    }
}
