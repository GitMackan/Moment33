using Microsoft.EntityFrameworkCore;
using Moment33.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Connect to database
builder.Services.AddDbContext<SongContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("SqliteSongString")));

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
