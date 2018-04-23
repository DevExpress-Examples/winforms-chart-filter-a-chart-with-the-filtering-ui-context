namespace FilterCriteriaSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.filtersContainer = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.filteringUIContext = new DevExpress.Utils.Filtering.FilteringUIContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtersContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl
            // 
            this.chartControl.DataBindings = null;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.Rotated = true;
            this.chartControl.Diagram = xyDiagram2;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chartControl.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Location = new System.Drawing.Point(0, 0);
            this.chartControl.Name = "chartControl";
            series2.Name = "Products";
            series2.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series2.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl.Size = new System.Drawing.Size(882, 688);
            this.chartControl.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.chartControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.filtersContainer);
            this.splitContainerControl1.Panel2.MinSize = 300;
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1278, 688);
            this.splitContainerControl1.SplitterPosition = 882;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // filtersContainer
            // 
            this.filtersContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtersContainer.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Multiple;
            this.filtersContainer.Location = new System.Drawing.Point(0, 0);
            this.filtersContainer.Name = "filtersContainer";
            this.filtersContainer.Size = new System.Drawing.Size(384, 688);
            this.filtersContainer.TabIndex = 3;
            this.filtersContainer.Text = "accordionControl1";
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // filteringUIContext
            // 
            this.filteringUIContext.Control = this.filtersContainer;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 688);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filtersContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.Utils.Filtering.FilteringUIContext filteringUIContext;
        private DevExpress.XtraBars.Navigation.AccordionControl filtersContainer;
    }
}

