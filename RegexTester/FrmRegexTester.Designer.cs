namespace RegexTester
{
    partial class FrmRegexTester
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTest = new System.Windows.Forms.Button();
            this.tbxPattern = new System.Windows.Forms.TextBox();
            this.gbxPattern = new System.Windows.Forms.GroupBox();
            this.gbxInput = new System.Windows.Forms.GroupBox();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.gbxResult = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.gbxDefaultPatterns = new System.Windows.Forms.GroupBox();
            this.listPatterns = new System.Windows.Forms.ComboBox();
            this.gbxPattern.SuspendLayout();
            this.gbxInput.SuspendLayout();
            this.gbxResult.SuspendLayout();
            this.gbxDefaultPatterns.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(18, 215);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(348, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.TabStop = false;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tbxPattern
            // 
            this.tbxPattern.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPattern.Location = new System.Drawing.Point(6, 19);
            this.tbxPattern.Name = "tbxPattern";
            this.tbxPattern.Size = new System.Drawing.Size(348, 19);
            this.tbxPattern.TabIndex = 0;
            // 
            // gbxPattern
            // 
            this.gbxPattern.Controls.Add(this.tbxPattern);
            this.gbxPattern.Location = new System.Drawing.Point(12, 83);
            this.gbxPattern.Name = "gbxPattern";
            this.gbxPattern.Size = new System.Drawing.Size(360, 60);
            this.gbxPattern.TabIndex = 5;
            this.gbxPattern.TabStop = false;
            this.gbxPattern.Text = "Pattern";
            // 
            // gbxInput
            // 
            this.gbxInput.Controls.Add(this.tbxInput);
            this.gbxInput.Location = new System.Drawing.Point(12, 149);
            this.gbxInput.Name = "gbxInput";
            this.gbxInput.Size = new System.Drawing.Size(360, 60);
            this.gbxInput.TabIndex = 6;
            this.gbxInput.TabStop = false;
            this.gbxInput.Text = "Input";
            // 
            // tbxInput
            // 
            this.tbxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInput.Location = new System.Drawing.Point(6, 19);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(348, 19);
            this.tbxInput.TabIndex = 1;
            // 
            // gbxResult
            // 
            this.gbxResult.Controls.Add(this.labelResult);
            this.gbxResult.Location = new System.Drawing.Point(12, 244);
            this.gbxResult.Name = "gbxResult";
            this.gbxResult.Size = new System.Drawing.Size(360, 60);
            this.gbxResult.TabIndex = 7;
            this.gbxResult.TabStop = false;
            this.gbxResult.Text = "Result";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(6, 26);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(21, 20);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "...";
            // 
            // gbxDefaultPatterns
            // 
            this.gbxDefaultPatterns.Controls.Add(this.listPatterns);
            this.gbxDefaultPatterns.Location = new System.Drawing.Point(12, 12);
            this.gbxDefaultPatterns.Name = "gbxDefaultPatterns";
            this.gbxDefaultPatterns.Size = new System.Drawing.Size(360, 65);
            this.gbxDefaultPatterns.TabIndex = 8;
            this.gbxDefaultPatterns.TabStop = false;
            this.gbxDefaultPatterns.Text = "Registered Patterns";
            // 
            // listPatterns
            // 
            this.listPatterns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listPatterns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listPatterns.FormattingEnabled = true;
            this.listPatterns.Location = new System.Drawing.Point(6, 19);
            this.listPatterns.Name = "listPatterns";
            this.listPatterns.Size = new System.Drawing.Size(348, 21);
            this.listPatterns.TabIndex = 99;
            this.listPatterns.SelectedIndexChanged += new System.EventHandler(this.listPatterns_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 316);
            this.Controls.Add(this.gbxDefaultPatterns);
            this.Controls.Add(this.gbxResult);
            this.Controls.Add(this.gbxInput);
            this.Controls.Add(this.gbxPattern);
            this.Controls.Add(this.btnTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Regex Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxPattern.ResumeLayout(false);
            this.gbxPattern.PerformLayout();
            this.gbxInput.ResumeLayout(false);
            this.gbxInput.PerformLayout();
            this.gbxResult.ResumeLayout(false);
            this.gbxResult.PerformLayout();
            this.gbxDefaultPatterns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox tbxPattern;
        private System.Windows.Forms.GroupBox gbxPattern;
        private System.Windows.Forms.GroupBox gbxInput;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.GroupBox gbxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.GroupBox gbxDefaultPatterns;
        private System.Windows.Forms.ComboBox listPatterns;
    }
}

