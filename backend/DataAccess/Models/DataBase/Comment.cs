using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace DataAccess.Models;

public class Comment
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public DateTime Datetime { get; set; } = DateTime.Now;
    [MaxLength(2000)]
    public string Text { get; set; } = null!;
    public Guid RequestId { get; set; }

    //EF Navigation
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public VerificationRequest Request { get; set; } = null!;
}
