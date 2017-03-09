namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.btn_EntrarOff = new System.Windows.Forms.Button();
            this.btn_EntrarOn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_Senha);
            this.panel1.Controls.Add(this.lbl_Login);
            this.panel1.Controls.Add(this.txt_Senha);
            this.panel1.Controls.Add(this.txt_Login);
            this.panel1.Controls.Add(this.btn_EntrarOff);
            this.panel1.Controls.Add(this.btn_EntrarOn);
            this.panel1.Location = new System.Drawing.Point(247, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 375);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Senha.Location = new System.Drawing.Point(78, 175);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(61, 20);
            this.lbl_Senha.TabIndex = 3;
            this.lbl_Senha.Text = "Senha";
            this.lbl_Senha.Visible = false;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Login.Location = new System.Drawing.Point(86, 115);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(53, 20);
            this.lbl_Login.TabIndex = 2;
            this.lbl_Login.Text = "Login";
            this.lbl_Login.Visible = false;
            // 
            // txt_Senha
            // 
            this.txt_Senha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(158, 172);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(260, 26);
            this.txt_Senha.TabIndex = 1;
            this.txt_Senha.UseSystemPasswordChar = true;
            this.txt_Senha.Visible = false;
            // 
            // txt_Login
            // 
            this.txt_Login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login.Location = new System.Drawing.Point(158, 112);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(260, 26);
            this.txt_Login.TabIndex = 0;
            this.txt_Login.Visible = false;
            // 
            // btn_EntrarOff
            // 
            this.btn_EntrarOff.BackColor = System.Drawing.Color.Transparent;
            this.btn_EntrarOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EntrarOff.BackgroundImage")));
            this.btn_EntrarOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_EntrarOff.FlatAppearance.BorderSize = 0;
            this.btn_EntrarOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_EntrarOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_EntrarOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EntrarOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EntrarOff.ForeColor = System.Drawing.Color.White;
            this.btn_EntrarOff.Location = new System.Drawing.Point(320, 231);
            this.btn_EntrarOff.Name = "btn_EntrarOff";
            this.btn_EntrarOff.Size = new System.Drawing.Size(98, 57);
            this.btn_EntrarOff.TabIndex = 4;
            this.btn_EntrarOff.UseVisualStyleBackColor = false;
            this.btn_EntrarOff.Visible = false;
            this.btn_EntrarOff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_EntrarOff_MouseClick);
            // 
            // btn_EntrarOn
            // 
            this.btn_EntrarOn.BackColor = System.Drawing.Color.Transparent;
            this.btn_EntrarOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EntrarOn.BackgroundImage")));
            this.btn_EntrarOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_EntrarOn.FlatAppearance.BorderSize = 0;
            this.btn_EntrarOn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_EntrarOn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_EntrarOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EntrarOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EntrarOn.ForeColor = System.Drawing.Color.White;
            this.btn_EntrarOn.Location = new System.Drawing.Point(320, 231);
            this.btn_EntrarOn.Name = "btn_EntrarOn";
            this.btn_EntrarOn.Size = new System.Drawing.Size(98, 57);
            this.btn_EntrarOn.TabIndex = 5;
            this.btn_EntrarOn.UseVisualStyleBackColor = false;
            this.btn_EntrarOn.Visible = false;
            this.btn_EntrarOn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_EntrarOn_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(341, 54);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(341, 83);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(300, 23);
            this.progressBar2.TabIndex = 2;
            this.progressBar2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 557);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.Button btn_EntrarOff;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Button btn_EntrarOn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

