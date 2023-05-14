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
    public partial class Form1 : Form
    {
        BigIntArray bigIntArray;
        private void strCalcBtn_Click(object sender, EventArgs e)
        {
            CharacterStringCalculator characterStringCalculator = new CharacterStringCalculator();
            characterStringCalculator.ShowDialog();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void IntCalBtn_Click(object sender, EventArgs e)
        {
            BigIntCalulator bigIntCalulator = new BigIntCalulator();
            bigIntCalulator.ShowDialog();
        }

        private void AddValBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(AddValueTxt.Text))
            {
                MessageBox.Show("FILL THE VALUE FIELD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                   bigIntArray.AddValue(AddValueTxt.Text);
                    AddValueTxt.Clear(); 
                }
                catch (MyException ex)
                {
                    MessageBox.Show(ex.ShowException(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                BigIntListView.Items.Clear();
                foreach(BigIntValues bgInt in bigIntArray.GetValue())
                {
                    BigIntListView.Items.Add(new ListViewItem(bgInt.ToString()));
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bigIntArray = new BigIntArray();
        }

        private void SumAllValBtn_Click(object sender, EventArgs e)
        {
            BigIntValues result = new BigIntValues("0");
            foreach (BigIntValues bgInt in bigIntArray.GetValue())
                result = result + bgInt;
            sumAllObjResult.Text = result.ToString();
        }
    }
}
