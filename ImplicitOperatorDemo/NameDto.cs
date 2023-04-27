
public record NameDto(string? GivenName)
{
    public Guid Id { get; set; } = Guid.NewGuid();
}