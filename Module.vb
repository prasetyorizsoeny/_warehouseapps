Imports System.Data.OleDb
Imports System.Globalization

Public Module Module1
    Public ConStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\Database3.Mdb;Jet OLEDB:Database Password=RSA2016;"
    Private standardCharacters() As String = Enumerable.Range(1, 26).Select(Function(x) Chr(64 + x).ToString) _
                                 .Concat(Enumerable.Range(1, 26).Select(Function(x) Chr(96 + x).ToString)) _
                                 .Concat(Enumerable.Range(0, 10).Select(Function(x) Chr(48 + x).ToString)) _
                                 .Concat(New String() {"!", """", "£", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=", "\", "|", "{", "[", "}", "]", ":", ";", "@", "'", "~", "#", "<", ",", ">", ".", "?", "/", " "}) _
                                 .Concat(New String() {vbCr, vbLf}).ToArray
    Public UserId As String
    Public SQL As String
    Public ErrMsg As String
    Public culture As CultureInfo

    Public Function encrypt(ByVal s As String) As String
        Dim r As New Random(33)
        Dim dyslexia() As String = standardCharacters.OrderBy(Function(str) r.NextDouble).ToArray
        For x As Integer = 0 To s.Length - 1
            If standardCharacters.Contains(s.Substring(x, 1)) Then
                Mid(s, x + 1, 1) = dyslexia(Array.IndexOf(standardCharacters, s.Substring(x, 1)))
            End If
        Next
        Return s
    End Function

    Public Function decrypt(ByVal s As String) As String
        Dim r As New Random(33)
        Dim dyslexia() As String = standardCharacters.OrderBy(Function(str) r.NextDouble).ToArray
        For x As Integer = 0 To s.Length - 1
            If dyslexia.Contains(s.Substring(x, 1)) Then
                Mid(s, x + 1, 1) = standardCharacters(Array.IndexOf(dyslexia, s.Substring(x, 1)))
            End If
        Next
        Return s
    End Function

    Public Function tostr(ByVal value As Object)
        Dim str As String
        Try
            If IsNothing(value) Or IsDBNull(value) Then
                str = ""
            Else
                str = CStr(value)
                str = str.Replace("'", "`")
                If str = "&nbsp;" Then str = ""
            End If
        Catch ex As Exception
            str = ""
        End Try
        tostr = str
    End Function

    Public Function todate(ByVal Value As Object, Optional ByVal Culture As CultureInfo = Nothing) As Date
        Try
            If IsNothing(Value) Or IsDBNull(Value) Then
                todate = Today.Date
            Else
                If TypeName(Value) = "String" Then
                    If Not Culture Is Nothing Then
                        todate = Date.Parse(Value, Culture.DateTimeFormat)
                    Else
                        If IsDate(Value) Then
                            todate = CDate(Value)
                        Else
                            todate = Today.Date
                        End If
                    End If
                Else
                    If IsDate(Value) Then
                        todate = CDate(Value)
                    Else
                        todate = Today.Date
                    End If
                End If
            End If
        Catch ex As Exception
            todate = Today.Date
        End Try
    End Function

    Public Function toval(ByVal Value As Object, Optional ByVal Culture As CultureInfo = Nothing) As Double
        Dim nValue As Double
        Try
            If IsNothing(Value) Or IsDBNull(Value) Then
                nValue = 0
            Else
                If TypeName(Value) = "String" Then
                    If Value = "True" Then
                        nValue = -1
                    ElseIf Value = "False" Then
                        nValue = 0
                    Else
                        If Not Culture Is Nothing Then
                            nValue = Double.Parse(Value, Culture.NumberFormat)
                        Else
                            If IsNumeric(Value) Then
                                nValue = CDbl(Value)
                            Else
                                nValue = 0
                            End If
                        End If
                    End If
                Else
                    If IsNumeric(Value) Then
                        nValue = CDbl(Value)
                    Else
                        nValue = 0
                    End If
                End If
            End If
        Catch ex As Exception
            nValue = 0
        End Try
        toval = nValue
    End Function

    Public Function GetConnectionString() As String
        Return ConStr
    End Function

    Public Function ExecuteSQL(ByVal SQL As String, ByRef ErrMsg As String) As Boolean
        Dim Conn As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim Tr As OleDbTransaction

        Try
            Conn = New OleDbConnection(GetConnectionString)
            Conn.Open()
            Tr = Conn.BeginTransaction
            Cmd.Connection = Conn
            Cmd.Transaction = Tr

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Tr.Commit()
            Cmd.Dispose()
            Conn.Close()

            Cmd = Nothing
            Conn = Nothing
            ExecuteSQL = True
        Catch ex As Exception
            ErrMsg = ex.Message.ToString
            Tr.Rollback()
            ExecuteSQL = False
        End Try
    End Function

    Public Function GetRecordValue(ByVal SQL As String, ByRef ErrMsg As String) As Boolean
        Dim Conn As New OleDbConnection(GetConnectionString)
        Dim Cmd As OleDbCommand
        Dim da As OleDbDataAdapter = New OleDbDataAdapter()
        Dim count As Integer
        Dim tr As OleDbTransaction

        Try
            Conn.Open()
            tr = Conn.BeginTransaction

            Cmd = New OleDbCommand(SQL, Conn)
            Cmd.Transaction = tr

            count = Convert.ToInt64(Cmd.ExecuteScalar())
            GetRecordValue = IIf(count > 0, True, False)

            tr.Commit()
            Cmd.Dispose()
            Conn.Close()

            Cmd = Nothing
            Conn = Nothing
            Return GetRecordValue
        Catch ex As Exception
            ErrMsg = ex.Message.ToString
            tr.Rollback()
            Return False
        End Try
    End Function

    Public Function GetDataTable(ByVal SQL As String, ByRef dt As System.Data.DataTable, ByRef ErrMsg As String) As Boolean
        Dim connetionString As String = Nothing
        Dim Conn As New OleDbConnection(GetConnectionString)
        Dim Cmd As OleDbCommand
        Dim DA As OleDbDataAdapter = New OleDbDataAdapter()

        Try
            Conn.Open()
            Cmd = New OleDbCommand(SQL, Conn)
            DA.SelectCommand = Cmd
            DA.Fill(dt)
            dt.AcceptChanges()

            da.Dispose()
            Cmd.Dispose()
            Conn.Close()
            Return True
        Catch ex As Exception
            ErrMsg = ex.Message
            Return False
        End Try
    End Function
End Module
