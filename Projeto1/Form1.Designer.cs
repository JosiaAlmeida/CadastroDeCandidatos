
namespace Projeto1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.idadeDp = new Bunifu.Framework.UI.BunifuDropdown();
            this.salarioTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.telefoneTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.nomeTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Entrarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(116, 56);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(229, 31);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Funcionario Login";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(107, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(247, 31);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Colegio GraceLand";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(34, 230);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(82, 31);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "Idade";
            // 
            // idadeDp
            // 
            this.idadeDp.BackColor = System.Drawing.Color.Transparent;
            this.idadeDp.BorderRadius = 3;
            this.idadeDp.DisabledColor = System.Drawing.Color.Gray;
            this.idadeDp.ForeColor = System.Drawing.Color.White;
            this.idadeDp.Items = new string[] {
        "18",
        "19",
        "20",
        "21",
        "22",
        "23",
        "24",
        "25",
        "26",
        "27",
        "28",
        "29",
        "30",
        "31",
        "32",
        "33",
        "34",
        "35",
        "36",
        "37",
        "38",
        "39",
        "40",
        "41",
        "42",
        "43",
        "44",
        "45",
        "46",
        "47",
        "48",
        "49",
        "50"};
            this.idadeDp.Location = new System.Drawing.Point(164, 230);
            this.idadeDp.Name = "idadeDp";
            this.idadeDp.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.idadeDp.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.idadeDp.selectedIndex = 0;
            this.idadeDp.Size = new System.Drawing.Size(85, 35);
            this.idadeDp.TabIndex = 12;
            // 
            // salarioTxt
            // 
            this.salarioTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salarioTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.salarioTxt.ForeColor = System.Drawing.Color.White;
            this.salarioTxt.HintForeColor = System.Drawing.Color.White;
            this.salarioTxt.HintText = "Salario";
            this.salarioTxt.isPassword = false;
            this.salarioTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.salarioTxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.salarioTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.salarioTxt.LineThickness = 3;
            this.salarioTxt.Location = new System.Drawing.Point(291, 144);
            this.salarioTxt.Margin = new System.Windows.Forms.Padding(4);
            this.salarioTxt.Name = "salarioTxt";
            this.salarioTxt.Size = new System.Drawing.Size(159, 33);
            this.salarioTxt.TabIndex = 11;
            this.salarioTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // telefoneTxt
            // 
            this.telefoneTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telefoneTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.telefoneTxt.ForeColor = System.Drawing.Color.White;
            this.telefoneTxt.HintForeColor = System.Drawing.Color.White;
            this.telefoneTxt.HintText = "Telefone";
            this.telefoneTxt.isPassword = false;
            this.telefoneTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.telefoneTxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.telefoneTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.telefoneTxt.LineThickness = 3;
            this.telefoneTxt.Location = new System.Drawing.Point(13, 144);
            this.telefoneTxt.Margin = new System.Windows.Forms.Padding(4);
            this.telefoneTxt.Name = "telefoneTxt";
            this.telefoneTxt.Size = new System.Drawing.Size(159, 33);
            this.telefoneTxt.TabIndex = 10;
            this.telefoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(-2, -1);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(466, 87);
            this.bunifuCards1.TabIndex = 8;
            // 
            // nomeTxt
            // 
            this.nomeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nomeTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nomeTxt.ForeColor = System.Drawing.Color.White;
            this.nomeTxt.HintForeColor = System.Drawing.Color.White;
            this.nomeTxt.HintText = "Nome";
            this.nomeTxt.isPassword = false;
            this.nomeTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.nomeTxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nomeTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nomeTxt.LineThickness = 3;
            this.nomeTxt.Location = new System.Drawing.Point(13, 103);
            this.nomeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(437, 33);
            this.nomeTxt.TabIndex = 7;
            this.nomeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Entrarbtn
            // 
            this.Entrarbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Entrarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Entrarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Entrarbtn.BorderRadius = 0;
            this.Entrarbtn.ButtonText = "Entrar";
            this.Entrarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Entrarbtn.DisabledColor = System.Drawing.Color.Gray;
            this.Entrarbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Entrarbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Entrarbtn.Iconimage")));
            this.Entrarbtn.Iconimage_right = null;
            this.Entrarbtn.Iconimage_right_Selected = null;
            this.Entrarbtn.Iconimage_Selected = null;
            this.Entrarbtn.IconMarginLeft = 0;
            this.Entrarbtn.IconMarginRight = 0;
            this.Entrarbtn.IconRightVisible = true;
            this.Entrarbtn.IconRightZoom = 0D;
            this.Entrarbtn.IconVisible = true;
            this.Entrarbtn.IconZoom = 90D;
            this.Entrarbtn.IsTab = false;
            this.Entrarbtn.Location = new System.Drawing.Point(164, 296);
            this.Entrarbtn.Name = "Entrarbtn";
            this.Entrarbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Entrarbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Entrarbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.Entrarbtn.selected = false;
            this.Entrarbtn.Size = new System.Drawing.Size(114, 48);
            this.Entrarbtn.TabIndex = 6;
            this.Entrarbtn.Text = "Entrar";
            this.Entrarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Entrarbtn.Textcolor = System.Drawing.Color.White;
            this.Entrarbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrarbtn.Click += new System.EventHandler(this.Entrarbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(463, 365);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.idadeDp);
            this.Controls.Add(this.salarioTxt);
            this.Controls.Add(this.telefoneTxt);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.Entrarbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDropdown idadeDp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox salarioTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox telefoneTxt;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nomeTxt;
        private Bunifu.Framework.UI.BunifuFlatButton Entrarbtn;
    }
}

