using Gogolib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gogobot
{
  public partial class frmSettings : Form
  {
    Settings _settings = null;

    public frmSettings(Settings settings)
    {
      InitializeComponent();
      _settings = settings;
    }

    private void frmSettings_Load(object sender, EventArgs e)
    {
      try
      {
        txtApiKey.Text = _settings.ApiKey;
        txtSecretKey.Text = _settings.SecretKey;
        chkUseProduction.Checked = _settings.UseProduction;
        chkMinimizeOnStartup.Checked = _settings.MinimizeOnStartup;
      }
      catch (Exception ex)
      {
        btnSave.Enabled = false;
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        _settings.ApiKey = txtApiKey.Text;
        _settings.SecretKey = txtSecretKey.Text;
        _settings.UseProduction = chkUseProduction.Checked;
        _settings.MinimizeOnStartup = chkMinimizeOnStartup.Checked;
        _settings.Save(Program.SettingsPath);

        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }
  }
}
