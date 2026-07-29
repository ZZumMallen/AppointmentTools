using System.Windows.Forms;

namespace AppointmentTools.Views {
    partial class SettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private const int MinThresholdMinutes = 1;
        private const int MaxThresholdMinutes = 180;

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.chkShowKey = new System.Windows.Forms.CheckBox();
            this.numThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkPlaySound = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(12, 35);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(308, 23);
            this.txtApiKey.TabIndex = 0;
            this.txtApiKey.UseSystemPasswordChar = true;
            // 
            // chkShowKey
            // 
            this.chkShowKey.AutoSize = true;
            this.chkShowKey.Location = new System.Drawing.Point(326, 37);
            this.chkShowKey.Name = "chkShowKey";
            this.chkShowKey.Size = new System.Drawing.Size(56, 20);
            this.chkShowKey.TabIndex = 1;
            this.chkShowKey.Text = "Show";
            this.chkShowKey.UseVisualStyleBackColor = true;
            this.chkShowKey.CheckedChanged += new System.EventHandler(this.ChkShowKey_CheckedChanged);
            // 
            // numThreshold
            // 
            this.numThreshold.Location = new System.Drawing.Point(12, 90);
            this.numThreshold.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThreshold.Name = "numThreshold";
            this.numThreshold.Size = new System.Drawing.Size(80, 23);
            this.numThreshold.TabIndex = 2;
            this.numThreshold.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(12, 70);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(152, 16);
            this.lblThreshold.TabIndex = 3;
            this.lblThreshold.Text = "Drive Time Policy Threshold";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(226, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(307, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Location = new System.Drawing.Point(12, 15);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(120, 16);
            this.lblApiKey.TabIndex = 6;
            this.lblApiKey.Text = "Google Maps Api Key";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Firebrick;
            this.lblStatus.Location = new System.Drawing.Point(12, 122);
            this.lblStatus.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 7;
            // 
            // chkPlaySound
            // 
            this.chkPlaySound.AutoSize = true;
            this.chkPlaySound.Checked = true;
            this.chkPlaySound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlaySound.Location = new System.Drawing.Point(12, 145);
            this.chkPlaySound.Name = "chkPlaySound";
            this.chkPlaySound.Size = new System.Drawing.Size(99, 20);
            this.chkPlaySound.TabIndex = 8;
            this.chkPlaySound.Text = "Enable Sound";
            this.chkPlaySound.UseVisualStyleBackColor = true;
            this.chkPlaySound.CheckedChanged += new System.EventHandler(this.ChkPlaySound_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(394, 222);
            this.Controls.Add(this.chkPlaySound);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblApiKey);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblThreshold);
            this.Controls.Add(this.numThreshold);
            this.Controls.Add(this.chkShowKey);
            this.Controls.Add(this.txtApiKey);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CSR Tools Settings";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtApiKey;
        private CheckBox chkShowKey;
        private NumericUpDown numThreshold;
        private Label lblThreshold;
        private Button btnSave;
        private Button btnCancel;
        private Label lblApiKey;
        private Label lblStatus;
        private CheckBox chkPlaySound;
    }
}