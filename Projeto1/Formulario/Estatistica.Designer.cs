
namespace Projeto1.Formulario
{
    partial class Estatistica
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estatistica));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Progress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProgressMulher = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.hmTxt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MlhTxt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.SystemColors.Highlight;
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(-3, 1);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(653, 47);
            this.bunifuCards1.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(271, 8);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(140, 31);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Estatistica";
            // 
            // Progress
            // 
            this.Progress.animated = false;
            this.Progress.animationIterval = 5;
            this.Progress.animationSpeed = 300;
            this.Progress.BackColor = System.Drawing.SystemColors.Highlight;
            this.Progress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Progress.BackgroundImage")));
            this.Progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.Progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Progress.LabelVisible = true;
            this.Progress.LineProgressThickness = 8;
            this.Progress.LineThickness = 5;
            this.Progress.Location = new System.Drawing.Point(26, 225);
            this.Progress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Progress.MaxValue = 100;
            this.Progress.Name = "Progress";
            this.Progress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.Progress.ProgressColor = System.Drawing.Color.SeaGreen;
            this.Progress.Size = new System.Drawing.Size(126, 126);
            this.Progress.TabIndex = 1;
            this.Progress.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProgressMulher
            // 
            this.ProgressMulher.animated = false;
            this.ProgressMulher.animationIterval = 5;
            this.ProgressMulher.animationSpeed = 300;
            this.ProgressMulher.BackColor = System.Drawing.SystemColors.Highlight;
            this.ProgressMulher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgressMulher.BackgroundImage")));
            this.ProgressMulher.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.ProgressMulher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProgressMulher.LabelVisible = true;
            this.ProgressMulher.LineProgressThickness = 8;
            this.ProgressMulher.LineThickness = 5;
            this.ProgressMulher.Location = new System.Drawing.Point(490, 225);
            this.ProgressMulher.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ProgressMulher.MaxValue = 100;
            this.ProgressMulher.Name = "ProgressMulher";
            this.ProgressMulher.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.ProgressMulher.ProgressColor = System.Drawing.Color.SeaGreen;
            this.ProgressMulher.Size = new System.Drawing.Size(138, 138);
            this.ProgressMulher.TabIndex = 5;
            this.ProgressMulher.Value = 0;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(20, 121);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(115, 31);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Homens";
            // 
            // hmTxt
            // 
            this.hmTxt.AutoSize = true;
            this.hmTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmTxt.ForeColor = System.Drawing.Color.White;
            this.hmTxt.Location = new System.Drawing.Point(63, 176);
            this.hmTxt.Name = "hmTxt";
            this.hmTxt.Size = new System.Drawing.Size(29, 31);
            this.hmTxt.TabIndex = 4;
            this.hmTxt.Text = "0";
            // 
            // MlhTxt
            // 
            this.MlhTxt.AutoSize = true;
            this.MlhTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MlhTxt.ForeColor = System.Drawing.Color.White;
            this.MlhTxt.Location = new System.Drawing.Point(534, 176);
            this.MlhTxt.Name = "MlhTxt";
            this.MlhTxt.Size = new System.Drawing.Size(29, 31);
            this.MlhTxt.TabIndex = 6;
            this.MlhTxt.Text = "0";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(503, 121);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(125, 31);
            this.bunifuCustomLabel5.TabIndex = 7;
            this.bunifuCustomLabel5.Text = "Mulheres";
            // 
            // Estatistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(647, 390);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.MlhTxt);
            this.Controls.Add(this.hmTxt);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.ProgressMulher);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "Estatistica";
            this.Text = "Estatistica";
            this.Load += new System.EventHandler(this.Estatistica_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar Progress;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar ProgressMulher;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel hmTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel MlhTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
    }
}