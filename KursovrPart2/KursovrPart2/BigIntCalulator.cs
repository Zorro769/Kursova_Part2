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
    public partial class BigIntCalulator : Form
    {
        BigIntValues left, right, result;
        public BigIntCalulator()
        {
            InitializeComponent();
        }
        private void AddIntBtn_Click(object sender, EventArgs e)
        {
            SetCharacterStrings();
            result = left + right;
            txtResultString.Text = result.ToString();
            TxtBoxClearing();
        }
        private void SubstractIntBtn_Click(object sender, EventArgs e)
        {
            SetCharacterStrings();
            result = left - right;
            txtResultString.Text = result.ToString();
            TxtBoxClearing();
        }

        private void MultiplyInBtn_Click(object sender, EventArgs e)
        {
            SetCharacterStrings();
            result = left * right;
            txtResultString.Text = result.ToString();
            TxtBoxClearing();
        }

        private void DivideIntBtn_Click(object sender, EventArgs e)
        {
            SetCharacterStrings();
            try
            {
                result = left / right;
                txtResultString.Text = result.ToString();
            }
            catch(MyException ex)
            {
                MessageBox.Show(ex.ShowException(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxtBoxClearing();
        }
        private void GreaterThanBtn_Click(object sender, EventArgs e)
        {
            SetCharacterStrings();
            if (left > right)
                txtResultString.Text = "The first value is bigger than the second value";
            else
                txtResultString.Text = "The first value is not bigger than the second value";
            TxtBoxClearing();
        }
        private void LessThanBtn_Click(object sender, EventArgs e)
        {
            SetCharacterStrings();
            if (left < right)
                txtResultString.Text = "The first value is less than the second value";
            else
                txtResultString.Text = "The first value is not less than the second value";
            TxtBoxClearing();
        }

        private void GreaterOrEqualBtn_Click(object sender, EventArgs e)
        {
            SetCharacterStrings();
            if (left >= right)
                txtResultString.Text = "The first value is bigger than the second value or equal";
            else
                txtResultString.Text = "The first value is not bigger than the second value or equal";
            TxtBoxClearing();
        }
        private void LessOrEqualBtn_Click(object sender, EventArgs e)
        {
            SetCharacterStrings();
            if (left <= right)
                txtResultString.Text = "The first value is less than the second value or equal";
            else
                txtResultString.Text = "The first value is not less than the second value or equal";
            TxtBoxClearing();
        }
        private void EqualBtn_Click(object sender, EventArgs e)
        {
            SetCharacterStrings();
            if (left == right)
                txtResultString.Text = "The first value is equal the second value";
            else
                txtResultString.Text = "The first value is not equal the second value";
            TxtBoxClearing();
        }

        private void NotEqualBtn_Click(object sender, EventArgs e)
        {
            SetCharacterStrings();
            if (left != right)
                txtResultString.Text = "The first value is not equal the second value";
            else
                txtResultString.Text = "The first value is equal the second value";
            TxtBoxClearing();
        }

        private void TxtBoxClearing()
        {
            txtLeftString.Text = string.Empty;
            txtRightString.Text = string.Empty;
        }
        private void SetCharacterStrings()
        {
            bool flag = false;
            if((String.IsNullOrEmpty(txtLeftString.Text)) || (String.IsNullOrEmpty(txtRightString.Text)))
                MessageBox.Show("FILL THE VALUE FIELD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            while (!flag)
            {
                try
                {
                    left = new BigIntValues(txtLeftString.Text);
                    right = new BigIntValues(txtRightString.Text);
                    flag = true;
                }
                catch (MyException ex)
                {
                    MessageBox.Show(ex.ShowException(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtBoxClearing();
                }
            }
        }
    }
}
