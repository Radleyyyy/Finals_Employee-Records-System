<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Mysql = New System.Windows.Forms.Button()
        Me.DatGridViewEmployees = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDepartment = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSalary = New System.Windows.Forms.TextBox()
        Me.TextBoxPosition = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DatGridViewEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonCreate
        '
        Me.ButtonCreate.Location = New System.Drawing.Point(276, 71)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(100, 20)
        Me.ButtonCreate.TabIndex = 0
        Me.ButtonCreate.Text = "CREATE"
        Me.ButtonCreate.UseVisualStyleBackColor = True
        '
        'ButtonRead
        '
        Me.ButtonRead.Location = New System.Drawing.Point(276, 104)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(100, 20)
        Me.ButtonRead.TabIndex = 1
        Me.ButtonRead.Text = "READ"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(276, 145)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(100, 20)
        Me.ButtonUpdate.TabIndex = 2
        Me.ButtonUpdate.Text = "UPDATE"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(276, 185)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(100, 20)
        Me.ButtonDelete.TabIndex = 3
        Me.ButtonDelete.Text = "DELETE"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Mysql)
        Me.GroupBox1.Controls.Add(Me.DatGridViewEmployees)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxDepartment)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxSalary)
        Me.GroupBox1.Controls.Add(Me.TextBoxPosition)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.TextBoxID)
        Me.GroupBox1.Controls.Add(Me.ButtonDelete)
        Me.GroupBox1.Controls.Add(Me.ButtonCreate)
        Me.GroupBox1.Controls.Add(Me.ButtonRead)
        Me.GroupBox1.Controls.Add(Me.ButtonUpdate)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 433)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(360, 36)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Employee Record System"
        '
        'Mysql
        '
        Me.Mysql.Location = New System.Drawing.Point(132, 267)
        Me.Mysql.Name = "Mysql"
        Me.Mysql.Size = New System.Drawing.Size(156, 46)
        Me.Mysql.TabIndex = 15
        Me.Mysql.Text = "Connect MySQL"
        Me.Mysql.UseVisualStyleBackColor = True
        '
        'DatGridViewEmployees
        '
        Me.DatGridViewEmployees.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DatGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatGridViewEmployees.Location = New System.Drawing.Point(30, 319)
        Me.DatGridViewEmployees.Name = "DatGridViewEmployees"
        Me.DatGridViewEmployees.Size = New System.Drawing.Size(372, 103)
        Me.DatGridViewEmployees.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "DEPARTMENT:"
        '
        'TextBoxDepartment
        '
        Me.TextBoxDepartment.Location = New System.Drawing.Point(100, 222)
        Me.TextBoxDepartment.Name = "TextBoxDepartment"
        Me.TextBoxDepartment.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxDepartment.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "SALARY:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "POSITION:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "NAME:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(247, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 8
        '
        'TextBoxSalary
        '
        Me.TextBoxSalary.Location = New System.Drawing.Point(100, 186)
        Me.TextBoxSalary.Name = "TextBoxSalary"
        Me.TextBoxSalary.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxSalary.TabIndex = 7
        '
        'TextBoxPosition
        '
        Me.TextBoxPosition.Location = New System.Drawing.Point(100, 146)
        Me.TextBoxPosition.Name = "TextBoxPosition"
        Me.TextBoxPosition.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxPosition.TabIndex = 6
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(100, 108)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxName.TabIndex = 5
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(100, 72)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxID.TabIndex = 4
        Me.TextBoxID.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DatGridViewEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonRead As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DatGridViewEmployees As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxDepartment As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSalary As TextBox
    Friend WithEvents TextBoxPosition As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Mysql As Button
    Friend WithEvents Label6 As Label
End Class
