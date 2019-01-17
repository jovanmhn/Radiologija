namespace Radiologija
{
    partial class FormAddEditMaske
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditMaske));
            this.nazivTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MaskeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            nazivLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nazivTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaskeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(15, 20);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 0;
            nazivLabel.Text = "Naziv:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(32, 13);
            label1.TabIndex = 3;
            label1.Text = "Opis:";
            // 
            // nazivTextEdit
            // 
            this.nazivTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MaskeBindingSource, "naziv", true));
            this.nazivTextEdit.Location = new System.Drawing.Point(56, 17);
            this.nazivTextEdit.Name = "nazivTextEdit";
            this.nazivTextEdit.Size = new System.Drawing.Size(210, 20);
            this.nazivTextEdit.TabIndex = 1;
            // 
            // MaskeBindingSource
            // 
            this.MaskeBindingSource.DataSource = typeof(Radiologija.maska);
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MaskeBindingSource, "opis", true));
            this.memoEdit1.Location = new System.Drawing.Point(56, 44);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(210, 100);
            this.memoEdit1.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(248, 156);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Sačuvaj";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FormAddEditMaske
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 191);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(label1);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddEditMaske";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddEditMaske";
            ((System.ComponentModel.ISupportInitialize)(this.nazivTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaskeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource MaskeBindingSource;
        private DevExpress.XtraEditors.TextEdit nazivTextEdit;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}