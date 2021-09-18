using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gogolib
{
  public class Settings
  {
    private static byte[] _entropy = new byte[] { 33, 34, 123, 212, 5, 78 };

    public string ApiKey { get; set; }
    public string SecretKey { get; set; }
    public bool UseProduction { get; set; }
    public bool MinimizeOnStartup { get; set; }

    public static Settings Load(string path)
    {
      Settings ret = null;

      if (!File.Exists(path))
      {
        ret = new Settings();
        ret.Save(path);
      }
      else
      {
        byte[] dataProtected = File.ReadAllBytes(path);
        byte[] dataPlain = ProtectedData.Unprotect(dataProtected, _entropy, DataProtectionScope.CurrentUser);
        string jsonPlain = UTF8Encoding.UTF8.GetString(dataPlain);
        ret = JsonConvert.DeserializeObject<Settings>(jsonPlain);
      }

      return ret;
    }

    public void Save(string path)
    {
      string jsonPlain = JsonConvert.SerializeObject(this);
      byte[] dataPlain = UTF8Encoding.UTF8.GetBytes(jsonPlain);
      byte[] dataProtected = ProtectedData.Protect(dataPlain, _entropy, DataProtectionScope.CurrentUser);
      File.WriteAllBytes(path, dataProtected);
    }
  }
}
