<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreportecomprobante
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.generar_comprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbventasDataSet1 = New sisventas.dbventasDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.generar_comprobanteTableAdapter = New sisventas.dbventasDataSet1TableAdapters.generar_comprobanteTableAdapter()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        CType(Me.generar_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbventasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'generar_comprobanteBindingSource
        '
        Me.generar_comprobanteBindingSource.DataMember = "generar_comprobante"
        Me.generar_comprobanteBindingSource.DataSource = Me.dbventasDataSet1
        '
        'dbventasDataSet1
        '
        Me.dbventasDataSet1.DataSetName = "dbventasDataSet1"
        Me.dbventasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.generar_comprobanteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sisventas.rptcomprobante.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1225, 654)
        Me.ReportViewer1.TabIndex = 0
        '
        'generar_comprobanteTableAdapter
        '
        Me.generar_comprobanteTableAdapter.ClearBeforeFill = True
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(265, 239)
        Me.txtidventa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(132, 22)
        Me.txtidventa.TabIndex = 1
        Me.txtidventa.Visible = False
        '
        'frmreportecomprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 654)
        Me.Controls.Add(Me.txtidventa)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmreportecomprobante"
        Me.Text = ".:. Reporte de Comprobante .:."
        CType(Me.generar_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbventasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents generar_comprobanteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbventasDataSet1 As sisventas.dbventasDataSet1
    Friend WithEvents generar_comprobanteTableAdapter As sisventas.dbventasDataSet1TableAdapters.generar_comprobanteTableAdapter
    Friend WithEvents txtidventa As System.Windows.Forms.TextBox
End Class
