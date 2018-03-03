using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300_HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BOK_Click(object sender, EventArgs e)
        {

            String nom;


            nom = TBNom.Text;
            RTText.Text = RTText.Text + nom+"\n";
            TBNom.Text = "";



        }
    }
}
