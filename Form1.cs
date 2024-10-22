using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Procentowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelBeerImagine.Image = Properties.Resources.beer;
        }

        // Zapewne powinienem zaciągać te dane z zewnątrz kodu, ale niestety budżet tego nie obejmuje ...

        // Rodzaje i Stężenie Alkoholu
        string alkoholOpt1 = "Piwo (5 %)";
        string alkoholOpt2 = "Wino (12 %)";
        string alkoholOpt3 = "Whisky (35 %)";
        string alkoholOpt4 = "Wódka (50 %)";

        int alkoholVol1 = 5;
        int alkoholVol2 = 12;
        int alkoholVol3 = 35;
        int alkoholVol4 = 50;

        // Rodzaje i Pojemność Naczyń
        string capacityOpt1 = "Kufel do piwa (800 ml)";
        string capacityOpt2 = "Kieliszek do wina (150 ml)";
        string capacityOpt3 = "Szklanka do whisky (180 ml)";
        string capacityOpt4 = "Kieliszek do wódki (60 ml)";

        int alkoholCap1 = 800;
        int alkoholCap2 = 220;
        int alkoholCap3 = 180;
        int alkoholCap4 = 60;

        // Input Wprowadzającego
        double inputAlkohol = 0;
        int inputCapacity = 0;
        int inputAmount = 0;

        // Finalne Wartości
        double finalAlkoholCapacity = 0;
        double finalAlkoholVolume = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void labelBeerImagine_Click(object sender, EventArgs e)
        {

        }

        private void labelAlcohol_Click(object sender, EventArgs e)
        {

        }
        private void labelCapacity_Click(object sender, EventArgs e)
        {

        }

        private void labelAmount_Click(object sender, EventArgs e)
        {

        }
        private void labelResultText_Click(object sender, EventArgs e)
        {

        }

        private void labelResultText2_Click(object sender, EventArgs e)
        {

        }
        private void labelAlcoholResult_Click(object sender, EventArgs e)
        {

        }

        private void labelAmountResult_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            // Jak kolory ci nie pasują to mów jak cos bo sa słabe
            // plus ja ten przycisk po wyświetlenie wyniku zamieniłbym w cleara bo na cleara nie znalazlem miejsca i bedzie tak clean
        }

        private void comboBoxAlcohol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCapacity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAmount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
