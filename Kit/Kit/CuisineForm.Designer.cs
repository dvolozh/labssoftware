namespace Kit
{
    partial class CuisineForm
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
            this.tbAddCuisine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCuisine = new System.Windows.Forms.ListBox();
            this.BtnOpenDishes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(140, 79);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(99, 23);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Remove";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tbAddCuisine
            // 
            this.tbAddCuisine.Location = new System.Drawing.Point(139, 24);
            this.tbAddCuisine.Name = "tbAddCuisine";
            this.tbAddCuisine.Size = new System.Drawing.Size(100, 20);
            this.tbAddCuisine.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cuisine:";
            // 
            // lbCuisine
            // 
            this.lbCuisine.FormattingEnabled = true;
            this.lbCuisine.Location = new System.Drawing.Point(12, 24);
            this.lbCuisine.Name = "lbCuisine";
            this.lbCuisine.Size = new System.Drawing.Size(120, 108);
            this.lbCuisine.TabIndex = 12;
            // 
            // BtnOpenDishes
            // 
            this.BtnOpenDishes.Location = new System.Drawing.Point(140, 108);
            this.BtnOpenDishes.Name = "BtnOpenDishes";
            this.BtnOpenDishes.Size = new System.Drawing.Size(99, 23);
            this.BtnOpenDishes.TabIndex = 18;
            this.BtnOpenDishes.Text = "Open Dishes";
            this.BtnOpenDishes.UseVisualStyleBackColor = true;
            this.BtnOpenDishes.Click += new System.EventHandler(this.BtnOpenDishes_Click);
            // 
            // CuisineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 135);
            this.Controls.Add(this.BtnOpenDishes);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAddCuisine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCuisine);
            this.Name = "CuisineForm";
            this.Text = "Cuisine";
            this.Load += new System.EventHandler(this.CuisineForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbAddCuisine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCuisine;
        private System.Windows.Forms.Button BtnOpenDishes;
    }
}