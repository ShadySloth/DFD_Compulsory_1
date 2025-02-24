using System.ComponentModel.DataAnnotations.Schema;

namespace DFD_Compulsory_1.Entities;

public class Course
{
    public int Id { get; set; }
    
    [Column(TypeName = "varchar(50)")]
    public string Title { get; set; }
    
    public int Credits { get; set; }
}