﻿
namespace SpectrumPlotter
{
    partial class MainScreen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.btnConnect = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDark = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExposure = new System.Windows.Forms.TextBox();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnFetch = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstElementLib = new System.Windows.Forms.ListView();
            this.colHdrSymbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHdrMatch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstCaptures = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.lstPoly = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstPolyfit = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(137, 11);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 27);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmbPorts);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btnDark);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.btnCapture);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtExposure);
            this.splitContainer1.Panel1.Controls.Add(this.btnConnect);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.formsPlot1);
            this.splitContainer1.Size = new System.Drawing.Size(1390, 644);
            this.splitContainer1.SplitterDistance = 51;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(17, 12);
            this.cmbPorts.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(111, 24);
            this.cmbPorts.TabIndex = 11;
            this.cmbPorts.DropDown += new System.EventHandler(this.cmbPorts_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1311, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "¯\\_(ツ)_/¯";
            // 
            // btnDark
            // 
            this.btnDark.Location = new System.Drawing.Point(1176, 11);
            this.btnDark.Margin = new System.Windows.Forms.Padding(4);
            this.btnDark.Name = "btnDark";
            this.btnDark.Size = new System.Drawing.Size(71, 27);
            this.btnDark.TabIndex = 10;
            this.btnDark.Text = "Dark";
            this.btnDark.UseVisualStyleBackColor = true;
            this.btnDark.Click += new System.EventHandler(this.btnDark_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 46);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.MarqueeAnimationSpeed = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1369, 15);
            this.progressBar.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1315, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "g3gg0.de";
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(1085, 11);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(80, 27);
            this.btnCapture.TabIndex = 7;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exposure [µs]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtExposure
            // 
            this.txtExposure.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExposure.Location = new System.Drawing.Point(377, 12);
            this.txtExposure.Margin = new System.Windows.Forms.Padding(4);
            this.txtExposure.Name = "txtExposure";
            this.txtExposure.Size = new System.Drawing.Size(105, 23);
            this.txtExposure.TabIndex = 3;
            this.txtExposure.Text = "10";
            this.txtExposure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExposure.TextChanged += new System.EventHandler(this.txtExposure_TextChanged);
            this.txtExposure.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExposure_KeyDown);
            // 
            // formsPlot1
            // 
            this.formsPlot1.AutoSize = true;
            this.formsPlot1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.formsPlot1.BackColor = System.Drawing.Color.Transparent;
            this.formsPlot1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1.Location = new System.Drawing.Point(0, 0);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(1390, 588);
            this.formsPlot1.TabIndex = 0;
            this.formsPlot1.MouseEnter += new System.EventHandler(this.formsPlot1_MouseEnter);
            this.formsPlot1.MouseLeave += new System.EventHandler(this.formsPlot1_MouseLeave);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(1709, 644);
            this.splitContainer2.SplitterDistance = 1390;
            this.splitContainer2.SplitterWidth = 11;
            this.splitContainer2.TabIndex = 1;
            // 
            // btnFetch
            // 
            this.btnFetch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFetch.Enabled = false;
            this.btnFetch.Location = new System.Drawing.Point(157, 4);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(4);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(135, 28);
            this.btnFetch.TabIndex = 1;
            this.btnFetch.Text = "Fetch NIST";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(308, 644);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(300, 615);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NIST Database";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstElementLib
            // 
            this.lstElementLib.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstElementLib.CheckBoxes = true;
            this.lstElementLib.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHdrSymbol,
            this.colHdrMatch});
            this.lstElementLib.HideSelection = false;
            this.lstElementLib.Location = new System.Drawing.Point(0, 0);
            this.lstElementLib.Margin = new System.Windows.Forms.Padding(4);
            this.lstElementLib.Name = "lstElementLib";
            this.lstElementLib.Size = new System.Drawing.Size(292, 564);
            this.lstElementLib.TabIndex = 0;
            this.lstElementLib.UseCompatibleStateImageBehavior = false;
            this.lstElementLib.View = System.Windows.Forms.View.Details;
            this.lstElementLib.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstElementLib_ColumnClick);
            this.lstElementLib.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstElementLib_ItemCheck);
            this.lstElementLib.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstElementLib_ItemChecked);
            this.lstElementLib.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstElementLib_MouseDown);
            // 
            // colHdrSymbol
            // 
            this.colHdrSymbol.Text = "Symbol";
            this.colHdrSymbol.Width = 88;
            // 
            // colHdrMatch
            // 
            this.colHdrMatch.Text = "%";
            this.colHdrMatch.Width = 43;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstCaptures);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(300, 615);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Captures";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstCaptures
            // 
            this.lstCaptures.CheckBoxes = true;
            this.lstCaptures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.columnHeader1});
            this.lstCaptures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCaptures.HideSelection = false;
            this.lstCaptures.LabelEdit = true;
            this.lstCaptures.Location = new System.Drawing.Point(4, 4);
            this.lstCaptures.Margin = new System.Windows.Forms.Padding(4);
            this.lstCaptures.Name = "lstCaptures";
            this.lstCaptures.Size = new System.Drawing.Size(292, 607);
            this.lstCaptures.TabIndex = 1;
            this.lstCaptures.UseCompatibleStateImageBehavior = false;
            this.lstCaptures.View = System.Windows.Forms.View.Details;
            this.lstCaptures.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lstCaptures_AfterLabelEdit);
            this.lstCaptures.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstCaptures_ItemChecked);
            this.lstCaptures.SelectedIndexChanged += new System.EventHandler(this.lstCaptures_SelectedIndexChanged);
            this.lstCaptures.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstCaptures_MouseUp);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 146;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "%";
            this.columnHeader1.Width = 47;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(300, 576);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Polyfit";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.lstPoly);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.lstPolyfit);
            this.splitContainer4.Size = new System.Drawing.Size(300, 576);
            this.splitContainer4.SplitterDistance = 119;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 1;
            // 
            // lstPoly
            // 
            this.lstPoly.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lstPoly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPoly.HideSelection = false;
            this.lstPoly.Location = new System.Drawing.Point(0, 0);
            this.lstPoly.Margin = new System.Windows.Forms.Padding(4);
            this.lstPoly.Name = "lstPoly";
            this.lstPoly.Size = new System.Drawing.Size(300, 119);
            this.lstPoly.TabIndex = 1;
            this.lstPoly.UseCompatibleStateImageBehavior = false;
            this.lstPoly.View = System.Windows.Forms.View.Details;
            this.lstPoly.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstPoly_MouseUp);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Coeff";
            this.columnHeader4.Width = 54;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Value";
            this.columnHeader5.Width = 146;
            // 
            // lstPolyfit
            // 
            this.lstPolyfit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lstPolyfit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPolyfit.HideSelection = false;
            this.lstPolyfit.Location = new System.Drawing.Point(0, 0);
            this.lstPolyfit.Margin = new System.Windows.Forms.Padding(4);
            this.lstPolyfit.Name = "lstPolyfit";
            this.lstPolyfit.Size = new System.Drawing.Size(300, 452);
            this.lstPolyfit.TabIndex = 0;
            this.lstPolyfit.UseCompatibleStateImageBehavior = false;
            this.lstPolyfit.View = System.Windows.Forms.View.Details;
            this.lstPolyfit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstPolyfit_MouseUp);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CMOS Pixel";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "λ";
            this.columnHeader3.Width = 74;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(4, 4);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.cmbDatabase);
            this.splitContainer5.Panel1.Controls.Add(this.btnFetch);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.lstElementLib);
            this.splitContainer5.Size = new System.Drawing.Size(292, 607);
            this.splitContainer5.SplitterDistance = 39;
            this.splitContainer5.TabIndex = 1;
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(3, 7);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(147, 24);
            this.cmbDatabase.TabIndex = 2;
            this.cmbDatabase.DropDown += new System.EventHandler(this.cmbDatabase_DropDown);
            this.cmbDatabase.TextChanged += new System.EventHandler(this.cmbDatabase_Changed);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 644);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.Text = ">_    Spectral plotter";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExposure;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.ListView lstElementLib;
        private System.Windows.Forms.ColumnHeader colHdrMatch;
        private System.Windows.Forms.ColumnHeader colHdrSymbol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnDark;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lstCaptures;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ListView lstPoly;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lstPolyfit;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ComboBox cmbDatabase;
    }
}

