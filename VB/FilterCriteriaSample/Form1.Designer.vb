Namespace FilterCriteriaSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram2 As New DevExpress.XtraCharts.XYDiagram()
            Dim series2 As New DevExpress.XtraCharts.Series()
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.filtersContainer = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.defaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.filteringUIContext = New DevExpress.Utils.Filtering.FilteringUIContext(Me.components)
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.filtersContainer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.filteringUIContext, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl
            ' 
            Me.chartControl.DataBindings = Nothing
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram2.Rotated = True
            Me.chartControl.Diagram = xyDiagram2
            Me.chartControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartControl.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom
            Me.chartControl.Legend.Name = "Default Legend"
            Me.chartControl.Location = New System.Drawing.Point(0, 0)
            Me.chartControl.Name = "chartControl"
            series2.Name = "Products"
            series2.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
            series2.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series() { series2}
            Me.chartControl.Size = New System.Drawing.Size(882, 688)
            Me.chartControl.TabIndex = 0
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.chartControl)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.filtersContainer)
            Me.splitContainerControl1.Panel2.MinSize = 300
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(1278, 688)
            Me.splitContainerControl1.SplitterPosition = 882
            Me.splitContainerControl1.TabIndex = 2
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' filtersContainer
            ' 
            Me.filtersContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.filtersContainer.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Multiple
            Me.filtersContainer.Location = New System.Drawing.Point(0, 0)
            Me.filtersContainer.Name = "filtersContainer"
            Me.filtersContainer.Size = New System.Drawing.Size(384, 688)
            Me.filtersContainer.TabIndex = 3
            Me.filtersContainer.Text = "accordionControl1"
            ' 
            ' defaultLookAndFeel
            ' 
            Me.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' filteringUIContext
            ' 
            Me.filteringUIContext.Control = Me.filtersContainer
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1278, 688)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(xyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.filtersContainer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.filteringUIContext, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chartControl As DevExpress.XtraCharts.ChartControl
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private defaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private filteringUIContext As DevExpress.Utils.Filtering.FilteringUIContext
        Private filtersContainer As DevExpress.XtraBars.Navigation.AccordionControl
    End Class
End Namespace

