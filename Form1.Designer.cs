namespace PrimjenaWindowsKontrola
{
    partial class FormaProgram
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxPokreniProgram = new System.Windows.Forms.GroupBox();
            this.btnPokreniProgram = new System.Windows.Forms.Button();
            this.cmbProgrami = new System.Windows.Forms.ComboBox();
            this.chkShowProgramAction = new System.Windows.Forms.CheckBox();
            this.grpBoxKontrolaPrograma = new System.Windows.Forms.GroupBox();
            this.txtOpisPrograma = new System.Windows.Forms.TextBox();
            this.lblOpisPrograma = new System.Windows.Forms.Label();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.txtImePrograma = new System.Windows.Forms.TextBox();
            this.lblImePrograma = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.grpBoxPokreniProgram.SuspendLayout();
            this.grpBoxKontrolaPrograma.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(365, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.messageToolStripMenuItem.Text = "Message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // grpBoxPokreniProgram
            // 
            this.grpBoxPokreniProgram.Controls.Add(this.btnPokreniProgram);
            this.grpBoxPokreniProgram.Controls.Add(this.cmbProgrami);
            this.grpBoxPokreniProgram.Location = new System.Drawing.Point(12, 27);
            this.grpBoxPokreniProgram.Name = "grpBoxPokreniProgram";
            this.grpBoxPokreniProgram.Size = new System.Drawing.Size(340, 130);
            this.grpBoxPokreniProgram.TabIndex = 1;
            this.grpBoxPokreniProgram.TabStop = false;
            this.grpBoxPokreniProgram.Text = "Pokreni program";
            // 
            // btnPokreniProgram
            // 
            this.btnPokreniProgram.Location = new System.Drawing.Point(182, 52);
            this.btnPokreniProgram.Name = "btnPokreniProgram";
            this.btnPokreniProgram.Size = new System.Drawing.Size(108, 23);
            this.btnPokreniProgram.TabIndex = 3;
            this.btnPokreniProgram.Text = "Pokreni program";
            this.btnPokreniProgram.UseVisualStyleBackColor = true;
            // 
            // cmbProgrami
            // 
            this.cmbProgrami.FormattingEnabled = true;
            this.cmbProgrami.Items.AddRange(new object[] {
            "Notepad",
            "Paint"});
            this.cmbProgrami.Location = new System.Drawing.Point(6, 52);
            this.cmbProgrami.Name = "cmbProgrami";
            this.cmbProgrami.Size = new System.Drawing.Size(144, 21);
            this.cmbProgrami.TabIndex = 2;
            this.cmbProgrami.SelectedIndexChanged += new System.EventHandler(this.cmbProgrami_SelectedIndexChanged);
            // 
            // chkShowProgramAction
            // 
            this.chkShowProgramAction.AutoSize = true;
            this.chkShowProgramAction.Location = new System.Drawing.Point(12, 177);
            this.chkShowProgramAction.Name = "chkShowProgramAction";
            this.chkShowProgramAction.Size = new System.Drawing.Size(126, 17);
            this.chkShowProgramAction.TabIndex = 2;
            this.chkShowProgramAction.Text = "Show program action";
            this.chkShowProgramAction.UseVisualStyleBackColor = true;
            // 
            // grpBoxKontrolaPrograma
            // 
            this.grpBoxKontrolaPrograma.Controls.Add(this.txtOpisPrograma);
            this.grpBoxKontrolaPrograma.Controls.Add(this.lblOpisPrograma);
            this.grpBoxKontrolaPrograma.Controls.Add(this.btnIzbrisi);
            this.grpBoxKontrolaPrograma.Controls.Add(this.txtImePrograma);
            this.grpBoxKontrolaPrograma.Controls.Add(this.lblImePrograma);
            this.grpBoxKontrolaPrograma.Location = new System.Drawing.Point(12, 212);
            this.grpBoxKontrolaPrograma.Name = "grpBoxKontrolaPrograma";
            this.grpBoxKontrolaPrograma.Size = new System.Drawing.Size(340, 226);
            this.grpBoxKontrolaPrograma.TabIndex = 3;
            this.grpBoxKontrolaPrograma.TabStop = false;
            this.grpBoxKontrolaPrograma.Text = "Kontrola programa";
            // 
            // txtOpisPrograma
            // 
            this.txtOpisPrograma.Location = new System.Drawing.Point(9, 134);
            this.txtOpisPrograma.Multiline = true;
            this.txtOpisPrograma.Name = "txtOpisPrograma";
            this.txtOpisPrograma.Size = new System.Drawing.Size(310, 75);
            this.txtOpisPrograma.TabIndex = 4;
            // 
            // lblOpisPrograma
            // 
            this.lblOpisPrograma.AutoSize = true;
            this.lblOpisPrograma.Location = new System.Drawing.Point(7, 105);
            this.lblOpisPrograma.Name = "lblOpisPrograma";
            this.lblOpisPrograma.Size = new System.Drawing.Size(75, 13);
            this.lblOpisPrograma.TabIndex = 3;
            this.lblOpisPrograma.Text = "Opis programa";
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(203, 56);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(116, 23);
            this.btnIzbrisi.TabIndex = 2;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            // 
            // txtImePrograma
            // 
            this.txtImePrograma.Location = new System.Drawing.Point(9, 58);
            this.txtImePrograma.Name = "txtImePrograma";
            this.txtImePrograma.Size = new System.Drawing.Size(168, 20);
            this.txtImePrograma.TabIndex = 1;
            // 
            // lblImePrograma
            // 
            this.lblImePrograma.AutoSize = true;
            this.lblImePrograma.Location = new System.Drawing.Point(6, 30);
            this.lblImePrograma.Name = "lblImePrograma";
            this.lblImePrograma.Size = new System.Drawing.Size(71, 13);
            this.lblImePrograma.TabIndex = 0;
            this.lblImePrograma.Text = "Ime programa";
            // 
            // FormaProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.grpBoxKontrolaPrograma);
            this.Controls.Add(this.chkShowProgramAction);
            this.Controls.Add(this.grpBoxPokreniProgram);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormaProgram";
            this.Text = "Program";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpBoxPokreniProgram.ResumeLayout(false);
            this.grpBoxKontrolaPrograma.ResumeLayout(false);
            this.grpBoxKontrolaPrograma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBoxPokreniProgram;
        private System.Windows.Forms.Button btnPokreniProgram;
        private System.Windows.Forms.ComboBox cmbProgrami;
        private System.Windows.Forms.CheckBox chkShowProgramAction;
        private System.Windows.Forms.GroupBox grpBoxKontrolaPrograma;
        private System.Windows.Forms.Label lblOpisPrograma;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.TextBox txtImePrograma;
        private System.Windows.Forms.Label lblImePrograma;
        private System.Windows.Forms.TextBox txtOpisPrograma;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

