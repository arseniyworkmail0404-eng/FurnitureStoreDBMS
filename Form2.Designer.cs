namespace FurnitureStoreDBMS
{
    partial class DropDownDialogForm
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
            okButton = new Button();
            listBox = new ListBox();
            label = new Label();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(53, 152);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(8, 52);
            listBox.Name = "listBox";
            listBox.Size = new Size(158, 94);
            listBox.TabIndex = 1;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // label
            // 
            label.Location = new Point(8, 9);
            label.Name = "label";
            label.Size = new Size(158, 40);
            label.TabIndex = 2;
            label.Text = "Enter value";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DropDownDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(178, 184);
            Controls.Add(label);
            Controls.Add(listBox);
            Controls.Add(okButton);
            Name = "DropDownDialogForm";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button okButton;
        private ListBox listBox;
        private Label label;
    }
}