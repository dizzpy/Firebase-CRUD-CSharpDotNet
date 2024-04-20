namespace FirebaseCsharpDotNet
{
    partial class HomeView
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadData = new System.Windows.Forms.Button();
            this.DisplayText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddText = new System.Windows.Forms.TextBox();
            this.AddData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.LoadData);
            this.panel1.Controls.Add(this.DisplayText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(35, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 197);
            this.panel1.TabIndex = 1;
            // 
            // LoadData
            // 
            this.LoadData.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LoadData.Location = new System.Drawing.Point(249, 124);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(135, 47);
            this.LoadData.TabIndex = 2;
            this.LoadData.Text = "Load Data";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // DisplayText
            // 
            this.DisplayText.AutoSize = true;
            this.DisplayText.Font = new System.Drawing.Font("Poppins Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayText.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DisplayText.Location = new System.Drawing.Point(22, 72);
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.Size = new System.Drawing.Size(156, 48);
            this.DisplayText.TabIndex = 1;
            this.DisplayText.Text = "My Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.AddText);
            this.panel2.Controls.Add(this.AddData);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(35, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 197);
            this.panel2.TabIndex = 3;
            // 
            // AddText
            // 
            this.AddText.Location = new System.Drawing.Point(27, 85);
            this.AddText.Name = "AddText";
            this.AddText.Size = new System.Drawing.Size(198, 31);
            this.AddText.TabIndex = 3;
            // 
            // AddData
            // 
            this.AddData.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AddData.Location = new System.Drawing.Point(249, 124);
            this.AddData.Name = "AddData";
            this.AddData.Size = new System.Drawing.Size(135, 47);
            this.AddData.TabIndex = 2;
            this.AddData.Text = "Add Data";
            this.AddData.UseVisualStyleBackColor = true;
            this.AddData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(22, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add Data";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(35, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 69);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firebase Add/Delete";
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 568);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "HomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firebase Data Add/Delete C# .Net";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DisplayText;
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}

