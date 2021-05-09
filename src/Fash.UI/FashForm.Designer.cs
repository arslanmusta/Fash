
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
            this.CompareGroupBox = new System.Windows.Forms.GroupBox();
            this.CompareResultLabel = new System.Windows.Forms.Label();
            this.CompareButton = new System.Windows.Forms.Button();
            this.CompareTextBox = new System.Windows.Forms.TextBox();
            this.HashPanelGroupBox.SuspendLayout();
            this.CompareGroupBox.SuspendLayout();
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
            this.HashResultTextBox.ReadOnly = true;
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
            this.HashComboBox.SelectedIndexChanged += new System.EventHandler(this.HashComboBox_SelectedIndexChanged);
            // 
            // CompareGroupBox
            // 
            this.CompareGroupBox.Controls.Add(this.CompareResultLabel);
            this.CompareGroupBox.Controls.Add(this.CompareButton);
            this.CompareGroupBox.Controls.Add(this.CompareTextBox);
            this.CompareGroupBox.Location = new System.Drawing.Point(31, 142);
            this.CompareGroupBox.Name = "CompareGroupBox";
            this.CompareGroupBox.Size = new System.Drawing.Size(746, 148);
            this.CompareGroupBox.TabIndex = 2;
            this.CompareGroupBox.TabStop = false;
            this.CompareGroupBox.Text = "Compare";
            // 
            // CompareResultLabel
            // 
            this.CompareResultLabel.AutoSize = true;
            this.CompareResultLabel.Location = new System.Drawing.Point(117, 96);
            this.CompareResultLabel.Name = "CompareResultLabel";
            this.CompareResultLabel.Size = new System.Drawing.Size(36, 15);
            this.CompareResultLabel.TabIndex = 2;
            this.CompareResultLabel.Text = "result";
            this.CompareResultLabel.Visible = false;
            // 
            // CompareButton
            // 
            this.CompareButton.Location = new System.Drawing.Point(19, 92);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(75, 23);
            this.CompareButton.TabIndex = 1;
            this.CompareButton.Text = "Compare";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // CompareTextBox
            // 
            this.CompareTextBox.Location = new System.Drawing.Point(19, 48);
            this.CompareTextBox.Name = "CompareTextBox";
            this.CompareTextBox.Size = new System.Drawing.Size(709, 23);
            this.CompareTextBox.TabIndex = 0;
            // 
            // FashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.CompareGroupBox);
            this.Controls.Add(this.HashPanelGroupBox);
            this.Name = "FashForm";
            this.Text = "Fash";
            this.HashPanelGroupBox.ResumeLayout(false);
            this.HashPanelGroupBox.PerformLayout();
            this.CompareGroupBox.ResumeLayout(false);
            this.CompareGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HashPanelGroupBox;
        private System.Windows.Forms.TextBox HashResultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HashComboBox;
        private System.Windows.Forms.GroupBox CompareGroupBox;
        private System.Windows.Forms.Button CompareButton;
        private System.Windows.Forms.TextBox CompareTextBox;
        private System.Windows.Forms.Label CompareLabel;
        private System.Windows.Forms.Label CompareResultLabel;
    }
}

