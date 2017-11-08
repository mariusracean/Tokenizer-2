using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Tokenizer_2.Validation;

namespace Tokenizer_2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            base.Close();
        }

        private void AutocompleteCombobox(object sender, EventArgs e)
        {
            string text = this.CountryComboBox.Text;
            if (text != null)
            {
                if (text == "Australia")
                {
                    this.GroupIDComboBox.SelectedIndex = this.GroupIDComboBox.FindStringExact("ERP LN 408");
                    this.CultureComboBox.SelectedIndex = this.CultureComboBox.FindStringExact("en-AU");
                    this.UserIDComboBox.DataSource = Enum.GetValues(typeof(AUS));
                    this.UserIDComboBox.SelectedIndex = -1;

                }
                else if (text == "Canada")
                {
                    this.GroupIDComboBox.SelectedIndex = this.GroupIDComboBox.FindStringExact("ERP LN 100");
                    this.CultureComboBox.SelectedIndex = this.CultureComboBox.FindStringExact("en-CA");
                    this.UserIDComboBox.DataSource = Enum.GetValues(typeof(CAN));
                    this.UserIDComboBox.SelectedIndex = -1;
                }
                else if (text == "Ireland")
                {
                    this.GroupIDComboBox.SelectedIndex = this.GroupIDComboBox.FindStringExact("ERP LN 387");
                    this.CultureComboBox.SelectedIndex = this.CultureComboBox.FindStringExact("en-IE");
                    this.UserIDComboBox.DataSource = Enum.GetValues(typeof(IRL));
                    this.UserIDComboBox.SelectedIndex = -1;
                }
                else if (text == "New-Zealand")
                {
                    this.GroupIDComboBox.SelectedIndex = this.GroupIDComboBox.FindStringExact("ERP LN 408");
                    this.CultureComboBox.SelectedIndex = this.CultureComboBox.FindStringExact("en-NZ");
                    this.UserIDComboBox.DataSource = Enum.GetValues(typeof(NZL));
                    this.UserIDComboBox.SelectedIndex = -1;
                }
                else if (text == "United Kingdom")
                {
                    this.GroupIDComboBox.SelectedIndex = this.GroupIDComboBox.FindStringExact("ERP LN 387");
                    this.CultureComboBox.SelectedIndex = this.CultureComboBox.FindStringExact("en-GB");
                    this.UserIDComboBox.DataSource = Enum.GetValues(typeof(UK));
                    this.UserIDComboBox.SelectedIndex = -1;
                }
                else if (text == "United States")
                {
                    this.GroupIDComboBox.SelectedIndex = this.GroupIDComboBox.FindStringExact("ERP LN 130");
                    this.CultureComboBox.SelectedIndex = this.CultureComboBox.FindStringExact("en-US");
                    this.UserIDComboBox.DataSource = Enum.GetValues(typeof(USA));
                    this.UserIDComboBox.SelectedIndex = -1;
                }
            }
        }

        private void AutoCompleteClientKey(object sender, EventArgs e)
        {
            var user = this.UserIDComboBox.SelectedItem;
            if (user != null)
            {
                int clientkey = (int)user;
                this.ClientKeyTextBox.Text = clientkey.ToString();
            }
        }


        private Country GetCountryCodeFromString()
        {
            Country result;
            Country userCountry;
            string text = this.CountryComboBox.Text;
            if (text != null)
            {
                switch (text)
                {
                    case "Australia":
                        {
                            result = Country.Aus;
                            break;
                        }
                    case "Canada":
                        {
                            result = Country.Can;
                            break;
                        }
                    case "Ireland":
                        {
                            result = Country.Irl;
                            break;
                        }
                    case "New-Zealand":
                        {
                            result = Country.Nzl;
                            break;
                        }
                    case "United Kingdom":
                        {
                            result = Country.Gbr;
                            break;
                        }
                    case "United States":
                        {
                            result = Country.Usa;
                            break;
                        }
                    default:
                        {
                            result = Country.None;
                            userCountry = result;
                            return userCountry;
                        }
                }
            }
            else
            {
                result = Country.None;
                userCountry = result;
                return userCountry;
            }
            userCountry = result;
            return userCountry;
        }

        private void ToggleClientKeyBox(object sender, EventArgs e)
        {
            if (WRTokenRadioButton.Checked)
            {
                ClientKeyTextBox.Enabled = true;
            }
            else
            {
                ClientKeyTextBox.Enabled = false;
            }
        }

        private void GenerateToken(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            string country = CountryComboBox.Text;
            string userName = UserIDComboBox.Text;
            string clientKey = ClientKeyTextBox.Text;
            string validation = ValidateClientKey(clientKey);
            if (validation != String.Empty && WRTokenRadioButton.Checked)
            {
                ErrorLabel.Text = validation;
                ErrorLabel.Visible = true;
            }
            else
            {
                validation = ValidateUserName(userName);
                if (validation != String.Empty)
                {
                    ErrorLabel.Text = validation;
                    ErrorLabel.Visible = true;
                }
                else
                {
                    validation = ValidateCountry(country);
                    if (validation != String.Empty)
                    {
                        ErrorLabel.Text = validation;
                        ErrorLabel.Visible = true;
                    }
                    else
                    {
                        ////aici am ajuns!!!
                    }
                }
            }
        }
    }
}
