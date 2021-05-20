namespace Kit
{
    partial class Dish_TypeForm
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
            this.tbAddDishType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDishType = new System.Windows.Forms.ListBox();
            this.BtnOpenCuisines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(139, 79);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 23);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "Remove";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbAddDishType
            // 
            this.tbAddDishType.Location = new System.Drawing.Point(139, 24);
            this.tbAddDishType.Name = "tbAddDishType";
            this.tbAddDishType.Size = new System.Drawing.Size(100, 20);
            this.tbAddDishType.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Type:";
            // 
            // lbDishType
            // 
            this.lbDishType.FormattingEnabled = true;
            this.lbDishType.Location = new System.Drawing.Point(12, 24);
            this.lbDishType.Name = "lbDishType";
            this.lbDishType.Size = new System.Drawing.Size(120, 108);
            this.lbDishType.TabIndex = 18;
            // 
            // BtnOpenCuisines
            // 
            this.BtnOpenCuisines.Location = new System.Drawing.Point(139, 108);
            this.BtnOpenCuisines.Name = "BtnOpenCuisines";
            this.BtnOpenCuisines.Size = new System.Drawing.Size(100, 23);
            this.BtnOpenCuisines.TabIndex = 24;
            this.BtnOpenCuisines.Text = "Open Cuisines";
            this.BtnOpenCuisines.UseVisualStyleBackColor = true;
            this.BtnOpenCuisines.Click += new System.EventHandler(this.BtnOpenCuisines_Click);
            // 
            // Dish_TypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 135);
            this.Controls.Add(this.BtnOpenCuisines);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAddDishType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDishType);
            this.Name = "Dish_TypeForm";
            this.Text = "Dish_Type";
            this.Load += new System.EventHandler(this.Dish_TypeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbAddDishType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDishType;
        private System.Windows.Forms.Button BtnOpenCuisines;
    }
}