//// Exercise 1.1: custom exception InvalidAgeException
//a custom exception.Write class InvalidAgeException : Exception
//with a constructor that takes a message.
//	Write int ParseAge(string text) that throws it 
//	with “Age must be a number” if the text is not a
//	number, and with “Age must be between 0 and 120” 
//	if the number is outside that range (use int.TryParse).
//	Loop over "25", "abc", "-3" and "200". 
//	For each, print<text> is valid,or catch the exception and
//	print Invalid: < message >.
    const int MinAge = 0;
    const int MaxAge = 120;
    string[] Ages = { "25", "abc", "-3", "200" };
    foreach (var txt in Ages)
    {
        try
        {
            ParseAge(txt);
            Console.WriteLine($"{txt} Is a Valid Age.");
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine($"\n {txt} Is a Invalid Age!!..{ex.Message}");
        }
    }
      int ParseAge(string text)
      {
        if (!int.TryParse(text, out var age))
        {
        throw new InvalidAgeException($"Age must be a number");
        }
        if (age < MinAge || age > MaxAge)
        {
        throw new InvalidAgeException($"Age must be between {MinAge} and {MaxAge}");
        }
        return age;
      }
class InvalidAgeException : Exception
{
    public InvalidAgeException(String message) : base(message) { }
}
