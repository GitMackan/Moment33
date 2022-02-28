using Microsoft.EntityFrameworkCore;
using Moment33.Models;

namespace Moment33.Data;

public class SongContext : DbContext
{
    // Constructor
    public SongContext(DbContextOptions<SongContext> options) : base(options)
    {

    }

    // Set tables to DB
    public DbSet<Song> Songs { get; set; }
}