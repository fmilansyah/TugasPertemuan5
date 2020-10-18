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
        Me.tablet_list = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.syrup_list = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ointment_list = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ointment_total = New System.Windows.Forms.TextBox()
        Me.third_ointment_price = New System.Windows.Forms.TextBox()
        Me.third_ointment_name = New System.Windows.Forms.TextBox()
        Me.second_ointment_price = New System.Windows.Forms.TextBox()
        Me.second_ointment_name = New System.Windows.Forms.TextBox()
        Me.first_ointment_price = New System.Windows.Forms.TextBox()
        Me.first_ointment_name = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.syrup_total = New System.Windows.Forms.TextBox()
        Me.third_syrup_price = New System.Windows.Forms.TextBox()
        Me.third_syrup_name = New System.Windows.Forms.TextBox()
        Me.second_syrup_price = New System.Windows.Forms.TextBox()
        Me.second_syrup_name = New System.Windows.Forms.TextBox()
        Me.first_syrup_price = New System.Windows.Forms.TextBox()
        Me.first_syrup_name = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tablet_total = New System.Windows.Forms.TextBox()
        Me.third_tablet_price = New System.Windows.Forms.TextBox()
        Me.third_tablet_name = New System.Windows.Forms.TextBox()
        Me.second_tablet_price = New System.Windows.Forms.TextBox()
        Me.second_tablet_name = New System.Windows.Forms.TextBox()
        Me.first_tablet_price = New System.Windows.Forms.TextBox()
        Me.first_tablet_name = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tablet_list)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.syrup_list)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ointment_list)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(612, 273)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Obat"
        '
        'tablet_list
        '
        Me.tablet_list.FormattingEnabled = True
        Me.tablet_list.ItemHeight = 16
        Me.tablet_list.Location = New System.Drawing.Point(418, 52)
        Me.tablet_list.Name = "tablet_list"
        Me.tablet_list.Size = New System.Drawing.Size(187, 196)
        Me.tablet_list.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(415, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jenis Tablet"
        '
        'syrup_list
        '
        Me.syrup_list.FormattingEnabled = True
        Me.syrup_list.ItemHeight = 16
        Me.syrup_list.Location = New System.Drawing.Point(212, 51)
        Me.syrup_list.Name = "syrup_list"
        Me.syrup_list.Size = New System.Drawing.Size(187, 196)
        Me.syrup_list.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jenis Sirup"
        '
        'ointment_list
        '
        Me.ointment_list.FormattingEnabled = True
        Me.ointment_list.ItemHeight = 16
        Me.ointment_list.Location = New System.Drawing.Point(9, 52)
        Me.ointment_list.Name = "ointment_list"
        Me.ointment_list.Size = New System.Drawing.Size(185, 196)
        Me.ointment_list.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jenis Salep"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.total)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(631, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 70)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Pembelian"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(7, 31)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(237, 23)
        Me.total.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ointment_total)
        Me.GroupBox3.Controls.Add(Me.third_ointment_price)
        Me.GroupBox3.Controls.Add(Me.third_ointment_name)
        Me.GroupBox3.Controls.Add(Me.second_ointment_price)
        Me.GroupBox3.Controls.Add(Me.second_ointment_name)
        Me.GroupBox3.Controls.Add(Me.first_ointment_price)
        Me.GroupBox3.Controls.Add(Me.first_ointment_name)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 293)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 259)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pembelian Salep"
        '
        'ointment_total
        '
        Me.ointment_total.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ointment_total.Location = New System.Drawing.Point(6, 217)
        Me.ointment_total.Name = "ointment_total"
        Me.ointment_total.Size = New System.Drawing.Size(187, 23)
        Me.ointment_total.TabIndex = 7
        '
        'third_ointment_price
        '
        Me.third_ointment_price.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.third_ointment_price.Location = New System.Drawing.Point(6, 179)
        Me.third_ointment_price.Name = "third_ointment_price"
        Me.third_ointment_price.Size = New System.Drawing.Size(187, 23)
        Me.third_ointment_price.TabIndex = 6
        '
        'third_ointment_name
        '
        Me.third_ointment_name.Location = New System.Drawing.Point(5, 150)
        Me.third_ointment_name.Name = "third_ointment_name"
        Me.third_ointment_name.Size = New System.Drawing.Size(187, 23)
        Me.third_ointment_name.TabIndex = 5
        '
        'second_ointment_price
        '
        Me.second_ointment_price.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.second_ointment_price.Location = New System.Drawing.Point(7, 119)
        Me.second_ointment_price.Name = "second_ointment_price"
        Me.second_ointment_price.Size = New System.Drawing.Size(187, 23)
        Me.second_ointment_price.TabIndex = 4
        '
        'second_ointment_name
        '
        Me.second_ointment_name.Location = New System.Drawing.Point(6, 90)
        Me.second_ointment_name.Name = "second_ointment_name"
        Me.second_ointment_name.Size = New System.Drawing.Size(187, 23)
        Me.second_ointment_name.TabIndex = 3
        '
        'first_ointment_price
        '
        Me.first_ointment_price.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.first_ointment_price.Location = New System.Drawing.Point(7, 60)
        Me.first_ointment_price.Name = "first_ointment_price"
        Me.first_ointment_price.Size = New System.Drawing.Size(187, 23)
        Me.first_ointment_price.TabIndex = 2
        '
        'first_ointment_name
        '
        Me.first_ointment_name.Location = New System.Drawing.Point(6, 31)
        Me.first_ointment_name.Name = "first_ointment_name"
        Me.first_ointment_name.Size = New System.Drawing.Size(187, 23)
        Me.first_ointment_name.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.syrup_total)
        Me.GroupBox4.Controls.Add(Me.third_syrup_price)
        Me.GroupBox4.Controls.Add(Me.third_syrup_name)
        Me.GroupBox4.Controls.Add(Me.second_syrup_price)
        Me.GroupBox4.Controls.Add(Me.second_syrup_name)
        Me.GroupBox4.Controls.Add(Me.first_syrup_price)
        Me.GroupBox4.Controls.Add(Me.first_syrup_name)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(219, 293)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 259)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pembelian Sirup"
        '
        'syrup_total
        '
        Me.syrup_total.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.syrup_total.Location = New System.Drawing.Point(6, 217)
        Me.syrup_total.Name = "syrup_total"
        Me.syrup_total.Size = New System.Drawing.Size(187, 23)
        Me.syrup_total.TabIndex = 7
        '
        'third_syrup_price
        '
        Me.third_syrup_price.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.third_syrup_price.Location = New System.Drawing.Point(6, 179)
        Me.third_syrup_price.Name = "third_syrup_price"
        Me.third_syrup_price.Size = New System.Drawing.Size(187, 23)
        Me.third_syrup_price.TabIndex = 6
        '
        'third_syrup_name
        '
        Me.third_syrup_name.Location = New System.Drawing.Point(5, 150)
        Me.third_syrup_name.Name = "third_syrup_name"
        Me.third_syrup_name.Size = New System.Drawing.Size(187, 23)
        Me.third_syrup_name.TabIndex = 5
        '
        'second_syrup_price
        '
        Me.second_syrup_price.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.second_syrup_price.Location = New System.Drawing.Point(7, 119)
        Me.second_syrup_price.Name = "second_syrup_price"
        Me.second_syrup_price.Size = New System.Drawing.Size(187, 23)
        Me.second_syrup_price.TabIndex = 4
        '
        'second_syrup_name
        '
        Me.second_syrup_name.Location = New System.Drawing.Point(6, 90)
        Me.second_syrup_name.Name = "second_syrup_name"
        Me.second_syrup_name.Size = New System.Drawing.Size(187, 23)
        Me.second_syrup_name.TabIndex = 3
        '
        'first_syrup_price
        '
        Me.first_syrup_price.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.first_syrup_price.Location = New System.Drawing.Point(7, 61)
        Me.first_syrup_price.Name = "first_syrup_price"
        Me.first_syrup_price.Size = New System.Drawing.Size(187, 23)
        Me.first_syrup_price.TabIndex = 2
        '
        'first_syrup_name
        '
        Me.first_syrup_name.Location = New System.Drawing.Point(6, 31)
        Me.first_syrup_name.Name = "first_syrup_name"
        Me.first_syrup_name.Size = New System.Drawing.Size(187, 23)
        Me.first_syrup_name.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.tablet_total)
        Me.GroupBox5.Controls.Add(Me.third_tablet_price)
        Me.GroupBox5.Controls.Add(Me.third_tablet_name)
        Me.GroupBox5.Controls.Add(Me.second_tablet_price)
        Me.GroupBox5.Controls.Add(Me.second_tablet_name)
        Me.GroupBox5.Controls.Add(Me.first_tablet_price)
        Me.GroupBox5.Controls.Add(Me.first_tablet_name)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(425, 293)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 259)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Pembelian Tablet"
        '
        'tablet_total
        '
        Me.tablet_total.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tablet_total.Location = New System.Drawing.Point(6, 217)
        Me.tablet_total.Name = "tablet_total"
        Me.tablet_total.Size = New System.Drawing.Size(187, 23)
        Me.tablet_total.TabIndex = 7
        '
        'third_tablet_price
        '
        Me.third_tablet_price.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.third_tablet_price.Location = New System.Drawing.Point(6, 179)
        Me.third_tablet_price.Name = "third_tablet_price"
        Me.third_tablet_price.Size = New System.Drawing.Size(187, 23)
        Me.third_tablet_price.TabIndex = 6
        '
        'third_tablet_name
        '
        Me.third_tablet_name.Location = New System.Drawing.Point(5, 150)
        Me.third_tablet_name.Name = "third_tablet_name"
        Me.third_tablet_name.Size = New System.Drawing.Size(187, 23)
        Me.third_tablet_name.TabIndex = 5
        '
        'second_tablet_price
        '
        Me.second_tablet_price.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.second_tablet_price.Location = New System.Drawing.Point(7, 119)
        Me.second_tablet_price.Name = "second_tablet_price"
        Me.second_tablet_price.Size = New System.Drawing.Size(187, 23)
        Me.second_tablet_price.TabIndex = 4
        '
        'second_tablet_name
        '
        Me.second_tablet_name.Location = New System.Drawing.Point(6, 90)
        Me.second_tablet_name.Name = "second_tablet_name"
        Me.second_tablet_name.Size = New System.Drawing.Size(187, 23)
        Me.second_tablet_name.TabIndex = 3
        '
        'first_tablet_price
        '
        Me.first_tablet_price.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.first_tablet_price.Location = New System.Drawing.Point(7, 61)
        Me.first_tablet_price.Name = "first_tablet_price"
        Me.first_tablet_price.Size = New System.Drawing.Size(187, 23)
        Me.first_tablet_price.TabIndex = 2
        '
        'first_tablet_name
        '
        Me.first_tablet_name.Location = New System.Drawing.Point(6, 31)
        Me.first_tablet_name.Name = "first_tablet_name"
        Me.first_tablet_name.Size = New System.Drawing.Size(187, 23)
        Me.first_tablet_name.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(632, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(249, 462)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 564)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tablet_list As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents syrup_list As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ointment_list As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents total As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ointment_total As TextBox
    Friend WithEvents third_ointment_price As TextBox
    Friend WithEvents third_ointment_name As TextBox
    Friend WithEvents second_ointment_price As TextBox
    Friend WithEvents second_ointment_name As TextBox
    Friend WithEvents first_ointment_price As TextBox
    Friend WithEvents first_ointment_name As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents syrup_total As TextBox
    Friend WithEvents third_syrup_price As TextBox
    Friend WithEvents third_syrup_name As TextBox
    Friend WithEvents second_syrup_price As TextBox
    Friend WithEvents second_syrup_name As TextBox
    Friend WithEvents first_syrup_price As TextBox
    Friend WithEvents first_syrup_name As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents tablet_total As TextBox
    Friend WithEvents third_tablet_price As TextBox
    Friend WithEvents third_tablet_name As TextBox
    Friend WithEvents second_tablet_price As TextBox
    Friend WithEvents second_tablet_name As TextBox
    Friend WithEvents first_tablet_price As TextBox
    Friend WithEvents first_tablet_name As TextBox
    Friend WithEvents Button1 As Button
End Class
