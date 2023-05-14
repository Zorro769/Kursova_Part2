using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KursovrPart2
{
    public partial class TestFormcs : Form
    {
        CharacterString left, right, result;
        public TestFormcs()
        {
            InitializeComponent();
        }
        public bool IsValid()
        {
            if (string.IsNullOrEmpty(txtLeftString.Text))
                MessageBox.Show("Fill the first operand ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrEmpty(txtRightString.Text))
                MessageBox.Show("Fill the second operand ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                return true;
            return false;
        }
        private void btnCalculateStrings_Click(object sender, EventArgs e)
        {
            if (IsValid() == true)
            {
                left = new CharacterString(txtLeftString.Text);
                right = new CharacterString(txtRightString.Text);
                if (comboBox1.SelectedIndex == 0)
                    result = left + right;
                if (comboBox1.SelectedIndex == 1)
                {
                    try
                    {
                        result = left - right;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    txtResultString.Text = (left * right).ToString();
                }
                if (comboBox1.SelectedIndex != 2)
                    txtResultString.Text = result.ToString();
            }

        }
    }
   
}
