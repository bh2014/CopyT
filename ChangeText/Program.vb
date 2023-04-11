Imports System
Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Text


Module Program
  Const baseFolder As String = "20230406\110"

  Sub Main(args As String())
    Process189()
  End Sub
  Sub Process189()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "index.aaa") > 0) Or (InStr(file, "custom.css") > 0) Or (InStr(file, "aaaa.js") > 0) Then
        'ChangeMulti173(file)
        'AddText(file, str1)
        Count = Count + 1
      End If
      'If (InStr(file, "index11.") > 0) Or (InStr(file, "custom.css") > 0) Or (InStr(file, ".js") > 0) Then
      '  ChangeMulti173(file)
      '  'AddText(file, str1)
      '  Count = Count + 1
      'End If

      If (InStr(file, "tel.svg") > 0) Or (InStr(file, "trial06_02_pu1111") > 0) Or (InStr(file, "trial10_02_pu11111") > 0) Then
        CopyFile141(file)
      End If

    Next
    Console.WriteLine("Total : " & Count)
    'DeleteEmptyFolder(strFolder)
  End Sub

  Sub AddText(ByVal strFileName As String, strNew As String)
    Dim reader As String = File.ReadAllText(strFileName, Encoding.Default)
    Dim reader_new As String = File.ReadAllText(strNew, Encoding.Default)

    File.WriteAllText(strFileName, reader & reader_new, Encoding.Default)
    OutputLog(strLog, "Add text : " & strFileName)
  End Sub

  Sub CopyFile141(ByVal strFileName As String)
    Dim buf As String = strFileCopy & Path.GetFileName(strFileName)
    File.Copy(buf, strFileName, True)
    OutputLog(strLog, "Copied File :" & strFileName)
  End Sub

  Sub CopyFile333(ByVal strFileName As String)
    If InStr(strFileName, "p03_img03.webp") > 0 Then
      File.Copy(strFileCopy & "p03_img03.png", Replace(strFileName, ".webp", ".png"), True)
      OutputLog(strLog, "Copied File p03_img03.png")
    End If

    If InStr(strFileName, "p03_img05.webp") > 0 Then
      File.Copy(strFileCopy & "p03_img05.png", Replace(strFileName, ".webp", ".png"), True)
      OutputLog(strLog, "Copied File p03_img05.png")
    End If
  End Sub

  Sub CopyFile334(ByVal strFileName As String)
    If InStr(strFileName, "02_03") > 0 Then
      File.Copy(strFileCopy & "banner_2.png", strFileName, True)
      OutputLog(strLog, "Replace file 2: " & strFileName)
    Else
      File.Copy(strFileCopy & "banner_1.png", strFileName, True)
      OutputLog(strLog, "Replace file 1: " & strFileName)
    End If
  End Sub

  Sub ChangeMulti173(ByVal strFileName As String)
    Dim buf1, buf2, buf3, buf4, buf5, buf6, buf7, buf8, buf9, buf10, buf11, buf12 As String
    Dim buf13, buf14, buf15, buf16, buf17, buf18, buf19, buf20, buf21, buf22, buf23, buf24 As String
    buf1 = ""
    buf2 = ""
    buf3 = ""
    buf4 = ""
    buf5 = ""
    buf6 = ""
    buf7 = ""
    buf8 = ""
    buf9 = ""
    buf10 = ""
    buf11 = ""
    buf12 = ""
    buf13 = ""
    buf14 = ""
    buf15 = ""
    buf16 = ""
    buf17 = ""
    buf18 = ""
    buf19 = ""
    buf20 = ""
    buf21 = ""
    buf22 = ""
    buf23 = ""
    buf24 = ""


    Dim reader As String = File.ReadAllText(strFileName, Encoding.Default)
    If File.Exists(str1) Then
      buf1 = File.ReadAllText(str1, Encoding.Default)
    End If
    If File.Exists(str2) Then
      buf2 = File.ReadAllText(str2, Encoding.Default)
    End If
    If File.Exists(str3) Then
      buf3 = File.ReadAllText(str3, Encoding.Default)
    End If
    If File.Exists(str4) Then
      buf4 = File.ReadAllText(str4, Encoding.Default)
    End If
    If File.Exists(str5) Then
      buf5 = File.ReadAllText(str5, Encoding.Default)
    End If
    If File.Exists(str6) Then
      buf6 = File.ReadAllText(str6, Encoding.Default)
    End If
    If File.Exists(str7) Then
      buf7 = File.ReadAllText(str7, Encoding.Default)
    End If
    If File.Exists(str8) Then
      buf8 = File.ReadAllText(str8, Encoding.Default)
    End If
    If File.Exists(str9) Then
      buf9 = File.ReadAllText(str9, Encoding.Default)
    End If
    If File.Exists(str10) Then
      buf10 = File.ReadAllText(str10, Encoding.Default)
    End If
    If File.Exists(str11) Then
      buf11 = File.ReadAllText(str11, Encoding.Default)
    End If
    If File.Exists(str12) Then
      buf12 = File.ReadAllText(str12, Encoding.Default)
    End If
    If File.Exists(str13) Then
      buf13 = File.ReadAllText(str13, Encoding.Default)
    End If
    If File.Exists(str14) Then
      buf14 = File.ReadAllText(str14, Encoding.Default)
    End If
    If File.Exists(str15) Then
      buf15 = File.ReadAllText(str15, Encoding.Default)
    End If
    If File.Exists(str16) Then
      buf16 = File.ReadAllText(str16, Encoding.Default)
    End If
    If File.Exists(str17) Then
      buf17 = File.ReadAllText(str17, Encoding.Default)
    End If
    If File.Exists(str18) Then
      buf18 = File.ReadAllText(str18, Encoding.Default)
    End If
    If File.Exists(str19) Then
      buf19 = File.ReadAllText(str19, Encoding.Default)
    End If
    If File.Exists(str20) Then
      buf20 = File.ReadAllText(str20, Encoding.Default)
    End If
    If File.Exists(str21) Then
      buf21 = File.ReadAllText(str21, Encoding.Default)
    End If
    If File.Exists(str22) Then
      buf22 = File.ReadAllText(str22, Encoding.Default)
    End If
    If File.Exists(str23) Then
      buf23 = File.ReadAllText(str23, Encoding.Default)
    End If
    If File.Exists(str24) Then
      buf24 = File.ReadAllText(str24, Encoding.Default)
    End If


    If reader.IndexOf(buf1) > 0 Then
      reader = Replace(reader, buf1, buf2)
      OutputLog(strLog, "Replace Multi 1 " & strFileName)
    End If
    If reader.IndexOf(buf3) > 0 Then
      reader = Replace(reader, buf3, buf4)
      OutputLog(strLog, "Replace Multi 3 " & strFileName)
    End If
    If reader.IndexOf(buf5) > 0 Then
      reader = Replace(reader, buf5, buf6)
      OutputLog(strLog, "Replace Multi 5 " & strFileName)
    End If
    If reader.IndexOf(buf7) > 0 Then
      reader = Replace(reader, buf7, buf8)
      OutputLog(strLog, "Replace Multi 7 " & strFileName)
    End If
    If reader.IndexOf(buf9) > 0 Then
      reader = Replace(reader, buf9, buf10)
      OutputLog(strLog, "Replace Multi 9 " & strFileName)
    End If
    If reader.IndexOf(buf11) > 0 Then
      reader = Replace(reader, buf11, buf12)
      OutputLog(strLog, "Replace Multi 11 " & strFileName)
    End If
    If reader.IndexOf(buf13) > 0 Then
      reader = Replace(reader, buf13, buf14)
      OutputLog(strLog, "Replace Multi 13 " & strFileName)
    End If
    If reader.IndexOf(buf15) > 0 Then
      reader = Replace(reader, buf15, buf16)
      OutputLog(strLog, "Replace Multi 15 " & strFileName)
    End If
    If reader.IndexOf(buf17) > 0 Then
      reader = Replace(reader, buf17, buf18)
      OutputLog(strLog, "Replace Multi 17 " & strFileName)
    End If
    If reader.IndexOf(buf19) > 0 Then
      reader = Replace(reader, buf19, buf20)
      OutputLog(strLog, "Replace Multi 19 " & strFileName)
    End If
    If reader.IndexOf(buf21) > 0 Then
      reader = Replace(reader, buf21, buf22)
      OutputLog(strLog, "Replace Multi 21 " & strFileName)
    End If
    If reader.IndexOf(buf23) > 0 Then
      reader = Replace(reader, buf23, buf24)
      OutputLog(strLog, "Replace Multi 23 " & strFileName)
    End If

    File.WriteAllText(strFileName, reader, Encoding.Default)
  End Sub

  Const strDlf As String = "C:\Users\Nguyen\Downloads\"
  Const strFolder As String = strDlf & baseFolder & "\new"
  Const strLog As String = strDlf & baseFolder & "\log.txt"

  Const str1 As String = strDlf & baseFolder & "\txt01.txt"
  Const str2 As String = strDlf & baseFolder & "\txt02.txt"
  Const str3 As String = strDlf & baseFolder & "\txt03.txt"
  Const str4 As String = strDlf & baseFolder & "\txt04.txt"
  Const str5 As String = strDlf & baseFolder & "\txt05.txt"
  Const str6 As String = strDlf & baseFolder & "\txt06.txt"
  Const str7 As String = strDlf & baseFolder & "\txt07.txt"
  Const str8 As String = strDlf & baseFolder & "\txt08.txt"
  Const str9 As String = strDlf & baseFolder & "\txt09.txt"
  Const str10 As String = strDlf & baseFolder & "\txt10.txt"
  Const str11 As String = strDlf & baseFolder & "\txt11.txt"
  Const str12 As String = strDlf & baseFolder & "\txt12.txt"
  Const str13 As String = strDlf & baseFolder & "\txt13.txt"
  Const str14 As String = strDlf & baseFolder & "\txt14.txt"
  Const str15 As String = strDlf & baseFolder & "\txt15.txt"
  Const str16 As String = strDlf & baseFolder & "\txt16.txt"
  Const str17 As String = strDlf & baseFolder & "\txt17.txt"
  Const str18 As String = strDlf & baseFolder & "\txt18.txt"
  Const str19 As String = strDlf & baseFolder & "\txt19.txt"
  Const str20 As String = strDlf & baseFolder & "\txt20.txt"
  Const str21 As String = strDlf & baseFolder & "\txt21.txt"
  Const str22 As String = strDlf & baseFolder & "\txt22.txt"
  Const str23 As String = strDlf & baseFolder & "\txt23.txt"
  Const str24 As String = strDlf & baseFolder & "\txt24.txt"
  Const strFileCopy As String = strDlf & baseFolder & "\"
End Module

