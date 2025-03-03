using System.ComponentModel.DataAnnotations.Schema;

namespace DFD_Compulsory_1.Entities;

public class Instructor
{
    public int Id { get; set; }
    
    [Column(TypeName = "varchar(50)")]
    public required string FirstName { get; set; }
    
    [Column(TypeName = "varchar(50)")]
    public required string LastName { get; set; }
    
    public required DateTime HireDate { get; set; }
}