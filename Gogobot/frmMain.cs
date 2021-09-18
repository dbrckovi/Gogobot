using Gogolib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gogobot
{
  public partial class frmMain : Form
  {
    Cryptobot _bot = null;
    private bool _exitting = false;

    public frmMain()
    {
      InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      try
      {
        this.Icon = Properties.Resources.Gogobot;
        trayIcon.Icon = this.Icon;
        trayIcon.Text = this.Text;
        trayIcon.Visible = true;
        _bot = new Cryptobot(Program.SettingsPath);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error");
        Application.Exit();
      }
    }

    private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        frmSettings settingsForm = new frmSettings(_bot.Settings);
        DialogResult result = settingsForm.ShowDialog(this);
        if (result == DialogResult.OK) _bot.Restart();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Really exit Gogobot?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
      {
        _exitting = true;
        this.Close();
      }
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (!_exitting)
      {
        this.Hide();
        e.Cancel = true;
      }
    }

    private void trayIcon_DoubleClick(object sender, EventArgs e)
    {
      this.Show();
    }

    private void frmMain_Shown(object sender, EventArgs e)
    {
      if (_bot.Settings.MinimizeOnStartup) this.Close();
    }
  }
}
