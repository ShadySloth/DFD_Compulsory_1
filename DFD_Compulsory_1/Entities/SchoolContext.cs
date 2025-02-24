using Microsoft.EntityFrameworkCore;

namespace DFD_Compulsory_1.Entities;

public class SchoolContext : DbContext
{
    protected SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
    {
    }
    
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Enrollment>()
            .HasOne(enrollment => enrollment.Student)
            .WithMany()
            .HasForeignKey(enrollment => enrollment.StudentId);
        
        modelBuilder.Entity<Enrollment>()
            .HasOne(enrollment => enrollment.Course)
            .WithMany()
            .HasForeignKey(enrollment => enrollment.CourseId);
        
        base.OnModelCreating(modelBuilder);
    }
}