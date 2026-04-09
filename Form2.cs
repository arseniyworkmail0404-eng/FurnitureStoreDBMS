using FurnitureStoreDBMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureStoreDBMS
{
    public partial class DropDownDialogForm : Form
    {
        string[] items;
        public DropDownDialogForm(string[] items)
        {
            InitializeComponent();
            this.items = items;
            listBox.Items.AddRange(items);
        }
        public int Result { get; private set; }
        public void SetLabel(string text)
        {
            label.Text = text;
        }
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != null)
            {
                Result = listBox.SelectedIndex;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

public static class DropDownDialogService
{
    public static int InputBox(string prompt, string title, string[] items)
    {
        DropDownDialogForm dialogForm = new DropDownDialogForm(items);
        dialogForm.Name = title;
        dialogForm.SetLabel(prompt);

        DialogResult result = dialogForm.ShowDialog();

        // Код здесь выполнится ТОЛЬКО после закрытия dialogForm
        if (result == DialogResult.OK)
        {
            return dialogForm.Result;
        }
        throw new Exception();
    }

}
