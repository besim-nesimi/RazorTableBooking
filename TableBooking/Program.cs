using Microsoft.EntityFrameworkCore;
using TableBooking.Data;
using TableBooking.Repos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var connectionString = builder.Configuration.GetConnectionString("BookingDbConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

// L�gger till TablesRepo i Dependency injection container
builder.Services.AddScoped<ITablesRepo, TablesRepo>();

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
