using Microsoft.EntityFrameworkCore;
using MultipleORM.Bll.Interfaces.IServices;
using MultipleORM.Bll.Services;
using MultipleORM.Dal.Data.EntityFramework;
using MultipleORM.Dal.Initialization;
using MultipleORM.Dal.Interfaces.Initialization;
using MultipleORM.Dal.Interfaces.IRepository;
using MultipleORM.Dal.Repositories.Dapper;
using MultipleORM.Dal.Repositories.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("Default");

#region Services

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
SetDataProvider(builder);
builder.Services.AddScoped<IPuppyService, PuppyService>();
builder.Services.AddScoped<IColorService, ColorService>();
builder.Services.AddScoped<IBreedService, BreedService>();

#endregion

var app = builder.Build();

#region HTTP

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    InitializeDataBase();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

#endregion

app.Run();

#region Methods

void AddEfServices(WebApplicationBuilder builder)
{
    builder.Services.AddDbContext<PuppyDbContext>(options =>
    {
        options.UseSqlServer(connectionString);
    });
    builder.Services.AddScoped<IPuppyRepository, EfPuppyRepository>();
    builder.Services.AddScoped<IColorRepository, EfColorRepository>();
    builder.Services.AddScoped<IBreedRepository, EfBreedRepository>();
}

void AddDapperServices(WebApplicationBuilder builder)
{
    var connectionString = builder.Configuration.GetConnectionString("Default");
    builder.Services.AddScoped<IPuppyRepository, DpPuppyRepository>(s => new DpPuppyRepository(connectionString));
    builder.Services.AddScoped<IColorRepository, DpColorRepository>(s => new DpColorRepository(connectionString));
    builder.Services.AddScoped<IBreedRepository, DpBreedRepository>(s => new DpBreedRepository(connectionString));
}

void InitializeDataBase()
{
    int puppiesCount = app.Configuration.GetValue<int>("PuppiesRecordsCount");
    IDbInitialization initializer = new EfDbInitializer(puppiesCount,
        new PuppyDbContext(new DbContextOptionsBuilder<PuppyDbContext>()
            .UseSqlServer(connectionString)
            .Options));
    if (app.Configuration.GetValue<bool>("RecreateOnInitialization"))
    {
        initializer.InitializeWithRecreation();
        return;
    }
    initializer.Initialize();
}


void SetDataProvider(WebApplicationBuilder webApplicationBuilder)
{
    string provider = GetProviderName();
    if (provider == null) throw new ApplicationException("Provider not found");
    if (provider == "EF")
    {
        AddEfServices(webApplicationBuilder);
        return;
    }

    if (provider == "Dapper")
    {
        AddDapperServices(webApplicationBuilder);
        return;
    }

    string GetProviderName()
    {
        var json = webApplicationBuilder.Configuration.GetSection("DataProvider").GetChildren();
        if (json == null) throw new ApplicationException("Providers config not found");
        foreach (var section in json)
        {
            if (section.Get<bool>()) return section.Key;
        }
        return null;
    }
}

#endregion
