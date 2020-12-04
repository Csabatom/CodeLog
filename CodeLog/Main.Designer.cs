namespace CodeLog
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TC_ProgramingLanguages = new System.Windows.Forms.TabControl();
            this.ProgramingLanguage = new System.Windows.Forms.TabPage();
            this.PANEL_CodeDescription = new System.Windows.Forms.Panel();
            this.GB_CodeDescription = new System.Windows.Forms.GroupBox();
            this.LBL_CodeDescription = new System.Windows.Forms.Label();
            this.TXTBOX_Code = new System.Windows.Forms.TextBox();
            this.LB_CodeName = new System.Windows.Forms.ListBox();
            this.NewProgramingLanguageForm = new System.Windows.Forms.TabPage();
            this.BTN_AddProgramingLanguage = new System.Windows.Forms.Button();
            this.TXTBOX_ProgramingLanguageName = new System.Windows.Forms.TextBox();
            this.GB_AboutSoftware = new System.Windows.Forms.GroupBox();
            this.LBL_SoftwareDescription = new System.Windows.Forms.Label();
            this.BTN_DeleteProgramingLanguage = new System.Windows.Forms.Button();
            this.BTN_DeleteCode = new System.Windows.Forms.Button();
            this.TC_ProgramingLanguages.SuspendLayout();
            this.ProgramingLanguage.SuspendLayout();
            this.PANEL_CodeDescription.SuspendLayout();
            this.GB_CodeDescription.SuspendLayout();
            this.NewProgramingLanguageForm.SuspendLayout();
            this.GB_AboutSoftware.SuspendLayout();
            this.SuspendLayout();
            // 
            // TC_ProgramingLanguages
            // 
            this.TC_ProgramingLanguages.Controls.Add(this.ProgramingLanguage);
            this.TC_ProgramingLanguages.Controls.Add(this.NewProgramingLanguageForm);
            this.TC_ProgramingLanguages.Location = new System.Drawing.Point(13, 12);
            this.TC_ProgramingLanguages.Name = "TC_ProgramingLanguages";
            this.TC_ProgramingLanguages.SelectedIndex = 0;
            this.TC_ProgramingLanguages.Size = new System.Drawing.Size(619, 437);
            this.TC_ProgramingLanguages.TabIndex = 10;
            this.TC_ProgramingLanguages.SelectedIndexChanged += new System.EventHandler(this.TC_ProgramingLanguages_SelectedIndexChanged);
            // 
            // ProgramingLanguage
            // 
            this.ProgramingLanguage.Controls.Add(this.PANEL_CodeDescription);
            this.ProgramingLanguage.Controls.Add(this.TXTBOX_Code);
            this.ProgramingLanguage.Controls.Add(this.LB_CodeName);
            this.ProgramingLanguage.Location = new System.Drawing.Point(4, 30);
            this.ProgramingLanguage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProgramingLanguage.Name = "ProgramingLanguage";
            this.ProgramingLanguage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProgramingLanguage.Size = new System.Drawing.Size(611, 403);
            this.ProgramingLanguage.TabIndex = 0;
            this.ProgramingLanguage.Text = "Programozási Nyelv";
            this.ProgramingLanguage.UseVisualStyleBackColor = true;
            // 
            // PANEL_CodeDescription
            // 
            this.PANEL_CodeDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PANEL_CodeDescription.Controls.Add(this.GB_CodeDescription);
            this.PANEL_CodeDescription.Location = new System.Drawing.Point(199, 307);
            this.PANEL_CodeDescription.Name = "PANEL_CodeDescription";
            this.PANEL_CodeDescription.Size = new System.Drawing.Size(412, 96);
            this.PANEL_CodeDescription.TabIndex = 3;
            // 
            // GB_CodeDescription
            // 
            this.GB_CodeDescription.Controls.Add(this.LBL_CodeDescription);
            this.GB_CodeDescription.Location = new System.Drawing.Point(9, 7);
            this.GB_CodeDescription.Name = "GB_CodeDescription";
            this.GB_CodeDescription.Size = new System.Drawing.Size(392, 80);
            this.GB_CodeDescription.TabIndex = 4;
            this.GB_CodeDescription.TabStop = false;
            this.GB_CodeDescription.Text = "Megjegyzés";
            // 
            // LBL_CodeDescription
            // 
            this.LBL_CodeDescription.Font = new System.Drawing.Font("Montserrat", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_CodeDescription.ForeColor = System.Drawing.Color.Gray;
            this.LBL_CodeDescription.Location = new System.Drawing.Point(7, 26);
            this.LBL_CodeDescription.Name = "LBL_CodeDescription";
            this.LBL_CodeDescription.Size = new System.Drawing.Size(383, 53);
            this.LBL_CodeDescription.TabIndex = 0;
            this.LBL_CodeDescription.Text = "A kódrészlet arra jó, hogy a placeholdert, ami az előző verziójú C# formokban nem" +
    " létezik, helyettesítse";
            // 
            // TXTBOX_Code
            // 
            this.TXTBOX_Code.Location = new System.Drawing.Point(199, 0);
            this.TXTBOX_Code.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TXTBOX_Code.Multiline = true;
            this.TXTBOX_Code.Name = "TXTBOX_Code";
            this.TXTBOX_Code.Size = new System.Drawing.Size(412, 308);
            this.TXTBOX_Code.TabIndex = 2;
            // 
            // LB_CodeName
            // 
            this.LB_CodeName.FormattingEnabled = true;
            this.LB_CodeName.IntegralHeight = false;
            this.LB_CodeName.ItemHeight = 21;
            this.LB_CodeName.Location = new System.Drawing.Point(0, 0);
            this.LB_CodeName.Margin = new System.Windows.Forms.Padding(0);
            this.LB_CodeName.Name = "LB_CodeName";
            this.LB_CodeName.Size = new System.Drawing.Size(204, 403);
            this.LB_CodeName.TabIndex = 0;
            // 
            // NewProgramingLanguageForm
            // 
            this.NewProgramingLanguageForm.Controls.Add(this.BTN_AddProgramingLanguage);
            this.NewProgramingLanguageForm.Controls.Add(this.TXTBOX_ProgramingLanguageName);
            this.NewProgramingLanguageForm.Location = new System.Drawing.Point(4, 30);
            this.NewProgramingLanguageForm.Margin = new System.Windows.Forms.Padding(0);
            this.NewProgramingLanguageForm.Name = "NewProgramingLanguageForm";
            this.NewProgramingLanguageForm.Size = new System.Drawing.Size(611, 403);
            this.NewProgramingLanguageForm.TabIndex = 1;
            this.NewProgramingLanguageForm.Text = "Új (+)";
            this.NewProgramingLanguageForm.UseVisualStyleBackColor = true;
            // 
            // BTN_AddProgramingLanguage
            // 
            this.BTN_AddProgramingLanguage.Enabled = false;
            this.BTN_AddProgramingLanguage.Location = new System.Drawing.Point(229, 197);
            this.BTN_AddProgramingLanguage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTN_AddProgramingLanguage.Name = "BTN_AddProgramingLanguage";
            this.BTN_AddProgramingLanguage.Size = new System.Drawing.Size(141, 30);
            this.BTN_AddProgramingLanguage.TabIndex = 1;
            this.BTN_AddProgramingLanguage.Text = "Hozzáadás";
            this.BTN_AddProgramingLanguage.UseVisualStyleBackColor = true;
            this.BTN_AddProgramingLanguage.Click += new System.EventHandler(this.BTN_AddProgramingLanguage_Click);
            // 
            // TXTBOX_ProgramingLanguageName
            // 
            this.TXTBOX_ProgramingLanguageName.Location = new System.Drawing.Point(152, 165);
            this.TXTBOX_ProgramingLanguageName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TXTBOX_ProgramingLanguageName.Name = "TXTBOX_ProgramingLanguageName";
            this.TXTBOX_ProgramingLanguageName.PlaceholderText = "Programnyelv neve";
            this.TXTBOX_ProgramingLanguageName.Size = new System.Drawing.Size(289, 26);
            this.TXTBOX_ProgramingLanguageName.TabIndex = 0;
            this.TXTBOX_ProgramingLanguageName.TextChanged += new System.EventHandler(this.TXTBOX_ProgramingLanguageName_TextChanged);
            // 
            // GB_AboutSoftware
            // 
            this.GB_AboutSoftware.Controls.Add(this.LBL_SoftwareDescription);
            this.GB_AboutSoftware.ForeColor = System.Drawing.Color.Gray;
            this.GB_AboutSoftware.Location = new System.Drawing.Point(638, 226);
            this.GB_AboutSoftware.Name = "GB_AboutSoftware";
            this.GB_AboutSoftware.Size = new System.Drawing.Size(149, 219);
            this.GB_AboutSoftware.TabIndex = 13;
            this.GB_AboutSoftware.TabStop = false;
            this.GB_AboutSoftware.Text = "A CodeLog-ról";
            // 
            // LBL_SoftwareDescription
            // 
            this.LBL_SoftwareDescription.Font = new System.Drawing.Font("Montserrat", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_SoftwareDescription.Location = new System.Drawing.Point(6, 34);
            this.LBL_SoftwareDescription.Name = "LBL_SoftwareDescription";
            this.LBL_SoftwareDescription.Size = new System.Drawing.Size(137, 167);
            this.LBL_SoftwareDescription.TabIndex = 0;
            this.LBL_SoftwareDescription.Text = "A program a Trophien© Bt. tulajdona. Az alkalmazás használatával tud már megírt k" +
    "ódokat elmenteni, és később újra felhasználni.";
            // 
            // BTN_DeleteProgramingLanguage
            // 
            this.BTN_DeleteProgramingLanguage.Location = new System.Drawing.Point(638, 42);
            this.BTN_DeleteProgramingLanguage.Name = "BTN_DeleteProgramingLanguage";
            this.BTN_DeleteProgramingLanguage.Size = new System.Drawing.Size(149, 84);
            this.BTN_DeleteProgramingLanguage.TabIndex = 11;
            this.BTN_DeleteProgramingLanguage.Text = "Kijelölt programozási nyelv törlése";
            this.BTN_DeleteProgramingLanguage.UseVisualStyleBackColor = true;
            // 
            // BTN_DeleteCode
            // 
            this.BTN_DeleteCode.Location = new System.Drawing.Point(638, 132);
            this.BTN_DeleteCode.Name = "BTN_DeleteCode";
            this.BTN_DeleteCode.Size = new System.Drawing.Size(149, 84);
            this.BTN_DeleteCode.TabIndex = 12;
            this.BTN_DeleteCode.Text = "Kijelölt kód törlése";
            this.BTN_DeleteCode.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.TC_ProgramingLanguages);
            this.Controls.Add(this.GB_AboutSoftware);
            this.Controls.Add(this.BTN_DeleteProgramingLanguage);
            this.Controls.Add(this.BTN_DeleteCode);
            this.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Main";
            this.Text = "Form1";
            this.TC_ProgramingLanguages.ResumeLayout(false);
            this.ProgramingLanguage.ResumeLayout(false);
            this.ProgramingLanguage.PerformLayout();
            this.PANEL_CodeDescription.ResumeLayout(false);
            this.GB_CodeDescription.ResumeLayout(false);
            this.NewProgramingLanguageForm.ResumeLayout(false);
            this.NewProgramingLanguageForm.PerformLayout();
            this.GB_AboutSoftware.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TC_ProgramingLanguages;
        private System.Windows.Forms.TabPage ProgramingLanguage;
        private System.Windows.Forms.TextBox TXTBOX_Code;
        private System.Windows.Forms.ListBox LB_CodeName;
        private System.Windows.Forms.TabPage NewProgramingLanguageForm;
        private System.Windows.Forms.Button BTN_AddProgramingLanguage;
        private System.Windows.Forms.TextBox TXTBOX_ProgramingLanguageName;
        private System.Windows.Forms.GroupBox GB_AboutSoftware;
        private System.Windows.Forms.Label LBL_SoftwareDescription;
        private System.Windows.Forms.Button BTN_DeleteProgramingLanguage;
        private System.Windows.Forms.Button BTN_DeleteCode;
        private System.Windows.Forms.Panel PANEL_CodeDescription;
        private System.Windows.Forms.GroupBox GB_CodeDescription;
        private System.Windows.Forms.Label LBL_CodeDescription;
    }
}

