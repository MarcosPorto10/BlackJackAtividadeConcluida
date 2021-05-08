using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    /*atividade blackjack em grupo

    https://classroom.google.com/c/MzMzNDY3ODkyNzgz?cjc=hktz2w3

    enviar nesse link individualmente
    cada aluno postar seu RA e Nome e link do gitHub 
    
     fausto garcia jacinto
    ra 2220100922
    */



    public partial class Form_jogo : Form
    {

        public Form_jogo()
        {
            InitializeComponent();
            btn_reiniciar.Enabled = false;
            btn_jogar_2.Enabled = false;
            btn_parar_2.Enabled = false;

        }

        public bool marvel = false;
        public bool tradicional = true;
        public bool futebol = false;
        int pontos_A = 0;
        int pontos_B = 0;


        public void resultado()
        {
            if (pontos_A <= 21 && pontos_B <= 21)
                if (pontos_A == pontos_B)
                    lbl_Resultado.Text = "EMPATE";
                else
                 if (pontos_A > pontos_B)
                    lbl_Resultado.Text = "Jogador 1 GANHOU!";
                else
                    lbl_Resultado.Text = "Jogador 2 GANHOU!";
            else
                if (pontos_A > 21 && pontos_B <= 21)
                lbl_Resultado.Text = "Jogador 2 GANHOU!";
            else
                 if (pontos_A <= 21 && pontos_B > 21)
                lbl_Resultado.Text = "Jogador 1 GANHOU!";
            else
                lbl_Resultado.Text = "SEM VENCEDOR";
        }

        public void Jogada(PictureBox A,PictureBox B,PictureBox D,int jogador,Label C)
        {
            int x, total_pontos = 0;
            Random sorteio = new Random();
            x = sorteio.Next(1, 14);

            switch (x)
            {
                case 1:
                    A.Image = Properties.Resources.a;
                    total_pontos += 1;
                    if (marvel == true)
                    {
                        B.Image = Properties.Resources.vingadores;
                        C.Visible = true;
                        C.Text = "A";
                    }else if (futebol == true)
                    {
                        D.Image = Properties.Resources.futebol__5_;
                        C.Visible = true;
                        C.Text = "Perde 1";
                        total_pontos -= 1;
                    }
                    break;
                case 2:
                    A.Image = Properties.Resources._2;
                    total_pontos += 2;
                    if (marvel == true)
                    {
                        B.Image = Properties.Resources.batman;
                        C.Visible = true;
                        C.Text = "2";
                    }
                    else if (futebol == true)
                    {
                        D.Image = Properties.Resources.futebol__1_;
                        C.Visible = true;
                        C.Text = "2";
                    }
                    break;
                case 3: 
                    A.Image = Properties.Resources._3;
                    total_pontos += 3;
                    if (marvel == true)
                    {
                        B.Image = Properties.Resources.homem_america;
                        C.Visible = true;
                        C.Text = "3";
                    }
                    else if (futebol == true)
                    {
                        D.Image = Properties.Resources.futebol__8_;
                        C.Visible = true;
                        C.Text = "3";
                    }
                    break;
                case 4: 
                    A.Image = Properties.Resources._4;
                    total_pontos += 4;
                    if (marvel == true)
                    {
                        B.Image = Properties.Resources.homem_aranha;
                        C.Visible = true;
                        C.Text = "4";
                    }
                    else if (futebol == true)
                    {
                        D.Image = Properties.Resources.futebol__13_;
                        C.Visible = true;
                        C.Text = "4";
                    }
                    break;
                case 5:
                    A.Image = Properties.Resources._5;
                    total_pontos += 5;
                    if (marvel == true)
                    {
                        B.Image = Properties.Resources.super_man;
                        C.Visible = true;
                        C.Text = "5";
                    }
                    else if (futebol == true)
                    {
                        D.Image = Properties.Resources.futebol__11_;
                        C.Visible = true;
                        C.Text = "5";
                    }
                    break;
                case 6:
                    A.Image = Properties.Resources._6;
                    total_pontos += 6;
                    if (marvel == true)
                    {
                       B.Image = Properties.Resources.mulher_maravilha;
                        C.Visible=true;
                        C.Text = "6";
                    }
                    else if (futebol == true)
                    {
                        D.Image = Properties.Resources.futebol__2_;
                        C.Visible = true;
                        C.Text = "6";
                    }
                    break;
                case 7:
                    A.Image = Properties.Resources._7;
                    total_pontos += 7;
                    if (marvel == true)
                    {
                        B.Image = Properties.Resources.hulk;
                        C.Visible = true;
                        C.Text = "7";
                    }
                    else if (futebol == true)
                    {
                        D.Image = Properties.Resources.futebol__10_;
                        C.Visible = true;
                        C.Text = "7";
                    }
                    break;
                case 8:
                    A.Image = Properties.Resources._8;
                    total_pontos += 8;
                    if (marvel == true)
                    {
                        B.Image = Properties.Resources.iron_man;
                        C.Visible = true;
                        C.Text="8";
                    }
                    else if (futebol == true)
                    {
                        D.Image = Properties.Resources.futebol__12_;
                        C.Visible = true;
                        C.Text = "8";
                    }
                    break;
                case 9:
                    A.Image = Properties.Resources._9;
                    total_pontos += 9;
                    if (marvel == true)
                    {
                        B.Image = Properties.Resources.thor;
                        C.Visible = true;
                        C.Text = "9";
                    }
                    else if (futebol == true)
                    {
                        D.Image = Properties.Resources.futebol__3_;
                        C.Visible = true;
                        C.Text = "9";
                    }

                    break;
                case 10:
                    A.Image = Properties.Resources._10;
                    total_pontos += 10;
                    if (marvel == true)
                    {
                        B.Image = Properties.Resources.wolverine;
                        C.Visible = true;
                        C.Text="10";
                    }else if (futebol == true)
                    {
                        D.Image = Properties.Resources.futebol__14_;
                        C.Visible = true;
                        C.Text = "10";
                    }
                    break;
                case 11:
                    A.Image = Properties.Resources.J;
                    total_pontos += 11;
                    if (marvel == true)
                    {
                        B.Image = Properties.Resources.flash;
                        C.Visible = true;
                        C.Text = "J";
                    }
                    else if (futebol == true)
                    {
                        D.Image = Properties.Resources.futebol__6_;
                        C.Visible = true;
                        C.Text = "J";
                    }
                    break;
                case 12:
                    A.Image = Properties.Resources.Q;
                    total_pontos += 12;
                    if (marvel == true)
                    {
                        B.Image = Properties.Resources.venom;
                        C.Visible = true;
                        C.Text = "Q";
                    }
                    else if (futebol == true)
                    {
                        D.Image = Properties.Resources.futebol__9_;
                        C.Visible = true;
                        C.Text = "Q";
                    }
                    break;
                case 13:
                    A.Image = Properties.Resources.K;
                    total_pontos += 13;
                    if (marvel == true)
                    {
                        B.Image = Properties.Resources.nick_fury;
                        C.Visible = true;
                        C.Text = "K";
                    }
                    else if (futebol == true)
                    {
                        D.Image = Properties.Resources.futebol__4_;
                        C.Visible = true;
                        C.Text = "A,B,C";
                        total_pontos = 21;
                    }

                    break;

            }
        
    
            if (jogador == 1)
                pontos_A += total_pontos;
            else
                pontos_B += total_pontos;
        }

            private void button1_Click(object sender, EventArgs e)
        {
            Jogada(pictureBox1,pictureBox3,pictureBox5, 1,label2);

            bntTradicional.Enabled = false;
            btnMarvel.Enabled = false;
            btnFutebol.Enabled = false;

            if (pontos_A <= 21)
            {   // JOGANDO
                lbl_Pontos_A.Text = Convert.ToString(pontos_A);
                if(pontos_A == 21)
                {
                    //lbl_Resultado.Text = "GANHOU!!!";
                    btn_jogar_1.Enabled = false;
                    btn_reiniciar.Enabled = true;
                }
            }
            else
            {   // PARTIDA PERDIDA
                lbl_Pontos_A.Text = Convert.ToString(pontos_A);
                //lbl_Resultado.Text = "PERDEU!!!! ";
                
                btn_jogar_1.Enabled = false;
                btn_parar_1.Enabled = false;

                btn_jogar_2.Enabled = true;
                btn_parar_2.Enabled = true;

                //btn_reiniciar.Enabled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pontos_A = 0;
            pontos_B = 0;
            btn_jogar_1.Enabled = true;
            btn_jogar_2.Enabled = false;
            btn_parar_1.Enabled = true;
            btn_parar_2.Enabled = false;

            btn_reiniciar.Enabled = false;
            lbl_Pontos_A.Text = "0";
            lbl_Pontos_B.Text = "0";
            lbl_Resultado.Text = "";

            pictureBox1.Image = Properties.Resources._0;
            pictureBox2.Image = Properties.Resources._0;
            pictureBox3.Image = Properties.Resources.marvel_comics;
            pictureBox4.Image = Properties.Resources.marvel_comics;
            pictureBox5.Image = Properties.Resources.futebol__7_;
            pictureBox6.Image = Properties.Resources.futebol__7_;

            label2.Visible = false;
            label3.Visible = false;
            if (marvel == true)
            {
                bntTradicional.Enabled = true;
                btnMarvel.Enabled = false;
                btnFutebol.Enabled = true;
            }
            else if(tradicional==true)
            {
                bntTradicional.Enabled = false;
                btnMarvel.Enabled = true;
                btnFutebol.Enabled = true;
            }
            else
            {
                bntTradicional.Enabled = true;
                btnMarvel.Enabled = true;
                btnFutebol.Enabled = false;
            }

           

        }

        private void btn_jogar_2_Click(object sender, EventArgs e)
        {
            //  ESCOLHER AS CARTAS
            Jogada(pictureBox2,pictureBox4,pictureBox6, 2,label3);

            if (pontos_B <= 21)
            {   // JOGANDO
                lbl_Pontos_B.Text = Convert.ToString(pontos_B);
               
                if (pontos_B == 21)
                {
                    //lbl_Resultado.Text = "GANHOU!!!";
                    btn_jogar_2.Enabled = false;
                    btn_reiniciar.Enabled = true;
                    resultado();
                }
            }
            else
            {   // PARTIDA PERDIDA
                lbl_Pontos_B.Text = Convert.ToString(pontos_B);
 

                btn_jogar_2.Enabled = false;
                btn_parar_2.Enabled = false;

                btn_jogar_2.Enabled = false;
                btn_parar_2.Enabled = false;

                resultado();
                btn_reiniciar.Enabled = true;
            }
        }

        private void btn_parar_1_Click(object sender, EventArgs e)
        {
            btn_jogar_1.Enabled = false;
            btn_parar_1.Enabled = false;
            btn_jogar_2.Enabled = true;
            btn_parar_2.Enabled = true;
        }

        private void btn_parar_2_Click(object sender, EventArgs e)
        {
            btn_jogar_2.Enabled = false;
            btn_parar_2.Enabled = false;
            btn_reiniciar.Enabled = true;
            resultado();
        }

        private void bntTradicional_Click(object sender, EventArgs e)
        {
            marvel = false;
            tradicional = true;
            futebol = false;
            bntTradicional.Enabled = false;
            btnFutebol.Enabled = true;
            btnMarvel.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }
        private void btnMarvel_Click(object sender, EventArgs e)
        {
            marvel = true;
            tradicional = false;
            futebol = false;
            bntTradicional.Enabled = true;
            btnFutebol.Enabled = true;
            btnMarvel.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void btnFutebol_Click_1(object sender, EventArgs e)
        {
            marvel = false;
            tradicional = false;
            futebol = true;
            bntTradicional.Enabled = true;
            btnFutebol.Enabled = false;
            btnMarvel.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
