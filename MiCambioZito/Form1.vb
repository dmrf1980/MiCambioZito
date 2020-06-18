Public Class Form1
    Dim indice As Integer

#Region "ENUM"
    Enum Monedas
        Dolar = 0
        Euro = 1
        Argentino = 2
        Real = 3
    End Enum

    Enum Operacion
        Moneda = 0
        Compra = 1
        Venta = 2
        Signo = 3
    End Enum
#End Region

#Region "LOAD"
    Private Sub Inicio_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        CbxCambiar.SelectedIndex = Monedas.Dolar

        LblSignoMoneda.Text = "U$"

    End Sub
#End Region

#Region "COMBOBOX"
    Private Sub CbxCambiar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCambiar.SelectedIndexChanged

        LblMonto.Text = ""

        LblVuelto.Text = ""

    End Sub
#End Region

#Region "RADIOBUTTONS"
    Private Sub RbnVenta_CheckedChange(ByVal sender As Object, ByVal e As EventArgs) Handles RbnVenta.CheckedChanged

        If RbnVenta.Checked Then

            LblSignoMoneda.Text = LvwCotizacion.Items(CbxCambiar.SelectedIndex).SubItems(Operacion.Signo).Text

            ChxEnPesos.Visible = True

        Else
            LblSignoMoneda.Text = "U$"

            ChxEnPesos.Visible = False

        End If

    End Sub
#End Region

#Region "LISTVIEW"
    Private Sub LvwCotizacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LvwCotizacion.Click
        Dim compra, venta, moneda As String

        If LvwCotizacion.SelectedIndices.Count > 0 Then
            indice = LvwCotizacion.SelectedIndices.Item(0)
            moneda = LvwCotizacion.Items(indice).SubItems(Operacion.Moneda).Text
            If MsgBox("Quieres cambiar la cotizacion del " + moneda + "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                compra = InputBox("Nueva cotizacion de Compra " + moneda, , "0")


                LvwCotizacion.Items(indice).SubItems(Operacion.Compra).Text = compra


                venta = InputBox("Nueva Cotizacion de Venta " + moneda, , "0")


                LvwCotizacion.Items(indice).SubItems(Operacion.Venta).Text = venta
            End If
        End If
    End Sub
#End Region

#Region "INGRESO DE MONTO"
    Private Sub TxtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMonto.KeyPress

        If e.KeyChar < "0" Or e.KeyChar > "9" Then
            If e.KeyChar <> Chr(Keys.Back) Then
                e.KeyChar = ""
            End If
        End If
    End Sub
#End Region

#Region "BOTON CAMBIAR"
    Private Sub BtnCambiar_Click(sender As Object, e As EventArgs) Handles BtnCambiar.Click
        Dim cotizacion As Decimal = 0
        Dim montoIngresado As String = TxtMonto.Text
        Dim signoMoneda As String = LvwCotizacion.Items(CbxCambiar.SelectedIndex).SubItems(Operacion.Signo).Text

        If RbNCompra.Checked Then

            '-------------------------EL CAMBIO COMPRA MONEDA EXTRANJERA-------------------------

            cotizacion = Decimal.Parse(LvwCotizacion.Items(CbxCambiar.SelectedIndex).SubItems(Operacion.Compra).Text)

            If TxtMonto.Text = "0" Or TxtMonto.Text = "" Then

                MsgBox("Ingrese un monto valido mayor a 0")

            Else

                LblMonto.Text = Int((Decimal.Parse(montoIngresado) * cotizacion))
                LblAccionARealizar.Text = " El Cliente recibe " + LblMonto.Text + " U$ por sus " + TxtMonto.Text + " " + signoMoneda

            End If

        Else

            '-------------------------EL CAMBIO VENDE MONEDA EXTRANJERA-------------------------

            cotizacion = Decimal.Parse(LvwCotizacion.Items(CbxCambiar.SelectedIndex).SubItems(Operacion.Venta).Text)
            LblSignoMoneda.Text = signoMoneda
            Dim montoResultado As Double
            LblVuelto.Text = ""
            LblMonto.Text = Int((Decimal.Parse(montoIngresado) / cotizacion))

            montoResultado = Decimal.Parse(montoIngresado) / cotizacion

            If ChxEnPesos.Checked Then
                '--------------------EL CLIENTE TIENE UN MONTO EN PESOS U$ Y QUIERE MONEDA EXTRANJERA--------------------
                LblSignoPeso.Text = "U$"

                '-------------------------VUELTO EN PESOS URUGUAYOS-------------------------

                LblVuelto.Text = FormatNumber((montoResultado - Int(montoResultado)) * cotizacion, 2)
                LblAccionARealizar.Text = " El Cliente paga con " + TxtMonto.Text + " U$ para recibir " + LblMonto.Text + signoMoneda + " y " + LblVuelto.Text + "U$ de vuelto"
            Else
                '--------------------MONTO INGRESADO EN MONEDA EXTRANJERA, INDICAR CUANTOS U$ SE NECESITAN PARA LA TRANSACCION--------------------

                LblSignoMoneda.Text = "U$"

                LblMonto.Text = (Decimal.Parse(montoIngresado) * cotizacion)
                LblAccionARealizar.Text = " El Cliente debe pagar " + LblMonto.Text + " " + LblSignoMoneda.Text + " para recibir " + montoIngresado.ToString + " " + signoMoneda
            End If
        End If
    End Sub

#End Region

End Class
