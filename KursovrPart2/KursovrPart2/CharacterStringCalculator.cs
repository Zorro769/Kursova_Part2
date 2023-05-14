using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovrPart2
{
    public partial class CharacterStringCalculator : Form
    {
        CharacterString left, right, result;

        private void button1_Click(object sender, EventArgs e)
        {
            SetCharacterStrings();
            result = left + right;
            txtResultString.Text = result.PStrStart;
            txtLeftString.Clear();
            txtRightString.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetCharacterStrings();
            try
            {
                result = left - right;
                txtResultString.Text = result.PStrStart;
            }
            catch(MyException ex)
            {
                MessageBox.Show(ex.ShowException(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtLeftString.Clear();
            txtRightString.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetCharacterStrings();
            if (left * right)
                txtResultString.Text = "The second string is substring of the first string";
            else
                txtResultString.Text = "The second string is not substring of the first string";
            txtLeftString.Clear();
            txtRightString.Clear();
        }

        public CharacterStringCalculator()
        {
            InitializeComponent();
            result = new CharacterString("0");
        }
        private void SetCharacterStrings()
        {
            if ((String.IsNullOrEmpty(txtLeftString.Text)) || (String.IsNullOrEmpty(txtRightString.Text)))
                MessageBox.Show("FILL THE VALUE FIELD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            left = new CharacterString(txtLeftString.Text);
            right = new CharacterString(txtRightString.Text);
        }

    }
}
