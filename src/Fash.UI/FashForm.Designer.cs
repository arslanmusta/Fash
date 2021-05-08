
namespace Fash.UI
{
    partial class FashForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HashPanelGroupBox = new System.Windows.Forms.GroupBox();
            this.HashResultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HashComboBox = new System.Windows.Forms.ComboBox();
            this.HashPanelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HashPanelGroupBox
            // 
            this.HashPanelGroupBox.Controls.Add(this.HashResultTextBox);
            this.HashPanelGroupBox.Controls.Add(this.label1);
            this.HashPanelGroupBox.Controls.Add(this.HashComboBox);
            this.HashPanelGroupBox.Location = new System.Drawing.Point(31, 22);
            this.HashPanelGroupBox.Name = "HashPanelGroupBox";
            this.HashPanelGroupBox.Size = new System.Drawing.Size(746, 100);
            this.HashPanelGroupBox.TabIndex = 1;
            this.HashPanelGroupBox.TabStop = false;
            this.HashPanelGroupBox.Text = "Hash";
            // 
            // HashResultTextBox
            // 
            this.HashResultTextBox.Location = new System.Drawing.Point(19, 59);
            this.HashResultTextBox.Name = "HashResultTextBox";
            this.HashResultTextBox.Size = new System.Drawing.Size(709, 23);
            this.HashResultTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hash Algorithm";
            // 
            // HashComboBox
            // 
            this.HashComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HashComboBox.FormattingEnabled = true;
            this.HashComboBox.Location = new System.Drawing.Point(135, 18);
            this.HashComboBox.Name = "HashComboBox";
            this.HashComboBox.Size = new System.Drawing.Size(121, 23);
            this.HashComboBox.TabIndex = 3;
            this.HashComboBox.SelectedIndexChanged += new System.EventHandler(this.HashComboBox_SelectedIndexChanged_1);
            // 
            // FashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HashPanelGroupBox);
            this.Name = "FashForm";
            this.Text = "Fash";
            this.HashPanelGroupBox.ResumeLayout(false);
            this.HashPanelGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HashPanelGroupBox;
        private System.Windows.Forms.TextBox HashResultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HashComboBox;
    }
}

