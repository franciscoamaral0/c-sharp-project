namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      var texto = "ola testando";
      var texto2 = "ola testando";

      Console.WriteLine(texto.Length);
      Console.WriteLine(texto.Equals(texto2));
      Console.WriteLine(texto.IndexOf("ndo"));
      Console.WriteLine(texto.Replace("ola", "olár"));
    }
  }
}