Public Class Form1
    Inherits System.Windows.Forms.Form

    Public Shared flag As Integer = 1
    Public Shared pallet() As String = {"FFFFFF", "FFFFFF", "FFFFFF", "FFFFFF", "FFFFFF", "FFFFFF", "FFFFFF", "FFFFFF", "FFFFFF", "FFFFFF", "FFFFFF", "FFFFFF"}
    Public Shared palletCount As Integer = 0
    Public Shared lockRed As Integer = 0
    Public Shared lockGreen As Integer = 0
    Public Shared lockBlue As Integer = 0

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents tbRed As System.Windows.Forms.TrackBar
    Friend WithEvents tbGreen As System.Windows.Forms.TrackBar
    Friend WithEvents tbBlue As System.Windows.Forms.TrackBar
    Friend WithEvents lblBlue As System.Windows.Forms.Label
    Friend WithEvents lblRed As System.Windows.Forms.Label
    Friend WithEvents lblGreen As System.Windows.Forms.Label
    Friend WithEvents preview As System.Windows.Forms.Panel
    Friend WithEvents txtGreen As System.Windows.Forms.TextBox
    Friend WithEvents txtBlue As System.Windows.Forms.TextBox
    Friend WithEvents txtRed As System.Windows.Forms.TextBox
    Friend WithEvents txtHex As System.Windows.Forms.TextBox
    Friend WithEvents lblHex As System.Windows.Forms.Label
    Friend WithEvents btnRandom As System.Windows.Forms.Button
    Friend WithEvents gbPallet As System.Windows.Forms.GroupBox
    Friend WithEvents btnPallet As System.Windows.Forms.Button
    Friend WithEvents pColor3 As System.Windows.Forms.Panel
    Friend WithEvents pColor5 As System.Windows.Forms.Panel
    Friend WithEvents pColor1 As System.Windows.Forms.Panel
    Friend WithEvents pColor2 As System.Windows.Forms.Panel
    Friend WithEvents pColor4 As System.Windows.Forms.Panel
    Friend WithEvents pColor6 As System.Windows.Forms.Panel
    Friend WithEvents pColor12 As System.Windows.Forms.Panel
    Friend WithEvents pColor10 As System.Windows.Forms.Panel
    Friend WithEvents pColor8 As System.Windows.Forms.Panel
    Friend WithEvents pColor7 As System.Windows.Forms.Panel
    Friend WithEvents pColor9 As System.Windows.Forms.Panel
    Friend WithEvents pColor11 As System.Windows.Forms.Panel
    Friend WithEvents btnLockRed As System.Windows.Forms.Button
    Friend WithEvents btnLockGreen As System.Windows.Forms.Button
    Friend WithEvents btnLockBlue As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.tbRed = New System.Windows.Forms.TrackBar
        Me.tbGreen = New System.Windows.Forms.TrackBar
        Me.tbBlue = New System.Windows.Forms.TrackBar
        Me.lblBlue = New System.Windows.Forms.Label
        Me.lblRed = New System.Windows.Forms.Label
        Me.lblGreen = New System.Windows.Forms.Label
        Me.preview = New System.Windows.Forms.Panel
        Me.txtGreen = New System.Windows.Forms.TextBox
        Me.txtBlue = New System.Windows.Forms.TextBox
        Me.txtRed = New System.Windows.Forms.TextBox
        Me.txtHex = New System.Windows.Forms.TextBox
        Me.lblHex = New System.Windows.Forms.Label
        Me.btnRandom = New System.Windows.Forms.Button
        Me.gbPallet = New System.Windows.Forms.GroupBox
        Me.pColor12 = New System.Windows.Forms.Panel
        Me.pColor10 = New System.Windows.Forms.Panel
        Me.pColor8 = New System.Windows.Forms.Panel
        Me.pColor7 = New System.Windows.Forms.Panel
        Me.pColor9 = New System.Windows.Forms.Panel
        Me.pColor11 = New System.Windows.Forms.Panel
        Me.pColor6 = New System.Windows.Forms.Panel
        Me.pColor4 = New System.Windows.Forms.Panel
        Me.pColor2 = New System.Windows.Forms.Panel
        Me.pColor1 = New System.Windows.Forms.Panel
        Me.pColor3 = New System.Windows.Forms.Panel
        Me.pColor5 = New System.Windows.Forms.Panel
        Me.btnPallet = New System.Windows.Forms.Button
        Me.btnLockRed = New System.Windows.Forms.Button
        Me.btnLockGreen = New System.Windows.Forms.Button
        Me.btnLockBlue = New System.Windows.Forms.Button
        CType(Me.tbRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPallet.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbRed
        '
        Me.tbRed.Location = New System.Drawing.Point(32, 16)
        Me.tbRed.Maximum = 255
        Me.tbRed.Name = "tbRed"
        Me.tbRed.Size = New System.Drawing.Size(184, 45)
        Me.tbRed.TabIndex = 0
        Me.tbRed.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbGreen
        '
        Me.tbGreen.Location = New System.Drawing.Point(32, 64)
        Me.tbGreen.Maximum = 255
        Me.tbGreen.Name = "tbGreen"
        Me.tbGreen.Size = New System.Drawing.Size(184, 45)
        Me.tbGreen.TabIndex = 2
        Me.tbGreen.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbBlue
        '
        Me.tbBlue.Location = New System.Drawing.Point(32, 112)
        Me.tbBlue.Maximum = 255
        Me.tbBlue.Name = "tbBlue"
        Me.tbBlue.Size = New System.Drawing.Size(184, 45)
        Me.tbBlue.TabIndex = 4
        Me.tbBlue.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblBlue
        '
        Me.lblBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlue.Location = New System.Drawing.Point(8, 112)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(16, 24)
        Me.lblBlue.TabIndex = 3
        Me.lblBlue.Text = "B"
        '
        'lblRed
        '
        Me.lblRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRed.Location = New System.Drawing.Point(8, 16)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(16, 24)
        Me.lblRed.TabIndex = 4
        Me.lblRed.Text = "R"
        '
        'lblGreen
        '
        Me.lblGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreen.Location = New System.Drawing.Point(8, 64)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(16, 24)
        Me.lblGreen.TabIndex = 5
        Me.lblGreen.Text = "G"
        '
        'preview
        '
        Me.preview.BackColor = System.Drawing.Color.Black
        Me.preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.preview.Location = New System.Drawing.Point(304, 16)
        Me.preview.Name = "preview"
        Me.preview.Size = New System.Drawing.Size(120, 120)
        Me.preview.TabIndex = 6
        '
        'txtGreen
        '
        Me.txtGreen.Location = New System.Drawing.Point(224, 64)
        Me.txtGreen.MaxLength = 3
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(40, 20)
        Me.txtGreen.TabIndex = 3
        Me.txtGreen.Text = "0"
        Me.txtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBlue
        '
        Me.txtBlue.AcceptsReturn = True
        Me.txtBlue.Location = New System.Drawing.Point(224, 112)
        Me.txtBlue.MaxLength = 3
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(40, 20)
        Me.txtBlue.TabIndex = 5
        Me.txtBlue.Text = "0"
        Me.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRed
        '
        Me.txtRed.Location = New System.Drawing.Point(224, 16)
        Me.txtRed.MaxLength = 3
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(40, 20)
        Me.txtRed.TabIndex = 1
        Me.txtRed.Text = "0"
        Me.txtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHex
        '
        Me.txtHex.Location = New System.Drawing.Point(368, 152)
        Me.txtHex.MaxLength = 6
        Me.txtHex.Name = "txtHex"
        Me.txtHex.Size = New System.Drawing.Size(48, 20)
        Me.txtHex.TabIndex = 7
        Me.txtHex.Text = "000000"
        '
        'lblHex
        '
        Me.lblHex.Location = New System.Drawing.Point(336, 152)
        Me.lblHex.Name = "lblHex"
        Me.lblHex.Size = New System.Drawing.Size(32, 16)
        Me.lblHex.TabIndex = 8
        Me.lblHex.Text = "Hex:"
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(360, 186)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(56, 24)
        Me.btnRandom.TabIndex = 9
        Me.btnRandom.Text = "Random"
        '
        'gbPallet
        '
        Me.gbPallet.Controls.Add(Me.pColor12)
        Me.gbPallet.Controls.Add(Me.pColor10)
        Me.gbPallet.Controls.Add(Me.pColor8)
        Me.gbPallet.Controls.Add(Me.pColor7)
        Me.gbPallet.Controls.Add(Me.pColor9)
        Me.gbPallet.Controls.Add(Me.pColor11)
        Me.gbPallet.Controls.Add(Me.pColor6)
        Me.gbPallet.Controls.Add(Me.pColor4)
        Me.gbPallet.Controls.Add(Me.pColor2)
        Me.gbPallet.Controls.Add(Me.pColor1)
        Me.gbPallet.Controls.Add(Me.pColor3)
        Me.gbPallet.Controls.Add(Me.pColor5)
        Me.gbPallet.Location = New System.Drawing.Point(16, 152)
        Me.gbPallet.Name = "gbPallet"
        Me.gbPallet.Size = New System.Drawing.Size(256, 96)
        Me.gbPallet.TabIndex = 10
        Me.gbPallet.TabStop = False
        Me.gbPallet.Text = "Color Pallet"
        '
        'pColor12
        '
        Me.pColor12.BackColor = System.Drawing.Color.White
        Me.pColor12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pColor12.Location = New System.Drawing.Point(216, 56)
        Me.pColor12.Name = "pColor12"
        Me.pColor12.Size = New System.Drawing.Size(24, 24)
        Me.pColor12.TabIndex = 11
        '
        'pColor10
        '
        Me.pColor10.BackColor = System.Drawing.Color.White
        Me.pColor10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pColor10.Location = New System.Drawing.Point(136, 56)
        Me.pColor10.Name = "pColor10"
        Me.pColor10.Size = New System.Drawing.Size(24, 24)
        Me.pColor10.TabIndex = 10
        '
        'pColor8
        '
        Me.pColor8.BackColor = System.Drawing.Color.White
        Me.pColor8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pColor8.Location = New System.Drawing.Point(56, 56)
        Me.pColor8.Name = "pColor8"
        Me.pColor8.Size = New System.Drawing.Size(24, 24)
        Me.pColor8.TabIndex = 9
        '
        'pColor7
        '
        Me.pColor7.BackColor = System.Drawing.Color.White
        Me.pColor7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pColor7.Location = New System.Drawing.Point(16, 56)
        Me.pColor7.Name = "pColor7"
        Me.pColor7.Size = New System.Drawing.Size(24, 24)
        Me.pColor7.TabIndex = 8
        '
        'pColor9
        '
        Me.pColor9.BackColor = System.Drawing.Color.White
        Me.pColor9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pColor9.Location = New System.Drawing.Point(96, 56)
        Me.pColor9.Name = "pColor9"
        Me.pColor9.Size = New System.Drawing.Size(24, 24)
        Me.pColor9.TabIndex = 6
        '
        'pColor11
        '
        Me.pColor11.BackColor = System.Drawing.Color.White
        Me.pColor11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pColor11.Location = New System.Drawing.Point(176, 56)
        Me.pColor11.Name = "pColor11"
        Me.pColor11.Size = New System.Drawing.Size(24, 24)
        Me.pColor11.TabIndex = 7
        '
        'pColor6
        '
        Me.pColor6.BackColor = System.Drawing.Color.White
        Me.pColor6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pColor6.Location = New System.Drawing.Point(216, 24)
        Me.pColor6.Name = "pColor6"
        Me.pColor6.Size = New System.Drawing.Size(24, 24)
        Me.pColor6.TabIndex = 5
        '
        'pColor4
        '
        Me.pColor4.BackColor = System.Drawing.Color.White
        Me.pColor4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pColor4.Location = New System.Drawing.Point(136, 24)
        Me.pColor4.Name = "pColor4"
        Me.pColor4.Size = New System.Drawing.Size(24, 24)
        Me.pColor4.TabIndex = 4
        '
        'pColor2
        '
        Me.pColor2.BackColor = System.Drawing.Color.White
        Me.pColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pColor2.Location = New System.Drawing.Point(56, 24)
        Me.pColor2.Name = "pColor2"
        Me.pColor2.Size = New System.Drawing.Size(24, 24)
        Me.pColor2.TabIndex = 3
        '
        'pColor1
        '
        Me.pColor1.BackColor = System.Drawing.Color.White
        Me.pColor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pColor1.Location = New System.Drawing.Point(16, 24)
        Me.pColor1.Name = "pColor1"
        Me.pColor1.Size = New System.Drawing.Size(24, 24)
        Me.pColor1.TabIndex = 2
        '
        'pColor3
        '
        Me.pColor3.BackColor = System.Drawing.Color.White
        Me.pColor3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pColor3.Location = New System.Drawing.Point(96, 24)
        Me.pColor3.Name = "pColor3"
        Me.pColor3.Size = New System.Drawing.Size(24, 24)
        Me.pColor3.TabIndex = 0
        '
        'pColor5
        '
        Me.pColor5.BackColor = System.Drawing.Color.White
        Me.pColor5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pColor5.Location = New System.Drawing.Point(176, 24)
        Me.pColor5.Name = "pColor5"
        Me.pColor5.Size = New System.Drawing.Size(24, 24)
        Me.pColor5.TabIndex = 1
        '
        'btnPallet
        '
        Me.btnPallet.Location = New System.Drawing.Point(336, 224)
        Me.btnPallet.Name = "btnPallet"
        Me.btnPallet.Size = New System.Drawing.Size(80, 24)
        Me.btnPallet.TabIndex = 11
        Me.btnPallet.Text = "Add to Pallet"
        '
        'btnLockRed
        '
        Me.btnLockRed.Image = CType(resources.GetObject("btnLockRed.Image"), System.Drawing.Image)
        Me.btnLockRed.Location = New System.Drawing.Point(272, 16)
        Me.btnLockRed.Name = "btnLockRed"
        Me.btnLockRed.Size = New System.Drawing.Size(24, 24)
        Me.btnLockRed.TabIndex = 12
        '
        'btnLockGreen
        '
        Me.btnLockGreen.Image = CType(resources.GetObject("btnLockGreen.Image"), System.Drawing.Image)
        Me.btnLockGreen.Location = New System.Drawing.Point(272, 64)
        Me.btnLockGreen.Name = "btnLockGreen"
        Me.btnLockGreen.Size = New System.Drawing.Size(24, 24)
        Me.btnLockGreen.TabIndex = 13
        '
        'btnLockBlue
        '
        Me.btnLockBlue.Image = CType(resources.GetObject("btnLockBlue.Image"), System.Drawing.Image)
        Me.btnLockBlue.Location = New System.Drawing.Point(272, 112)
        Me.btnLockBlue.Name = "btnLockBlue"
        Me.btnLockBlue.Size = New System.Drawing.Size(24, 24)
        Me.btnLockBlue.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 260)
        Me.Controls.Add(Me.btnLockBlue)
        Me.Controls.Add(Me.btnLockGreen)
        Me.Controls.Add(Me.btnLockRed)
        Me.Controls.Add(Me.btnPallet)
        Me.Controls.Add(Me.gbPallet)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.lblHex)
        Me.Controls.Add(Me.txtHex)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.txtRed)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtGreen)
        Me.Controls.Add(Me.preview)
        Me.Controls.Add(Me.tbBlue)
        Me.Controls.Add(Me.tbGreen)
        Me.Controls.Add(Me.tbRed)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(456, 296)
        Me.MinimumSize = New System.Drawing.Size(456, 296)
        Me.Name = "Form1"
        Me.Text = "Color Picker 1.0"
        CType(Me.tbRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPallet.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub tbRed_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbRed.Scroll
        txtRed.Text = tbRed.Value.ToString
        preview.BackColor = Color.FromArgb(Int32.Parse(txtRed.Text), Int32.Parse(txtGreen.Text), Int32.Parse(txtBlue.Text))
        txtHex.Text = Hex(Int32.Parse(txtRed.Text)).ToString.PadLeft(2, "0") + Hex(Int32.Parse(txtGreen.Text)).ToString.PadLeft(2, "0") + Hex(Int32.Parse(txtBlue.Text)).ToString.PadLeft(2, "0")
    End Sub

    Private Sub tbGreen_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbGreen.Scroll
        txtGreen.Text = tbGreen.Value.ToString
        preview.BackColor = Color.FromArgb(Int32.Parse(txtRed.Text), Int32.Parse(txtGreen.Text), Int32.Parse(txtBlue.Text))
        txtHex.Text = Hex(Int32.Parse(txtRed.Text)).ToString.PadLeft(2, "0") + Hex(Int32.Parse(txtGreen.Text)).ToString.PadLeft(2, "0") + Hex(Int32.Parse(txtBlue.Text)).ToString.PadLeft(2, "0")
    End Sub

    Private Sub tbBlue_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBlue.Scroll
        txtBlue.Text = tbBlue.Value.ToString
        preview.BackColor = Color.FromArgb(Int32.Parse(txtRed.Text), Int32.Parse(txtGreen.Text), Int32.Parse(txtBlue.Text))
        If flag = 1 Then
            txtHex.Text = Hex(Int32.Parse(txtRed.Text)).ToString.PadLeft(2, "0") + Hex(Int32.Parse(txtGreen.Text)).ToString.PadLeft(2, "0") + Hex(Int32.Parse(txtBlue.Text)).ToString.PadLeft(2, "0")
        End If
    End Sub

    Private Sub txtRed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRed.TextChanged
        Try
            If (Int32.Parse(txtRed.Text) > 255) Then
                tbRed.Value = 255
                txtRed.Text = "255"
            ElseIf (Int32.Parse(txtRed.Text) < 0) Then
                tbRed.Value = 0
                txtRed.Text = "0"
            Else
                tbRed.Value = txtRed.Text
            End If

            preview.BackColor = Color.FromArgb(255, tbRed.Value, tbGreen.Value, tbBlue.Value)
            If flag = 1 Then
                txtHex.Text = Hex(Int32.Parse(tbRed.Value)).ToString.PadLeft(2, "0") + Hex(Int32.Parse(tbGreen.Value)).ToString.PadLeft(2, "0") + Hex(Int32.Parse(tbBlue.Value)).ToString.PadLeft(2, "0")
            End If
        Catch
            MessageBox.Show("Error: Please enter a numerical value.", "Error")
            txtRed.Text = "0"
        End Try
    End Sub

    Private Sub txtGreen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGreen.TextChanged
        Try
            If (Int32.Parse(txtGreen.Text) > 255) Then
                tbGreen.Value = 255
                txtGreen.Text = "255"
            ElseIf (Int32.Parse(txtGreen.Text) < 0) Then
                tbGreen.Value = 0
                txtGreen.Text = "0"
            Else
                tbGreen.Value = txtGreen.Text
            End If

            preview.BackColor = Color.FromArgb(255, tbRed.Value, tbGreen.Value, tbBlue.Value)
            If flag = 1 Then
                txtHex.Text = Hex(Int32.Parse(tbRed.Value)).ToString.PadLeft(2, "0") + Hex(Int32.Parse(tbGreen.Value)).ToString.PadLeft(2, "0") + Hex(Int32.Parse(tbBlue.Value)).ToString.PadLeft(2, "0")
            End If
        Catch
            MessageBox.Show("Error: Please enter a numerical value.", "Error")
            txtGreen.Text = "0"
        End Try
    End Sub

    Private Sub txtBlue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBlue.TextChanged
        Try
            If (Int32.Parse(txtBlue.Text) > 255) Then
                tbBlue.Value = 255
                txtBlue.Text = "255"
            ElseIf (Int32.Parse(txtBlue.Text) < 0) Then
                tbBlue.Value = 0
                txtBlue.Text = "0"
            Else
                tbBlue.Value = txtBlue.Text
            End If

            preview.BackColor = Color.FromArgb(255, tbRed.Value, tbGreen.Value, tbBlue.Value)
            If flag = 1 Then
                txtHex.Text = Hex(Int32.Parse(tbRed.Value)).ToString.PadLeft(2, "0") + Hex(Int32.Parse(tbGreen.Value)).ToString.PadLeft(2, "0") + Hex(Int32.Parse(tbBlue.Value)).ToString.PadLeft(2, "0")
            End If
        Catch
            MessageBox.Show("Error: Please enter a numerical value.", "Error")
            txtBlue.Text = "0"
        End Try
    End Sub

    Private Sub txtHex_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHex.TextChanged
        If txtHex.Text.Length = 6 Then
            flag = 0
            txtRed.Text = Val("&H" & Mid(txtHex.Text, 1, 2))
            txtGreen.Text = Val("&H" & Mid(txtHex.Text, 3, 2))
            txtBlue.Text = Val("&H" & Mid(txtHex.Text, 5, 2))
            flag = 1
        End If
    End Sub

    Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click
        Dim RandomClass As New Random

        If (lockRed = 0) Then
            txtRed.Text = RandomClass.Next(0, 256)
        End If
        If lockGreen = 0 Then
            txtGreen.Text = RandomClass.Next(0, 256)
        End If
        If lockBlue = 0 Then
            txtBlue.Text = RandomClass.Next(0, 256)
        End If
    End Sub

    Private Sub btnPallet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPallet.Click
        pallet(palletCount) = txtHex.Text

        Dim red As Integer = Val("&H" & Mid(pallet(palletCount), 1, 2))
        Dim green As Integer = Val("&H" & Mid(pallet(palletCount), 3, 2))
        Dim blue As Integer = Val("&H" & Mid(pallet(palletCount), 5, 2))

        Select Case palletCount
            Case 0
                pColor1.BackColor = Color.FromArgb(255, red, green, blue)
            Case 1
                pColor2.BackColor = Color.FromArgb(255, red, green, blue)
            Case 2
                pColor3.BackColor = Color.FromArgb(255, red, green, blue)
            Case 3
                pColor4.BackColor = Color.FromArgb(255, red, green, blue)
            Case 4
                pColor5.BackColor = Color.FromArgb(255, red, green, blue)
            Case 5
                pColor6.BackColor = Color.FromArgb(255, red, green, blue)
            Case 6
                pColor7.BackColor = Color.FromArgb(255, red, green, blue)
            Case 7
                pColor8.BackColor = Color.FromArgb(255, red, green, blue)
            Case 8
                pColor9.BackColor = Color.FromArgb(255, red, green, blue)
            Case 9
                pColor10.BackColor = Color.FromArgb(255, red, green, blue)
            Case 10
                pColor11.BackColor = Color.FromArgb(255, red, green, blue)
            Case 11
                pColor12.BackColor = Color.FromArgb(255, red, green, blue)
        End Select

        palletCount += 1
        If palletCount > 11 Then
            btnPallet.Enabled = False
        End If

    End Sub

    Private Sub pColor1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pColor1.MouseUp

        txtRed.Text = Val("&H" & Mid(pallet(0), 1, 2))
        txtGreen.Text = Val("&H" & Mid(pallet(0), 3, 2))
        txtBlue.Text = Val("&H" & Mid(pallet(0), 5, 2))

    End Sub

    Private Sub pColor2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pColor2.MouseUp

        txtRed.Text = Val("&H" & Mid(pallet(1), 1, 2))
        txtGreen.Text = Val("&H" & Mid(pallet(1), 3, 2))
        txtBlue.Text = Val("&H" & Mid(pallet(1), 5, 2))

    End Sub

    Private Sub pColor3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pColor3.MouseUp

        txtRed.Text = Val("&H" & Mid(pallet(2), 1, 2))
        txtGreen.Text = Val("&H" & Mid(pallet(2), 3, 2))
        txtBlue.Text = Val("&H" & Mid(pallet(2), 5, 2))

    End Sub

    Private Sub pColor4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pColor4.MouseUp

        txtRed.Text = Val("&H" & Mid(pallet(3), 1, 2))
        txtGreen.Text = Val("&H" & Mid(pallet(3), 3, 2))
        txtBlue.Text = Val("&H" & Mid(pallet(3), 5, 2))

    End Sub

    Private Sub pColor5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pColor5.MouseUp

        txtRed.Text = Val("&H" & Mid(pallet(4), 1, 2))
        txtGreen.Text = Val("&H" & Mid(pallet(4), 3, 2))
        txtBlue.Text = Val("&H" & Mid(pallet(4), 5, 2))

    End Sub

    Private Sub pColor6_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pColor6.MouseUp

        txtRed.Text = Val("&H" & Mid(pallet(5), 1, 2))
        txtGreen.Text = Val("&H" & Mid(pallet(5), 3, 2))
        txtBlue.Text = Val("&H" & Mid(pallet(5), 5, 2))

    End Sub

    Private Sub pColor7_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pColor7.MouseUp

        txtRed.Text = Val("&H" & Mid(pallet(6), 1, 2))
        txtGreen.Text = Val("&H" & Mid(pallet(6), 3, 2))
        txtBlue.Text = Val("&H" & Mid(pallet(6), 5, 2))

    End Sub

    Private Sub pColor8_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pColor8.MouseUp

        txtRed.Text = Val("&H" & Mid(pallet(7), 1, 2))
        txtGreen.Text = Val("&H" & Mid(pallet(7), 3, 2))
        txtBlue.Text = Val("&H" & Mid(pallet(7), 5, 2))

    End Sub

    Private Sub pColor9_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pColor9.MouseUp

        txtRed.Text = Val("&H" & Mid(pallet(8), 1, 2))
        txtGreen.Text = Val("&H" & Mid(pallet(8), 3, 2))
        txtBlue.Text = Val("&H" & Mid(pallet(8), 5, 2))

    End Sub

    Private Sub pColor10_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pColor10.MouseUp

        txtRed.Text = Val("&H" & Mid(pallet(9), 1, 2))
        txtGreen.Text = Val("&H" & Mid(pallet(9), 3, 2))
        txtBlue.Text = Val("&H" & Mid(pallet(9), 5, 2))

    End Sub

    Private Sub pColor11_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pColor11.MouseUp

        txtRed.Text = Val("&H" & Mid(pallet(10), 1, 2))
        txtGreen.Text = Val("&H" & Mid(pallet(10), 3, 2))
        txtBlue.Text = Val("&H" & Mid(pallet(10), 5, 2))

    End Sub

    Private Sub pColor12_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pColor12.MouseUp

        txtRed.Text = Val("&H" & Mid(pallet(11), 1, 2))
        txtGreen.Text = Val("&H" & Mid(pallet(11), 3, 2))
        txtBlue.Text = Val("&H" & Mid(pallet(11), 5, 2))

    End Sub

    Private Sub btnLockRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLockRed.Click
        If lockRed = 1 Then
            lockRed = 0
            txtRed.Enabled = True
            tbRed.Enabled = True
            Try
                btnLockRed.Image = Image.FromFile("16-security-lock.png")
            Catch
            End Try
        Else
            lockRed = 1
            txtRed.Enabled = False
            tbRed.Enabled = False
            Try
                btnLockRed.Image = Image.FromFile("16-security-lock-open.png")
            Catch
            End Try
        End If
    End Sub

    Private Sub btnLockGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLockGreen.Click
        If lockGreen = 1 Then
            lockGreen = 0
            txtGreen.Enabled = True
            tbGreen.Enabled = True
            Try
                btnLockGreen.Image = Image.FromFile("16-security-lock.png")
            Catch
            End Try
        Else
            lockGreen = 1
            txtGreen.Enabled = False
            tbGreen.Enabled = False
            Try
                btnLockGreen.Image = Image.FromFile("16-security-lock-open.png")
            Catch
            End Try
        End If
    End Sub

    Private Sub btnLockBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLockBlue.Click
        If lockBlue = 1 Then
            lockBlue = 0
            txtBlue.Enabled = True
            tbBlue.Enabled = True
            Try
                btnLockBlue.Image = Image.FromFile("16-security-lock.png")
            Catch
            End Try
        Else
            lockBlue = 1
            txtBlue.Enabled = False
            tbBlue.Enabled = False
            Try
                btnLockBlue.Image = Image.FromFile("16-security-lock-open.png")
            Catch
            End Try
        End If
    End Sub
End Class
