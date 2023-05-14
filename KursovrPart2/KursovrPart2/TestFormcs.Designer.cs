namespace KursovrPart2
{
    partial class TestFormcs
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
            this.btnCalculateStrings = new System.Windows.Forms.Button();
            this.txtResultIntValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRightIntValue = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtLeftIntValue = new System.Windows.Forms.TextBox();
            this.txtResultString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRightString = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtLeftString = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.String = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculateStrings
            // 
            this.btnCalculateStrings.Location = new System.Drawing.Point(461, 158);
            this.btnCalculateStrings.Name = "btnCalculateStrings";
            this.btnCalculateStrings.Size = new System.Drawing.Size(109, 23);
            this.btnCalculateStrings.TabIndex = 23;
            this.btnCalculateStrings.Text = "Calculate";
            this.btnCalculateStrings.UseVisualStyleBackColor = true;
            // 
            // txtResultIntValue
            // 
            this.txtResultIntValue.Location = new System.Drawing.Point(44, 412);
            this.txtResultIntValue.Name = "txtResultIntValue";
            this.txtResultIntValue.Size = new System.Drawing.Size(577, 22);
            this.txtResultIntValue.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            // 
            // txtRightIntValue
            // 
            this.txtRightIntValue.Location = new System.Drawing.Point(44, 347);
            this.txtRightIntValue.Name = "txtRightIntValue";
            this.txtRightIntValue.Size = new System.Drawing.Size(577, 22);
            this.txtRightIntValue.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(314, 303);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(48, 24);
            this.comboBox2.TabIndex = 19;
            // 
            // txtLeftIntValue
            // 
            this.txtLeftIntValue.Location = new System.Drawing.Point(44, 263);
            this.txtLeftIntValue.Name = "txtLeftIntValue";
            this.txtLeftIntValue.Size = new System.Drawing.Size(577, 22);
            this.txtLeftIntValue.TabIndex = 18;
            // 
            // txtResultString
            // 
            this.txtResultString.Location = new System.Drawing.Point(44, 192);
            this.txtResultString.Name = "txtResultString";
            this.txtResultString.Size = new System.Drawing.Size(577, 22);
            this.txtResultString.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "=";
            // 
            // txtRightString
            // 
            this.txtRightString.Location = new System.Drawing.Point(44, 127);
            this.txtRightString.Name = "txtRightString";
            this.txtRightString.Size = new System.Drawing.Size(577, 22);
            this.txtRightString.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*"});
            this.comboBox1.Location = new System.Drawing.Point(314, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(48, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // txtLeftString
            // 
            this.txtLeftString.Location = new System.Drawing.Point(44, 43);
            this.txtLeftString.Name = "txtLeftString";
            this.txtLeftString.Size = new System.Drawing.Size(577, 22);
            this.txtLeftString.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.String,
            this.Length});
            this.dataGridView1.Location = new System.Drawing.Point(650, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(359, 401);
            this.dataGridView1.TabIndex = 12;
            // 
            // String
            // 
            this.String.FillWeight = 125.1337F;
            this.String.HeaderText = "String";
            this.String.MinimumWidth = 6;
            this.String.Name = "String";
            // 
            // Length
            // 
            this.Length.FillWeight = 74.86631F;
            this.Length.HeaderText = "Length";
            this.Length.MinimumWidth = 6;
            this.Length.Name = "Length";
            // 
            // TestFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 449);
            this.Controls.Add(this.btnCalculateStrings);
            this.Controls.Add(this.txtResultIntValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRightIntValue);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtLeftIntValue);
            this.Controls.Add(this.txtResultString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRightString);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtLeftString);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TestFormcs";
            this.Text = "TestFormcs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateStrings;
        private System.Windows.Forms.TextBox txtResultIntValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRightIntValue;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtLeftIntValue;
        private System.Windows.Forms.TextBox txtResultString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRightString;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtLeftString;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn String;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
    }
}