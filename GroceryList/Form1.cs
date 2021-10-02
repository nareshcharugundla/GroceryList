using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryList
{
    public partial class Form1 : Form
    {
        public string filePath = @"E:\GitHub\GroceryList\grocery.json";
        public Form1()
        {
            InitializeComponent();
            //File.WriteAllText(filePath, string.Empty);
        }

        private void textBoxItems_Enter(object sender, EventArgs e)
        {
            textBoxItems.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (checkBoxApnaBazaar.Checked == false && checkBoxFredMeyer.Checked == false && checkBoxCostco.Checked == false && checkBoxWholeFoods.Checked == false)
            {
                MessageBox.Show("Please select the store:");
            }
            else
            {
                if (checkBoxWholeFoods.Checked)
                {
                    Common.SaveToFile(filePath, checkBoxWholeFoods, textBoxItems.Text);
                    textBoxItems.Clear();
                }
                else if (checkBoxFredMeyer.Checked)
                {
                    Common.SaveToFile(filePath, checkBoxFredMeyer, textBoxItems.Text);
                    textBoxItems.Clear();
                }
                else if (checkBoxApnaBazaar.Checked)
                {
                    Common.SaveToFile(filePath, checkBoxApnaBazaar, textBoxItems.Text);
                    textBoxItems.Clear();
                }
                else if (checkBoxCostco.Checked)
                {
                    Common.SaveToFile(filePath, checkBoxCostco, textBoxItems.Text);
                    textBoxItems.Clear();
                }
            }
        }

        private void buttonMail_Click(object sender, EventArgs e)
        {
            string To = "nachar@microsoft.com";
            string From = "nachar@microsoft.com";
            string server = "SMTPHOST.redmond.corp.microsoft.com";

            MailMessage msg = new MailMessage(From, To);
            msg.Subject = "Grocery - List";
            msg.Body = Common.GetMessageBody(filePath);

            SmtpClient client = new SmtpClient(server);
            client.UseDefaultCredentials = true;

            try
            {
                client.Send(msg);
                MessageBox.Show("Mail Sent Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}

