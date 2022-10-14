namespace PrevisaoDoTempo
{
    partial class Core
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Core));
            this.PanelHeader = new DevExpress.Utils.FlyoutPanel();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.panelControlCenter = new DevExpress.XtraEditors.PanelControl();
            this.TabPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.tab2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabPrevTempo = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.Temp = new DevExpress.XtraEditors.TileGroup();
            this.Minima = new DevExpress.XtraEditors.TileItem();
            this.Máxima = new DevExpress.XtraEditors.TileItem();
            this.SunriseSunset = new DevExpress.XtraEditors.TileItem();
            this.ChartPrevisao = new DevExpress.XtraCharts.ChartControl();
            this.lblBusca = new DevExpress.XtraEditors.LabelControl();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtBusca = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).BeginInit();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlCenter)).BeginInit();
            this.panelControlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabPane)).BeginInit();
            this.TabPane.SuspendLayout();
            this.tabPrevTempo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPrevisao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusca.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.PanelHeader.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(105)))), ((int)(((byte)(107)))));
            this.PanelHeader.Appearance.Options.UseBackColor = true;
            this.PanelHeader.Controls.Add(this.lblTitulo);
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Options.CloseOnHidingOwner = false;
            this.PanelHeader.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.PanelHeader.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.PanelHeader.OptionsButtonPanel.ButtonPanelHeight = 25;
            this.PanelHeader.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top;
            this.PanelHeader.OwnerControl = this.panelControlCenter;
            this.PanelHeader.Size = new System.Drawing.Size(1262, 87);
            this.PanelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Location = new System.Drawing.Point(5, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(431, 52);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Weather Forecast";
            // 
            // panelControlCenter
            // 
            this.panelControlCenter.Controls.Add(this.TabPane);
            this.panelControlCenter.Controls.Add(this.PanelHeader);
            this.panelControlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlCenter.Location = new System.Drawing.Point(0, 0);
            this.panelControlCenter.Name = "panelControlCenter";
            this.panelControlCenter.Size = new System.Drawing.Size(1262, 677);
            this.panelControlCenter.TabIndex = 1;
            // 
            // TabPane
            // 
            this.TabPane.Controls.Add(this.tab2);
            this.TabPane.Controls.Add(this.tabPrevTempo);
            this.TabPane.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabPane.Location = new System.Drawing.Point(2, 83);
            this.TabPane.Name = "TabPane";
            this.TabPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabPrevTempo,
            this.tab2});
            this.TabPane.RegularSize = new System.Drawing.Size(1258, 592);
            this.TabPane.SelectedPage = this.tabPrevTempo;
            this.TabPane.Size = new System.Drawing.Size(1258, 592);
            this.TabPane.TabIndex = 5;
            this.TabPane.Text = "tabPane1";
            // 
            // tab2
            // 
            this.tab2.Caption = "Em breve";
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(1258, 592);
            // 
            // tabPrevTempo
            // 
            this.tabPrevTempo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPrevTempo.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.tabPrevTempo.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.tabPrevTempo.Appearance.Options.UseBackColor = true;
            this.tabPrevTempo.Appearance.Options.UseTextOptions = true;
            this.tabPrevTempo.Caption = "Previsão do Tempo";
            this.tabPrevTempo.Controls.Add(this.tileControl1);
            this.tabPrevTempo.Controls.Add(this.ChartPrevisao);
            this.tabPrevTempo.Controls.Add(this.lblBusca);
            this.tabPrevTempo.Controls.Add(this.btnBuscar);
            this.tabPrevTempo.Controls.Add(this.txtBusca);
            this.tabPrevTempo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPrevTempo.Name = "tabPrevTempo";
            this.tabPrevTempo.Properties.AppearanceCaption.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPrevTempo.Properties.AppearanceCaption.Options.UseFont = true;
            this.tabPrevTempo.Properties.AppearanceCaption.Options.UseTextOptions = true;
            this.tabPrevTempo.Size = new System.Drawing.Size(1258, 559);
            // 
            // tileControl1
            // 
            this.tileControl1.AllowDisabledStateIndication = false;
            this.tileControl1.AllowDrag = false;
            this.tileControl1.Groups.Add(this.Temp);
            this.tileControl1.Location = new System.Drawing.Point(424, 17);
            this.tileControl1.MaxId = 4;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(316, 478);
            this.tileControl1.TabIndex = 4;
            this.tileControl1.Text = "oTileControl";
            // 
            // Temp
            // 
            this.Temp.Items.Add(this.Minima);
            this.Temp.Items.Add(this.Máxima);
            this.Temp.Items.Add(this.SunriseSunset);
            this.Temp.Name = "Temp";
            this.Temp.Text = "Hoje";
            // 
            // Minima
            // 
            this.Minima.AllowAnimation = false;
            this.Minima.AllowSelectAnimation = false;
            this.Minima.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.Minima.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Minima.AppearanceItem.Normal.Options.UseBackColor = true;
            this.Minima.AppearanceItem.Normal.Options.UseBorderColor = true;
            tileItemElement1.Appearance.Normal.BackColor = System.Drawing.Color.Transparent;
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.Black;
            tileItemElement1.Appearance.Normal.Options.UseBackColor = true;
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement1.Text = "Mínima";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement2.Appearance.Normal.BackColor = System.Drawing.Color.Transparent;
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.Black;
            tileItemElement2.Appearance.Normal.Options.UseBackColor = true;
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement2.Text = "34°";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.Minima.Elements.Add(tileItemElement1);
            this.Minima.Elements.Add(tileItemElement2);
            this.Minima.Id = 0;
            this.Minima.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.Minima.Name = "Minima";
            this.Minima.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            // 
            // Máxima
            // 
            this.Máxima.AllowAnimation = false;
            this.Máxima.AllowSelectAnimation = false;
            this.Máxima.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.Máxima.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.Máxima.AppearanceItem.Normal.Options.UseBackColor = true;
            this.Máxima.AppearanceItem.Normal.Options.UseBorderColor = true;
            tileItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement3.Appearance.Normal.ForeColor = System.Drawing.Color.Black;
            tileItemElement3.Appearance.Normal.Options.UseFont = true;
            tileItemElement3.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement3.Text = "Máxima";
            tileItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement4.Appearance.Normal.ForeColor = System.Drawing.Color.Black;
            tileItemElement4.Appearance.Normal.Options.UseFont = true;
            tileItemElement4.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement4.Text = "35°";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.Máxima.Elements.Add(tileItemElement3);
            this.Máxima.Elements.Add(tileItemElement4);
            this.Máxima.Id = 1;
            this.Máxima.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.Máxima.Name = "Máxima";
            // 
            // SunriseSunset
            // 
            this.SunriseSunset.AllowAnimation = false;
            this.SunriseSunset.AllowSelectAnimation = false;
            this.SunriseSunset.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.SunriseSunset.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.SunriseSunset.AppearanceItem.Normal.Options.UseBackColor = true;
            this.SunriseSunset.AppearanceItem.Normal.Options.UseBorderColor = true;
            tileItemElement5.Appearance.Normal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.Black;
            tileItemElement5.Appearance.Normal.Options.UseFont = true;
            tileItemElement5.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement5.Text = "Nascer do Sol";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            tileItemElement6.Appearance.Normal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement6.Appearance.Normal.ForeColor = System.Drawing.Color.Black;
            tileItemElement6.Appearance.Normal.Options.UseFont = true;
            tileItemElement6.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement6.Text = "Pôr do Sol";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            tileItemElement7.ImageOptions.Image = global::PrevisaoDoTempo.Properties.Resources.Sunrise;
            tileItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement7.Text = "";
            this.SunriseSunset.Elements.Add(tileItemElement5);
            this.SunriseSunset.Elements.Add(tileItemElement6);
            this.SunriseSunset.Elements.Add(tileItemElement7);
            this.SunriseSunset.Id = 3;
            this.SunriseSunset.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.SunriseSunset.Name = "SunriseSunset";
            // 
            // ChartPrevisao
            // 
            this.ChartPrevisao.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.ChartPrevisao.AppearanceNameSerializable = "Gray";
            this.ChartPrevisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ChartPrevisao.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChartPrevisao.CacheToMemory = true;
            this.ChartPrevisao.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient;
            this.ChartPrevisao.IndicatorsPaletteName = "Chameleon";
            this.ChartPrevisao.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.ChartPrevisao.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.ChartPrevisao.Legend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ChartPrevisao.Legend.MarkerSize = new System.Drawing.Size(19, 15);
            this.ChartPrevisao.Location = new System.Drawing.Point(746, 17);
            this.ChartPrevisao.Name = "ChartPrevisao";
            this.ChartPrevisao.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.ChartPrevisao.Size = new System.Drawing.Size(502, 478);
            this.ChartPrevisao.TabIndex = 3;
            // 
            // lblBusca
            // 
            this.lblBusca.Appearance.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.lblBusca.Appearance.Options.UseFont = true;
            this.lblBusca.Location = new System.Drawing.Point(15, 17);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(81, 23);
            this.lblBusca.TabIndex = 1;
            this.lblBusca.Text = "Cidade:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Appearance.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Appearance.Options.UseFont = true;
            this.btnBuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.ImageOptions.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(55, 76);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 24);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(15, 46);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Properties.Appearance.Options.UseFont = true;
            this.txtBusca.Size = new System.Drawing.Size(210, 24);
            this.txtBusca.TabIndex = 0;
            // 
            // Core
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 677);
            this.ControlBox = false;
            this.Controls.Add(this.panelControlCenter);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Name = "Core";
            this.Text = "Previsão do Tempo";
            this.Load += new System.EventHandler(this.Core_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlCenter)).EndInit();
            this.panelControlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabPane)).EndInit();
            this.TabPane.ResumeLayout(false);
            this.tabPrevTempo.ResumeLayout(false);
            this.tabPrevTempo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPrevisao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusca.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.FlyoutPanel PanelHeader;
        private DevExpress.XtraEditors.LabelControl lblBusca;
        private DevExpress.XtraEditors.TextEdit txtBusca;
        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraCharts.ChartControl ChartPrevisao;
        private DevExpress.XtraEditors.PanelControl panelControlCenter;
        private DevExpress.XtraBars.Navigation.TabPane TabPane;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tab2;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup Temp;
        public DevExpress.XtraEditors.TileItem Minima;
        private DevExpress.XtraEditors.TileItem Máxima;
        private DevExpress.XtraEditors.TileItem SunriseSunset;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabPrevTempo;
    }
}

