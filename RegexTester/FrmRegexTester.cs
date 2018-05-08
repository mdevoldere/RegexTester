using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexTester
{
    public partial class FrmRegexTester : Form
    {

        const string emptyFields = "Les champs sont vides !";

        protected static Dictionary<string, string> defaultPatterns = new Dictionary<string, string>()
        {
            {"Alpahnumérique sans accent", @"^[0-9A-Za-z\s]+$"},
            {"Lettres sans accent", @"^[A-Za-z\s]+$"},
            {"Lettres avec accents", @"^[A-Za-zàâÂäÄéÉèÈêÊëËîÎïÏôÔöÖ\s]+$"},
            {"Lettres sans accent + tiret", @"^[A-Za-z\s\-]+$"},
            {"Lettres avec accents + tiret", @"^[A-Za-zàâÂäÄéÉèÈêÊëËîÎïÏôÔöÖ\s\-]+$"},
            {"Date Française", @"^(([1-2]\d|0[1-9]|[3][0-1])\/([0][1-9]|[1][0-2])\/[2][0-9]\d{2})$"},
            {"Code postal Français", @"^\d{5}$"}
        };

        protected bool regexMatch;

        public FrmRegexTester()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> item in defaultPatterns)
            {
                listPatterns.Items.Add(item.Key);
            }

            labelResult.Text = emptyFields;
            tbxPattern.Focus();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            labelResult.Text = "Traitement en cours...";
            labelResult.ForeColor = Color.DarkGray;

            if((tbxInput.Text.Length == 0) || (tbxPattern.Text.Length == 0))
            {
                labelResult.Text = emptyFields;
                MessageBox.Show(emptyFields);
                return;
            }

            try
            {
                regexMatch = Regex.IsMatch(tbxInput.Text, tbxPattern.Text);
                //MessageBox.Show(tbxPattern.Text + " \n" + tbxInput.Text +  " \n" +regexMatch.ToString());

                if (regexMatch)
                {
                    labelResult.Text = "Entrée valide !";
                    labelResult.ForeColor = Color.DarkGreen;
                }
                else
                {
                    labelResult.Text = "Entrée non valide !";
                    labelResult.ForeColor = Color.DarkRed;
                }

                labelResult.Text = regexMatch ? "Entrée valide !" : "Entrée non valide !";
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listPatterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = listPatterns.SelectedItem.ToString();

            tbxPattern.Text = defaultPatterns[item];

            //MessageBox.Show(item);
        }
    }
}
