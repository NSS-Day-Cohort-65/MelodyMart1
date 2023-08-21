List<Instrument> instruments = new List<Instrument>()
{
    // collection initializer
new Instrument()
// object initializer
{
    Name = "Guitar",
    Price = 190.00M,
    SoldOnDate = new DateTime(2023, 08, 20),
    DateAdded = new DateTime(2022, 08, 01)
},
new Instrument()
{
    Name = "Clarinet",
    Price = 50.00M,
    // SoldOnDate = null,
    DateAdded = new DateTime(2020, 03, 15)
},
new Instrument()
{
    Name = "Flute",
    Price = 35.00M,
    DateAdded = new DateTime(2021, 05, 30)
},
new Instrument()
{
    Name = "Trumpet",
    Price = 65.00M,
    DateAdded = new DateTime(2023, 02, 25)
},
new Instrument()
{
    Name = "Tuba",
    Price = 100.00M,
    DateAdded = new DateTime(2022, 11, 15)
}
};

Console.WriteLine(@"\  |      |           |         \  |            |   
 |\/ |  _ \ |  _ \   _` | |   |  |\/ |  _` |  __| __| 
 |   |  __/ | (   | (   | |   |  |   | (   | |    |   
_|  _|\___|_|\___/ \__,_|\__, | _|  _|\__,_|_|   \__| 
                         ____/                        ");
