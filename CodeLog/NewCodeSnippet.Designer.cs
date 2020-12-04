
namespace CodeLog
{
    partial class NewCodeSnippet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXTBOX_Code = new System.Windows.Forms.TextBox();
            this.TXTBOX_CodeName = new System.Windows.Forms.TextBox();
            this.BTN_AddCode = new System.Windows.Forms.Button();
            this.TXTBOX_CodeDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXTBOX_Code
            // 
            this.TXTBOX_Code.Location = new System.Drawing.Point(25, 60);
            this.TXTBOX_Code.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TXTBOX_Code.Multiline = true;
            this.TXTBOX_Code.Name = "TXTBOX_Code";
            this.TXTBOX_Code.PlaceholderText = "Kód";
            this.TXTBOX_Code.Size = new System.Drawing.Size(324, 215);
            this.TXTBOX_Code.TabIndex = 0;
            this.TXTBOX_Code.TabStop = false;
            // 
            // TXTBOX_CodeName
            // 
            this.TXTBOX_CodeName.Location = new System.Drawing.Point(25, 24);
            this.TXTBOX_CodeName.Name = "TXTBOX_CodeName";
            this.TXTBOX_CodeName.PlaceholderText = "Kódtöredék neve";
            this.TXTBOX_CodeName.Size = new System.Drawing.Size(324, 27);
            this.TXTBOX_CodeName.TabIndex = 0;
            this.TXTBOX_CodeName.TabStop = false;
            this.TXTBOX_CodeName.TextChanged += new System.EventHandler(this.TXTBOX_CodeName_TextChanged);
            // 
            // BTN_AddCode
            // 
            this.BTN_AddCode.Enabled = false;
            this.BTN_AddCode.Location = new System.Drawing.Point(25, 456);
            this.BTN_AddCode.Name = "BTN_AddCode";
            this.BTN_AddCode.Size = new System.Drawing.Size(324, 55);
            this.BTN_AddCode.TabIndex = 1;
            this.BTN_AddCode.Text = "Hozzáadás";
            this.BTN_AddCode.UseVisualStyleBackColor = true;
            this.BTN_AddCode.Click += new System.EventHandler(this.BTN_AddCode_Click);
            // 
            // TXTBOX_CodeDescription
            // 
            this.TXTBOX_CodeDescription.Location = new System.Drawing.Point(25, 285);
            this.TXTBOX_CodeDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TXTBOX_CodeDescription.Multiline = true;
            this.TXTBOX_CodeDescription.Name = "TXTBOX_CodeDescription";
            this.TXTBOX_CodeDescription.PlaceholderText = "Megjegyzés";
            this.TXTBOX_CodeDescription.Size = new System.Drawing.Size(324, 136);
            this.TXTBOX_CodeDescription.TabIndex = 0;
            this.TXTBOX_CodeDescription.TabStop = false;
            // 
            // NewCodeSnippet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 523);
            this.Controls.Add(this.TXTBOX_CodeDescription);
            this.Controls.Add(this.BTN_AddCode);
            this.Controls.Add(this.TXTBOX_CodeName);
            this.Controls.Add(this.TXTBOX_Code);
            this.Name = "NewCodeSnippet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCodeSnippet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTBOX_Code;
        private System.Windows.Forms.TextBox TXTBOX_CodeName;
        private System.Windows.Forms.Button BTN_AddCode;
        private System.Windows.Forms.TextBox TXTBOX_CodeDescription;
    }
}