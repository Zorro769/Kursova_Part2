namespace KursovrPart2
{
    partial class Form1
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
            this.strCalcBtn = new System.Windows.Forms.Button();
            this.IntCalBtn = new System.Windows.Forms.Button();
            this.AddValBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BigIntListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.AddValueTxt = new System.Windows.Forms.TextBox();
            this.SumAllValBtn = new System.Windows.Forms.Button();
            this.sumAllObjResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // strCalcBtn
            // 
            this.strCalcBtn.Location = new System.Drawing.Point(90, 55);
            this.strCalcBtn.Name = "strCalcBtn";
            this.strCalcBtn.Size = new System.Drawing.Size(142, 46);
            this.strCalcBtn.TabIndex = 1;
            this.strCalcBtn.Text = "Calculate Strings";
            this.strCalcBtn.UseVisualStyleBackColor = true;
            this.strCalcBtn.Click += new System.EventHandler(this.strCalcBtn_Click);
            // 
            // IntCalBtn
            // 
            this.IntCalBtn.Location = new System.Drawing.Point(90, 146);
            this.IntCalBtn.Name = "IntCalBtn";
            this.IntCalBtn.Size = new System.Drawing.Size(142, 46);
            this.IntCalBtn.TabIndex = 2;
            this.IntCalBtn.Text = "Calculate Int Values";
            this.IntCalBtn.UseVisualStyleBackColor = true;
            this.IntCalBtn.Click += new System.EventHandler(this.IntCalBtn_Click);
            // 
            // AddValBtn
            // 
            this.AddValBtn.Location = new System.Drawing.Point(90, 314);
            this.AddValBtn.Name = "AddValBtn";
            this.AddValBtn.Size = new System.Drawing.Size(142, 46);
            this.AddValBtn.TabIndex = 3;
            this.AddValBtn.Text = "Add Int Value";
            this.AddValBtn.UseVisualStyleBackColor = true;
            this.AddValBtn.Click += new System.EventHandler(this.AddValBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humnst777 Blk BT", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Big Int Values Array";
            // 
            // BigIntListView
            // 
            this.BigIntListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.BigIntListView.GridLines = true;
            this.BigIntListView.HideSelection = false;
            this.BigIntListView.Location = new System.Drawing.Point(340, 55);
            this.BigIntListView.Name = "BigIntListView";
            this.BigIntListView.Size = new System.Drawing.Size(212, 383);
            this.BigIntListView.TabIndex = 5;
            this.BigIntListView.UseCompatibleStateImageBehavior = false;
            this.BigIntListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "BigIntValue";
            this.columnHeader1.Width = 155;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "To add Big Int Value to Array,input Value";
            // 
            // AddValueTxt
            // 
            this.AddValueTxt.Location = new System.Drawing.Point(75, 277);
            this.AddValueTxt.Name = "AddValueTxt";
            this.AddValueTxt.Size = new System.Drawing.Size(166, 22);
            this.AddValueTxt.TabIndex = 9;
            // 
            // SumAllValBtn
            // 
            this.SumAllValBtn.Location = new System.Drawing.Point(90, 366);
            this.SumAllValBtn.Name = "SumAllValBtn";
            this.SumAllValBtn.Size = new System.Drawing.Size(142, 46);
            this.SumAllValBtn.TabIndex = 10;
            this.SumAllValBtn.Text = "Sum of all elements";
            this.SumAllValBtn.UseVisualStyleBackColor = true;
            this.SumAllValBtn.Click += new System.EventHandler(this.SumAllValBtn_Click);
            // 
            // sumAllObjResult
            // 
            this.sumAllObjResult.Location = new System.Drawing.Point(75, 418);
            this.sumAllObjResult.Name = "sumAllObjResult";
            this.sumAllObjResult.Size = new System.Drawing.Size(166, 22);
            this.sumAllObjResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.sumAllObjResult);
            this.Controls.Add(this.SumAllValBtn);
            this.Controls.Add(this.AddValueTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BigIntListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddValBtn);
            this.Controls.Add(this.IntCalBtn);
            this.Controls.Add(this.strCalcBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button strCalcBtn;
        private System.Windows.Forms.Button IntCalBtn;
        private System.Windows.Forms.Button AddValBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView BigIntListView;
        internal System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddValueTxt;
        private System.Windows.Forms.Button SumAllValBtn;
        private System.Windows.Forms.TextBox sumAllObjResult;
    }
}

