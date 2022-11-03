
using odev;

GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
gamerManager.Add(new Gamer
{
    Id = 1,
    BirthDate = 1985,
    FirstName = "engin",
    LastName = "demirog",
    IdentityNumber = 12345
});
Console.WriteLine("Hello, World!");
