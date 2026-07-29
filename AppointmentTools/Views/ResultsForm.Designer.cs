namespace AppointmentTools.Views {
    partial class ResultsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            this.Button_Ok = new System.Windows.Forms.Button();
            this.Label_HeaderFrom = new System.Windows.Forms.Label();
            this.Label_HeaderTo = new System.Windows.Forms.Label();
            this.Label_HeaderTime = new System.Windows.Forms.Label();
            this.Label_PolicyLine = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Ok
            // 
            this.Button_Ok.Location = new System.Drawing.Point(160, 190);
            this.Button_Ok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(75, 23);
            this.Button_Ok.TabIndex = 3;
            this.Button_Ok.Text = "OK";
            this.Button_Ok.UseVisualStyleBackColor = true;
            this.Button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // Label_HeaderFrom
            // 
            this.Label_HeaderFrom.BackColor = System.Drawing.SystemColors.Window;
            this.Label_HeaderFrom.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_HeaderFrom.Location = new System.Drawing.Point(12, 35);
            this.Label_HeaderFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_HeaderFrom.Name = "Label_HeaderFrom";
            this.Label_HeaderFrom.Size = new System.Drawing.Size(372, 23);
            this.Label_HeaderFrom.TabIndex = 5;
            this.Label_HeaderFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_HeaderTo
            // 
            this.Label_HeaderTo.BackColor = System.Drawing.Color.White;
            this.Label_HeaderTo.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_HeaderTo.Location = new System.Drawing.Point(12, 90);
            this.Label_HeaderTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_HeaderTo.Name = "Label_HeaderTo";
            this.Label_HeaderTo.Size = new System.Drawing.Size(372, 23);
            this.Label_HeaderTo.TabIndex = 6;
            this.Label_HeaderTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_HeaderTime
            // 
            this.Label_HeaderTime.BackColor = System.Drawing.Color.Transparent;
            this.Label_HeaderTime.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_HeaderTime.Location = new System.Drawing.Point(12, 125);
            this.Label_HeaderTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_HeaderTime.Name = "Label_HeaderTime";
            this.Label_HeaderTime.Size = new System.Drawing.Size(374, 16);
            this.Label_HeaderTime.TabIndex = 7;
            this.Label_HeaderTime.Text = "Time:";
            this.Label_HeaderTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_PolicyLine
            // 
            this.Label_PolicyLine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Label_PolicyLine.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PolicyLine.Location = new System.Drawing.Point(12, 145);
            this.Label_PolicyLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_PolicyLine.MinimumSize = new System.Drawing.Size(233, 2);
            this.Label_PolicyLine.Name = "Label_PolicyLine";
            this.Label_PolicyLine.Size = new System.Drawing.Size(372, 23);
            this.Label_PolicyLine.TabIndex = 8;
            this.Label_PolicyLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(12, 15);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(99, 16);
            this.lblOrigin.TabIndex = 9;
            this.lblOrigin.Text = "Selected Address:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(12, 70);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(114, 16);
            this.lblDestination.TabIndex = 10;
            this.lblDestination.Text = "Destination Address:";
            // 
            // ResultsForm
            // 
            this.AcceptButton = this.Button_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 237);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.Label_PolicyLine);
            this.Controls.Add(this.Label_HeaderTime);
            this.Controls.Add(this.Label_HeaderTo);
            this.Controls.Add(this.Button_Ok);
            this.Controls.Add(this.Label_HeaderFrom);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Drive Time Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_Ok;
        private System.Windows.Forms.Label Label_HeaderFrom;
        private System.Windows.Forms.Label Label_HeaderTo;
        private System.Windows.Forms.Label Label_HeaderTime;
        private System.Windows.Forms.Label Label_PolicyLine;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblDestination;
    }
}