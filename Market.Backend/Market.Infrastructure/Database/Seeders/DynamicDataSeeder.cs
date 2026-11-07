using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Market.Domain.Entities.Finance;
using Market.Domain.Entities.Identity;

namespace Market.Infrastructure.Database.Seeders;

/// <summary>
/// Runtime seeder, called at application startup (Development and Testing only).
/// Inserts demo/test data that is not part of the migrations.
/// </summary>
public static class DynamicDataSeeder
{
    public static async Task SeedAsync(DatabaseContext context)
    {
        // The schema is not created here: DatabaseInitializer runs the migrations (SQL Server)
        // or EnsureCreated (in-memory database in tests) before seeding.

        await SeedUsersAsync(context);
        await SeedExchangeRatesAsync(context);
    }

    /// <summary>
    /// Creates demo users if there are none yet.
    /// Roles and IsEnabled are set explicitly (the database has no default values for them).
    /// </summary>
    private static async Task SeedUsersAsync(DatabaseContext context)
    {
        if (await context.Users.AnyAsync())
            return;

        var hasher = new PasswordHasher<MarketUserEntity>();

        var admin = new MarketUserEntity
        {
            Firstname = "Admin",
            Lastname = "Market",
            Email = "admin@market.local",
            PasswordHash = hasher.HashPassword(null!, "Admin123!"),
            Address = "Maršala Tita 1",
            City = "Sarajevo",
            IsAdmin = true,
            IsManager = false,
            IsEmployee = false,
            IsEnabled = true,
            CreatedAtUtc = DateTime.UtcNow
        };

        var manager = new MarketUserEntity
        {
            Firstname = "Manager",
            Lastname = "Market",
            Email = "manager@market.local",
            PasswordHash = hasher.HashPassword(null!, "Manager123!"),
            Address = "Ferhadija 12",
            City = "Sarajevo",
            IsAdmin = false,
            IsManager = true,
            IsEmployee = false,
            IsEnabled = true,
            CreatedAtUtc = DateTime.UtcNow
        };

        var employee = new MarketUserEntity
        {
            Firstname = "Employee",
            Lastname = "Market",
            Email = "employee@market.local",
            PasswordHash = hasher.HashPassword(null!, "Employee123!"),
            Address = "Kralja Tvrtka 5",
            City = "Zenica",
            IsAdmin = false,
            IsManager = false,
            IsEmployee = true,
            IsEnabled = true,
            CreatedAtUtc = DateTime.UtcNow
        };

        var dummyForSwagger = new MarketUserEntity
        {
            Firstname = "Swagger",
            Lastname = "Demo",
            Email = "string",
            PasswordHash = hasher.HashPassword(null!, "string"),
            Address = "Zmaja od Bosne 8",
            City = "Sarajevo",
            IsAdmin = false,
            IsManager = false,
            IsEmployee = true,
            IsEnabled = true,
            CreatedAtUtc = DateTime.UtcNow
        };

        var dummyForTests = new MarketUserEntity
        {
            Firstname = "Test",
            Lastname = "User",
            Email = "test",
            PasswordHash = hasher.HashPassword(null!, "test123"),
            Address = "Titova 3",
            City = "Tuzla",
            IsAdmin = false,
            IsManager = false,
            IsEmployee = true,
            IsEnabled = true,
            CreatedAtUtc = DateTime.UtcNow
        };

        // Demo users without a role
        var customer1 = new MarketUserEntity
        {
            Firstname = "Nina",
            Lastname = "Bijedić",
            Email = "nina.bijedic@email.com",
            PasswordHash = hasher.HashPassword(null!, "Customer123!"),
            Address = "Bulevar Meše Selimovića 15",
            City = "Sarajevo",
            IsAdmin = false,
            IsManager = false,
            IsEmployee = false,
            IsEnabled = true,
            CreatedAtUtc = DateTime.UtcNow.AddDays(-30)
        };

        var customer2 = new MarketUserEntity
        {
            Firstname = "Iris",
            Lastname = "Memić",
            Email = "iris.memic@email.com",
            PasswordHash = hasher.HashPassword(null!, "Customer123!"),
            Address = "Kneza Domagoja 22",
            City = "Mostar",
            IsAdmin = false,
            IsManager = false,
            IsEmployee = false,
            IsEnabled = true,
            CreatedAtUtc = DateTime.UtcNow.AddDays(-25)
        };

        var customer3 = new MarketUserEntity
        {
            Firstname = "Azra",
            Lastname = "Smajić",
            Email = "azra.smajic@email.com",
            PasswordHash = hasher.HashPassword(null!, "Customer123!"),
            Address = "Trg slobode 4",
            City = "Tuzla",
            IsAdmin = false,
            IsManager = false,
            IsEmployee = false,
            IsEnabled = true,
            CreatedAtUtc = DateTime.UtcNow.AddDays(-20)
        };

        context.Users.AddRange(
            admin,
            manager,
            employee,
            dummyForSwagger,
            dummyForTests,
            customer1,
            customer2,
            customer3
        );

        await context.SaveChangesAsync();
        Console.WriteLine("✅ Dynamic seed: demo users added.");
    }

    /// <summary>
    /// Approximate USD, CHF, GBP and RSD rates on four dates in 2026, so conversion works right after startup.
    /// Currencies and the fixed EUR rate (1.95583) come from the migration (StaticDataSeeder).
    /// These are not real rates: in production an administrator enters them or they are downloaded via ExchangeRates:Provider.
    /// </summary>
    private static async Task SeedExchangeRatesAsync(DatabaseContext context)
    {
        const string source = "Seed (približno)";

        if (await context.ExchangeRates.AnyAsync(r => r.Source == source))
            return;

        // KM za 1 jedinicu valute, redom za 01.01, 01.04, 01.07. i 01.10.2026.
        var approximateRates = new Dictionary<string, decimal[]>
        {
            ["USD"] = [1.6650m, 1.6800m, 1.6600m, 1.6750m],
            ["CHF"] = [2.0900m, 2.1000m, 2.0850m, 2.0950m],
            ["GBP"] = [2.2400m, 2.2550m, 2.2300m, 2.2450m],
            ["RSD"] = [0.016690m, 0.016685m, 0.016692m, 0.016688m]
        };

        DateTime[] validFromDates =
        [
            new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2026, 4, 1, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2026, 7, 1, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2026, 10, 1, 0, 0, 0, DateTimeKind.Utc)
        ];

        var codes = approximateRates.Keys.ToList();
        var currencyIdsByCode = await context.Currencies
            .Where(c => codes.Contains(c.Code))
            .ToDictionaryAsync(c => c.Code, c => c.Id);

        var rates = new List<ExchangeRateEntity>();
        foreach (var (code, values) in approximateRates)
        {
            if (!currencyIdsByCode.TryGetValue(code, out var currencyId))
                continue;

            for (var i = 0; i < validFromDates.Length; i++)
            {
                rates.Add(new ExchangeRateEntity
                {
                    CurrencyId = currencyId,
                    RateToBase = values[i],
                    ValidFromUtc = validFromDates[i],
                    Source = source,
                    CreatedAtUtc = DateTime.UtcNow
                });
            }
        }

        context.ExchangeRates.AddRange(rates);
        await context.SaveChangesAsync();

        Console.WriteLine($"✅ Dynamic seed: {rates.Count} approximate exchange rates added.");
    }
}
