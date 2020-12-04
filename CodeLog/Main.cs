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
            }
            catch (Exception ex)
            {

            }
            SQLCommand("CREATE TABLE IF NOT EXISTS ProgramingLanguages (id INTEGER PRIMARY KEY, name VARCHAR DEFAULT NULL)");
            SQLCommand("CREATE TABLE IF NOT EXISTS Codes (id INTEGER PRIMARY KEY, programinglanguage_id DEFAULT -1, name VARCHAR DEFAULT NULL, code VARCHAR DEFAULT NULL, description VARCHAR(170) DEFAULT NULL)");
        }

        private void BTN_AddProgramingLanguage_Click(object sender, EventArgs e)
        {
            if(TXTBOX_ProgramingLanguageName.Text != "")
            {
                TabPage tabPage = new TabPage();
                tabPage.Name = TXTBOX_ProgramingLanguageName.Text;
                tabPage.Text = TXTBOX_ProgramingLanguageName.Text;
                tabPage.CreateControl();
                TC_ProgramingLanguages.TabPages.Insert(TC_ProgramingLanguages.TabPages.Count-1, tabPage);

                tabPage.Controls.Add(this.LB_CodeName);
                tabPage.Controls.Add(this.TXTBOX_Code);
                tabPage.Controls.Add(this.GB_CodeDescription);
                tabPage.Controls.Add(this.LBL_CodeDescription);
                tabPage.Controls.Add(this.PANEL_CodeDescription);

                this.LB_CodeName.Items.Clear();
                this.LB_CodeName.Items.Add("Új kódrészlet (+)");

                SQLCommand("INSERT INTO ProgramingLanguages (name) VALUES('"+TXTBOX_ProgramingLanguageName.Text+"')");

                TC_ProgramingLanguages.SelectTab(TC_ProgramingLanguages.TabPages[TC_ProgramingLanguages.TabPages.Count - 2]);
                TXTBOX_ProgramingLanguageName.Text = "";
                BTN_AddProgramingLanguage.Enabled = false;
            }
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
                if (tabPage.Text == TXTBOX_ProgramingLanguageName.Text)
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
            if(TC_ProgramingLanguages.SelectedTab.Name != "NewProgramingLanguageForm")
            {
                TabPage tabPage = TC_ProgramingLanguages.SelectedTab;
                tabPage.Controls.Add(this.LB_CodeName);
                tabPage.Controls.Add(this.TXTBOX_Code);
                tabPage.Controls.Add(this.GB_CodeDescription);
                tabPage.Controls.Add(this.LBL_CodeDescription);
                tabPage.Controls.Add(this.PANEL_CodeDescription);

                this.LB_CodeName.Items.Clear();
                SQLiteDataReader reader = SQLCommand("SELECT * FROM Codes");
                while (reader.Read())
                {
                    this.LB_CodeName.Items.Add(new CodeSnippet(int.Parse(reader["id"].ToString()), int.Parse(reader["programinglanguage_id"].ToString()), reader["name"].ToString(), reader["code"].ToString(), reader["description"].ToString()));
                }
                this.LB_CodeName.Items.Add("Új kódrészlet (+)");
            }
        }
    }
}
