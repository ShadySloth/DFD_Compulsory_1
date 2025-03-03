using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;

namespace DFD_Compulsory_1.Entities;

public class Student
{
    public int Id { get; set; }
    
    [Column(TypeName = "varchar(50)")]
    public required string FirstName { get; set; }
    
    [Column(TypeName = "varchar(50)")]
    public string? MiddleName { get; set; }
    
    [Column(TypeName = "varchar(50)")]
    public required string LastName { get; set; }
    
    [Column(TypeName = "varchar(60)")]
    public required string Email { get; set; }
    
    public required DateTime BirthDate { get; set; }
    
    public DateTime EnrollmentDate { get; set; }
}