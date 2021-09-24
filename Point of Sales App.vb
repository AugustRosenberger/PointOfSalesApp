Public Class Form1


    Dim aryCosts(4) As Double
    Dim arySubTax(2) As Double
    Dim total As Double


    Private Sub chkbxWarranty_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxWarranty.CheckedChanged
        If chkbxWarranty.Checked = True Then
            aryCosts(2) = 125
        Else
            aryCosts(2) = 0
        End If
    End Sub

    Private Sub txtCPU_TextChanged(sender As Object, e As EventArgs) Handles txtCPU.TextChanged
        Try
            aryCosts(0) = txtCPU.Text
            txtCPUCharge.Text = txtCPU.Text
        Catch ex As InvalidCastException
            MsgBox("Please Enter Only Numeric Data")
            txtCPU.Clear()
        End Try
    End Sub


    Private Sub txtMonitor_TextChanged(sender As Object, e As EventArgs) Handles txtMonitor.TextChanged
        Try
            aryCosts(1) = txtMonitor.Text
            txtMonitorCharge.Text = txtMonitor.Text
        Catch ex As InvalidCastException
            MsgBox("Please Enter Only Numeric Data")
            txtMonitor.Clear()
        End Try
    End Sub

    Private Sub chkbxMaintenance_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxMaintenance.CheckedChanged
        If chkbxMaintenance.Checked = True Then
            aryCosts(3) = 250
        Else
            aryCosts(3) = 0
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        txtAddOn.Text = aryCosts(2) + aryCosts(3)
        For i = 0 To aryCosts.Length - 1
            arySubTax(0) += aryCosts(i)
        Next
        txtSubTot.Text = arySubTax(0)
        arySubTax(1) = arySubTax(0) * 0.0625
        txtTax.Text = arySubTax(1)

        total = arySubTax(0) + arySubTax(1)
        txtTotal.Text = total
        arySubTax(0) = 0
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbxCPU.ResetText()
        cmbxMonitor.ResetText()
        txtCPU.Clear()
        txtMonitor.Clear()
        chkbxWarranty.Checked = False
        chkbxMaintenance.Checked = False
        txtCPUCharge.Clear()
        txtMonitorCharge.Clear()
        txtAddOn.Clear()
        txtSubTot.Clear()
        txtTax.Clear()
        txtTotal.Clear()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub


End Class
