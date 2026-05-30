using dot_net_course;

Address address = new Address();

address.Index = "01001";
address.Country = "Ukraine";
address.City = "Kyiv";
address.Street = "Khreshchatyk";
address.House = "1";
address.Apartment = "10";

Console.WriteLine($"Index: {address.Index}");
Console.WriteLine($"Country: {address.Country}");
Console.WriteLine($"City: {address.City}");
Console.WriteLine($"Street: {address.Street}");
Console.WriteLine($"House: {address.House}");
Console.WriteLine($"Apartment: {address.Apartment}");
