namespace AppointmentTools.Views {
    partial class InputForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.Origin_TextBox = new System.Windows.Forms.TextBox();
            this.Destination_TextBox = new System.Windows.Forms.TextBox();
            this.Origin_Label = new System.Windows.Forms.Label();
            this.Destination_Label = new System.Windows.Forms.Label();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.Results_List = new System.Windows.Forms.ListBox();
            this.BTN_Paste = new System.Windows.Forms.Button();
            this.ttpPaste = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Origin_TextBox
            // 
            this.Origin_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.Origin_TextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Origin_TextBox.Location = new System.Drawing.Point(12, 35);
            this.Origin_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Origin_TextBox.MaxLength = 500;
            this.Origin_TextBox.Name = "Origin_TextBox";
            this.Origin_TextBox.ReadOnly = true;
            this.Origin_TextBox.Size = new System.Drawing.Size(325, 23);
            this.Origin_TextBox.TabIndex = 5;
            this.Origin_TextBox.TabStop = false;
            this.Origin_TextBox.Text = "123 Main St, Anytown, USA";
            // 
            // Destination_TextBox
            // 
            this.Destination_TextBox.AcceptsReturn = true;
            this.Destination_TextBox.AcceptsTab = true;
            this.Destination_TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Destination_TextBox.Location = new System.Drawing.Point(12, 90);
            this.Destination_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Destination_TextBox.Name = "Destination_TextBox";
            this.Destination_TextBox.Size = new System.Drawing.Size(325, 23);
            this.Destination_TextBox.TabIndex = 0;
            this.Destination_TextBox.WordWrap = false;
            this.Destination_TextBox.TextChanged += new System.EventHandler(this.OnDestinationText_TextChanged);
            this.Destination_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnDestinationText_KeyDown);
            // 
            // Origin_Label
            // 
            this.Origin_Label.AutoSize = true;
            this.Origin_Label.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Origin_Label.Location = new System.Drawing.Point(12, 15);
            this.Origin_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Origin_Label.Name = "Origin_Label";
            this.Origin_Label.Size = new System.Drawing.Size(99, 16);
            this.Origin_Label.TabIndex = 4;
            this.Origin_Label.Text = "Selected Address:";
            // 
            // Destination_Label
            // 
            this.Destination_Label.AutoSize = true;
            this.Destination_Label.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Destination_Label.Location = new System.Drawing.Point(12, 70);
            this.Destination_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Destination_Label.Name = "Destination_Label";
            this.Destination_Label.Size = new System.Drawing.Size(114, 16);
            this.Destination_Label.TabIndex = 6;
            this.Destination_Label.Text = "Destination Address:";
            // 
            // BTN_Search
            // 
            this.BTN_Search.Location = new System.Drawing.Point(210, 160);
            this.BTN_Search.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(75, 23);
            this.BTN_Search.TabIndex = 2;
            this.BTN_Search.Text = "Search";
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.OnSearchButton_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(289, 160);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 3;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.OnCancelButton_Click);
            // 
            // Results_List
            // 
            this.Results_List.FormattingEnabled = true;
            this.Results_List.HorizontalScrollbar = true;
            this.Results_List.ItemHeight = 16;
            this.Results_List.Location = new System.Drawing.Point(13, 117);
            this.Results_List.Margin = new System.Windows.Forms.Padding(2);
            this.Results_List.Name = "Results_List";
            this.Results_List.Size = new System.Drawing.Size(324, 68);
            this.Results_List.TabIndex = 1;
            this.Results_List.Visible = false;
            this.Results_List.Click += new System.EventHandler(this.OnResults_Click);
            this.Results_List.SelectedIndexChanged += new System.EventHandler(this.Results_List_SelectedIndexChanged);
            this.Results_List.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnResults_KeyDown);
            // 
            // BTN_Paste
            // 
            this.BTN_Paste.BackgroundImage = global::AppointmentTools.Properties.Resources.paste;
            this.BTN_Paste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Paste.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.BTN_Paste.FlatAppearance.BorderSize = 0;
            this.BTN_Paste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BTN_Paste.Location = new System.Drawing.Point(341, 91);
            this.BTN_Paste.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Paste.Name = "BTN_Paste";
            this.BTN_Paste.Size = new System.Drawing.Size(23, 22);
            this.BTN_Paste.TabIndex = 7;
            this.BTN_Paste.TabStop = false;
            this.ttpPaste.SetToolTip(this.BTN_Paste, "Click here to paste from your clipboard instead of Ctrl+V or Right-Click > Paste");
            this.BTN_Paste.UseVisualStyleBackColor = true;
            this.BTN_Paste.Click += new System.EventHandler(this.OnPasteButton_Click);
            // 
            // ttpPaste
            // 
            this.ttpPaste.IsBalloon = true;
            this.ttpPaste.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpPaste.ToolTipTitle = "Paste from Clipboard";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 194);
            this.Controls.Add(this.Results_List);
            this.Controls.Add(this.BTN_Paste);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Search);
            this.Controls.Add(this.Destination_TextBox);
            this.Controls.Add(this.Origin_TextBox);
            this.Controls.Add(this.Origin_Label);
            this.Controls.Add(this.Destination_Label);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Drive Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Origin_TextBox;
        private System.Windows.Forms.Label Origin_Label;
        public System.Windows.Forms.TextBox Destination_TextBox;
        private System.Windows.Forms.ListBox Results_List;
        private System.Windows.Forms.Label Destination_Label;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Paste;
        private System.Windows.Forms.ToolTip ttpPaste;
    }
}