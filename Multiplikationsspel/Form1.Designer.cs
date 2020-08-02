using System.Windows.Forms;

namespace Multiplikationsspel
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
            this.display = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.startrandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.display.AutoSize = true;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(12, 34);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(731, 95);
            this.display.TabIndex = 0;
            this.display.Text = "Multiplikationsspel";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(76, 331);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(300, 76);
            this.start.TabIndex = 1;
            this.start.Text = "Spela i ordning";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(136, 209);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(137, 58);
            this.timer.TabIndex = 3;
            this.timer.Text = "timer";
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(279, 188);
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(204, 102);
            this.answer.TabIndex = 6;
            // 
            // startrandom
            // 
            this.startrandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startrandom.Location = new System.Drawing.Point(382, 331);
            this.startrandom.Name = "startrandom";
            this.startrandom.Size = new System.Drawing.Size(286, 76);
            this.startrandom.TabIndex = 7;
            this.startrandom.Text = "Spela i slumpmässig ordning";
            this.startrandom.UseVisualStyleBackColor = true;
            this.startrandom.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.startrandom);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.start);
            this.Controls.Add(this.display);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label timer;
        private TextBox answer;
        private Button startrandom;
    }
}

