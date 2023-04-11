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
        AddText(file, str1)
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

  Sub Process163()
    Dim filename1 As String = "counseling014_1"
    Dim filename2 As String = "counseling014_y"
    Dim filename3 As String = "counseling015"
    Dim filename4 As String = "counseling016"

    Dim file1 As String = strDlf & baseFolder & "\" & filename1 & ".txt"
    Dim file2 As String = strDlf & baseFolder & "\" & filename2 & ".txt"
    Dim file3 As String = strDlf & baseFolder & "\" & filename3 & ".txt"
    Dim file4 As String = strDlf & baseFolder & "\" & filename4 & ".txt"

    Dim reader1 As String = System.IO.File.ReadAllText(file1)
    Dim reader2 As String = System.IO.File.ReadAllText(file2)
    Dim reader3 As String = System.IO.File.ReadAllText(file3)
    Dim reader4 As String = System.IO.File.ReadAllText(file4)

    Dim lines1() As String = reader1.Split({vbCrLf, Environment.NewLine}, StringSplitOptions.None)
    Dim lines2() As String = reader2.Split({vbCrLf, Environment.NewLine}, StringSplitOptions.None)
    Dim lines3() As String = reader3.Split({vbCrLf, Environment.NewLine}, StringSplitOptions.None)
    Dim lines4() As String = reader4.Split({vbCrLf, Environment.NewLine}, StringSplitOptions.None)


    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, ".php") > 0) Or (InStr(file, ".css") > 0) Then
        If InStr(file, filename1) > 0 Then
          ChangeFile163(lines1, file)
        Else
          If InStr(file, filename2) > 0 Then
            ChangeFile163(lines2, file)
          Else
            If InStr(file, filename3) > 0 Then
              ChangeFile163(lines3, file)
            Else
              If InStr(file, filename4) > 0 Then
                ChangeFile163(lines4, file)
              End If
            End If
          End If
        End If
        Count1 = Count1 + 1
        Count = Count + 1
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    'DeleteEmptyFolder(strFolder)
  End Sub

  Sub CopyFile496(ByVal strFileName As String)
    Dim buf As String
    'buf = strFileCopy & "treatment.gif"
    buf = strFileCopy & Path.GetFileName(strFileName)
    buf = Replace(buf, ".webp", ".png")

    If InStr(strFileName, ".webp") > 0 Then
      File.Copy(buf, Replace(strFileName, ".webp", ".png"), True)
      OutputLog(strLog, "Replace File " & buf & " , " & strFileName)
    End If
  End Sub

  Sub ChangeFile163(ByVal line() As String, ByVal filename As String)
    Dim reader As String = System.IO.File.ReadAllText(filename)
    Dim check As Boolean = True

    For Each buf As String In line
      If buf <> "" Then
        Dim buf1, buf2 As String
        buf1 = Replace(buf, ".webp", ".jpg")
        buf2 = Replace(buf, ".webp", ".png")
        If (InStr(reader, buf1) > 0) Then
          reader = Replace(reader, buf1, buf)
          check = False
          OutputLog(strLog, filename & vbCrLf & buf1)
        End If
        If (InStr(reader, buf2) > 0) Then
          reader = Replace(reader, buf2, buf)
          check = False
          OutputLog(strLog, filename & vbCrLf & buf2)
        End If
      End If
    Next
    If Not check Then
      File.WriteAllText(filename, reader, Encoding.Default)
    End If

  End Sub

  Sub Process356()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, ".js") > 0) Or (InStr(file, "topxxxx.min.css") > 0) Then
        ChangeMulti173(file)
        Count1 = Count1 + 1
        Count = Count + 1
      End If

      'If (InStr(file, "index.html") > 0) Or (InStr(file, "aaaacg187.png") > 0) Then
      '  ChangeMulti173(file)
      '  Count1 = Count1 + 1
      '  Count = Count + 1
      'Else
      '  'System.IO.File.Delete(file)
      'End If

    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    'DeleteEmptyFolder(strFolder)
  End Sub

  Sub Process196()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "induction.png") > 0) Or (InStr(file, "cg187.png") > 0) Then
        CopyFile141(file)
        Count1 = Count1 + 1
        Count = Count + 1
      End If

      If (InStr(file, "index.") > 0) Or (InStr(file, "11111.css") > 0) Then
        ChangeMulti173(file)
        Count1 = Count1 + 1
        Count = Count + 1
      End If
      'If (InStr(file, "ttl.webp") > 0) Or (InStr(file, "ttl_bg.webp") > 0) Then
      '  If (InStr(file, "campaign\ttl.webp") > 0) Or (InStr(file, "campaign\ttl_bg.webp") > 0) Then
      '    CopyFile141(file)
      '    Count1 = Count1 + 1
      '    Count = Count + 1
      '  Else
      '    System.IO.File.Delete(file)
      '  End If
      'End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    'DeleteEmptyFolder(strFolder)
  End Sub

  Sub Process1361()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, ".html") > 0) Or (InStr(file, ".php") > 0) Then
        ChangeMulti173(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        'System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    'DeleteEmptyFolder(strFolder)
  End Sub

  Sub CopyFile192(ByVal strFileName As String)
    Dim buf As String = strFileCopy & "induction.png"

    File.Copy(buf, Replace(strFileName, Path.GetFileName(strFileName), "img\induction.png"), True)
    OutputLog(strLog, "Copied File : induction")
  End Sub
  Sub Process556()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      'If (InStr(file, "index.") > 0) Then
      '  ChangeSettingsJS156(file)
      '  Count1 = Count1 + 1
      '  Count = Count + 1
      'End If
      If (InStr(file, "new.jpg") > 0) Then
        CopyFile1531(file)
        Count1 = Count1 + 1
        Count = Count + 1
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    'DeleteEmptyFolder(strFolder)
  End Sub

  Sub Process821()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, ".jpg") > 0) Or (InStr(file, ".png") > 0) Or (InStr(file, "settings.js") > 0) Then
        CopyFile1531(file)
        Count1 = Count1 + 1
        Count = Count + 1
      End If
      If (InStr(file, "index.php") > 0) Then
        ChangeMulti173(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        'System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    'DeleteEmptyFolder(strFolder)
  End Sub


  Sub ChangeSettingsJS553(ByVal strFileName As String)
    Dim reader As String = File.ReadAllText(strFileName, Encoding.Default)

    If InStr(strFileName, "index.") > 0 Then
      If InStr(reader, "https://lin.ee/gBJh3oD") > 0 Then
        reader = Replace(reader, "https://lin.ee/gBJh3oD",
                   "https://aura-mico.jp/qr-codes/f542da01978dbf66b676c68c4245fa76/preview")
        OutputLog(strLog, "Replace line Url " & strFileName)
      End If
    End If

    File.WriteAllText(strFileName, reader, Encoding.Default)
  End Sub

  Sub Process1532()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "index.php") > 0) Or (InStr(file, "form.php") > 0) Then
        ChangeMulti173(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    DeleteEmptyFolder(strFolder)
  End Sub

  Sub Process1531()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "campaign\ttl_bg.webp") > 0) Or (InStr(file, "campaign\ttl.webp") > 0) Then
        CopyFile1531(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    DeleteEmptyFolder(strFolder)
  End Sub
  Sub CopyFile1531(ByVal strFileName As String)
    Dim buf As String = strFileCopy & Path.GetFileName(strFileName)
    File.Copy(buf, strFileName, True)
    OutputLog(strLog, "Copied File :" & strFileName)
  End Sub

  Sub Process547()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "index.html") > 0) Or (InStr(file, "index.php") > 0) Then
        ChangeSettingsJS547(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        'System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    'DeleteEmptyFolder(strFolder)
    End
  End Sub

  Sub ChangeSettingsJS547(ByVal strFileName As String)
    Dim reader As String = File.ReadAllText(strFileName, Encoding.Default)

    If InStr(strFileName, "index.") > 0 Then
      If InStr(reader, "GTM-MLZTJWC") > 0 Then
        reader = Replace(reader, "GTM-MLZTJWC",
                   "GTM-MC66V6T")
        OutputLog(strLog, "Replace GTM-MLZTJWC " & strFileName)
      End If
      If InStr(reader, "https://mensclear.com/reservations") > 0 Then
        reader = Replace(reader, "https://mensclear.com/reservations",
                   "https://reserve.mensclear.site/reservations")
        OutputLog(strLog, "Replace post URL " & strFileName)
      End If
      'btn_cta.png
      If InStr(reader, "btn_cta.png") > 0 Then
        reader = Replace(reader, "btn_cta.png",
                   "btn.png")
        OutputLog(strLog, "Replace post URL " & strFileName)
      End If
    End If

    File.WriteAllText(strFileName, reader, Encoding.Default)
  End Sub

  Sub Process541()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "index.html") > 0) Or (InStr(file, "index.php") > 0) Or (InStr(file, "style.css") > 0) Then
        ChangeMulti173(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        'System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    'DeleteEmptyFolder(strFolder)
  End Sub

  Sub Process149()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "mi\bg.webp") > 0) Or (InStr(file, "addprice\img.webp") > 0) Or (InStr(file, "campaign021111\bg.webp") > 0) _
        Or (InStr(file, "reason\reason01_img01.webp") > 0) Or (InStr(file, "reason\reason02_img01.webp") > 0) Or (InStr(file, "price\bg.webp") > 0) _
        Or (InStr(file, "reason11111\img02.webp") > 0) Or (InStr(file, "choose\point01_img02.webp") > 0) Then
        'ChangeMulti173(file)
        CopyFile148(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    DeleteEmptyFolder(strFolder)
  End Sub

  Sub Process148()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "mi\bg.webp") > 0) Or (InStr(file, "addprice\img.webp") > 0) Or (InStr(file, "campaign02\bg.webp") > 0) _
        Or (InStr(file, "secret\reason01_img01.webp") > 0) Or (InStr(file, "secret\reason02_img01.webp") > 0) Or (InStr(file, "price\bg.webp") > 0) _
        Or (InStr(file, "discount\bg.webp") > 0) Or (InStr(file, "reason\bg.webp") > 0) Or (InStr(file, "reason\img01.webp") > 0) _
        Or (InStr(file, "reason\img02.webp") > 0) Or (InStr(file, "reason\img03.web") > 0) Then
        'ChangeMulti173(file)
        CopyFile148(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    DeleteEmptyFolder(strFolder)
  End Sub

  Sub CopyFile148(ByVal strFileName As String)

    If InStr(strFileName, "mi\bg.webp") > 0 Then
      File.Copy(strFileCopy & "mi_bg.webp", strFileName, True)
      OutputLog(strLog, "Replace file 1: " & strFileName)
    End If
    If InStr(strFileName, "addprice\img.webp") > 0 Then
      File.Copy(strFileCopy & "addprice_img.webp", strFileName, True)
      OutputLog(strLog, "Replace file 2: " & strFileName)
    End If
    If InStr(strFileName, "campaign02\bg.webp") > 0 Then
      File.Copy(strFileCopy & "campaign02_bg.webp", strFileName, True)
      OutputLog(strLog, "Replace file 3: " & strFileName)
    End If
    If InStr(strFileName, "secret\reason01_img01.webp") > 0 Then
      File.Copy(strFileCopy & "secret_reason01_img01.webp", strFileName, True)
      OutputLog(strLog, "Replace file 4: " & strFileName)
    End If
    If InStr(strFileName, "secret\reason02_img01.webp") > 0 Then
      File.Copy(strFileCopy & "secret_reason02_img01.webp", strFileName, True)
      OutputLog(strLog, "Replace file 5: " & strFileName)
    End If
    If InStr(strFileName, "price\bg.webp") > 0 Then
      File.Copy(strFileCopy & "price_bg.webp", strFileName, True)
      OutputLog(strLog, "Replace file 6: " & strFileName)
    End If
    If InStr(strFileName, "discount\bg.webp") > 0 Then
      File.Copy(strFileCopy & "discount_bg.webp", strFileName, True)
      OutputLog(strLog, "Replace file 7: " & strFileName)
    End If
    If InStr(strFileName, "reason\bg.webp") > 0 Then
      File.Copy(strFileCopy & "reason_bg.webp", strFileName, True)
      OutputLog(strLog, "Replace file 8: " & strFileName)
    End If
    If InStr(strFileName, "reason\img01.webp") > 0 Then
      File.Copy(strFileCopy & "reason_img01.webp", strFileName, True)
      OutputLog(strLog, "Replace file 9: " & strFileName)
    End If
    If InStr(strFileName, "reason\img02.webp") > 0 Then
      File.Copy(strFileCopy & "reason_img02.webp", strFileName, True)
      OutputLog(strLog, "Replace file 10: " & strFileName)
    End If
    If InStr(strFileName, "reason\img03.webp") > 0 Then
      File.Copy(strFileCopy & "reason_img03.webp", strFileName, True)
      OutputLog(strLog, "Replace file 11: " & strFileName)
    End If
    If InStr(strFileName, "choose\point01_img02.webp") > 0 Then
      File.Copy(strFileCopy & "choose_point01_img02.webp", strFileName, True)
      OutputLog(strLog, "Replace file 12: " & strFileName)
    End If
    If InStr(strFileName, "reason\reason01_img01.webp") > 0 Then
      File.Copy(strFileCopy & "reason_reason01_img01.webp", strFileName, True)
      OutputLog(strLog, "Replace file 13: " & strFileName)
    End If
    If InStr(strFileName, "reason\reason02_img01.webp") > 0 Then
      File.Copy(strFileCopy & "reason_reason02_img01.webp", strFileName, True)
      OutputLog(strLog, "Replace file 14: " & strFileName)
    End If

  End Sub

  Sub ChangeSettingsJS337(ByVal strFileName As String)
    Dim reader As String = File.ReadAllText(strFileName, Encoding.Default)

    If InStr(strFileName, "input.html") > 0 Then
      If InStr(reader, "https://dsclinic.diet/privacy/") > 0 Then
        reader = Replace(reader, "https://dsclinic.diet/privacy/",
                   "https://dsclinic.jp/privacy/")
        OutputLog(strLog, "Replace idx01 " & strFileName)
      End If

      If InStr(reader, "p03_img02.webp") > 0 Then
        reader = Replace(reader, "p03_img02.webp",
                   "p03_img02.png")
        OutputLog(strLog, "Replace p03_img02 " & strFileName)
      End If
      If InStr(reader, "p03_img03.webp") > 0 Then
        reader = Replace(reader, "p03_img03.webp",
                   "p03_img03.png")
        OutputLog(strLog, "Replace p03_img03 " & strFileName)
      End If
      If InStr(reader, "p03_img05.webp") > 0 Then
        reader = Replace(reader, "p03_img05.webp",
                   "p03_img05.png")
        OutputLog(strLog, "Replace p03_img05 " & strFileName)
      End If
    End If

    File.WriteAllText(strFileName, reader, Encoding.Default)
  End Sub
  Sub Process181()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "lessoncp.jpg") > 0) Or (InStr(file, "reason01.png") > 0) Or (InStr(file, "style.css") > 0) Then
        CopyFile184(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        'System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    'DeleteEmptyFolder(strFolder)
  End Sub
  Sub CopyFile184(ByVal strFileName As String)
    Dim buf As String = strFileCopy & Path.GetFileName(strFileName)

    If (InStr(strFileName, "05_01") > 0) And (InStr(strFileName, "reason") > 0) Then
      File.Copy(buf, strFileName, True)
      OutputLog(strLog, "Copied File :" & strFileName)
    End If
    If (InStr(strFileName, "_rl") > 0) And (InStr(strFileName, "lesson") > 0) Then
      File.Copy(buf, strFileName, True)
      OutputLog(strLog, "Copied File :" & strFileName)
    End If
  End Sub

  Sub Process141()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "campaign\ttl_bg.webp") > 0) Or (InStr(file, "campaign\ttl.webp") > 0) Or (InStr(file, "11115.webp") > 0) Then
        CopyFile141(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    DeleteEmptyFolder(strFolder)
  End Sub

  Sub CopyFile141(ByVal strFileName As String)
    Dim buf As String = strFileCopy & Path.GetFileName(strFileName)
    File.Copy(buf, strFileName, True)
    OutputLog(strLog, "Copied File :" & strFileName)
  End Sub

  Sub Process333()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "index.html") > 0) Or (InStr(file, "p03_img03.webp") > 0) Or (InStr(file, "p03_img05.webp") > 0) Then
        CopyFile333(file)
        If InStr(file, "index.html") > 0 Then
          ChangeMulti173(file)
        End If
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        'System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    'DeleteEmptyFolder(strFolder)
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

  Sub Process124()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "index.html") > 0) Or (InStr(file, "1111.png") > 0) Then
        'ChangeMulti173(file)

        'FileSystem.Rename(file, "index.php")
        Console.WriteLine("changed file name :" & file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        'System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    'DeleteEmptyFolder(strFolder)
  End Sub

  Sub Process521()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "redirect.php") > 0) Or (InStr(file, "1111.png") > 0) Then
        ChangeMulti173(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        'System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    'DeleteEmptyFolder(strFolder)
  End Sub

  Sub Process520()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, ".gif") > 0) Or (InStr(file, "1111.png") > 0) Then
        CopyFile496(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        'System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    'DeleteEmptyFolder(strFolder)
  End Sub

  Sub Process334()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    'For Each file In txtFilesArray
    '  If (InStr(file, "banner.png") > 0) Or (InStr(file, "winterplan.png") > 0) Then
    '    If InStr(file, "img\") = 0 Then
    '      System.IO.File.Delete(file)
    '    End If
    '  End If
    'Next

    For Each file In txtFilesArray
      If (InStr(file, "banner.png") > 0) Or (InStr(file, "winterplan1.png") > 0) Then
        CopyFile334(file)
        'If InStr(file, "index.html") > 0 Then
        '  ChangeMulti173(file)
        'End If
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        'System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    DeleteEmptyFolder(strFolder)
  End Sub
  Sub CopyFile334(ByVal strFileName As String)
    'Dim buf, buf1, buf2 As String

    'buf = Replace(strFileName, "index.html", "img")
    'buf1 = Replace(strFileName, "index.html", "img\reason")
    'buf2 = Replace(strFileName, "index.html", "img\banner")

    'If Not Directory.Exists(buf) Then
    '  Directory.CreateDirectory(buf)
    'End If
    'If Not Directory.Exists(buf1) Then
    '  Directory.CreateDirectory(buf1)
    'End If
    'If Not Directory.Exists(buf2) Then
    '  Directory.CreateDirectory(buf2)
    'End If

    'File.Copy(strFileCopy & "winterplan.png", buf1 & "\winterplan.png", True)
    'OutputLog(strLog, "Copied File winterplan")

    'File.Copy(strFileCopy & "banner.png", buf2 & "\banner.png", True)
    'OutputLog(strLog, "Copied File banner")

    If InStr(strFileName, "02_03") > 0 Then
      File.Copy(strFileCopy & "banner_2.png", strFileName, True)
      OutputLog(strLog, "Replace file 2: " & strFileName)
    Else
      File.Copy(strFileCopy & "banner_1.png", strFileName, True)
      OutputLog(strLog, "Replace file 1: " & strFileName)
    End If
  End Sub

  Sub Process177()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    'For Each file In txtFilesArray
    '  If (InStr(file, "air-datepicker") > 0) Then
    '    System.IO.File.Delete(file)
    '  End If
    'Next

    For Each file In txtFilesArray
      If (InStr(file, "index.php") > 0) Or (InStr(file, ".png") > 0) Then
        CopyFile496(file)
        If InStr(file, "index.php") > 0 Then
          ChangeMulti173(file)
        End If
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        'System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    DeleteEmptyFolder(strFolder)
  End Sub

  Sub ChangeMulti496(ByVal strFileName As String)
    Dim buf1, buf2, buf3, buf4, buf5, buf6, buf7, buf8, buf9 As String
    buf1 = ""
    buf2 = ""
    buf3 = ""
    buf4 = ""
    buf5 = ""
    buf6 = ""
    buf7 = ""
    buf8 = ""
    buf9 = ""


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


    If reader.IndexOf(buf1) > 0 Then
      reader = Replace(reader, buf1, buf2)
      OutputLog(strLog, "Replace Multi 1 " & strFileName)
    End If

    File.WriteAllText(strFileName, reader, Encoding.Default)
  End Sub

  Sub Process122()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "settings.js") > 0) Or (InStr(file, "common.") > 0) Then
        ChangeMulti173(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        'System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    'DeleteEmptyFolder(strFolder)
  End Sub
  Sub Process509()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "index.") > 0) Or (InStr(file, "common.") > 0) Then
        ChangeSettingsJS509(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        'System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    'DeleteEmptyFolder(strFolder)
  End Sub

  Sub ChangeSettingsJS509(ByVal strFileName As String)
    Dim reader As String = File.ReadAllText(strFileName, Encoding.Default)

    If InStr(strFileName, "index.") > 0 Then
      If InStr(reader, "<span class=""fs120 pink oswald count-up"">116</span>ìXï‹</span></h2>") > 0 Then
        reader = Replace(reader, "<span class=""fs120 pink oswald count-up"">116</span>ìXï‹</span></h2>",
                   "<span class=""fs120 pink oswald count-up"">110</span>ìXï‹à»è„</span></h2>")
        OutputLog(strLog, "Replace idx01 " & strFileName)
      End If

      If InStr(reader, "<span class=""fs42 lh13 white"">ëSçë116ìXï‹ìWäJÇ≈<span class=""yellow dblock"">") > 0 Then
        reader = Replace(reader, "<span class=""fs42 lh13 white"">ëSçë116ìXï‹ìWäJÇ≈<span class=""yellow dblock"">",
                   "<span class=""fs42 lh13 white"">ëSçë110ìXï‹à»è„ìWäJÇ≈<span class=""yellow dblock"">")
        OutputLog(strLog, "Replace idx02 " & strFileName)
      End If

      If InStr(reader, "ëSçë116ìXï‹Ç…ìWäJ") > 0 Then
        reader = Replace(reader, "ëSçë116ìXï‹Ç…ìWäJ",
                   "ëSçë110ìXï‹à»è„Ç…ìWäJ")
        OutputLog(strLog, "Replace idx03 " & strFileName)
      End If

    End If
    If InStr(strFileName, "common.min.css") > 0 Then
      If InStr(reader, "fs120{font-size:12rem}") > 0 Then
        reader = Replace(reader, "fs120{font-size:12rem}",
                   "fs120{font-size:9rem}")
        OutputLog(strLog, "Replace min01 " & strFileName)
      End If

      If InStr(reader, "fs64{font-size:6.4rem}") > 0 Then
        reader = Replace(reader, "fs64{font-size:6.4rem}",
                   "fs64{font-size:5.4rem}")
        OutputLog(strLog, "Replace min02 " & strFileName)
      End If
    End If

    If InStr(strFileName, "common.css") > 0 Then
      If InStr(reader, ".fs120 {font-size: 12rem;}") > 0 Then
        reader = Replace(reader, ".fs120 {font-size: 12rem;}",
                   ".fs120 {font-size: 9rem;}")
        OutputLog(strLog, "Replace css01 " & strFileName)
      End If

      If InStr(reader, ".fs64 {font-size: 6.4rem;}") > 0 Then
        reader = Replace(reader, ".fs64 {font-size: 6.4rem;}",
                   ".fs64 {font-size: 5.4rem;}")
        OutputLog(strLog, "Replace css02" & strFileName)
      End If
    End If

    File.WriteAllText(strFileName, reader, Encoding.Default)
  End Sub

  Sub Process173()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "index.php") > 0) Then
        ChangeMulti173(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        'System.IO.File.Delete(file)
      End If
    Next
    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    DeleteEmptyFolder(strFolder)
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

  Sub Process508()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "img\campaign\img.webp") > 0) Then
        CopyFile508(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        System.IO.File.Delete(file)
      End If

    Next

    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    DeleteEmptyFolder(strFolder)
  End Sub

  Sub CopyFile508(ByVal strFileName As String)
    Dim buf As String
    buf = strFileCopy & Path.GetFileName(strFileName)

    File.Copy(strFileCopy & "img.webp", strFileName, True)
    OutputLog(strLog, "Replace File " & buf & " , " & strFileName)
  End Sub

  Sub Process172()
    Dim txtFilesArray As String() = Directory.GetFiles(strFolder, "*.*", SearchOption.AllDirectories)
    Dim Count As Integer = 0
    Dim Count1 As Integer = 0

    For Each file In txtFilesArray
      If (InStr(file, "index.php") > 0) Or (InStr(file, "style.js") > 0) Then
        ChangeMulti272(file)
        CopyFile172(file)
        Count1 = Count1 + 1
        Count = Count + 1
      Else
        'System.IO.File.Delete(file)
      End If

    Next
    'ChangeName172(strFolder)

    Console.WriteLine("Total : " & Count & ". Count1: " & Count1)
    '    DeleteEmptyFolder(strFolder)
  End Sub
  Sub CopyFile172(ByVal strFileName As String)
    Dim buf As String
    buf = Replace(strFileName, "\index.php", "\img\lessoncp.jpg")

    If InStr(strFileName, "index.php") > 0 Then
      File.Copy(strFileCopy & "lessoncp.jpg", buf, True)
      OutputLog(strLog, "Replace File " & buf & " , " & strFileName)
    End If

  End Sub

  Sub ChangeMulti272(ByVal strFileName As String)
    Dim buf1, buf2, buf3, buf4, buf5, buf6, buf7, buf8, buf9 As String
    buf1 = ""
    buf2 = ""
    buf3 = ""
    buf4 = ""
    buf5 = ""
    buf6 = ""
    buf7 = ""
    buf8 = ""
    buf9 = ""


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


    If reader.IndexOf(buf1) > 0 Then
      reader = Replace(reader, buf1, buf2)
      OutputLog(strLog, "Replace Multi 1 " & strFileName)
    End If
    If reader.IndexOf(buf3) > 0 Then
      reader = Replace(reader, buf3, buf4)
      OutputLog(strLog, "Replace Multi 3 " & strFileName)
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

