using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gogobot
{
  static class Program
  {
    public static string ProgramDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Gogobot");
    public static string SettingsPath = Path.Combine(Program.ProgramDataFolder, "Settings.gbs");

    [STAThread]
    static void Main()
    {
      try
      {
        InitializePrerequisites();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new frmMain());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private static void InitializePrerequisites()
    {
      if (!Directory.Exists(ProgramDataFolder)) Directory.CreateDirectory(ProgramDataFolder);
    }
  }
}
