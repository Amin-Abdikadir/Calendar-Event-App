using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using CalendarApp.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args); // Ensure this line exists

// Load environment variables from .env file
Env.Load();

// Ensure that the connection string is loaded from the environment variables
var connectionString = builder.Configuration["ConnectionStrings__DefaultConnection"];
if (string.IsNullOrEmpty(connectionString))
{
    connectionString = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");
}

if (string.IsNullOrEmpty(connectionString))
{
    throw new ArgumentNullException(nameof(connectionString), "Connection string is not provided.");
}

// Log the connection string for debugging (remove in production)
Console.WriteLine("Loaded Connection String: " + connectionString);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSession(); // Add this line for session support

// Configure DbContext and Identity
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AppDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseSession(); // Add this middleware for session handling

// Enable Authentication & Authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();





