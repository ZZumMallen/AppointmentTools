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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txt_apiKey = new System.Windows.Forms.TextBox();
            this.lbl_apiKey = new System.Windows.Forms.Label();
            this.lbl_policyThreshold = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.num_UpDown = new System.Windows.Forms.NumericUpDown();
            this.btn_unlockPolicyThreshold = new System.Windows.Forms.Button();
            this.btn_unlockApiKey = new System.Windows.Forms.Button();
            this.btn_showApiKey = new System.Windows.Forms.Button();
            this.btn_saveSettings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_apiKey
            // 
            this.txt_apiKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_apiKey.Location = new System.Drawing.Point(180, 5);
            this.txt_apiKey.Name = "txt_apiKey";
            this.txt_apiKey.ReadOnly = true;
            this.txt_apiKey.Size = new System.Drawing.Size(342, 23);
            this.txt_apiKey.TabIndex = 0;
            this.txt_apiKey.Text = "AIzaSyAW_DRZU9uXOZud2w3LUsFBC0F9s_cvqgA";
            this.txt_apiKey.UseSystemPasswordChar = true;
            // 
            // lbl_apiKey
            // 
            this.lbl_apiKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_apiKey.AutoSize = true;
            this.lbl_apiKey.Location = new System.Drawing.Point(3, 8);
            this.lbl_apiKey.Name = "lbl_apiKey";
            this.lbl_apiKey.Size = new System.Drawing.Size(57, 17);
            this.lbl_apiKey.TabIndex = 2;
            this.lbl_apiKey.Text = "API Key";
            // 
            // lbl_policyThreshold
            // 
            this.lbl_policyThreshold.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_policyThreshold.AutoSize = true;
            this.lbl_policyThreshold.Location = new System.Drawing.Point(3, 41);
            this.lbl_policyThreshold.Name = "lbl_policyThreshold";
            this.lbl_policyThreshold.Size = new System.Drawing.Size(135, 17);
            this.lbl_policyThreshold.TabIndex = 3;
            this.lbl_policyThreshold.Text = "Drivetime Threshold";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tableLayoutPanel1.Controls.Add(this.num_UpDown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_apiKey, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_apiKey, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_policyThreshold, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_unlockPolicyThreshold, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_unlockApiKey, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_showApiKey, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_saveSettings, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 134);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // num_UpDown
            // 
            this.num_UpDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.num_UpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_UpDown.Location = new System.Drawing.Point(438, 38);
            this.num_UpDown.Name = "num_UpDown";
            this.num_UpDown.ReadOnly = true;
            this.num_UpDown.Size = new System.Drawing.Size(84, 23);
            this.num_UpDown.TabIndex = 5;
            this.num_UpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_UpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // btn_unlockPolicyThreshold
            // 
            this.btn_unlockPolicyThreshold.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_unlockPolicyThreshold.Location = new System.Drawing.Point(528, 36);
            this.btn_unlockPolicyThreshold.Name = "btn_unlockPolicyThreshold";
            this.btn_unlockPolicyThreshold.Size = new System.Drawing.Size(75, 27);
            this.btn_unlockPolicyThreshold.TabIndex = 7;
            this.btn_unlockPolicyThreshold.Text = "unlock";
            this.btn_unlockPolicyThreshold.UseVisualStyleBackColor = true;
            this.btn_unlockPolicyThreshold.Click += new System.EventHandler(this.OnThresholdUnlockButton);
            // 
            // btn_unlockApiKey
            // 
            this.btn_unlockApiKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_unlockApiKey.Location = new System.Drawing.Point(528, 3);
            this.btn_unlockApiKey.Name = "btn_unlockApiKey";
            this.btn_unlockApiKey.Size = new System.Drawing.Size(75, 27);
            this.btn_unlockApiKey.TabIndex = 6;
            this.btn_unlockApiKey.Text = "unlock";
            this.btn_unlockApiKey.UseVisualStyleBackColor = true;
            this.btn_unlockApiKey.Click += new System.EventHandler(this.OnApiUnlockButton);
            // 
            // btn_showApiKey
            // 
            this.btn_showApiKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_showApiKey.Location = new System.Drawing.Point(610, 3);
            this.btn_showApiKey.Name = "btn_showApiKey";
            this.btn_showApiKey.Size = new System.Drawing.Size(75, 27);
            this.btn_showApiKey.TabIndex = 5;
            this.btn_showApiKey.Text = "show";
            this.btn_showApiKey.UseVisualStyleBackColor = true;
            this.btn_showApiKey.Click += new System.EventHandler(this.OnApiShowButton);
            // 
            // btn_saveSettings
            // 
            this.btn_saveSettings.Location = new System.Drawing.Point(610, 102);
            this.btn_saveSettings.Name = "btn_saveSettings";
            this.btn_saveSettings.Size = new System.Drawing.Size(75, 27);
            this.btn_saveSettings.TabIndex = 5;
            this.btn_saveSettings.Text = "Save";
            this.btn_saveSettings.UseVisualStyleBackColor = true;
            this.btn_saveSettings.Click += new System.EventHandler(this.OnSaveButton);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Undo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnUndoButton);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 160);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_apiKey;
        private System.Windows.Forms.Label lbl_apiKey;
        private System.Windows.Forms.Label lbl_policyThreshold;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_showApiKey;
        private System.Windows.Forms.NumericUpDown num_UpDown;
        private System.Windows.Forms.Button btn_unlockApiKey;
        private System.Windows.Forms.Button btn_unlockPolicyThreshold;
        private System.Windows.Forms.Button btn_saveSettings;
        private System.Windows.Forms.Button button1;
    }
}