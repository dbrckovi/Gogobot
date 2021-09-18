using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gogolib
{
  public class Cryptobot
  {
    private string _settingsPath = null;
    private Settings _settings = null;

    public Settings Settings
    {
      get { return _settings; }
    }

    public Cryptobot(string settingsPath)
    {
      _settingsPath = settingsPath;
      _settings = Settings.Load(_settingsPath);
    }

    public void Restart()
    {

    }
  }
}
