using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersionApp
{
    public partial class PersionUI : Form
    {
        public PersionUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            Persion persion1 = new Persion();

            persion1.firstName = firstNameTextBox.Text;
            persion1.middleName = middleNameTextBox.Text;
            persion1.lastName = lastNameTextBox.Text;

            string fullName = persion1.GetFullName();

            string reverseName = persion1.GetReverseFullName();

            fullNameTextBox.Text = fullName;
            reverseFullNameTextBox.Text = reverseName;

        }
    }
}
