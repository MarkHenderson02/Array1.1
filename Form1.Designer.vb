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
        Me.Nama = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.LVNama = New System.Windows.Forms.ListView()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(51, 55)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(51, 20)
        Me.Nama.TabIndex = 0
        Me.Nama.Text = "Nama"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(145, 55)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(275, 20)
        Me.TxtNama.TabIndex = 1
        '
        'LVNama
        '
        Me.LVNama.HideSelection = False
        Me.LVNama.Location = New System.Drawing.Point(33, 90)
        Me.LVNama.Name = "LVNama"
        Me.LVNama.Size = New System.Drawing.Size(416, 340)
        Me.LVNama.TabIndex = 2
        Me.LVNama.UseCompatibleStateImageBehavior = False
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(121, 462)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 3
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(286, 462)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BtnKeluar.TabIndex = 4
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 505)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.LVNama)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Nama)
        Me.Name = "Form1"
        Me.Text = "Latihan 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nama As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents LVNama As ListView
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnKeluar As Button
End Class
