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
            this.Button_Ok = new System.Windows.Forms.Button();
            this.Label_HeaderFrom = new System.Windows.Forms.Label();
            this.Label_HeaderTo = new System.Windows.Forms.Label();
            this.Label_HeaderTime = new System.Windows.Forms.Label();
            this.Label_PolicyLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Ok
            // 
            this.Button_Ok.Location = new System.Drawing.Point(378, 174);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(75, 44);
            this.Button_Ok.TabIndex = 3;
            this.Button_Ok.Text = "Ok";
            this.Button_Ok.UseVisualStyleBackColor = true;
            this.Button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // Label_HeaderFrom
            // 
            this.Label_HeaderFrom.BackColor = System.Drawing.Color.Transparent;
            this.Label_HeaderFrom.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_HeaderFrom.Location = new System.Drawing.Point(30, 30);
            this.Label_HeaderFrom.Name = "Label_HeaderFrom";
            this.Label_HeaderFrom.Size = new System.Drawing.Size(423, 21);
            this.Label_HeaderFrom.TabIndex = 5;
            this.Label_HeaderFrom.Text = "From:";
            // 
            // Label_HeaderTo
            // 
            this.Label_HeaderTo.BackColor = System.Drawing.Color.Transparent;
            this.Label_HeaderTo.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_HeaderTo.Location = new System.Drawing.Point(30, 64);
            this.Label_HeaderTo.Name = "Label_HeaderTo";
            this.Label_HeaderTo.Size = new System.Drawing.Size(423, 21);
            this.Label_HeaderTo.TabIndex = 6;
            this.Label_HeaderTo.Text = "To:";
            // 
            // Label_HeaderTime
            // 
            this.Label_HeaderTime.BackColor = System.Drawing.Color.Transparent;
            this.Label_HeaderTime.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_HeaderTime.Location = new System.Drawing.Point(30, 97);
            this.Label_HeaderTime.Name = "Label_HeaderTime";
            this.Label_HeaderTime.Size = new System.Drawing.Size(423, 21);
            this.Label_HeaderTime.TabIndex = 7;
            this.Label_HeaderTime.Text = "Time:";
            // 
            // Label_PolicyLine
            // 
            this.Label_PolicyLine.BackColor = System.Drawing.Color.Transparent;
            this.Label_PolicyLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_PolicyLine.Location = new System.Drawing.Point(30, 130);
            this.Label_PolicyLine.MinimumSize = new System.Drawing.Size(300, 0);
            this.Label_PolicyLine.Name = "Label_PolicyLine";
            this.Label_PolicyLine.Size = new System.Drawing.Size(423, 30);
            this.Label_PolicyLine.TabIndex = 8;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 238);
            this.Controls.Add(this.Label_PolicyLine);
            this.Controls.Add(this.Label_HeaderTime);
            this.Controls.Add(this.Label_HeaderTo);
            this.Controls.Add(this.Button_Ok);
            this.Controls.Add(this.Label_HeaderFrom);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultsForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button_Ok;
        private System.Windows.Forms.Label Label_HeaderFrom;
        private System.Windows.Forms.Label Label_HeaderTo;
        private System.Windows.Forms.Label Label_HeaderTime;
        private System.Windows.Forms.Label Label_PolicyLine;
    }
}