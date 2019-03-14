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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_Total_Buy = New System.Windows.Forms.TextBox()
        Me.Txt_Name_Buy = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_Amount_Money = New System.Windows.Forms.TextBox()
        Me.Txt_Name_Money = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lstbx = New System.Windows.Forms.ListBox()
        Me.Btn_Buy = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_Total_Buy)
        Me.GroupBox1.Controls.Add(Me.Txt_Name_Buy)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buy Food"
        '
        'Txt_Total_Buy
        '
        Me.Txt_Total_Buy.Location = New System.Drawing.Point(82, 113)
        Me.Txt_Total_Buy.Name = "Txt_Total_Buy"
        Me.Txt_Total_Buy.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Total_Buy.TabIndex = 4
        '
        'Txt_Name_Buy
        '
        Me.Txt_Name_Buy.Location = New System.Drawing.Point(82, 34)
        Me.Txt_Name_Buy.Name = "Txt_Name_Buy"
        Me.Txt_Name_Buy.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Name_Buy.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Txt_Amount_Money)
        Me.GroupBox2.Controls.Add(Me.Txt_Name_Money)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(333, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 160)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Money"
        '
        'Txt_Amount_Money
        '
        Me.Txt_Amount_Money.Location = New System.Drawing.Point(82, 113)
        Me.Txt_Amount_Money.Name = "Txt_Amount_Money"
        Me.Txt_Amount_Money.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Amount_Money.TabIndex = 4
        '
        'Txt_Name_Money
        '
        Me.Txt_Name_Money.Location = New System.Drawing.Point(82, 34)
        Me.Txt_Name_Money.Name = "Txt_Name_Money"
        Me.Txt_Name_Money.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Name_Money.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Name"
        '
        'Lstbx
        '
        Me.Lstbx.FormattingEnabled = True
        Me.Lstbx.ItemHeight = 16
        Me.Lstbx.Location = New System.Drawing.Point(579, 12)
        Me.Lstbx.Name = "Lstbx"
        Me.Lstbx.Size = New System.Drawing.Size(431, 548)
        Me.Lstbx.TabIndex = 7
        '
        'Btn_Buy
        '
        Me.Btn_Buy.Location = New System.Drawing.Point(106, 256)
        Me.Btn_Buy.Name = "Btn_Buy"
        Me.Btn_Buy.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Buy.TabIndex = 8
        Me.Btn_Buy.Text = "Buy"
        Me.Btn_Buy.UseVisualStyleBackColor = True
        '
        'Btn_Add
        '
        Me.Btn_Add.Location = New System.Drawing.Point(398, 256)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Add.TabIndex = 9
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 581)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Btn_Buy)
        Me.Controls.Add(Me.Lstbx)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Total_Buy As TextBox
    Friend WithEvents Txt_Name_Buy As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Txt_Amount_Money As TextBox
    Friend WithEvents Txt_Name_Money As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lstbx As ListBox
    Friend WithEvents Btn_Buy As Button
    Friend WithEvents Btn_Add As Button
End Class
