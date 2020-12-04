using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CodeLog
{
    public partial class NewCodeSnippet : Form
    {
        private List<CodeSnippet> codeSnippets = new List<CodeSnippet>();
        private CodeSnippet returnCodeSnippet;
        private ProgramingLanguage programingLanguage;

        public NewCodeSnippet()
        {
            InitializeComponent();
        }

        public ProgramingLanguage ProgramingLanguage
        {
            get { return programingLanguage; }
            set { programingLanguage = value; }
        }

        public List<CodeSnippet> CodeSnippets
        {
            get { return codeSnippets; }
            set { codeSnippets = value; }
        }

        public CodeSnippet ReturnCodeSnippet
        {
            get { return returnCodeSnippet; }
            set { returnCodeSnippet = value; }
        }

        private void TXTBOX_CodeName_TextChanged(object sender, EventArgs e)
        {
            if (TXTBOX_CodeName.Text != "")
            {
                if (codeSnippets.Count != 0)
                {
                    foreach (var codeSnippet in codeSnippets)
                    {
                        if (codeSnippet.Name.ToLower() != TXTBOX_CodeName.Text.ToLower())
                        {
                            BTN_AddCode.Enabled = true;
                        }
                        else
                        {
                            BTN_AddCode.Enabled = false;
                            break;
                        }
                    }
                }
                else
                {
                    BTN_AddCode.Enabled = true;
                }
            }
            else
            {
                BTN_AddCode.Enabled = false;
            }
        }

        private void BTN_AddCode_Click(object sender, EventArgs e)
        {
            returnCodeSnippet = new CodeSnippet(0, programingLanguage.Id, TXTBOX_CodeName.Text, TXTBOX_Code.Text, TXTBOX_CodeDescription.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
