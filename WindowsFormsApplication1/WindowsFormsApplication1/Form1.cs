using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string caminho = Environment.CurrentDirectory;

        public Form1()
        {
            InitializeComponent();
            PlayAudioLogin();
        }

        //Metodos responsáveis pela transparencia do BG de login.
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PainelTransparente(panel1, e);
            using (Brush brush = new SolidBrush(Color.FromArgb(150, panel1.BackColor)))
            {
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }
        }

        private static void PainelTransparente(Control controle, PaintEventArgs e)
        {
            if (controle.Parent == null || !Application.RenderWithVisualStyles)
                return;

            ButtonRenderer.DrawParentBackground(e.Graphics, controle.ClientRectangle, controle);
        }// Fim.


         // Métodos responsáveis pelo botão de logar.
        private void btn_EntrarOff_MouseClick(object sender, MouseEventArgs e)
        {
            btn_EntrarOn.Visible = true;
            btn_EntrarOff.Visible = false;
        }

        private void btn_EntrarOn_MouseClick(object sender, MouseEventArgs e)
        {
            btn_EntrarOff.Visible = true;
            btn_EntrarOn.Visible = false;
        }// Fim.


        // Método responsável pelo play do aúdio do login.
        private void PlayAudioLogin()
        {           
            SoundPlayer audio_Trovao = new SoundPlayer(caminho + @"\trovao.wav");
            audio_Trovao.Play();
        } // Fim.


        // Método responsável pelo "timer" do áudio.
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 25)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {           
                panel1.Visible = true;

                if (progressBar2.Value < 60)
                {
                    progressBar2.Value = progressBar2.Value + 2;
                }
                else
                {                   
                    lbl_Login.Visible = true;
                    lbl_Senha.Visible = true;
                    txt_Login.Visible = true;
                    txt_Senha.Visible = true;
                    btn_EntrarOff.Visible = true;
                    btn_EntrarOn.Visible = true;
                    timer1.Enabled = false;
                }
            }
        }// Fim


        // Métodos de responsáveis pelos eventos dos textobox Login e Senha
        private void txt_Login_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Login.BackColor = Color.White;
        }

        private void txt_Login_Leave(object sender, EventArgs e)
        {
            txt_Login.BackColor = Color.WhiteSmoke;
        }

        private void txt_Senha_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Login.BackColor = Color.White;
        }

        private void txt_Senha_Leave(object sender, EventArgs e)
        {
            txt_Login.BackColor = Color.WhiteSmoke;
        }// Fim.
    }
}
