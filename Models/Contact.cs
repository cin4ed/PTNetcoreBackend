
namespace PTNetcoreBackend.Models;

public class Contact
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int ApplicationUserId { get; set; }
    public virtual ApplicationUser User { get; set; } = null!;
}