
namespace Gogobot
{
  partial class frmSettings
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtApiKey = new System.Windows.Forms.TextBox();
      this.txtSecretKey = new System.Windows.Forms.TextBox();
      this.chkUseProduction = new System.Windows.Forms.CheckBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.chkMinimizeOnStartup = new System.Windows.Forms.CheckBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.chkUseProduction);
      this.groupBox1.Controls.Add(this.txtSecretKey);
      this.groupBox1.Controls.Add(this.txtApiKey);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(16, 16);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(576, 152);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Crypto.com connection";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "API key";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 72);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(84, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Secret key";
      // 
      // txtApiKey
      // 
      this.txtApiKey.Location = new System.Drawing.Point(120, 40);
      this.txtApiKey.Name = "txtApiKey";
      this.txtApiKey.Size = new System.Drawing.Size(440, 26);
      this.txtApiKey.TabIndex = 2;
      // 
      // txtSecretKey
      // 
      this.txtSecretKey.Location = new System.Drawing.Point(120, 72);
      this.txtSecretKey.Name = "txtSecretKey";
      this.txtSecretKey.Size = new System.Drawing.Size(440, 26);
      this.txtSecretKey.TabIndex = 3;
      // 
      // chkUseProduction
      // 
      this.chkUseProduction.AutoSize = true;
      this.chkUseProduction.Location = new System.Drawing.Point(120, 112);
      this.chkUseProduction.Name = "chkUseProduction";
      this.chkUseProduction.Size = new System.Drawing.Size(173, 24);
      this.chkUseProduction.TabIndex = 4;
      this.chkUseProduction.Text = "Use production API";
      this.chkUseProduction.UseVisualStyleBackColor = true;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(232, 264);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(144, 48);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(448, 264);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(144, 48);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.chkMinimizeOnStartup);
      this.groupBox2.Location = new System.Drawing.Point(16, 176);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(576, 72);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Application settings";
      // 
      // chkMinimizeOnStartup
      // 
      this.chkMinimizeOnStartup.AutoSize = true;
      this.chkMinimizeOnStartup.Location = new System.Drawing.Point(120, 32);
      this.chkMinimizeOnStartup.Name = "chkMinimizeOnStartup";
      this.chkMinimizeOnStartup.Size = new System.Drawing.Size(172, 24);
      this.chkMinimizeOnStartup.TabIndex = 5;
      this.chkMinimizeOnStartup.Text = "Minimize on startup";
      this.chkMinimizeOnStartup.UseVisualStyleBackColor = true;
      // 
      // frmSettings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(612, 334);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmSettings";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Settings";
      this.Load += new System.EventHandler(this.frmSettings_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.CheckBox chkUseProduction;
    private System.Windows.Forms.TextBox txtSecretKey;
    private System.Windows.Forms.TextBox txtApiKey;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.CheckBox chkMinimizeOnStartup;
  }
}