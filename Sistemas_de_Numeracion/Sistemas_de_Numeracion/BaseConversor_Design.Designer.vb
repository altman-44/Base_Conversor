<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaseConversor_Design
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaseConversor_Design))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtQuantDecimals = New System.Windows.Forms.TextBox()
        Me.LblDecimals = New System.Windows.Forms.Label()
        Me.LblTxtNumber = New System.Windows.Forms.Label()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.TxtResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbSecondBase = New System.Windows.Forms.ComboBox()
        Me.CmbFirstBase = New System.Windows.Forms.ComboBox()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.TxtQuantDecimals)
        Me.GroupBox1.Controls.Add(Me.LblDecimals)
        Me.GroupBox1.Controls.Add(Me.LblTxtNumber)
        Me.GroupBox1.Controls.Add(Me.TxtNumber)
        Me.GroupBox1.Controls.Add(Me.TxtResult)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CmbSecondBase)
        Me.GroupBox1.Controls.Add(Me.CmbFirstBase)
        Me.GroupBox1.Controls.Add(Me.BtnConvert)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(425, 283)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtQuantDecimals
        '
        Me.TxtQuantDecimals.Location = New System.Drawing.Point(26, 134)
        Me.TxtQuantDecimals.Name = "TxtQuantDecimals"
        Me.TxtQuantDecimals.Size = New System.Drawing.Size(375, 26)
        Me.TxtQuantDecimals.TabIndex = 4
        Me.TxtQuantDecimals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblDecimals
        '
        Me.LblDecimals.AutoSize = True
        Me.LblDecimals.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDecimals.Location = New System.Drawing.Point(23, 160)
        Me.LblDecimals.Name = "LblDecimals"
        Me.LblDecimals.Size = New System.Drawing.Size(356, 14)
        Me.LblDecimals.TabIndex = 10
        Me.LblDecimals.Text = "(opcional, en caso de tener decimales, por predeterminado son 4)"
        '
        'LblTxtNumber
        '
        Me.LblTxtNumber.AutoSize = True
        Me.LblTxtNumber.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTxtNumber.Location = New System.Drawing.Point(22, 102)
        Me.LblTxtNumber.Name = "LblTxtNumber"
        Me.LblTxtNumber.Size = New System.Drawing.Size(302, 14)
        Me.LblTxtNumber.TabIndex = 9
        Me.LblTxtNumber.Text = "Para números con decimales usar ""."". Por ejemplo: 4.12"
        '
        'TxtNumber
        '
        Me.TxtNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtNumber.Location = New System.Drawing.Point(25, 76)
        Me.TxtNumber.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(377, 26)
        Me.TxtNumber.TabIndex = 3
        Me.TxtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtResult
        '
        Me.TxtResult.Location = New System.Drawing.Point(26, 235)
        Me.TxtResult.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtResult.Multiline = True
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.ReadOnly = True
        Me.TxtResult.Size = New System.Drawing.Size(376, 23)
        Me.TxtResult.TabIndex = 6
        Me.TxtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "convertir en"
        '
        'CmbSecondBase
        '
        Me.CmbSecondBase.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmbSecondBase.FormattingEnabled = True
        Me.CmbSecondBase.Location = New System.Drawing.Point(263, 34)
        Me.CmbSecondBase.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CmbSecondBase.Name = "CmbSecondBase"
        Me.CmbSecondBase.Size = New System.Drawing.Size(138, 24)
        Me.CmbSecondBase.TabIndex = 2
        Me.CmbSecondBase.Text = "Seleccionar base"
        '
        'CmbFirstBase
        '
        Me.CmbFirstBase.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmbFirstBase.FormattingEnabled = True
        Me.CmbFirstBase.Location = New System.Drawing.Point(25, 34)
        Me.CmbFirstBase.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CmbFirstBase.Name = "CmbFirstBase"
        Me.CmbFirstBase.Size = New System.Drawing.Size(139, 24)
        Me.CmbFirstBase.TabIndex = 1
        Me.CmbFirstBase.Text = "Seleccionar base"
        '
        'BtnConvert
        '
        Me.BtnConvert.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConvert.Location = New System.Drawing.Point(26, 190)
        Me.BtnConvert.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(112, 29)
        Me.BtnConvert.TabIndex = 5
        Me.BtnConvert.Text = "Convertir"
        Me.BtnConvert.UseVisualStyleBackColor = False
        '
        'BaseConversor_Design
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(455, 295)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "BaseConversor_Design"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversor de Bases"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbSecondBase As ComboBox
    Friend WithEvents CmbFirstBase As ComboBox
    Friend WithEvents BtnConvert As Button
    Friend WithEvents TxtResult As TextBox
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents LblTxtNumber As Label
    Friend WithEvents LblDecimals As Label
    Friend WithEvents TxtQuantDecimals As TextBox
End Class
