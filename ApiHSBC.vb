Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class SaleResponse
    Public Property status As Boolean
    Public Property requestId As String
    Public Property [date] As String
    Public Property time As String
    Public Property detailError As String
    Public Property dataResponse As DataResponse
End Class

Public Class DataResponse
    Public Property lastFour As String
    Public Property cardType As String
    Public Property brand As String
    Public Property bank As String
    Public Property amount As String
    Public Property currencyType As String
    Public Property reference As String
    Public Property realCounter As String
    Public Property cardHolder As String
    Public Property authorizationCode As String
    Public Property operationType As String
    Public Property operationNumber As Integer
    Public Property descriptionResponse As String
    Public Property dateTransaction As String
    Public Property aid As String
    Public Property arqc As String
    Public Property tc As String
    Public Property tipAmount As Decimal
    Public Property waiterNumber As Integer
    Public Property authentication As String
    Public Property membership As String
    Public Property batch As String
    Public Property q6Legend As String
End Class

Public Class RespuestaConfiguracion
    Public Property status As Boolean
    Public Property description As String
    Public Property token As String
End Class


