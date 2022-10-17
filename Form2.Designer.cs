namespace PrimjenaWindowsKontrola
{
    partial class FormaText
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblImePrograma = new System.Windows.Forms.Label();
            this.txtImePrograma = new System.Windows.Forms.TextBox();
            this.lblOpisPrograma = new System.Windows.Forms.Label();
            this.txtOpisPrograma = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblImePrograma
            // 
            this.lblImePrograma.AutoSize = true;
            this.lblImePrograma.Location = new System.Drawing.Point(13, 13);
            this.lblImePrograma.Name = "lblImePrograma";
            this.lblImePrograma.Size = new System.Drawing.Size(74, 13);
            this.lblImePrograma.TabIndex = 0;
            this.lblImePrograma.Text = "Ime programa:";
            // 
            // txtImePrograma
            // 
            this.txtImePrograma.Location = new System.Drawing.Point(117, 10);
            this.txtImePrograma.Name = "txtImePrograma";
            this.txtImePrograma.Size = new System.Drawing.Size(164, 20);
            this.txtImePrograma.TabIndex = 1;
            // 
            // lblOpisPrograma
            // 
            this.lblOpisPrograma.AutoSize = true;
            this.lblOpisPrograma.Location = new System.Drawing.Point(13, 46);
            this.lblOpisPrograma.Name = "lblOpisPrograma";
            this.lblOpisPrograma.Size = new System.Drawing.Size(75, 13);
            this.lblOpisPrograma.TabIndex = 2;
            this.lblOpisPrograma.Text = "Opis programa";
            // 
            // txtOpisPrograma
            // 
            this.txtOpisPrograma.Location = new System.Drawing.Point(117, 43);
            this.txtOpisPrograma.Multiline = true;
            this.txtOpisPrograma.Name = "txtOpisPrograma";
            this.txtOpisPrograma.Size = new System.Drawing.Size(164, 156);
            this.txtOpisPrograma.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(13, 224);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(206, 224);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 5;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // FormaText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 259);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtOpisPrograma);
            this.Controls.Add(this.lblOpisPrograma);
            this.Controls.Add(this.txtImePrograma);
            this.Controls.Add(this.lblImePrograma);
            this.Name = "FormaText";
            this.Text = "Text";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtImePrograma;
        private System.Windows.Forms.Label lblImePrograma;
        private System.Windows.Forms.Label lblOpisPrograma;
        private System.Windows.Forms.TextBox txtOpisPrograma;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnOK;
    }
}