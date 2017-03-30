namespace addform
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxnameSystm = new System.Windows.Forms.TextBox();
            this.textBoxPriceSystm = new System.Windows.Forms.TextBox();
            this.textBoxAmountSystm = new System.Windows.Forms.TextBox();
            this.buttonAddtosystm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock level";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxnameSystm
            // 
            this.textBoxnameSystm.Location = new System.Drawing.Point(160, 35);
            this.textBoxnameSystm.Name = "textBoxnameSystm";
            this.textBoxnameSystm.Size = new System.Drawing.Size(361, 20);
            this.textBoxnameSystm.TabIndex = 3;
            // 
            // textBoxPriceSystm
            // 
            this.textBoxPriceSystm.Location = new System.Drawing.Point(160, 80);
            this.textBoxPriceSystm.Name = "textBoxPriceSystm";
            this.textBoxPriceSystm.Size = new System.Drawing.Size(361, 20);
            this.textBoxPriceSystm.TabIndex = 4;
            // 
            // textBoxAmountSystm
            // 
            this.textBoxAmountSystm.Location = new System.Drawing.Point(160, 125);
            this.textBoxAmountSystm.Name = "textBoxAmountSystm";
            this.textBoxAmountSystm.Size = new System.Drawing.Size(361, 20);
            this.textBoxAmountSystm.TabIndex = 5;
            this.textBoxAmountSystm.TextChanged += new System.EventHandler(this.textBoxAmountSystm_TextChanged);
            // 
            // buttonAddtosystm
            // 
            this.buttonAddtosystm.Location = new System.Drawing.Point(372, 212);
            this.buttonAddtosystm.Name = "buttonAddtosystm";
            this.buttonAddtosystm.Size = new System.Drawing.Size(149, 23);
            this.buttonAddtosystm.TabIndex = 6;
            this.buttonAddtosystm.Text = "Update stock information";
            this.buttonAddtosystm.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Item location";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Remove item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add item";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(533, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAddtosystm);
            this.Controls.Add(this.textBoxAmountSystm);
            this.Controls.Add(this.textBoxPriceSystm);
            this.Controls.Add(this.textBoxnameSystm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxnameSystm;
        private System.Windows.Forms.TextBox textBoxPriceSystm;
        private System.Windows.Forms.TextBox textBoxAmountSystm;
        private System.Windows.Forms.Button buttonAddtosystm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

