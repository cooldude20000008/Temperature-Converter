<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemperatureConverter
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
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.radKelvinOne = New System.Windows.Forms.RadioButton()
        Me.radCelciusOne = New System.Windows.Forms.RadioButton()
        Me.radFahrenheitOne = New System.Windows.Forms.RadioButton()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.radKelvinTwo = New System.Windows.Forms.RadioButton()
        Me.radCelciusTwo = New System.Windows.Forms.RadioButton()
        Me.radFahrenheitTwo = New System.Windows.Forms.RadioButton()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.lblOutputHeading = New System.Windows.Forms.Label()
        Me.lblInputHeading = New System.Windows.Forms.Label()
        Me.lblFormulaHeading = New System.Windows.Forms.Label()
        Me.grpInput.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.radKelvinOne)
        Me.grpInput.Controls.Add(Me.radCelciusOne)
        Me.grpInput.Controls.Add(Me.radFahrenheitOne)
        Me.grpInput.Location = New System.Drawing.Point(12, 12)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(200, 172)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Input"
        '
        'radKelvinOne
        '
        Me.radKelvinOne.AutoSize = True
        Me.radKelvinOne.Location = New System.Drawing.Point(7, 148)
        Me.radKelvinOne.Name = "radKelvinOne"
        Me.radKelvinOne.Size = New System.Drawing.Size(54, 17)
        Me.radKelvinOne.TabIndex = 2
        Me.radKelvinOne.Text = "Kelvin"
        Me.radKelvinOne.UseVisualStyleBackColor = True
        '
        'radCelciusOne
        '
        Me.radCelciusOne.AutoSize = True
        Me.radCelciusOne.Location = New System.Drawing.Point(7, 84)
        Me.radCelciusOne.Name = "radCelciusOne"
        Me.radCelciusOne.Size = New System.Drawing.Size(59, 17)
        Me.radCelciusOne.TabIndex = 1
        Me.radCelciusOne.Text = "Celcius"
        Me.radCelciusOne.UseVisualStyleBackColor = True
        '
        'radFahrenheitOne
        '
        Me.radFahrenheitOne.AutoSize = True
        Me.radFahrenheitOne.Location = New System.Drawing.Point(7, 20)
        Me.radFahrenheitOne.Name = "radFahrenheitOne"
        Me.radFahrenheitOne.Size = New System.Drawing.Size(75, 17)
        Me.radFahrenheitOne.TabIndex = 0
        Me.radFahrenheitOne.Text = "Fahrenheit"
        Me.radFahrenheitOne.UseVisualStyleBackColor = True
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.radKelvinTwo)
        Me.grpOutput.Controls.Add(Me.radCelciusTwo)
        Me.grpOutput.Controls.Add(Me.radFahrenheitTwo)
        Me.grpOutput.Location = New System.Drawing.Point(588, 12)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(200, 172)
        Me.grpOutput.TabIndex = 3
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output"
        '
        'radKelvinTwo
        '
        Me.radKelvinTwo.AutoSize = True
        Me.radKelvinTwo.Location = New System.Drawing.Point(7, 148)
        Me.radKelvinTwo.Name = "radKelvinTwo"
        Me.radKelvinTwo.Size = New System.Drawing.Size(54, 17)
        Me.radKelvinTwo.TabIndex = 2
        Me.radKelvinTwo.Text = "Kelvin"
        Me.radKelvinTwo.UseVisualStyleBackColor = True
        '
        'radCelciusTwo
        '
        Me.radCelciusTwo.AutoSize = True
        Me.radCelciusTwo.Location = New System.Drawing.Point(7, 84)
        Me.radCelciusTwo.Name = "radCelciusTwo"
        Me.radCelciusTwo.Size = New System.Drawing.Size(59, 17)
        Me.radCelciusTwo.TabIndex = 1
        Me.radCelciusTwo.Text = "Celcius"
        Me.radCelciusTwo.UseVisualStyleBackColor = True
        '
        'radFahrenheitTwo
        '
        Me.radFahrenheitTwo.AutoSize = True
        Me.radFahrenheitTwo.Location = New System.Drawing.Point(7, 20)
        Me.radFahrenheitTwo.Name = "radFahrenheitTwo"
        Me.radFahrenheitTwo.Size = New System.Drawing.Size(75, 17)
        Me.radFahrenheitTwo.TabIndex = 0
        Me.radFahrenheitTwo.Text = "Fahrenheit"
        Me.radFahrenheitTwo.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(91, 227)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(200, 31)
        Me.txtInput.TabIndex = 4
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!)
        Me.lblOutput.Location = New System.Drawing.Point(218, 359)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(73, 24)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.Text = "Label1"
        '
        'lblFormula
        '
        Me.lblFormula.AutoSize = True
        Me.lblFormula.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!)
        Me.lblFormula.Location = New System.Drawing.Point(326, 29)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(63, 20)
        Me.lblFormula.TabIndex = 6
        Me.lblFormula.Text = "Label1"
        '
        'lblOutputHeading
        '
        Me.lblOutputHeading.AutoSize = True
        Me.lblOutputHeading.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblOutputHeading.Location = New System.Drawing.Point(106, 358)
        Me.lblOutputHeading.Name = "lblOutputHeading"
        Me.lblOutputHeading.Size = New System.Drawing.Size(89, 27)
        Me.lblOutputHeading.TabIndex = 7
        Me.lblOutputHeading.Text = "Output:"
        '
        'lblInputHeading
        '
        Me.lblInputHeading.AutoSize = True
        Me.lblInputHeading.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblInputHeading.Location = New System.Drawing.Point(7, 229)
        Me.lblInputHeading.Name = "lblInputHeading"
        Me.lblInputHeading.Size = New System.Drawing.Size(72, 27)
        Me.lblInputHeading.TabIndex = 8
        Me.lblInputHeading.Text = "Input:"
        '
        'lblFormulaHeading
        '
        Me.lblFormulaHeading.AutoSize = True
        Me.lblFormulaHeading.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormulaHeading.Location = New System.Drawing.Point(219, 24)
        Me.lblFormulaHeading.Name = "lblFormulaHeading"
        Me.lblFormulaHeading.Size = New System.Drawing.Size(101, 27)
        Me.lblFormulaHeading.TabIndex = 9
        Me.lblFormulaHeading.Text = "Formula:"
        '
        'frmTemperatureConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblFormulaHeading)
        Me.Controls.Add(Me.lblInputHeading)
        Me.Controls.Add(Me.lblOutputHeading)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.grpInput)
        Me.Name = "frmTemperatureConverter"
        Me.Text = "Temperature Converter"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents radKelvinOne As RadioButton
    Friend WithEvents radCelciusOne As RadioButton
    Friend WithEvents radFahrenheitOne As RadioButton
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents radKelvinTwo As RadioButton
    Friend WithEvents radCelciusTwo As RadioButton
    Friend WithEvents radFahrenheitTwo As RadioButton
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblFormula As Label
    Friend WithEvents lblOutputHeading As Label
    Friend WithEvents lblInputHeading As Label
    Friend WithEvents lblFormulaHeading As Label
End Class
