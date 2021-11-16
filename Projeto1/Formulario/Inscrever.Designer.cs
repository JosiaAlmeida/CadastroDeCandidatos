
namespace Projeto1.Formulario
{
    partial class Inscrever
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscrever));
            this.f = new System.Windows.Forms.Button();
            this.idadeDUP = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.sexoDUP = new System.Windows.Forms.DomainUpDown();
            this.resultlb = new System.Windows.Forms.Label();
            this.nametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lastNametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cursotxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nBItxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.inscreverbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.Red;
            this.f.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.ForeColor = System.Drawing.SystemColors.Control;
            this.f.Location = new System.Drawing.Point(25, 282);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(146, 33);
            this.f.TabIndex = 0;
            this.f.Text = "Close";
            this.f.UseVisualStyleBackColor = false;
            this.f.Click += new System.EventHandler(this.inscreverbtn_Click);
            // 
            // idadeDUP
            // 
            this.idadeDUP.BackColor = System.Drawing.Color.OrangeRed;
            this.idadeDUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeDUP.ForeColor = System.Drawing.SystemColors.Info;
            this.idadeDUP.Items.Add("12");
            this.idadeDUP.Items.Add("13");
            this.idadeDUP.Items.Add("14");
            this.idadeDUP.Items.Add("15");
            this.idadeDUP.Items.Add("16");
            this.idadeDUP.Items.Add("17");
            this.idadeDUP.Items.Add("18");
            this.idadeDUP.Items.Add("19");
            this.idadeDUP.Items.Add("20");
            this.idadeDUP.Location = new System.Drawing.Point(430, 226);
            this.idadeDUP.Name = "idadeDUP";
            this.idadeDUP.Size = new System.Drawing.Size(66, 21);
            this.idadeDUP.TabIndex = 9;
            this.idadeDUP.Text = "12";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sexo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // sexoDUP
            // 
            this.sexoDUP.BackColor = System.Drawing.Color.OrangeRed;
            this.sexoDUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexoDUP.ForeColor = System.Drawing.SystemColors.Info;
            this.sexoDUP.Items.Add("M");
            this.sexoDUP.Items.Add("F");
            this.sexoDUP.Location = new System.Drawing.Point(120, 226);
            this.sexoDUP.Name = "sexoDUP";
            this.sexoDUP.Size = new System.Drawing.Size(91, 21);
            this.sexoDUP.TabIndex = 13;
            this.sexoDUP.Text = "M";
            // 
            // resultlb
            // 
            this.resultlb.AutoSize = true;
            this.resultlb.Location = new System.Drawing.Point(229, 225);
            this.resultlb.Name = "resultlb";
            this.resultlb.Size = new System.Drawing.Size(16, 13);
            this.resultlb.TabIndex = 14;
            this.resultlb.Text = "...";
            // 
            // nametxt
            // 
            this.nametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nametxt.ForeColor = System.Drawing.Color.White;
            this.nametxt.HintForeColor = System.Drawing.Color.White;
            this.nametxt.HintText = "Nome";
            this.nametxt.isPassword = false;
            this.nametxt.LineFocusedColor = System.Drawing.Color.Red;
            this.nametxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nametxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nametxt.LineThickness = 3;
            this.nametxt.Location = new System.Drawing.Point(17, 103);
            this.nametxt.Margin = new System.Windows.Forms.Padding(4);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(195, 34);
            this.nametxt.TabIndex = 15;
            this.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lastNametxt
            // 
            this.lastNametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNametxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lastNametxt.ForeColor = System.Drawing.Color.White;
            this.lastNametxt.HintForeColor = System.Drawing.Color.White;
            this.lastNametxt.HintText = "Apelido";
            this.lastNametxt.isPassword = false;
            this.lastNametxt.LineFocusedColor = System.Drawing.Color.Red;
            this.lastNametxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lastNametxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.lastNametxt.LineThickness = 3;
            this.lastNametxt.Location = new System.Drawing.Point(301, 103);
            this.lastNametxt.Margin = new System.Windows.Forms.Padding(4);
            this.lastNametxt.Name = "lastNametxt";
            this.lastNametxt.Size = new System.Drawing.Size(204, 34);
            this.lastNametxt.TabIndex = 16;
            this.lastNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cursotxt
            // 
            this.cursotxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cursotxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cursotxt.ForeColor = System.Drawing.Color.White;
            this.cursotxt.HintForeColor = System.Drawing.Color.White;
            this.cursotxt.HintText = "Curso";
            this.cursotxt.isPassword = false;
            this.cursotxt.LineFocusedColor = System.Drawing.Color.Red;
            this.cursotxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cursotxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cursotxt.LineThickness = 3;
            this.cursotxt.Location = new System.Drawing.Point(301, 171);
            this.cursotxt.Margin = new System.Windows.Forms.Padding(4);
            this.cursotxt.Name = "cursotxt";
            this.cursotxt.Size = new System.Drawing.Size(204, 34);
            this.cursotxt.TabIndex = 17;
            this.cursotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nBItxt
            // 
            this.nBItxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nBItxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nBItxt.ForeColor = System.Drawing.Color.White;
            this.nBItxt.HintForeColor = System.Drawing.Color.White;
            this.nBItxt.HintText = "Numero Do Bi";
            this.nBItxt.isPassword = false;
            this.nBItxt.LineFocusedColor = System.Drawing.Color.Red;
            this.nBItxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nBItxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nBItxt.LineThickness = 3;
            this.nBItxt.Location = new System.Drawing.Point(17, 171);
            this.nBItxt.Margin = new System.Windows.Forms.Padding(4);
            this.nBItxt.Name = "nBItxt";
            this.nBItxt.Size = new System.Drawing.Size(194, 34);
            this.nBItxt.TabIndex = 18;
            this.nBItxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(-1, -3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(532, 55);
            this.bunifuCards1.TabIndex = 19;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(136, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(297, 31);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Inscrição De Candidato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(297, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Idade";
            // 
            // inscreverbtn
            // 
            this.inscreverbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.inscreverbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.inscreverbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inscreverbtn.BorderRadius = 0;
            this.inscreverbtn.ButtonText = "Inscrever Candidato";
            this.inscreverbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inscreverbtn.DisabledColor = System.Drawing.Color.Gray;
            this.inscreverbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.inscreverbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("inscreverbtn.Iconimage")));
            this.inscreverbtn.Iconimage_right = null;
            this.inscreverbtn.Iconimage_right_Selected = null;
            this.inscreverbtn.Iconimage_Selected = null;
            this.inscreverbtn.IconMarginLeft = 0;
            this.inscreverbtn.IconMarginRight = 0;
            this.inscreverbtn.IconRightVisible = true;
            this.inscreverbtn.IconRightZoom = 0D;
            this.inscreverbtn.IconVisible = true;
            this.inscreverbtn.IconZoom = 90D;
            this.inscreverbtn.IsTab = false;
            this.inscreverbtn.Location = new System.Drawing.Point(349, 282);
            this.inscreverbtn.Name = "inscreverbtn";
            this.inscreverbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.inscreverbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.inscreverbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.inscreverbtn.selected = false;
            this.inscreverbtn.Size = new System.Drawing.Size(170, 33);
            this.inscreverbtn.TabIndex = 21;
            this.inscreverbtn.Text = "Inscrever Candidato";
            this.inscreverbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inscreverbtn.Textcolor = System.Drawing.Color.White;
            this.inscreverbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscreverbtn.Click += new System.EventHandler(this.inscreverbtn_Click_1);
            // 
            // Inscrever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(531, 327);
            this.Controls.Add(this.inscreverbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.nBItxt);
            this.Controls.Add(this.cursotxt);
            this.Controls.Add(this.lastNametxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.resultlb);
            this.Controls.Add(this.sexoDUP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idadeDUP);
            this.Controls.Add(this.f);
            this.Name = "Inscrever";
            this.Text = "Inscrever";
            this.Load += new System.EventHandler(this.Inscrever_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button f;
        private System.Windows.Forms.DomainUpDown idadeDUP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown sexoDUP;
        private System.Windows.Forms.Label resultlb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nametxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lastNametxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cursotxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nBItxt;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton inscreverbtn;
    }
}