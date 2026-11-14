using System;
using System.ComponentModel.DataAnnotations;
public class Book
{
    public int Id { get; set; }                      

    [Required]                                        
    public string Title { get; set; } = string.Empty; 

    public string Author { get; set; } = string.Empty;

    [Range(0, int.MaxValue)]                         
    public int CopiesAvailable { get; set; }
}