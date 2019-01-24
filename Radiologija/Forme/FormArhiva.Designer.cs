namespace Radiologija
{
    partial class FormArhiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArhiva));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.nalazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_modalitet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_hospital = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_maska = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_doktor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_operater = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprezime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatum_rodj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatum_pregleda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnapomena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOtvori = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.nalazBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1197, 525);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nalazBindingSource
            // 
            this.nalazBindingSource.DataSource = typeof(Radiologija.nalaz);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_modalitet,
            this.colid_hospital,
            this.colid_maska,
            this.colid_doktor,
            this.colid_operater,
            this.colime,
            this.colprezime,
            this.coldatum_rodj,
            this.coldatum_pregleda,
            this.colnapomena});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            // 
            // colid_modalitet
            // 
            this.colid_modalitet.AppearanceCell.Options.UseTextOptions = true;
            this.colid_modalitet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid_modalitet.Caption = "Modalitet";
            this.colid_modalitet.FieldName = "modalitet.naziv";
            this.colid_modalitet.Name = "colid_modalitet";
            this.colid_modalitet.Visible = true;
            this.colid_modalitet.VisibleIndex = 3;
            this.colid_modalitet.Width = 79;
            // 
            // colid_hospital
            // 
            this.colid_hospital.AppearanceCell.Options.UseTextOptions = true;
            this.colid_hospital.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid_hospital.Caption = "Hospital";
            this.colid_hospital.FieldName = "hospital.naziv";
            this.colid_hospital.Name = "colid_hospital";
            this.colid_hospital.Visible = true;
            this.colid_hospital.VisibleIndex = 5;
            this.colid_hospital.Width = 116;
            // 
            // colid_maska
            // 
            this.colid_maska.AppearanceCell.Options.UseTextOptions = true;
            this.colid_maska.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid_maska.Caption = "Maska";
            this.colid_maska.FieldName = "maska.naziv";
            this.colid_maska.Name = "colid_maska";
            this.colid_maska.Visible = true;
            this.colid_maska.VisibleIndex = 6;
            this.colid_maska.Width = 116;
            // 
            // colid_doktor
            // 
            this.colid_doktor.Caption = "Doktor";
            this.colid_doktor.FieldName = "doktor.info_naziv";
            this.colid_doktor.Name = "colid_doktor";
            this.colid_doktor.Visible = true;
            this.colid_doktor.VisibleIndex = 7;
            this.colid_doktor.Width = 116;
            // 
            // colid_operater
            // 
            this.colid_operater.Caption = "Operater";
            this.colid_operater.FieldName = "operater.info_naziv";
            this.colid_operater.Name = "colid_operater";
            this.colid_operater.Visible = true;
            this.colid_operater.VisibleIndex = 8;
            this.colid_operater.Width = 116;
            // 
            // colime
            // 
            this.colime.Caption = "Ime";
            this.colime.FieldName = "ime";
            this.colime.Name = "colime";
            this.colime.Visible = true;
            this.colime.VisibleIndex = 0;
            this.colime.Width = 116;
            // 
            // colprezime
            // 
            this.colprezime.Caption = "Prezime";
            this.colprezime.FieldName = "prezime";
            this.colprezime.Name = "colprezime";
            this.colprezime.Visible = true;
            this.colprezime.VisibleIndex = 1;
            this.colprezime.Width = 116;
            // 
            // coldatum_rodj
            // 
            this.coldatum_rodj.Caption = "Datum rođenja";
            this.coldatum_rodj.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.coldatum_rodj.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldatum_rodj.FieldName = "datum_rodj";
            this.coldatum_rodj.Name = "coldatum_rodj";
            this.coldatum_rodj.Visible = true;
            this.coldatum_rodj.VisibleIndex = 2;
            this.coldatum_rodj.Width = 116;
            // 
            // coldatum_pregleda
            // 
            this.coldatum_pregleda.Caption = "Datum pregleda";
            this.coldatum_pregleda.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";
            this.coldatum_pregleda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldatum_pregleda.FieldName = "datum_pregleda";
            this.coldatum_pregleda.Name = "coldatum_pregleda";
            this.coldatum_pregleda.Visible = true;
            this.coldatum_pregleda.VisibleIndex = 4;
            this.coldatum_pregleda.Width = 116;
            // 
            // colnapomena
            // 
            this.colnapomena.Caption = "Napomena";
            this.colnapomena.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colnapomena.FieldName = "napomena";
            this.colnapomena.MaxWidth = 250;
            this.colnapomena.Name = "colnapomena";
            this.colnapomena.Visible = true;
            this.colnapomena.VisibleIndex = 9;
            this.colnapomena.Width = 140;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 543);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Dodaj";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(93, 543);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Otvori";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(1134, 543);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Obriši";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(174, 543);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "Refresh";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemOtvori),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Štampa";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItemOtvori
            // 
            this.barButtonItemOtvori.Caption = "Otvori";
            this.barButtonItemOtvori.Id = 0;
            this.barButtonItemOtvori.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemOtvori.ImageOptions.Image")));
            this.barButtonItemOtvori.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemOtvori.ImageOptions.LargeImage")));
            this.barButtonItemOtvori.Name = "barButtonItemOtvori";
            this.barButtonItemOtvori.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOtvori_ItemClick);
            // 
            // barButtonItemRefresh
            // 
            this.barButtonItemRefresh.Caption = "Osvježi";
            this.barButtonItemRefresh.Id = 2;
            this.barButtonItemRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemRefresh.ImageOptions.Image")));
            this.barButtonItemRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemRefresh.ImageOptions.LargeImage")));
            this.barButtonItemRefresh.Name = "barButtonItemRefresh";
            this.barButtonItemRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRefresh_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Obriši";
            this.barButtonItemDelete.Id = 1;
            this.barButtonItemDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemDelete.ImageOptions.Image")));
            this.barButtonItemDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemDelete.ImageOptions.LargeImage")));
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemOtvori,
            this.barButtonItemDelete,
            this.barButtonItemRefresh,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1221, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 572);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1221, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 572);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1221, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 572);
            // 
            // FormArhiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 572);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormArhiva";
            this.Text = "Arhiva";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.BindingSource nalazBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_modalitet;
        private DevExpress.XtraGrid.Columns.GridColumn colid_hospital;
        private DevExpress.XtraGrid.Columns.GridColumn colid_maska;
        private DevExpress.XtraGrid.Columns.GridColumn colid_doktor;
        private DevExpress.XtraGrid.Columns.GridColumn colid_operater;
        private DevExpress.XtraGrid.Columns.GridColumn colime;
        private DevExpress.XtraGrid.Columns.GridColumn colprezime;
        private DevExpress.XtraGrid.Columns.GridColumn coldatum_rodj;
        private DevExpress.XtraGrid.Columns.GridColumn coldatum_pregleda;
        private DevExpress.XtraGrid.Columns.GridColumn colnapomena;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOtvori;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}