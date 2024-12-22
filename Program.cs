// This program is able to read what is in a configuration file

using System.Diagnostics;

namespace Hello
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "DefaultName1";
      if(!CheckConfigExists())
      {
        name = "DefaultName2";
      }
      name = SourceConfig();
      Console.WriteLine($"Hello {name}");
    }

    static bool CheckConfigExists()
    {
      string home_path = Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
      if(File.Exists($"{home_path}/.config/hello/config.txt"))
      {
        return true;
      }
      return false;
    }

    static string SourceConfig()
    {
      string home_path = Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
      string[] content = File.ReadAllLines($"{home_path}/.config/hello/config.txt");
      string name = content[0];
      return name;
    }
  }
}
