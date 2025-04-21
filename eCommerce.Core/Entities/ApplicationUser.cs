
namespace eCommerce.Core.Entities;
/// <summary>
/// Define the ApplicationUser Class which acts as a entity model class to store details in data store 
/// </summary>
public class ApplicationUser
{
    public Guid UserID { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? PersonName { get; set; }
    public string? Gender { get; set; }
}
