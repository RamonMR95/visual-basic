<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.picSony = New System.Windows.Forms.PictureBox()
        Me.picLg = New System.Windows.Forms.PictureBox()
        Me.picIphone = New System.Windows.Forms.PictureBox()
        Me.picSamsung = New System.Windows.Forms.PictureBox()
        Me.lblIphone = New System.Windows.Forms.Label()
        Me.lbXiaomi = New System.Windows.Forms.Label()
        Me.lblSamS8 = New System.Windows.Forms.Label()
        Me.lblHuawei = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstCompra = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkbIphone = New System.Windows.Forms.CheckBox()
        Me.chkbLg = New System.Windows.Forms.CheckBox()
        Me.chkbSamsung = New System.Windows.Forms.CheckBox()
        Me.chkbSony = New System.Windows.Forms.CheckBox()
        CType(Me.picSony, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIphone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSamsung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picSony
        '
        Me.picSony.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSony.Image = CType(resources.GetObject("picSony.Image"), System.Drawing.Image)
        Me.picSony.Location = New System.Drawing.Point(105, 173)
        Me.picSony.Name = "picSony"
        Me.picSony.Size = New System.Drawing.Size(69, 84)
        Me.picSony.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSony.TabIndex = 0
        Me.picSony.TabStop = False
        '
        'picLg
        '
        Me.picLg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLg.Image = CType(resources.GetObject("picLg.Image"), System.Drawing.Image)
        Me.picLg.Location = New System.Drawing.Point(105, 34)
        Me.picLg.Name = "picLg"
        Me.picLg.Size = New System.Drawing.Size(69, 84)
        Me.picLg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLg.TabIndex = 1
        Me.picLg.TabStop = False
        '
        'picIphone
        '
        Me.picIphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picIphone.Image = CType(resources.GetObject("picIphone.Image"), System.Drawing.Image)
        Me.picIphone.Location = New System.Drawing.Point(19, 34)
        Me.picIphone.Name = "picIphone"
        Me.picIphone.Size = New System.Drawing.Size(68, 84)
        Me.picIphone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picIphone.TabIndex = 2
        Me.picIphone.TabStop = False
        '
        'picSamsung
        '
        Me.picSamsung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSamsung.Image = CType(resources.GetObject("picSamsung.Image"), System.Drawing.Image)
        Me.picSamsung.Location = New System.Drawing.Point(19, 173)
        Me.picSamsung.Name = "picSamsung"
        Me.picSamsung.Size = New System.Drawing.Size(68, 84)
        Me.picSamsung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSamsung.TabIndex = 3
        Me.picSamsung.TabStop = False
        '
        'lblIphone
        '
        Me.lblIphone.AllowDrop = True
        Me.lblIphone.AutoSize = True
        Me.lblIphone.BackColor = System.Drawing.Color.LightGreen
        Me.lblIphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIphone.Location = New System.Drawing.Point(19, 14)
        Me.lblIphone.Name = "lblIphone"
        Me.lblIphone.Size = New System.Drawing.Size(67, 17)
        Me.lblIphone.TabIndex = 4
        Me.lblIphone.Text = "Iphone11"
        '
        'lbXiaomi
        '
        Me.lbXiaomi.AllowDrop = True
        Me.lbXiaomi.AutoSize = True
        Me.lbXiaomi.BackColor = System.Drawing.Color.LightGreen
        Me.lbXiaomi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbXiaomi.Location = New System.Drawing.Point(104, 14)
        Me.lbXiaomi.Name = "lbXiaomi"
        Me.lbXiaomi.Size = New System.Drawing.Size(58, 17)
        Me.lbXiaomi.TabIndex = 5
        Me.lbXiaomi.Text = "Xiaomi9"
        '
        'lblSamS8
        '
        Me.lblSamS8.AllowDrop = True
        Me.lblSamS8.AutoSize = True
        Me.lblSamS8.BackColor = System.Drawing.Color.LightGreen
        Me.lblSamS8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSamS8.Location = New System.Drawing.Point(19, 153)
        Me.lblSamS8.Name = "lblSamS8"
        Me.lblSamS8.Size = New System.Drawing.Size(84, 17)
        Me.lblSamS8.TabIndex = 6
        Me.lblSamS8.Text = "SamsungS8"
        '
        'lblHuawei
        '
        Me.lblHuawei.AllowDrop = True
        Me.lblHuawei.AutoSize = True
        Me.lblHuawei.BackColor = System.Drawing.Color.LightGreen
        Me.lblHuawei.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHuawei.Location = New System.Drawing.Point(104, 153)
        Me.lblHuawei.Name = "lblHuawei"
        Me.lblHuawei.Size = New System.Drawing.Size(79, 17)
        Me.lblHuawei.TabIndex = 7
        Me.lblHuawei.Text = "HuaweiP30"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Orange
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "790€"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Orange
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(134, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "365€"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Orange
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "350€"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Orange
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(134, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 18)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "230€"
        '
        'lstCompra
        '
        Me.lstCompra.AllowDrop = True
        Me.lstCompra.FormattingEnabled = True
        Me.lstCompra.Location = New System.Drawing.Point(242, 34)
        Me.lstCompra.Name = "lstCompra"
        Me.lstCompra.Size = New System.Drawing.Size(120, 147)
        Me.lstCompra.TabIndex = 12
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 26)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGreen
        Me.Label1.Location = New System.Drawing.Point(239, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Bolsa Compra"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(287, 187)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(73, 20)
        Me.txtTotal.TabIndex = 14
        Me.txtTotal.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Total"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(285, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Comprar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkbIphone
        '
        Me.chkbIphone.AutoSize = True
        Me.chkbIphone.Location = New System.Drawing.Point(22, 121)
        Me.chkbIphone.Name = "chkbIphone"
        Me.chkbIphone.Size = New System.Drawing.Size(15, 14)
        Me.chkbIphone.TabIndex = 17
        Me.chkbIphone.UseVisualStyleBackColor = True
        Me.chkbIphone.Visible = False
        '
        'chkbLg
        '
        Me.chkbLg.AutoSize = True
        Me.chkbLg.Location = New System.Drawing.Point(107, 122)
        Me.chkbLg.Name = "chkbLg"
        Me.chkbLg.Size = New System.Drawing.Size(15, 14)
        Me.chkbLg.TabIndex = 18
        Me.chkbLg.UseVisualStyleBackColor = True
        Me.chkbLg.Visible = False
        '
        'chkbSamsung
        '
        Me.chkbSamsung.AutoSize = True
        Me.chkbSamsung.Location = New System.Drawing.Point(22, 263)
        Me.chkbSamsung.Name = "chkbSamsung"
        Me.chkbSamsung.Size = New System.Drawing.Size(15, 14)
        Me.chkbSamsung.TabIndex = 19
        Me.chkbSamsung.UseVisualStyleBackColor = True
        Me.chkbSamsung.Visible = False
        '
        'chkbSony
        '
        Me.chkbSony.AutoSize = True
        Me.chkbSony.Location = New System.Drawing.Point(107, 260)
        Me.chkbSony.Name = "chkbSony"
        Me.chkbSony.Size = New System.Drawing.Size(15, 14)
        Me.chkbSony.TabIndex = 20
        Me.chkbSony.UseVisualStyleBackColor = True
        Me.chkbSony.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 307)
        Me.Controls.Add(Me.chkbSony)
        Me.Controls.Add(Me.chkbSamsung)
        Me.Controls.Add(Me.chkbLg)
        Me.Controls.Add(Me.chkbIphone)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstCompra)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblHuawei)
        Me.Controls.Add(Me.lblSamS8)
        Me.Controls.Add(Me.lbXiaomi)
        Me.Controls.Add(Me.lblIphone)
        Me.Controls.Add(Me.picSamsung)
        Me.Controls.Add(Me.picIphone)
        Me.Controls.Add(Me.picLg)
        Me.Controls.Add(Me.picSony)
        Me.Name = "Form2"
        Me.Text = "Compras"
        CType(Me.picSony, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIphone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSamsung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picSony As System.Windows.Forms.PictureBox
    Friend WithEvents picLg As System.Windows.Forms.PictureBox
    Friend WithEvents picIphone As System.Windows.Forms.PictureBox
    Friend WithEvents picSamsung As System.Windows.Forms.PictureBox
    Friend WithEvents lblIphone As System.Windows.Forms.Label
    Friend WithEvents lbXiaomi As System.Windows.Forms.Label
    Friend WithEvents lblSamS8 As System.Windows.Forms.Label
    Friend WithEvents lblHuawei As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lstCompra As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkbIphone As System.Windows.Forms.CheckBox
    Friend WithEvents chkbLg As System.Windows.Forms.CheckBox
    Friend WithEvents chkbSamsung As System.Windows.Forms.CheckBox
    Friend WithEvents chkbSony As System.Windows.Forms.CheckBox
End Class
