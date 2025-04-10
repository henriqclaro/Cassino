using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cassino
{
    public partial class Form1 : Form
    {
        int[] roleta;
        int[] ciclos;
        Label[] tela;
        Random r;
        public Form1()
        {
            InitializeComponent();
            roleta = new int[3];
            ciclos = new int[3];
            tela = new Label[] {lbl1, lbl2, lbl3};
            r = new Random();
            for (int i = 0; i < roleta.Length; i++)
            {
                roleta[i] = r.Next(0, 10);
                Atualizar(i);
            }
        }

        void Atualizar(int i)
        {
            tela[i].Text = roleta[i].ToString();
        }

        private void btnGirar_Click(object sender, EventArgs e)
        {
            for (int i = 0;i < ciclos.Length; i++)
            {
                ciclos[i] = r.Next(1, 21);
                tela[i].ForeColor = Color.White;
            }
            Array.Sort(ciclos);
            btnGirar.Enabled = false;
            tmrGiro.Enabled = true;
        }

        void verificarVitoria() // Se lasque pra tentar ganhar sem mudar o código
        {
            if (lbl1.Text == lbl2.Text && lbl2.Text == lbl3.Text)
            {
                lbl1.ForeColor = lbl2.ForeColor = lbl3.ForeColor = Color.Green;
                MessageBox.Show("BIG WIIIIIIN!!!");
            }
        }

        private void tmrGiro_Tick(object sender, EventArgs e)
        {
            bool parado = true;
            for(int i = 0; i <ciclos.Length; i++)
            {
                if (ciclos[i] > 0)
                {
                    ciclos[i]--;
                    if (ciclos[i] == 0)
                        tela[i].ForeColor = Color.Red;
                    roleta[i]++;
                    if (roleta[i] == 10)
                        roleta[i] = 0;
                    Atualizar(i);
                    parado &= false;
                }
                else
                {
                    parado &= true;
                }
            }
            if (parado)
            {
                tmrGiro.Enabled = false;
                btnGirar .Enabled = true;
                verificarVitoria();

                lbxUltimos.Items.Add($"{roleta[0]}-{roleta[1]}-{roleta[2]}");
            }
        }

        List<string> jogadas;
        private void chbVitorias_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVitorias.Checked)
            {
                jogadas = new List<string>();
                foreach (string item in lbxUltimos.Items)
                {
                    jogadas.Add(item);
                }

                lbxUltimos.Items.Clear();
                foreach (string item in jogadas)
                {
                    string[] nums = item.Split('-');
                    if (nums[0] == nums[1] && nums[1] == nums[2])
                        lbxUltimos.Items.Add(item);
                    
                }
            }
            else
            {
                lbxUltimos.Items.Clear();
                foreach (string item in jogadas)
                {
                    lbxUltimos.Items.Add(item);
                }
            }
        }
    }
}
