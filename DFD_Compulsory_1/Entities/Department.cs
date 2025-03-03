using System.ComponentModel.DataAnnotations.Schema;

namespace DFD_Compulsory_1.Entities;

public class Department
{
    public int Id { get; set; }
    
    [Column(TypeName = "varchar(50)")]
    public required string Name { get; set; }
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Budget { get; set; }
    
    public DateTime StartDate { get; set; }
    
    /**
     * Department head
     */
    public int InstructorId { get; set; }
    
    
    public Instructor Instructor { get; set; }
}