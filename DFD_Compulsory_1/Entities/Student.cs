using System.ComponentModel.DataAnnotations.Schema;

namespace DFD_Compulsory_1.Entities;

public class Student
{
    public int Id { get; set; }
    
    [Column(TypeName = "varchar(50)")]
    public string FirstName { get; set; }
    
    [Column(TypeName = "varchar(50)")]
    public string LastName { get; set; }
    
    [Column(TypeName = "varchar(60)")]
    public string Email { get; set; }
    
    public DateTime EnrollmentDate { get; set; }
}