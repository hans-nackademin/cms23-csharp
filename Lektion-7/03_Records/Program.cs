using _03_Records.Records;

var user = new User("Hans", "Mattin-Lassei", "hans@domain.com");
//user.firstName = "Tommy"; <-- så här får/kan man inte göra

Console.WriteLine($"{user.firstName} {user.lastName} <{user.email}>");
Console.ReadKey();
