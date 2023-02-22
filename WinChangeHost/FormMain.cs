using System.Diagnostics;
using System.Security;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace WinChangeHost
{
    public partial class FormMain : Form
    {
        private OpenFileDialog openFileDialog1;

        public FormMain()
        {
            InitializeComponent();
            comboBoxProtocolloPartenza.SelectedItem = "HTTPS"; // 
            comboBoxProtocolloDestinazione.SelectedItem = "HTTPS"; // 

            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a text or sql file",
                Filter = "Database files |*.txt;*.sql",
                Title = "Open Database file"
            };
        }

        private void buttonScegliFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog1.FileName;
                textBoxFileDatabase.Text = filePath;
            }
        }

        private void textBoxFileDatabase_TextChanged(object sender, EventArgs e)
        {
            abilitaDisabilita_Button_Salva();
        }

        private void textBoxDominioPartenza_TextChanged(object sender, EventArgs e)
        {
            abilitaDisabilita_Button_Salva();
        }

        private void textBoxDominioDestinazione_TextChanged(object sender, EventArgs e)
        {
            abilitaDisabilita_Button_Salva();
        }

        private void comboBoxProtocollo_SelectedIndexChanged(object sender, EventArgs e)
        {
            abilitaDisabilita_Button_Salva();
        }


        private void abilitaDisabilita_Button_Salva()
        {
            buttonSalva.Enabled = (
                !string.IsNullOrEmpty(textBoxFileDatabase.Text.Trim())
                && !string.IsNullOrEmpty(textBoxDominioPartenza.Text.Trim())
                && !string.IsNullOrEmpty(textBoxDominioDestinazione.Text.Trim())
                );
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            if(!System.IO.File.Exists(textBoxFileDatabase.Text))
            {
                MessageBox.Show("Il file " + textBoxFileDatabase.Text + " non esiste");
                return;
            }
            
            string content = File.ReadAllText(textBoxFileDatabase.Text.Trim());
            if(string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Il file " + textBoxFileDatabase.Text + " è vuoto");
                return;
            }


            string DominioPartenza = textBoxDominioPartenza.Text.Trim().ToLower();
            string DominioDestinazione = textBoxDominioDestinazione.Text.Trim().ToLower();
            string ProtocolloPartenza = comboBoxProtocolloPartenza.SelectedItem.ToString().ToLower();
            string ProtocolloDestinazione = comboBoxProtocolloDestinazione.SelectedItem.ToString().ToLower();

            //if (Regex.IsMatch(DominioPartenza, @" # Rev:2013-03-26
            //        # Match DNS host domain having one or more subdomains.
            //        # Top level domain subset taken from IANA.ORG. See:
            //        # http://data.iana.org/TLD/tlds-alpha-by-domain.txt
            //        ^                  # Anchor to start of string.
            //        (?!.{256})         # Whole domain must be 255 or less.
            //        (?:                # Group for one or more sub-domains.
            //          [a-z0-9]         # Either subdomain length from 2-63.
            //          [a-z0-9-]{0,61}  # Middle part may have dashes.
            //          [a-z0-9]         # Starts and ends with alphanum.
            //          \.               # Dot separates subdomains.
            //        | [a-z0-9]         # or subdomain length == 1 char.
            //          \.               # Dot separates subdomains.
            //        )+                 # One or more sub-domains.
            //        (?:                # Top level domain alternatives.
            //          [a-z]{2}         # Either any 2 char country code,
            //        | AERO|ARPA|ASIA|BIZ|CAT|COM|COOP|EDU|  # or TLD 
            //          GOV|INFO|INT|JOBS|MIL|MOBI|MUSEUM|    # from list.
            //          NAME|NET|ORG|POST|PRO|TEL|TRAVEL|XXX  # IANA.ORG
            //        )                  # End group of TLD alternatives.
            //        $                  # Anchor to end of string.",
            //        RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace))
            //{
            //    // Valid named DNS host (domain).
            //}
            //else
            //{
            //    // NOT a valid named DNS host.
            //    MessageBox.Show("Il dominio " + DominioPartenza + " non è corretto");
            //    return;
            //}

            //if (Regex.IsMatch(DominioDestinazione, @" # Rev:2013-03-26
            //        # Match DNS host domain having one or more subdomains.
            //        # Top level domain subset taken from IANA.ORG. See:
            //        # http://data.iana.org/TLD/tlds-alpha-by-domain.txt
            //        ^                  # Anchor to start of string.
            //        (?!.{256})         # Whole domain must be 255 or less.
            //        (?:                # Group for one or more sub-domains.
            //          [a-z0-9]         # Either subdomain length from 2-63.
            //          [a-z0-9-]{0,61}  # Middle part may have dashes.
            //          [a-z0-9]         # Starts and ends with alphanum.
            //          \.               # Dot separates subdomains.
            //        | [a-z0-9]         # or subdomain length == 1 char.
            //          \.               # Dot separates subdomains.
            //        )+                 # One or more sub-domains.
            //        (?:                # Top level domain alternatives.
            //          [a-z]{2}         # Either any 2 char country code,
            //        | AERO|ARPA|ASIA|BIZ|CAT|COM|COOP|EDU|  # or TLD 
            //          GOV|INFO|INT|JOBS|MIL|MOBI|MUSEUM|    # from list.
            //          NAME|NET|ORG|POST|PRO|TEL|TRAVEL|XXX  # IANA.ORG
            //        )                  # End group of TLD alternatives.
            //        $                  # Anchor to end of string.",
            //        RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace))
            //{
            //    // Valid named DNS host (domain).
            //}
            //else
            //{
            //    // NOT a valid named DNS host.
            //    MessageBox.Show("Il dominio " + DominioDestinazione + " non è corretto");
            //    return;
            //}


            string sout = Regex.Replace(content, ProtocolloPartenza + "://" + DominioPartenza, ProtocolloDestinazione + "://" + DominioDestinazione);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "text file|*.txt";
            saveFileDialog1.Title = "Save text file";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, sout);
            }

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}