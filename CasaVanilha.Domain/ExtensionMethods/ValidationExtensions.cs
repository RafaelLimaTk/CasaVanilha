namespace CasaVanilha.Domain.ExtensionMethods;

public static class ValidationExtensions
{
    public static void EnsureNotNullOrEmpty(this string value, string parameterName)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException($"{parameterName} cannot be null or empty", parameterName);
    }

    public static void EnsureNotNull<T>(this T value, string parameterName) where T : class
    {
        if (value == null)
            throw new ArgumentNullException(parameterName, $"{parameterName} cannot be null");
    }

    public static void EnsureGreaterThanZero(this decimal value, string parameterName)
    {
        if (value <= 0)
            throw new ArgumentOutOfRangeException(parameterName, $"{parameterName} must be greater than zero");
    }

    public static void EnsureGreaterThanZero(this int value, string parameterName)
    {
        if (value <= 0)
            throw new ArgumentOutOfRangeException(parameterName, $"{parameterName} must be greater than zero");
    }

    public static void EnsureNotDefault(this DateTime value, string parameterName)
    {
        if (value == default)
            throw new ArgumentException($"{parameterName} cannot be default", parameterName);
    }
}
