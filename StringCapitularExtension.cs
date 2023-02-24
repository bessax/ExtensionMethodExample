public static class StringCapitularExtension
{
  
  public static string Capitular(this string s)
  {
    if (string.IsNullOrEmpty(s))
    {
        throw new ArgumentException("String está vazia ou nula");
    }
    var _primeiraLetra=s[0].ToString().ToUpper();
    
    return _primeiraLetra+s.Substring(1);
  }
    
}