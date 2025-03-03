using System.ComponentModel.DataAnnotations;

namespace DFD_Compulsory_1.Entities;

public class Enrollment
{
    public int Id { get; set; }
    
    public int StudentId { get; set; }
    
    public int CourseId { get; set; }
    
    public Grade Grade { get; set; }
    
    public Grade FinalGrade { get; set; }
    
    
    public Student Student { get; set; }
    public Course Course { get; set; }
}

public enum Grade {
    [Display(Name = "-3")]
    Grade_Negative3 = -3,
    
    [Display(Name = "00")]
    Grade_0 = 0,
    
    [Display(Name = "02")]
    Grade_02 = 2,
    
    [Display(Name = "4")]
    Grade_4 = 4,
    
    [Display(Name = "7")]
    Grade_7 = 7,
    
    [Display(Name = "10")]
    Grade_10 = 10,
    
    [Display(Name = "12")]
    Grade_12 = 12
}