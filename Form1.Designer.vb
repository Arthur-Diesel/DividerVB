<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtB = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        txtA = New TextBox()
        btnCalculate = New Button()
        txtResult = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.Controls.Add(txtB, 1, 1)
        TableLayoutPanel1.Controls.Add(Label2, 0, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label3, 0, 2)
        TableLayoutPanel1.Controls.Add(txtA, 1, 0)
        TableLayoutPanel1.Controls.Add(btnCalculate, 2, 2)
        TableLayoutPanel1.Controls.Add(txtResult, 1, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(496, 217)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' txtB
        ' 
        TableLayoutPanel1.SetColumnSpan(txtB, 2)
        txtB.Dock = DockStyle.Bottom
        txtB.Location = New Point(175, 70)
        txtB.Margin = New Padding(10, 0, 10, 15)
        txtB.Name = "txtB"
        txtB.Size = New Size(311, 23)
        txtB.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Location = New Point(3, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 54)
        Label2.TabIndex = 1
        Label2.Text = "B:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 54)
        Label1.TabIndex = 0
        Label1.Text = "A:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Label3.Dock = DockStyle.Fill
        Label3.ForeColor = Color.White
        Label3.Location = New Point(20, 128)
        Label3.Margin = New Padding(20)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 69)
        Label3.TabIndex = 2
        Label3.Text = "Result:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtA
        ' 
        TableLayoutPanel1.SetColumnSpan(txtA, 2)
        txtA.Dock = DockStyle.Bottom
        txtA.Location = New Point(175, 16)
        txtA.Margin = New Padding(10, 0, 10, 15)
        txtA.Name = "txtA"
        txtA.Size = New Size(311, 23)
        txtA.TabIndex = 3
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Dock = DockStyle.Fill
        btnCalculate.Location = New Point(333, 111)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(160, 103)
        btnCalculate.TabIndex = 5
        btnCalculate.Text = "Calculate!"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' txtResult
        ' 
        txtResult.AutoSize = True
        txtResult.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtResult.Dock = DockStyle.Fill
        txtResult.ForeColor = Color.White
        txtResult.Location = New Point(185, 128)
        txtResult.Margin = New Padding(20)
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(125, 69)
        txtResult.TabIndex = 6
        txtResult.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(496, 217)
        Controls.Add(TableLayoutPanel1)
        Name = "Form1"
        Text = "Form1"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtResult As Label

End Class
