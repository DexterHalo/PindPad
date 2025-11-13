Imports Cklass.Net
Imports EGlobal.TotalPosSDKNet.Interfaz.Catalog
Imports EGlobal.TotalPosSDKNet.Interfaz.Layout
Imports System.Text

Public Class TicketsHSBC
    Public SucNombre As String = ""
    Public SucDomicilio As String = ""
    Public SucColoinia As String = ""
    Public SucCiudad As String = ""
    Public SucCaja As String = ""
    Public MinMonto As Double = 0
    Public MaxMeses As Integer = 0
    Dim cklassSuc As New ckSucursal.CklassSucursal()




    'Public Function ConsultaPuntos(ByVal response As Respuesta) As String
    '    Dim resultado As New StringBuilder("")
    '    Try
    '        resultado.AppendLine(ckNet.StrCEN("BBVA Bancomer FECHA " & Format(Now.Date, "dd/MMM/yy").ToUpper & " HORA " & Format(Now, "HH:mm"), 40))
    '        resultado.AppendLine(ckNet.StrCEN("CKLASS " & cklassSuc.Sucursal, 40))
    '        resultado.AppendLine(ckNet.StrCEN(cklassSuc.SucursalDomicilioF, 40))
    '        resultado.AppendLine(ckNet.StrCEN(cklassSuc.SucursalColonia, 40))
    '        resultado.AppendLine(ckNet.StrCEN(cklassSuc.SucursalCiudad, 40))

    '        If response.CodigoRespuesta = "00" Then
    '            If response.Leyenda.Trim <> "" Then resultado.AppendLine(ckNet.StrCEN(response.Leyenda.Trim, 40))
    '        ElseIf response.CodigoRespuesta = "05" Or response.CodigoRespuesta = "04" Then
    '            resultado.AppendLine(ckNet.StrCEN(response.CodigoRespuesta & "=" & "DECLINADA", 40))
    '        Else
    '            resultado.AppendLine("!" & response.CodigoRespuesta & "=" & response.Leyenda.Trim & "!")
    '        End If

    '        resultado.AppendLine(ckNet.StrCEN(Format(Val(Mid(response.NumeroTarjeta, 1, 8)), "0000 0000") & " " & Format(Val(Mid(response.NumeroTarjeta, 9, 8)), "0000 0000"), 40))
    '        resultado.AppendLine(ckNet.StrIZQ("TIPO: " & IIf(response.ProductoTarjeta.Contains("c"), "CREDITO", "DEBITO"), 20))
    '        resultado.AppendLine(ckNet.StrIZQ("CONSULTA DE PUNTOS", 40))

    '        If response.CodigoRespuesta = "00" And response.Autorizacion.Trim <> "" Then
    '            resultado.AppendLine(ckNet.StrCEN("BC " & IIf(response.ModoLectura.Equals("05"), "|@1", IIf(response.ModoLectura.Equals("01"), "T1", IIf(response.ModoLectura.Equals("80") Or response.ModoLectura.Equals("90"), "D@1", "C@1"))), 40))
    '            resultado.AppendLine(ckNet.StrCEN("Autorizacion: " & response.Autorizacion, 40))
    '        End If

    '        If response.CriptogramaTarjeta.Trim <> "" Then resultado.AppendLine(ckNet.StrCEN(response.CriptogramaTarjeta.Trim, 40))
    '        If response.IdAplicacionTarjeta.Trim <> "" Then resultado.AppendLine(ckNet.StrCEN("AID: " + response.IdAplicacionTarjeta.Trim, 40))
    '        resultado.AppendLine(ckNet.StrIZQ("Referencia: " & Format(Val(response.ReferenciaFinanciera), "00000000"), 40))
    '        resultado.AppendLine(ckNet.StrIZQ("Afiliacion: " & Format(Val(response.Afiliacion), "00000000"), 20) & ckNet.StrDER("Sucursal: " & Format(Val(cklassSuc.SucursalId), "0000"), 20))
    '        resultado.AppendLine(ckNet.StrIZQ("Sec. Txn: " & Format(Val(response.SecuenciaTransaccion), "0000"), 20) & ckNet.StrDER("Terminal: " & Format(Val(ckNet.Terminal), "0000"), 20))

    '        resultado.AppendLine("")
    '        resultado.AppendLine(ckNet.StrIZQ("PUNTOS BANCOMER", 40))
    '        resultado.AppendLine(ckNet.StrIZQ("Saldo disponibles pesos ($): " & CDbl(response.SaldoDisponiblePesos).ToString, 40))
    '        resultado.AppendLine(ckNet.StrIZQ("Saldo disponible puntos (PTS):   " & CInt(response.SaldoPuntosDisponibles).ToString, 40))

    '        If response.CodigoRespuesta = "00" Then
    '            resultado.AppendLine(ckNet.StrIZQ("PAGARE NEGOCIABLE UNICAMENTE EN", 40))
    '            resultado.AppendLine(ckNet.StrIZQ("INSTITUCIONES DE CREDITO.", 40))
    '            resultado.AppendLine(ckNet.StrIZQ("", 40))
    '            resultado.AppendLine(ckNet.StrIZQ("", 40))
    '            resultado.AppendLine(ckNet.StrCEN("CLIENTE", 40))
    '        End If

    '    Catch ex As Exception
    '        Throw New Exception("Error al generar pagaré...!", ex)
    '    End Try
    '    Return resultado.ToString
    'End Function
End Class
