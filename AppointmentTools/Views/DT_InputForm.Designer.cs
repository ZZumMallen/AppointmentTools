namespace AppointmentTools.Views {
    partial class DT_InputForm {
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
            this.Origin_TextBox = new System.Windows.Forms.TextBox();
            this.Destination_TextBox = new System.Windows.Forms.TextBox();
            this.Origin_Label = new System.Windows.Forms.Label();
            this.Destination_Label = new System.Windows.Forms.Label();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Paste = new System.Windows.Forms.Button();
            this.Destination_ResultsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Origin_TextBox
            // 
            this.Origin_TextBox.Location = new System.Drawing.Point(61, 71);
            this.Origin_TextBox.Name = "Origin_TextBox";
            this.Origin_TextBox.Size = new System.Drawing.Size(498, 29);
            this.Origin_TextBox.TabIndex = 0;
            // 
            // Destination_TextBox
            // 
            this.Destination_TextBox.AcceptsTab = true;
            this.Destination_TextBox.Location = new System.Drawing.Point(61, 197);
            this.Destination_TextBox.Name = "Destination_TextBox";
            this.Destination_TextBox.Size = new System.Drawing.Size(498, 29);
            this.Destination_TextBox.TabIndex = 1;
            this.Destination_TextBox.WordWrap = false;
            this.Destination_TextBox.TextChanged += new System.EventHandler(this.OnDestinationTextChange);
            this.Destination_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnDestinationTextKeyDown);
            // 
            // Origin_Label
            // 
            this.Origin_Label.AutoSize = true;
            this.Origin_Label.Location = new System.Drawing.Point(61, 52);
            this.Origin_Label.Name = "Origin_Label";
            this.Origin_Label.Size = new System.Drawing.Size(54, 21);
            this.Origin_Label.TabIndex = 2;
            this.Origin_Label.Text = "Origin";
            // 
            // Destination_Label
            // 
            this.Destination_Label.AutoSize = true;
            this.Destination_Label.Location = new System.Drawing.Point(61, 173);
            this.Destination_Label.Name = "Destination_Label";
            this.Destination_Label.Size = new System.Drawing.Size(89, 21);
            this.Destination_Label.TabIndex = 3;
            this.Destination_Label.Text = "Destination";
            // 
            // BTN_Search
            // 
            this.BTN_Search.Location = new System.Drawing.Point(592, 243);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(75, 29);
            this.BTN_Search.TabIndex = 4;
            this.BTN_Search.Text = "Search";
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.OnSearchButtonClick);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(592, 292);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 29);
            this.BTN_Cancel.TabIndex = 5;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Paste
            // 
            this.BTN_Paste.Location = new System.Drawing.Point(592, 197);
            this.BTN_Paste.Name = "BTN_Paste";
            this.BTN_Paste.Size = new System.Drawing.Size(75, 29);
            this.BTN_Paste.TabIndex = 6;
            this.BTN_Paste.Text = "Paste";
            this.BTN_Paste.UseVisualStyleBackColor = true;
            this.BTN_Paste.Click += new System.EventHandler(this.BTN_Paste_Click);
            // 
            // Destination_ResultsList
            // 
            this.Destination_ResultsList.FormattingEnabled = true;
            this.Destination_ResultsList.ItemHeight = 21;
            this.Destination_ResultsList.Location = new System.Drawing.Point(61, 233);
            this.Destination_ResultsList.Name = "Destination_ResultsList";
            this.Destination_ResultsList.Size = new System.Drawing.Size(498, 88);
            this.Destination_ResultsList.TabIndex = 7;
            this.Destination_ResultsList.Click += new System.EventHandler(this.OnDestinationResultsList_Click);
            this.Destination_ResultsList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnDestinationText_KeyDown);
            // 
            // DT_InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 361);
            this.Controls.Add(this.Destination_ResultsList);
            this.Controls.Add(this.BTN_Paste);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Search);
            this.Controls.Add(this.Destination_Label);
            this.Controls.Add(this.Origin_Label);
            this.Controls.Add(this.Destination_TextBox);
            this.Controls.Add(this.Origin_TextBox);
            this.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DT_InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Drive Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Origin_TextBox;
        private System.Windows.Forms.Label Origin_Label;
        public System.Windows.Forms.TextBox Destination_TextBox;
        private System.Windows.Forms.ListBox Destination_ResultsList;
        private System.Windows.Forms.Label Destination_Label;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Paste;
    }
}