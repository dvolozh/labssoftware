namespace Kit
{
    partial class DishForm
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
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbAddDish = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDish = new System.Windows.Forms.ListBox();
            this.BtnOpenProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(140, 81);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(99, 23);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Remove";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbAddDish
            // 
            this.tbAddDish.Location = new System.Drawing.Point(139, 26);
            this.tbAddDish.Name = "tbAddDish";
            this.tbAddDish.Size = new System.Drawing.Size(100, 20);
            this.tbAddDish.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dish:";
            // 
            // lbDish
            // 
            this.lbDish.FormattingEnabled = true;
            this.lbDish.Location = new System.Drawing.Point(12, 26);
            this.lbDish.Name = "lbDish";
            this.lbDish.Size = new System.Drawing.Size(120, 108);
            this.lbDish.TabIndex = 6;
            this.lbDish.SelectedIndexChanged += new System.EventHandler(this.lbDish_SelectedIndexChanged);
            // 
            // BtnOpenProducts
            // 
            this.BtnOpenProducts.Location = new System.Drawing.Point(140, 110);
            this.BtnOpenProducts.Name = "BtnOpenProducts";
            this.BtnOpenProducts.Size = new System.Drawing.Size(99, 23);
            this.BtnOpenProducts.TabIndex = 12;
            this.BtnOpenProducts.Text = "Open products";
            this.BtnOpenProducts.UseVisualStyleBackColor = true;
            this.BtnOpenProducts.Click += new System.EventHandler(this.BtnOpenProducts_Click);
            // 
            // DishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 141);
            this.Controls.Add(this.BtnOpenProducts);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAddDish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDish);
            this.Name = "DishForm";
            this.Text = "Dish";
            this.Load += new System.EventHandler(this.DishForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbAddDish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDish;
        private System.Windows.Forms.Button BtnOpenProducts;
    }
}