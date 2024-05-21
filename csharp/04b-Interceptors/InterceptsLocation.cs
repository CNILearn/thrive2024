namespace System.Runtime.CompilerServices;

// Warning: The signature of this attribute will change before the stable release.
// https://github.com/dotnet/roslyn/blob/main/docs/features/interceptors.md

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
sealed class InterceptsLocationAttribute(string filePath, int line, int column) : Attribute
{
}