using System;

namespace CONSUMIR_API_DTOs.DTOs;

public class PostDto
{
    public int UserId { get; set; }
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Body { get; set; }

}
