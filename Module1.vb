Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Module Module1
    'Public con As New OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings("BajajConnectionString").ConnectionString)
    'Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\BajajAutoFinProcess.accdb")
    Public cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\tanvi\graduation\6th sem\Project\DLMProject\DLM.accdb")
    Public rs As New OleDbDataAdapter
    Public cmd As New OleDbCommand
    Dim Dt As New DataTable
End Module
