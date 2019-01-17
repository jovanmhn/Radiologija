namespace Radiologija
{
    partial class FormAddEditDoktor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label titulaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditDoktor));
            this.imeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DoktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prezimeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.titulaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            titulaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoktorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prezimeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulaTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(34, 15);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(29, 13);
            imeLabel.TabIndex = 0;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(14, 41);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(48, 13);
            prezimeLabel.TabIndex = 2;
            prezimeLabel.Text = "Prezime:";
            // 
            // titulaLabel
            // 
            titulaLabel.AutoSize = true;
            titulaLabel.Location = new System.Drawing.Point(16, 67);
            titulaLabel.Name = "titulaLabel";
            titulaLabel.Size = new System.Drawing.Size(44, 13);
            titulaLabel.TabIndex = 4;
            titulaLabel.Text = "Zvanje:";
            // 
            // imeTextEdit
            // 
            this.imeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.DoktorBindingSource, "ime", true));
            this.imeTextEdit.Location = new System.Drawing.Point(66, 12);
            this.imeTextEdit.Name = "imeTextEdit";
            this.imeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.imeTextEdit.TabIndex = 1;
            // 
            // DoktorBindingSource
            // 
            this.DoktorBindingSource.DataSource = typeof(Radiologija.doktor);
            // 
            // prezimeTextEdit
            // 
            this.prezimeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.DoktorBindingSource, "prezime", true));
            this.prezimeTextEdit.Location = new System.Drawing.Point(66, 38);
            this.prezimeTextEdit.Name = "prezimeTextEdit";
            this.prezimeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.prezimeTextEdit.TabIndex = 3;
            // 
            // titulaTextEdit
            // 
            this.titulaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.DoktorBindingSource, "titula", true));
            this.titulaTextEdit.Location = new System.Drawing.Point(66, 64);
            this.titulaTextEdit.Name = "titulaTextEdit";
            this.titulaTextEdit.Size = new System.Drawing.Size(100, 20);
            this.titulaTextEdit.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(127, 104);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Sačuvaj";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FormAddEditDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 134);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(titulaLabel);
            this.Controls.Add(this.titulaTextEdit);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextEdit);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAddEditDoktor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddEditDoktor";
            ((System.ComponentModel.ISupportInitialize)(this.imeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoktorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prezimeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulaTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource DoktorBindingSource;
        private DevExpress.XtraEditors.TextEdit imeTextEdit;
        private DevExpress.XtraEditors.TextEdit prezimeTextEdit;
        private DevExpress.XtraEditors.TextEdit titulaTextEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}