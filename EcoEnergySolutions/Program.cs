using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using EcoEnergySolutions.Utils;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


// Seed
builder.Services.AddDbContext<ApplicationDbContext>(options => 
options.UseSqlServer("name=DefaultConnection")
.UseSeeding((context, _) =>
{
    var anyEnergyIndicator = context.Set<EnergyIndicator>().Any();

    if (!anyEnergyIndicator)
    {
        string energyFilePath = "./Data/Csv/indicadors_energetics_cat.csv";
        string waterFilePath = "./Data/Csv/consum_aigua_cat_per_comarques.csv";

        List<EnergyIndicator> energyIndicators = CsvHandling.ReadEnergyIndicatorCsv(energyFilePath);
        List<WaterConsumption> waterConsumptions = CsvHandling.ReadWaterConsumptionCsv(waterFilePath);

        foreach (var newElement in energyIndicators)
        {
            context.Set<EnergyIndicator>().Add(newElement);
        }
        foreach (var newElement in waterConsumptions)
        {
            context.Set<WaterConsumption>().Add(newElement);
        }
        context.SaveChanges();
    }
})
.UseAsyncSeeding(async(context, _, CancellationToken) =>
{
    var anyEnergyIndicator = await context.Set<EnergyIndicator>().AnyAsync();

    if (!anyEnergyIndicator)
    {
        string energyFilePath = "./Data/Csv/indicadors_energetics_cat.csv";
        string waterFilePath = "./Data/Csv/consum_aigua_cat_per_comarques.csv";

        List<EnergyIndicator> energyIndicators = CsvHandling.ReadEnergyIndicatorCsv(energyFilePath);
        List<WaterConsumption> waterConsumptions = CsvHandling.ReadWaterConsumptionCsv(waterFilePath);

        foreach (var newElement in energyIndicators)
        {
            await context.Set<EnergyIndicator>().AddAsync(newElement);
        }
        foreach (var newElement in waterConsumptions)
        {
            await context.Set<WaterConsumption>().AddAsync(newElement);
        }
        await context.SaveChangesAsync();
    }
})

);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
