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

Console.WriteLine(
@"\  |      |           |         \  |            |
 |\/ |  _ \ |  _ \   _` | |   |  |\/ |  _` |  __| __|
 |   |  __/ | (   | (   | |   |  |   | (   | |    |
_|  _|\___|_|\___/ \__,_|\__, | _|  _|\__,_|_|   \__|
                         ____/                        ");


string choice = null;
while (choice != "0")
{
    Console.WriteLine(@"Please choose an option:
        0. Exit
        1. Display Instruments
        2. Post an Instrument
        3. Purchase an Instrument
        4. Update an Instrument
        5. Delist an Instrument");

    choice = Console.ReadLine().Trim();

    switch (choice)
    {
        case "0":
            Console.WriteLine("Exiting the system. Goodbye!");
            break;

        case "1":
            //Display Instruments
            DisplayInstruments(instruments);
            break;

        case "2":
            //Post an Instrument
            AddAInstrument();
            break;
        // break;
        case "3":
            //Purchase an Instrument
            throw new NotImplementedException();
        // break;
        case "4":
            //Update an Instrument
            throw new NotImplementedException();
        // break;
        case "5":
            //Delist an Instrument
            throw new NotImplementedException();
        // break;
        default:
            Console.WriteLine("Please choose one of the options above.");
            break;
    }
}

void DisplayInstruments(List<Instrument> instruments)
{
    for (int i = 0; i < instruments.Count; i++)
    {
        Console.WriteLine($"{i + 1} . {InstrumentDetails(instruments[i])}");
    };
    returnToMainMenu();
};



void returnToMainMenu()
{
    Console.WriteLine("Press Any Key to return to main menu: ");
    Console.ReadKey();
    Console.Clear();
}

string InstrumentDetails(Instrument instrument)
{
    string instrumentString = $"Name: {instrument.Name}, " +
    $"Price: ${instrument.Price}, " +
    $"Sold on Date: {(instrument.SoldOnDate == null ? "N/A" : instrument.SoldOnDate.Value.ToShortDateString())} " +
    $"Date Added: {instrument.DateAdded.ToShortDateString()}";
    return instrumentString;
}

void AddAInstrument()
{
    string response = null;
    while (string.IsNullOrWhiteSpace(response))
    {
        Console.WriteLine("Enter the name:");
        response = Console.ReadLine().Trim();
        if (string.IsNullOrWhiteSpace(response))
        {
            Console.WriteLine("Try again!");
        }
    }
    // if(!string.IsNullOrWhiteSpace(response))
    // {
    //     response = Console.ReadLine().Trim();
    // }
    // else
    // {
    //     Console.WriteLine("Enter the name:");
    //     response = Console.ReadLine().Trim();
    // }
    decimal price = 0;
    while (price <= 0)
    {
        Console.WriteLine("Enter the Price: ");
        try
        {
            price = decimal.Parse(Console.ReadLine().Trim());
        }
        catch (FormatException)
        {
            Console.WriteLine("please enter numbers only");
        }
    }
    DateTime dateAdded = DateTime.Now;

    Instrument newInstrument = new Instrument
    {
        Name = response,
        Price = price,
        DateAdded = dateAdded

    };

    instruments.Add(newInstrument);

    // add error checkings

    // instrument should be string
    // price should be decimal

    returnToMainMenu();
}