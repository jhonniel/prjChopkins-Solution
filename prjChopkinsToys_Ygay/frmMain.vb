Public Class frmMain


    Public Sub NumberOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        NumberOnly(e)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim Pack12, Pack5, Pack2, Ship, Total1, Total2, Total3, TotlSl, TotalShip As Double
        Dim Tpack As Integer
        Dim D As Date = Now()





        txtDate.Text = D

        Double.TryParse(txtPack12.Text, Pack12)
        Total1 = Pack12 * 14.99

        lblTpack12.Text = FormatCurrency(Total1)

        Double.TryParse(txtPack5.Text, Pack5)
        Total2 = Pack5 * 6.99

        lblTpack5.Text = FormatCurrency(Total2)

        Double.TryParse(txtPack2.Text, Pack2)
        Total3 = Pack2 * 2.5

        lblTpack2.Text = FormatCurrency(Total3)

        TotlSl = Total1 + Total2 + Total3
        txtSpack.Text = FormatCurrency(TotlSl)

        Tpack = Pack12 + Pack5 + Pack2
        txtTpack.Text = Tpack


        Double.TryParse(txtShip.Text, Ship)
        TotalShip = Ship
        lblShip.Text = FormatCurrency(TotalShip)




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtDate.Clear()
        txtPack12.Clear()
        txtPack5.Clear()
        txtPack2.Clear()
        lblShip.Clear()
        txtShip.Clear()
        txtSpack.Clear()
        txtTpack.Clear()
        lblTpack12.Clear()
        lblTpack5.Clear()
        lblTpack2.Clear()

        lblShip.Focus()
        txtDate.Focus()
    End Sub

    Private Sub txtPack12_TextChanged(sender As Object, e As EventArgs) Handles txtPack12.TextChanged




    End Sub


End Class
