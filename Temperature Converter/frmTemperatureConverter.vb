
Option Strict On
Public Class frmTemperatureConverter
    Private Sub frmTemperatureConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFormula.Text = ""
        lblOutput.Text = ""
        txtInput.Clear()
        txtInput.Focus()
    End Sub

    Private Sub radFahrenheitOne_CheckedChanged(sender As Object, e As EventArgs) Handles radFahrenheitOne.CheckedChanged
        Calculation()
    End Sub


    Private Sub Calculation()


        If Not IsNumeric(txtInput.Text) Then
            lblOutput.Text = "ERROR, put number in text box first before clicking the buttons."
        End If

        If IsNumeric(txtInput.Text) Then
            lblFormula.Visible = True
            Dim decInput As Decimal
            decInput = Decimal.Parse(txtInput.Text)

            If radFahrenheitOne.Checked And radFahrenheitTwo.Checked Then
                lblFormula.Text = "F=F"

                lblOutput.Text = decInput.ToString

            ElseIf radFahrenheitOne.Checked And radCelciusTwo.Checked Then
                lblFormula.Text = "5/9(F−32)=C"
                Dim decFtoC As Decimal

                decFtoC = CDec(5 / 9 * (decInput - 32))

                lblOutput.Text = decFtoC.ToString

            ElseIf radFahrenheitOne.Checked And radKelvinTwo.Checked Then
                lblFormula.Text = "(((F-32)*5)/9)+273.15=K"
                Dim decFtoKOne As Decimal
                Dim decFtoKTwo As Decimal
                Dim decFtoKThree As Decimal
                Dim decFtoKFinal As Decimal



                decFtoKOne = decInput - 32
                decFtoKTwo = decFtoKOne * 5
                decFtoKThree = decFtoKTwo / 9
                decFtoKFinal = CDec(decFtoKThree + 273.15)

                lblOutput.Text = decFtoKFinal.ToString


            ElseIf radCelciusOne.Checked And radFahrenheitTwo.Checked Then
                lblFormula.Text = "(C*9/5)+32=F"
                Dim decCtoF As Decimal

                decCtoF = (decInput * 9 / 5) + 32

                lblOutput.Text = decCtoF.ToString

            ElseIf radCelciusOne.Checked And radCelciusTwo.Checked Then
                lblFormula.Text = "C=C"

                lblOutput.Text = decInput.ToString

            ElseIf radCelciusOne.Checked And radKelvinTwo.Checked Then
                lblFormula.Text = "C+273.15=K"
                Dim decCtoK As Decimal

                decCtoK = CDec(decInput + 273.15)

                lblOutput.Text = decCtoK.ToString



            ElseIf radKelvinOne.Checked And radFahrenheitTwo.Checked Then
                lblFormula.Text = "K*9/5-459.67=F"
                Dim decKtoF As Decimal

                decKtoF = CDec(decInput * 9 / 5 - 459.67)

                lblOutput.Text = decKtoF.ToString

            ElseIf radKelvinOne.Checked And radCelciusTwo.Checked Then
                lblFormula.Text = "K-273.15=C"
                Dim decKtoC As Decimal

                decKtoC = CDec(decInput - 273.15)

                lblOutput.Text = decKtoC.ToString

            ElseIf radKelvinOne.Checked And radKelvinTwo.Checked Then
                lblFormula.Text = "K=K"

                lblOutput.Text = decInput.ToString



            Else
                lblFormula.Visible = False
            End If
        End If
    End Sub

    Private Sub radCelciusOne_CheckedChanged(sender As Object, e As EventArgs) Handles radCelciusOne.CheckedChanged
        Calculation()

    End Sub

    Private Sub radKelvinOne_CheckedChanged(sender As Object, e As EventArgs) Handles radKelvinOne.CheckedChanged
        Calculation()

    End Sub

    Private Sub radFahrenheitTwo_CheckedChanged(sender As Object, e As EventArgs) Handles radFahrenheitTwo.CheckedChanged
        Calculation()

    End Sub

    Private Sub radCelciusTwo_CheckedChanged(sender As Object, e As EventArgs) Handles radCelciusTwo.CheckedChanged
        Calculation()

    End Sub

    Private Sub radKelvinTwo_CheckedChanged(sender As Object, e As EventArgs) Handles radKelvinTwo.CheckedChanged
        Calculation()

    End Sub
End Class
