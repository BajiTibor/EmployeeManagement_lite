using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DatabaseManager_lite
{
    public partial class Form1 : Form
    {
        private readonly NewEmployeeCheck _employeeCheck = new NewEmployeeCheck();
        private DatabaseConnection _database;
        private string _host;
        private string _login;
        private string _showHidden = "";

        public Form1()
        {
            InitializeComponent();
            comboBox_add_state.SelectedIndex = 0;
            dateTimePicker_to.Value = DateTime.Now;
            tabPage_displayData.Enabled = false;
            tabPage_inputData.Enabled = false;
            dateTime_add_dob.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void LoadTableContent()
        {
            tabPage_displayData.Enabled = true;
            tabPage_inputData.Enabled = true;
            tabControl1.SelectedIndex = 1;
            tabPage_DatabaseLogin.Enabled = false;
            dataGridView1.DataSource = _database.GetTable(numericUpDown_limit.Text, _showHidden);
        }

        private void Btn_testCon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_pass.Text))
            {
                MessageBox.Show(DefinedStrings.er_login, DefinedStrings.er_login_cap);
            }
            else
            {
                _host = !string.IsNullOrWhiteSpace(txt_address.Text) ? txt_address.Text : "localhost";

                _login = !string.IsNullOrWhiteSpace(txt_login.Text) ? txt_login.Text : "root";


                _database = new DatabaseConnection(_host, _login,
                    txt_pass.Text);


                if (_database.IsPasswordCorrect())
                {
                    if (_database.TableExists())
                    {
                        LoadTableContent();
                    }
                    else
                    {
                        MessageBox.Show(DefinedStrings.inf_noTable);
                        _database.CreateSchema();
                        LoadTableContent();
                    }
                }
                else
                {
                    MessageBox.Show(DefinedStrings.er_invalidInf);
                }
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];
            label_CurrentId.Text = row.Cells["id"].Value.ToString();
            txt_mod_name.Text = row.Cells["nev"].Value.ToString();
            dateTime_mod_dob.Value = Convert.ToDateTime(row.Cells["szulido"].Value);
            txt_mod_phone.Text = row.Cells["telszam"].Value.ToString();
            txt_mod_edu.Text = row.Cells["vegzettseg"].Value.ToString();
            txt_mod_prof.Text = row.Cells["szakma"].Value.ToString();
            comboBox_mod_state.SelectedItem = row.Cells["statusz"].Value.ToString();
        }

        private void Button_modify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mod_name.Text)) return;

            if (Regex.IsMatch(txt_mod_phone.Text, @"^\(\+[1-9]\d\)\s[1-9]\d\s[1-9]\d\d\s\d{4}$"))
            {
                var employee = new Employee(label_CurrentId.Text, txt_mod_name.Text, dateTime_mod_dob.Value,
                    txt_mod_phone.Text, txt_mod_edu.Text, txt_mod_prof.Text, comboBox_mod_state.Text);

                _database.UpdateRecord(employee);
                LoadTableContent();
            }
            else
            {
                MessageBox.Show(DefinedStrings.er_phone);
            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txt_mod_phone.Text, @"^\(\+[1-9]\d\)\s[1-9]\d\s[1-9]\d\d\s\d{4}$"))
            {
                var employee = new Employee("0", txt_add_name.Text, dateTime_add_dob.Value,
                    txt_add_phone.Text, txt_add_edu.Text, txt_add_prof.Text, comboBox_add_state.Text);


                if (_employeeCheck.CheckEmployee(employee))
                {
                    _database.InsertNewRow(employee);
                    txt_add_edu.Clear();
                    txt_add_name.Clear();
                    txt_add_phone.Clear();
                    txt_add_prof.Clear();
                    dateTime_add_dob.Value = DateTime.Now;
                    LoadTableContent();
                }
                else
                {
                    MessageBox.Show(DefinedStrings.sql_inv_input);
                }
            }
            else
            {
                MessageBox.Show(DefinedStrings.er_phone);
            }
        }

        private void Button_removeEntity_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show(DefinedStrings.rem_employee, DefinedStrings.rem_employee_cap,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes) return;
            _database.SetExit(int.Parse(label_CurrentId.Text));
            LoadTableContent();
        }

        private void Button_reloadTable_Click(object sender, EventArgs e)
        {
            LoadTableContent();
        }

        private void NumericUpDown_limit_ValueChanged(object sender, EventArgs e)
        {
            LoadTableContent();
        }

        private void Txt_nameSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_nameSearch.Text))
            {
                dataGridView1.DataSource =
                    _database.GetNameSearch(numericUpDown_limit.Text, txt_nameSearch.Text);
            }
            else
            {
                LoadTableContent();
            }
        }

        private void Button_search_Click(object sender, EventArgs e)
        {
            txt_nameSearch.Clear();
            dataGridView1.DataSource = _database.GetFromTo(numericUpDown_limit.Text, _showHidden,
                dateTimePicker_from.Value,
                dateTimePicker_to.Value);
        }

        private void CheckBox_exited_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_exited.Checked)
            {
                _showHidden = "NOT";
                button_removeEntity.Enabled = false;
                button_modify.Enabled = false;
            }
            else
            {
                _showHidden = "";
                button_removeEntity.Enabled = true;
                button_modify.Enabled = true;
            }

            LoadTableContent();
        }

        private void Txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btn_testCon.PerformClick();
            }
        }
    }
}