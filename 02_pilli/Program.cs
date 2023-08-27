using System;

namespace _02_pilli
{
  class Program
  {
    /// <summary>
    /// prints the sound of the whistle.
    /// </summary>
    /// <param sorsapilli="Kvaak"></param>
    /// <param kukkopilli="Peef"></param>
    static void Main(string[] args)
    {
      Pilli sorsapilli = new Pilli("Kvaak");
      Pilli kukkopilli = new Pilli("Peef");
      sorsapilli.Soi();
      kukkopilli.Soi();
      sorsapilli.Soi();
      

    }
  }
}
