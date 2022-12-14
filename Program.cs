using System.Text.Json.Serialization;
using Data;
using Data.Interfaces;
using Data.Models;
using Data.Repositories;
using GraphQL;
using GraphQL.MicrosoftDI;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using Webshop.GraphQl;
using Webshop.Helpers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<AppDbContext>(opt =>
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddSingleton<ISchema, AppSchema>(services => new AppSchema(new SelfActivatingServiceProvider(services)));

// Add graphql
builder.Services.AddGraphQL(b => b
    .AddAutoSchema<Webshop.GraphQl.AppSchema>()
    .AddSystemTextJson());   // serializer

// add services to DI container
{
    var services = builder.Services;
    var env = builder.Environment;

    services.AddDbContext<AppDbContext>();
    services.AddCors();
    services.AddControllers().AddJsonOptions(x =>
    {
        // serialize enums as strings in api responses (e.g. Role)
        x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());

        // ignore omitted parameters on models to enable optional params (e.g. User update)
        x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });
    builder.Services.AddScoped<DbSeedInitializer>();

    services.AddHttpContextAccessor();
    services.AddSingleton<ContextServiceLocator>();
    
    services.AddScoped<IEndUserRepository, EndUserRepository>();

    // services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

    // configure DI for application services
    // services.AddScoped<IUserService, UserService>();
}

var app = builder.Build();

SeedData(app);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseDeveloperExceptionPage();
app.UseWebSockets();
app.UseGraphQL<ISchema>("/graphql");            // url to host GraphQL endpoint
app.UseGraphQLPlayground(
    "/",                               // url to host Playground at
    new GraphQL.Server.Ui.Playground.PlaygroundOptions
    {
        GraphQLEndPoint = "/graphql",         // url of GraphQL endpoint
        SubscriptionsEndPoint = "/graphql",   // url of GraphQL endpoint
    });

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// app.MapRazorPages();

// // Seed database
// var appDbContext = app.Services.GetRequiredService<AppDbContext>();
// new DbSeedInitializer().Seed(appDbContext);

app.Run("http://localhost:5000");


void SeedData(WebApplication host)
{
    using var scope = host.Services.CreateScope();
    var services = scope.ServiceProvider;

    try
    {
        var dbContext = services.GetRequiredService<AppDbContext>();

        if (dbContext.Database.IsSqlServer())
        {
            dbContext.Database.Migrate();
        }

        // var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
        // var roleManager = services.GetRequiredService<RoleManager<ApplicationRole>>();
        // AppDbContextSeed.SeedData(userManager, roleManager);

        new DbSeedInitializer().Initialize(dbContext);
    }
    catch (Exception)
    {
        //Log some error
        throw;
    }
}