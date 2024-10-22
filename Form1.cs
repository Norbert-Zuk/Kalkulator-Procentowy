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

        private void getUserInput()
        {
            inputAlkohol = getComboBoxInput(comboBoxAlcohol, alkoholOpt1, alkoholOpt2, alkoholOpt3, alkoholOpt4,
                alkoholVol1, alkoholVol2, alkoholVol3, alkoholVol4);
            inputCapacity = getComboBoxInput(comboBoxCapacity, capacityOpt1, capacityOpt2, capacityOpt3, capacityOpt4,
                alkoholCap1, alkoholCap2, alkoholCap3, alkoholCap4);
            inputAmount = tryParseInput(textBoxAmount.Text);
        }

        // Return -1 oznacza błąd (ale nie wiem czy to dobra praktyka)
        private int tryParseInput(String input)
        {
            if (int.TryParse(input, out int result))
            {
                if (result < 0)
                {
                    return -1;
                }
                return result;
            }
            else
            {
                return -1;
            }
        }

        private int getComboBoxInput(System.Windows.Forms.ComboBox comboBox,
            string Option1, string Option2, string Option3, string Option4,
            int value1, int value2, int value3, int value4)
        {
            string selectedOption = comboBox.Text;
            int value = 0;

            if (selectedOption == Option1)
            {
                value = value1;
            }
            else if (selectedOption == Option2)
            {
                value = value2;
            }
            else if (selectedOption == Option3)
            {
                value = value3;
            }
            else if (selectedOption == Option4)
            {
                value = value4;
            }
            else
            {
                value = tryParseInput(comboBox.Text);
            }

            return value;
        }

        private void addComboBoxItems()
        {
            comboBoxAlcohol.Items.Add(alkoholOpt1);
            comboBoxAlcohol.Items.Add(alkoholOpt2);
            comboBoxAlcohol.Items.Add(alkoholOpt3);
            comboBoxAlcohol.Items.Add(alkoholOpt4);

            comboBoxCapacity.Items.Add(capacityOpt1);
            comboBoxCapacity.Items.Add(capacityOpt2);
            comboBoxCapacity.Items.Add(capacityOpt3);
            comboBoxCapacity.Items.Add(capacityOpt4);
        }

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
