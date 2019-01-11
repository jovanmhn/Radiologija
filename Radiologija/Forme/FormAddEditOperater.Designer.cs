namespace Radiologija
{
    partial class FormAddEditOperater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditOperater));
            this.imeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.operaterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prezimeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prezimeTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(40, 24);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(29, 13);
            imeLabel.TabIndex = 1;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(20, 50);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(48, 13);
            prezimeLabel.TabIndex = 3;
            prezimeLabel.Text = "Prezime:";
            // 
            // imeTextEdit
            // 
            this.imeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.operaterBindingSource, "ime", true));
            this.imeTextEdit.Location = new System.Drawing.Point(72, 21);
            this.imeTextEdit.Name = "imeTextEdit";
            this.imeTextEdit.Size = new System.Drawing.Size(143, 20);
            this.imeTextEdit.TabIndex = 2;
            // 
            // operaterBindingSource
            // 
            this.operaterBindingSource.DataSource = typeof(Radiologija.operater);
            // 
            // prezimeTextEdit
            // 
            this.prezimeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.operaterBindingSource, "prezime", true));
            this.prezimeTextEdit.Location = new System.Drawing.Point(72, 47);
            this.prezimeTextEdit.Name = "prezimeTextEdit";
            this.prezimeTextEdit.Size = new System.Drawing.Size(143, 20);
            this.prezimeTextEdit.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(126, 94);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(89, 22);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Sačuvaj";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FormAddEditOperater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 128);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextEdit);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAddEditOperater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddEditOperater";
            ((System.ComponentModel.ISupportInitialize)(this.imeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prezimeTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource operaterBindingSource;
        private DevExpress.XtraEditors.TextEdit imeTextEdit;
        private DevExpress.XtraEditors.TextEdit prezimeTextEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}