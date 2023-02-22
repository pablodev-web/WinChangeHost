namespace WinChangeHost
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonScegliFile = new System.Windows.Forms.Button();
            this.textBoxFileDatabase = new System.Windows.Forms.TextBox();
            this.textBoxDominioPartenza = new System.Windows.Forms.TextBox();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.textBoxDominioDestinazione = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProtocolloPartenza = new System.Windows.Forms.ComboBox();
            this.comboBoxProtocolloDestinazione = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Databse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dominio Partenza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dominio Destinazione";
            // 
            // buttonScegliFile
            // 
            this.buttonScegliFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonScegliFile.Location = new System.Drawing.Point(727, 28);
            this.buttonScegliFile.Name = "buttonScegliFile";
            this.buttonScegliFile.Size = new System.Drawing.Size(110, 30);
            this.buttonScegliFile.TabIndex = 3;
            this.buttonScegliFile.Text = "Scegli file";
            this.buttonScegliFile.UseVisualStyleBackColor = true;
            this.buttonScegliFile.Click += new System.EventHandler(this.buttonScegliFile_Click);
            // 
            // textBoxFileDatabase
            // 
            this.textBoxFileDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileDatabase.Location = new System.Drawing.Point(234, 28);
            this.textBoxFileDatabase.Name = "textBoxFileDatabase";
            this.textBoxFileDatabase.ReadOnly = true;
            this.textBoxFileDatabase.Size = new System.Drawing.Size(475, 30);
            this.textBoxFileDatabase.TabIndex = 4;
            this.textBoxFileDatabase.TextChanged += new System.EventHandler(this.textBoxFileDatabase_TextChanged);
            // 
            // textBoxDominioPartenza
            // 
            this.textBoxDominioPartenza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDominioPartenza.Location = new System.Drawing.Point(234, 84);
            this.textBoxDominioPartenza.Name = "textBoxDominioPartenza";
            this.textBoxDominioPartenza.Size = new System.Drawing.Size(475, 30);
            this.textBoxDominioPartenza.TabIndex = 5;
            this.textBoxDominioPartenza.TextChanged += new System.EventHandler(this.textBoxDominioPartenza_TextChanged);
            // 
            // buttonSalva
            // 
            this.buttonSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalva.Enabled = false;
            this.buttonSalva.Location = new System.Drawing.Point(8, 301);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(828, 57);
            this.buttonSalva.TabIndex = 6;
            this.buttonSalva.Text = "Salva Nuovo File";
            this.buttonSalva.UseVisualStyleBackColor = true;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // textBoxDominioDestinazione
            // 
            this.textBoxDominioDestinazione.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDominioDestinazione.Location = new System.Drawing.Point(234, 188);
            this.textBoxDominioDestinazione.Name = "textBoxDominioDestinazione";
            this.textBoxDominioDestinazione.Size = new System.Drawing.Size(475, 30);
            this.textBoxDominioDestinazione.TabIndex = 7;
            this.textBoxDominioDestinazione.TextChanged += new System.EventHandler(this.textBoxDominioDestinazione_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Protocollo Partenza";
            // 
            // comboBoxProtocolloPartenza
            // 
            this.comboBoxProtocolloPartenza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProtocolloPartenza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProtocolloPartenza.FormattingEnabled = true;
            this.comboBoxProtocolloPartenza.Items.AddRange(new object[] {
            "HTTPS",
            "HTTP"});
            this.comboBoxProtocolloPartenza.Location = new System.Drawing.Point(234, 134);
            this.comboBoxProtocolloPartenza.Name = "comboBoxProtocolloPartenza";
            this.comboBoxProtocolloPartenza.Size = new System.Drawing.Size(475, 31);
            this.comboBoxProtocolloPartenza.TabIndex = 9;
            this.comboBoxProtocolloPartenza.SelectedIndexChanged += new System.EventHandler(this.comboBoxProtocollo_SelectedIndexChanged);
            // 
            // comboBoxProtocolloDestinazione
            // 
            this.comboBoxProtocolloDestinazione.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProtocolloDestinazione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProtocolloDestinazione.FormattingEnabled = true;
            this.comboBoxProtocolloDestinazione.Items.AddRange(new object[] {
            "HTTPS",
            "HTTP"});
            this.comboBoxProtocolloDestinazione.Location = new System.Drawing.Point(234, 243);
            this.comboBoxProtocolloDestinazione.Name = "comboBoxProtocolloDestinazione";
            this.comboBoxProtocolloDestinazione.Size = new System.Drawing.Size(475, 31);
            this.comboBoxProtocolloDestinazione.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Protocollo Destinazione";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 370);
            this.Controls.Add(this.comboBoxProtocolloDestinazione);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxProtocolloPartenza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDominioDestinazione);
            this.Controls.Add(this.buttonSalva);
            this.Controls.Add(this.textBoxDominioPartenza);
            this.Controls.Add(this.textBoxFileDatabase);
            this.Controls.Add(this.buttonScegliFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win Change Host";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonScegliFile;
        private TextBox textBoxFileDatabase;
        private TextBox textBoxDominioPartenza;
        private Button buttonSalva;
        private TextBox textBoxDominioDestinazione;
        private Label label4;
        private ComboBox comboBoxProtocolloPartenza;
        private ComboBox comboBoxProtocolloDestinazione;
        private Label label5;
    }
}