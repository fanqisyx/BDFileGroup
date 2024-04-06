<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox_ChosedFiles = New System.Windows.Forms.ListBox()
        Me.bt_ChoseFiles = New System.Windows.Forms.Button()
        Me.bt_ClearList = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtBox_DiskSize = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox_ChosedFiles
        '
        Me.ListBox_ChosedFiles.FormattingEnabled = True
        Me.ListBox_ChosedFiles.ItemHeight = 12
        Me.ListBox_ChosedFiles.Location = New System.Drawing.Point(12, 12)
        Me.ListBox_ChosedFiles.Name = "ListBox_ChosedFiles"
        Me.ListBox_ChosedFiles.Size = New System.Drawing.Size(825, 220)
        Me.ListBox_ChosedFiles.TabIndex = 0
        '
        'bt_ChoseFiles
        '
        Me.bt_ChoseFiles.Location = New System.Drawing.Point(843, 12)
        Me.bt_ChoseFiles.Name = "bt_ChoseFiles"
        Me.bt_ChoseFiles.Size = New System.Drawing.Size(75, 69)
        Me.bt_ChoseFiles.TabIndex = 1
        Me.bt_ChoseFiles.Text = "浏览"
        Me.bt_ChoseFiles.UseVisualStyleBackColor = True
        '
        'bt_ClearList
        '
        Me.bt_ClearList.Location = New System.Drawing.Point(843, 87)
        Me.bt_ClearList.Name = "bt_ClearList"
        Me.bt_ClearList.Size = New System.Drawing.Size(75, 69)
        Me.bt_ClearList.TabIndex = 2
        Me.bt_ClearList.Text = "清空"
        Me.bt_ClearList.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtBox_DiskSize)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 239)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 52)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "设置"
        '
        'TxtBox_DiskSize
        '
        Me.TxtBox_DiskSize.Location = New System.Drawing.Point(66, 18)
        Me.TxtBox_DiskSize.Name = "TxtBox_DiskSize"
        Me.TxtBox_DiskSize.Size = New System.Drawing.Size(100, 21)
        Me.TxtBox_DiskSize.TabIndex = 0
        Me.TxtBox_DiskSize.Text = "650"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "光盘大小"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MB"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(245, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(212, 52)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "文件信息"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "文件信息"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 596)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bt_ClearList)
        Me.Controls.Add(Me.bt_ChoseFiles)
        Me.Controls.Add(Me.ListBox_ChosedFiles)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox_ChosedFiles As ListBox
    Friend WithEvents bt_ChoseFiles As Button
    Friend WithEvents bt_ClearList As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBox_DiskSize As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
End Class
