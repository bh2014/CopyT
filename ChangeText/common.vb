Imports System
Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Text

Module common

  Public Sub OutputLog(ByVal strLog As String, ByVal str As String)
    If Not File.Exists(strLog) Then
      Using sw As StreamWriter = File.CreateText(strLog)
        sw.WriteLine(str)
        Console.WriteLine(str)
      End Using
    Else
      Using sw As StreamWriter = File.AppendText(strLog)
        sw.WriteLine(str)
        Console.WriteLine(str)
      End Using
    End If
  End Sub

  Public Sub DeleteEmptyFolder(ByVal strFolderName)
    Dim subFolders As String() = System.IO.Directory.GetDirectories(
    strFolderName, "*", System.IO.SearchOption.AllDirectories)

    For Each buf In subFolders
      Try
        DeleteEmptyFolder(buf)
      Catch ex As Exception

      End Try
    Next

    Dim fileCount As Integer = Directory.GetFiles(strFolderName, "*", SearchOption.AllDirectories).Length
    If fileCount = 0 Then
      Directory.Delete(strFolderName)
      'OutputLog("Delete Folder:" & strFolderName)
    End If
  End Sub
End Module
