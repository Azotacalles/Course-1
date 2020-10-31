namespace Task1
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCommandCount = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblMinCommandCount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCommand1.Location = new System.Drawing.Point(494, 17);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(99, 41);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCommand2.Location = new System.Drawing.Point(494, 81);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(99, 40);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "x2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(494, 225);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 46);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(25, 62);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(24, 26);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            // 
            // lblCommandCount
            // 
            this.lblCommandCount.AutoSize = true;
            this.lblCommandCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCommandCount.Location = new System.Drawing.Point(25, 141);
            this.lblCommandCount.Name = "lblCommandCount";
            this.lblCommandCount.Size = new System.Drawing.Size(24, 26);
            this.lblCommandCount.TabIndex = 4;
            this.lblCommandCount.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblChange);
            this.panel1.Controls.Add(this.lblMinCommandCount);
            this.panel1.Controls.Add(this.lblNumber);
            this.panel1.Controls.Add(this.lblCommandCount);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnCommand1);
            this.panel1.Controls.Add(this.btnCommand2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 343);
            this.panel1.TabIndex = 7;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChange.Location = new System.Drawing.Point(25, 17);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(68, 26);
            this.lblChange.TabIndex = 6;
            this.lblChange.Text = "0 -> 0";
            // 
            // lblMinCommandCount
            // 
            this.lblMinCommandCount.AutoSize = true;
            this.lblMinCommandCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinCommandCount.Location = new System.Drawing.Point(25, 182);
            this.lblMinCommandCount.Name = "lblMinCommandCount";
            this.lblMinCommandCount.Size = new System.Drawing.Size(24, 26);
            this.lblMinCommandCount.TabIndex = 5;
            this.lblMinCommandCount.Text = "0";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(494, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 367);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCommandCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMinCommandCount;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btnCancel;
    }
}

