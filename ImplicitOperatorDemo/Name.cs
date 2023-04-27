public record Name(string? GivenName)
{
    public static implicit operator NameDto(Name value)
    {
        return new NameDto(value.GivenName);
    }
}
