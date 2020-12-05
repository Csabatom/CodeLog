using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLog
{
    public partial class Main : Form
    {
        private SQLiteConnection conn;

        public Main()
        {
            InitializeComponent();

            TC_ProgramingLanguages.TabPages.RemoveAt(0);
            conn = new SQLiteConnection("Data Source=CodeLog.db;");
            try
            {
                conn.Open();
                LoadProgramingLanguagesList(-2);
            }
            catch (Exception ex)
            {

            }
            SQLCommand("CREATE TABLE IF NOT EXISTS ProgramingLanguages (id INTEGER PRIMARY KEY, name VARCHAR DEFAULT NULL)");
            SQLCommand("CREATE TABLE IF NOT EXISTS Codes (id INTEGER PRIMARY KEY, programinglanguage_id DEFAULT -1, name VARCHAR DEFAULT NULL, code VARCHAR DEFAULT NULL, description VARCHAR(170) DEFAULT NULL)");

            BTN_DeleteProgramingLanguage.Hide();
            BTN_DeleteCode.Hide();
            BTN_SaveChanges.Hide();
            BTN_DropChanges.Hide();
        }

        private void BTN_AddProgramingLanguage_Click(object sender, EventArgs e)
        {
            SQLCommand("INSERT INTO ProgramingLanguages (name) VALUES('" + TXTBOX_ProgramingLanguageName.Text + "')");
            LoadProgramingLanguagesList(TC_ProgramingLanguages.TabPages.Count - 1);

            TabPage tabPage = TC_ProgramingLanguages.SelectedTab;
            tabPage.Controls.Add(this.LB_CodeName);
            tabPage.Controls.Add(this.TXTBOX_Code);
            tabPage.Controls.Add(this.TXTBOX_CodeDescription);
            BTN_DeleteProgramingLanguage.Show();
            BTN_DeleteCode.Show();
            BTN_DeleteCode.Enabled = false;

            LoadCodeSnippetList(-1);
            TXTBOX_ProgramingLanguageName.Text = "";
            BTN_AddProgramingLanguage.Enabled = false;
            BTN_DeleteCode.Enabled = false;
        }

        public SQLiteDataReader SQLCommand(String inputComm)
        {
            SQLiteCommand command;
            command = conn.CreateCommand();
            command.CommandText = inputComm;
            //command.ExecuteNonQuery();

            SQLiteDataReader reader;
            reader = command.ExecuteReader();
            return reader;
        }

        private void TXTBOX_ProgramingLanguageName_TextChanged(object sender, EventArgs e)
        {
            foreach (var page in TC_ProgramingLanguages.TabPages)
            {
                TabPage tabPage = (TabPage)page;
                if (tabPage.Text.ToLower() == TXTBOX_ProgramingLanguageName.Text.ToLower())
                {
                    BTN_AddProgramingLanguage.Enabled = false;
                    break;
                }
                else
                {
                    if(TXTBOX_ProgramingLanguageName.Text != "")
                    {
                        BTN_AddProgramingLanguage.Enabled = true;
                    }
                }
            }
        }

        private void TC_ProgramingLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TC_ProgramingLanguages.SelectedIndex != -1)
            {
                if(TC_ProgramingLanguages.SelectedTab.Name != "NewProgramingLanguageForm")
            {
                TabPage tabPage = TC_ProgramingLanguages.SelectedTab;
                tabPage.Controls.Add(this.LB_CodeName);
                tabPage.Controls.Add(this.TXTBOX_Code);
                tabPage.Controls.Add(this.TXTBOX_CodeDescription);
                BTN_DeleteProgramingLanguage.Show();
                BTN_DeleteCode.Show();
                BTN_DeleteCode.Enabled = false;

                    this.TXTBOX_Code.Text = "";
                this.TXTBOX_CodeDescription.Text = "";
                LoadCodeSnippetList(-1);
                GB_AboutSoftware.Size = new Size(149, 219);
            } else
            {
                BTN_DeleteProgramingLanguage.Hide();
                BTN_DeleteCode.Hide();
            }
            BTN_SaveChanges.Hide();
            BTN_DropChanges.Hide();
            LB_CodeName.Enabled = true;
            }
        }

        private void LB_CodeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_CodeName.SelectedIndex + 1 == LB_CodeName.Items.Count)
            {
                LB_CodeName.SelectedIndex = -1;
                BTN_DeleteCode.Enabled = false;
                using (var newCodeSnippet = new NewCodeSnippet())
                {
                    newCodeSnippet.ProgramingLanguage = new ProgramingLanguage(int.Parse(TC_ProgramingLanguages.SelectedTab.Name), TC_ProgramingLanguages.SelectedTab.Text);
                    List<CodeSnippet> codeSnippets = new List<CodeSnippet>();
                    foreach (var CodeSnippet in LB_CodeName.Items)
                    {
                        try
                        {
                            if ((String)CodeSnippet != "Új kódrészlet (+)") { }
                        }
                        catch
                        {
                            codeSnippets.Add((CodeSnippet)CodeSnippet);
                        }
                    }
                    newCodeSnippet.CodeSnippets = codeSnippets;
                    var result = newCodeSnippet.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.LB_CodeName.Items.Insert(LB_CodeName.Items.Count - 1, newCodeSnippet.ReturnCodeSnippet);
                        SQLCommand("INSERT INTO Codes (programinglanguage_id, name, code, description) VALUES ('" + newCodeSnippet.ReturnCodeSnippet.ProgramingLanguage_Id + "', '" + newCodeSnippet.ReturnCodeSnippet.Name + "', '" + newCodeSnippet.ReturnCodeSnippet.Code + "', '" + newCodeSnippet.ReturnCodeSnippet.Description + "')");
                        LoadCodeSnippetList(-1);
                    }
                }
            }
            else
            {
                if (LB_CodeName.SelectedIndex != -1)
                {
                    try
                    {
                        // BETÖLTENI A KÓD RÉSZLETEIT.
                        TXTBOX_Code.Text = ((CodeSnippet)LB_CodeName.SelectedItem).Code;
                        TXTBOX_CodeDescription.Text = ((CodeSnippet)LB_CodeName.SelectedItem).Description;
                        BTN_DeleteCode.Enabled = true;
                    }
                    catch { }
                }
            }
        }

        private void TXTBOX_Code_TextChanged(object sender, EventArgs e)
        {
            if(LB_CodeName.SelectedIndex != -1)
            {
                try
                {
                    if (((CodeSnippet)LB_CodeName.SelectedItem).Code != TXTBOX_Code.Text || ((CodeSnippet)LB_CodeName.SelectedItem).Description != TXTBOX_CodeDescription.Text)
                    {
                        BTN_SaveChanges.Show();
                        BTN_DropChanges.Show();
                        BTN_DeleteCode.Hide();
                        LB_CodeName.Enabled = false;
                    }
                    else
                    {
                        BTN_SaveChanges.Hide();
                        BTN_DropChanges.Hide();
                        BTN_DeleteCode.Show();
                        LB_CodeName.Enabled = true;
                    }
                }
                catch { }
            }
        }

        private void TXTBOX_CodeDescription_TextChanged(object sender, EventArgs e)
        {
            if(LB_CodeName.SelectedIndex != -1)
            {
                try
                {
                    if (((CodeSnippet)LB_CodeName.SelectedItem).Code != TXTBOX_Code.Text || ((CodeSnippet)LB_CodeName.SelectedItem).Description != TXTBOX_CodeDescription.Text)
                    {
                        BTN_SaveChanges.Show();
                        BTN_DropChanges.Show();
                        BTN_DeleteCode.Hide();
                        LB_CodeName.Enabled = false;
                    }
                    else
                    {
                        BTN_SaveChanges.Hide();
                        BTN_DropChanges.Hide();
                        BTN_DeleteCode.Show();
                        LB_CodeName.Enabled = true;
                    }
                }
                catch { }
            }
        }

        private void BTN_SaveChanges_Click(object sender, EventArgs e)
        {
            SQLCommand("UPDATE Codes SET code = '" + TXTBOX_Code.Text + "', description = '" + TXTBOX_CodeDescription.Text + "' WHERE id LIKE '" + ((CodeSnippet)LB_CodeName.SelectedItem).Id + "'");
            BTN_SaveChanges.Hide();
            BTN_DropChanges.Hide();
            BTN_DeleteCode.Show();
            LB_CodeName.Enabled = true;
            LoadCodeSnippetList(LB_CodeName.SelectedIndex);
        }

        private void BTN_DropChanges_Click(object sender, EventArgs e)
        {
            TXTBOX_Code.Text = ((CodeSnippet)LB_CodeName.SelectedItem).Code;
            TXTBOX_CodeDescription.Text = ((CodeSnippet)LB_CodeName.SelectedItem).Description;
            BTN_SaveChanges.Hide();
            BTN_DropChanges.Hide();
            BTN_DeleteCode.Show();
            LB_CodeName.Enabled = true;
        }

        private void LoadCodeSnippetList(int index)
        {
            LB_CodeName.Items.Clear();
            SQLiteDataReader reader = SQLCommand("SELECT * FROM Codes WHERE programinglanguage_id LIKE '" + TC_ProgramingLanguages.SelectedTab.Name + "'");
            while (reader.Read())
            {
                LB_CodeName.Items.Add(new CodeSnippet(int.Parse(reader["id"].ToString()), int.Parse(reader["programinglanguage_id"].ToString()), reader["name"].ToString(), reader["code"].ToString(), reader["description"].ToString()));
            }
            LB_CodeName.Items.Add("Új kódrészlet (+)");
            TXTBOX_Code.Text = "";
            TXTBOX_CodeDescription.Text = "";
            LB_CodeName.SelectedIndex = index;
        }

        private void LoadProgramingLanguagesList(int index)
        {
            TC_ProgramingLanguages.TabPages.Clear();
            SQLiteDataReader reader = SQLCommand("SELECT * FROM ProgramingLanguages");
            while (reader.Read())
            {
                ProgramingLanguage programingLanguage = new ProgramingLanguage(int.Parse(reader["id"].ToString()), reader["name"].ToString());
                TabPage tabPage = new TabPage();
                tabPage.Name = programingLanguage.Id.ToString();
                tabPage.Text = programingLanguage.Name;
                tabPage.CreateControl();
                TC_ProgramingLanguages.TabPages.Add(tabPage);
            }
            TC_ProgramingLanguages.TabPages.Add(this.NewProgramingLanguageForm);
            if(index == -2)
            {
                TC_ProgramingLanguages.SelectTab(TC_ProgramingLanguages.TabPages.Count - 1);
            } else
            {
                TC_ProgramingLanguages.SelectTab(index);
            }
        }

        private void BTN_DeleteProgramingLanguage_Click(object sender, EventArgs e)
        {
            SQLCommand("DELETE FROM Codes WHERE programinglanguage_id LIKE '" + TC_ProgramingLanguages.SelectedTab.Name + "'");
            SQLCommand("DELETE FROM ProgramingLanguages WHERE id LIKE '" + TC_ProgramingLanguages.SelectedTab.Name + "'");
            TC_ProgramingLanguages.TabPages.Remove(TC_ProgramingLanguages.SelectedTab);
            if(TC_ProgramingLanguages.TabPages.Count-2 >= 0)
            {
                TC_ProgramingLanguages.SelectedIndex = TC_ProgramingLanguages.TabPages.Count - 2;
            } else
            {
                TC_ProgramingLanguages.SelectedIndex = TC_ProgramingLanguages.TabPages.Count - 1;
            }
        }

        private void BTN_DeleteCode_Click(object sender, EventArgs e)
        {
            if(LB_CodeName.SelectedIndex != -1)
            {
                SQLCommand("DELETE FROM Codes WHERE id LIKE '" + ((CodeSnippet)LB_CodeName.SelectedItem).Id + "'");
                LoadCodeSnippetList(-1);
                BTN_DeleteCode.Enabled = false;
            }
        }
    }
}
