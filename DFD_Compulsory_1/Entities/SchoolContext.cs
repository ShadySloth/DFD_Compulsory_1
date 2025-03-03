using Microsoft.EntityFrameworkCore;

namespace DFD_Compulsory_1.Entities;

public class SchoolContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=SchoolDb;Trusted_Connection=True;");
        }
    }
    
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Instructor> Instructors { get; set; }

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
        
        modelBuilder.Entity<Course>()
            .HasOne(course => course.Instructor)
            .WithMany()
            .HasForeignKey(course => course.InstructorId);
        
        modelBuilder.Entity<Department>()
            .HasOne(department => department.Instructor)
            .WithMany()
            .HasForeignKey(department => department.InstructorId);

        base.OnModelCreating(modelBuilder);
    }
}