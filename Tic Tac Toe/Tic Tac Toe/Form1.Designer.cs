namespace Tic_Tac_Toe
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
            this.B00 = new System.Windows.Forms.Button();
            this.B01 = new System.Windows.Forms.Button();
            this.B02 = new System.Windows.Forms.Button();
            this.B10 = new System.Windows.Forms.Button();
            this.B11 = new System.Windows.Forms.Button();
            this.B12 = new System.Windows.Forms.Button();
            this.B20 = new System.Windows.Forms.Button();
            this.B21 = new System.Windows.Forms.Button();
            this.B22 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B00
            // 
            this.B00.Location = new System.Drawing.Point(149, 60);
            this.B00.Name = "B00";
            this.B00.Size = new System.Drawing.Size(130, 116);
            this.B00.TabIndex = 0;
            this.B00.UseVisualStyleBackColor = true;
            this.B00.Click += new System.EventHandler(this.ButtonClick);
            // 
            // B01
            // 
            this.B01.Location = new System.Drawing.Point(303, 60);
            this.B01.Name = "B01";
            this.B01.Size = new System.Drawing.Size(130, 116);
            this.B01.TabIndex = 1;
            this.B01.UseVisualStyleBackColor = true;
            this.B01.Click += new System.EventHandler(this.ButtonClick);
            // 
            // B02
            // 
            this.B02.Location = new System.Drawing.Point(461, 60);
            this.B02.Name = "B02";
            this.B02.Size = new System.Drawing.Size(130, 116);
            this.B02.TabIndex = 2;
            this.B02.UseVisualStyleBackColor = true;
            this.B02.Click += new System.EventHandler(this.ButtonClick);
            // 
            // B10
            // 
            this.B10.Location = new System.Drawing.Point(149, 204);
            this.B10.Name = "B10";
            this.B10.Size = new System.Drawing.Size(130, 114);
            this.B10.TabIndex = 3;
            this.B10.UseVisualStyleBackColor = true;
            this.B10.Click += new System.EventHandler(this.ButtonClick);
            // 
            // B11
            // 
            this.B11.Location = new System.Drawing.Point(303, 204);
            this.B11.Name = "B11";
            this.B11.Size = new System.Drawing.Size(130, 114);
            this.B11.TabIndex = 4;
            this.B11.UseVisualStyleBackColor = true;
            this.B11.Click += new System.EventHandler(this.ButtonClick);
            // 
            // B12
            // 
            this.B12.Location = new System.Drawing.Point(461, 204);
            this.B12.Name = "B12";
            this.B12.Size = new System.Drawing.Size(130, 114);
            this.B12.TabIndex = 5;
            this.B12.UseVisualStyleBackColor = true;
            this.B12.Click += new System.EventHandler(this.ButtonClick);
            // 
            // B20
            // 
            this.B20.Location = new System.Drawing.Point(149, 348);
            this.B20.Name = "B20";
            this.B20.Size = new System.Drawing.Size(130, 116);
            this.B20.TabIndex = 6;
            this.B20.UseVisualStyleBackColor = true;
            this.B20.Click += new System.EventHandler(this.ButtonClick);
            // 
            // B21
            // 
            this.B21.Location = new System.Drawing.Point(303, 348);
            this.B21.Name = "B21";
            this.B21.Size = new System.Drawing.Size(130, 116);
            this.B21.TabIndex = 7;
            this.B21.UseVisualStyleBackColor = true;
            this.B21.Click += new System.EventHandler(this.ButtonClick);
            // 
            // B22
            // 
            this.B22.Location = new System.Drawing.Point(461, 348);
            this.B22.Name = "B22";
            this.B22.Size = new System.Drawing.Size(130, 116);
            this.B22.TabIndex = 8;
            this.B22.UseVisualStyleBackColor = true;
            this.B22.Click += new System.EventHandler(this.ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(724, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "O - Wins : 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(724, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "X - Wins : 0";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Gold;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(731, 407);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(187, 57);
            this.button10.TabIndex = 11;
            this.button10.Text = "Start new game";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 529);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B22);
            this.Controls.Add(this.B21);
            this.Controls.Add(this.B20);
            this.Controls.Add(this.B12);
            this.Controls.Add(this.B11);
            this.Controls.Add(this.B10);
            this.Controls.Add(this.B02);
            this.Controls.Add(this.B01);
            this.Controls.Add(this.B00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B00;
        private System.Windows.Forms.Button B01;
        private System.Windows.Forms.Button B02;
        private System.Windows.Forms.Button B10;
        private System.Windows.Forms.Button B11;
        private System.Windows.Forms.Button B12;
        private System.Windows.Forms.Button B20;
        private System.Windows.Forms.Button B21;
        private System.Windows.Forms.Button B22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button10;
    }
}

