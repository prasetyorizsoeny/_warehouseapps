Imports CrystalDecisions.CrystalReports.Engine

Public Class PrintTagihanFrm
    Dim CrystalReport As New ReportDocument
    Dim strDSN As String
    Dim strDB As String
    Dim strUID As String
    Dim strPWD As String

    Private Function SetupReport(ByRef objCrystalReportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument) As Boolean

        Dim crTableLogOnInfo As CrystalDecisions.Shared.TableLogOnInfo
        Dim crDatabase As CrystalDecisions.CrystalReports.Engine.Database
        Dim crTables As CrystalDecisions.CrystalReports.Engine.Tables
        Dim aTable As CrystalDecisions.CrystalReports.Engine.Table
        Dim blnTest As System.Boolean
        Dim strLocation As System.String

        crDatabase = objCrystalReportDocument.Database
        crTables = crDatabase.Tables

        For Each aTable In crTables
            crTableLogOnInfo = aTable.LogOnInfo

            strDSN = crTableLogOnInfo.ConnectionInfo.ServerName
            strDB = crTableLogOnInfo.ConnectionInfo.DatabaseName
            strUID = crTableLogOnInfo.ConnectionInfo.UserID
            strPWD = crTableLogOnInfo.ConnectionInfo.Password

            aTable.ApplyLogOnInfo(crTableLogOnInfo)

            strLocation = My.Application.Info.DirectoryPath & "\Database3.Mdb"

            Try
                aTable.Location = strLocation
            Catch ex As Exception
                MessageBox.Show("Set Location Error: " & ex.ToString, "RSA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                blnTest = aTable.TestConnectivity()
            Catch ex As Exception
                MessageBox.Show("Connected? " & ex.ToString, "RSA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next aTable
        CrystalReportViewer.ReportSource = CrystalReport
        CrystalReportViewer.Refresh()
    End Function

    Private Sub PrintTagihanFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CrystalReportViewer.Dispose()
        CrystalReport.Close()
        CrystalReport.Dispose()
        CrystalReportViewer = Nothing
        CrystalReport = Nothing
        GC.Collect()
    End Sub

    Private Sub PrintTagihanFrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CrystalReport.Load(My.Application.Info.DirectoryPath & "\FakturTagihan.rpt")
        SetupReport(CrystalReport)
    End Sub
End Class