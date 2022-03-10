using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spst_task_php
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] items = { "abc1deadf4", "12bcddef34", "2bdsadef3", "2bc10def3", "adsacd5ef3", "ab3d5fmo3", "ai9k8modmoa45", "ad12acdef", "minamarineimr" };

            for(int i = 0; i<items.Length; ++i)
            {

                listBox1.Items.Add(items[i]);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string item = listBox1.SelectedItem.ToString();
            int soucet = 0;
            string cislo = "0";
            
            foreach(char znak in item)
            {
                
                if(znak >=48 && znak <= 57)
                {
                    cislo += znak.ToString();
                        
                }

                else
                {
                    int clen = Convert.ToInt32(cislo);
                    soucet += clen;

                }
                

            }

            label1.Text = "=" + soucet.ToString();

        }
    }
}
