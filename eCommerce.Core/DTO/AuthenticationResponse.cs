namespace eCommerce.Core.DTO
{
    public record AuthenticationResponse(
        Guid UserIdD,
        string? Email,
        string? PersonName,
        string? Gender,
        string? Token,
        bool Success
    );
}
