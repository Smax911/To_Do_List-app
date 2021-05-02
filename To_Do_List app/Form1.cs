using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace To_Do_List_app 
{
    
    public partial class F : Form
    {
        
        public F()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItem.Text)) //  check whether the specified string from the textbox is null or an Empty string
                return;
            lstItems.Items.Add(txtItem.Text);// this method add the items from the text  box to the list box 

           
            txtItem.Clear(); // this will clear the list box after adding the string from the text box to the list box
            txtItem.Focus();

           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstItems.Items.Count > 0)
                lstItems.Items.RemoveAt(lstItems.SelectedIndex);// this methos will remove selected items from the  list
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();// this button closes the form when the user is done
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string sPath = "save.txt"; // constant value 
            StreamWriter SaveFile = new StreamWriter(sPath); //
            SaveFile.WriteLine(lstItems.Items);// write text on the text file 
            SaveFile.ToString();
            SaveFile.Close();
            MessageBox.Show("Programs saved!");// prompt message 
        }
    }
}
