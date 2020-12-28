Public Class Form1
    Private Sub GetJpegTranVersion()
        Try
            Dim jpegtranProcessInfo As New ProcessStartInfo
            Dim jpegtranProcess As Process
            jpegtranProcessInfo.FileName = "jpegtran-static.exe"
            jpegtranProcessInfo.Arguments = "-version"
            jpegtranProcessInfo.CreateNoWindow = True
            jpegtranProcessInfo.RedirectStandardError = True
            jpegtranProcessInfo.UseShellExecute = False
            jpegtranProcess = Process.Start(jpegtranProcessInfo)
            jpegtranProcess.WaitForExit()
            jpegtran_version.Text = "jpegtran version: " + jpegtranProcess.StandardError.ReadLine()
        Catch ex As Exception
            MsgBox("jpegtran-static.exe was not found. The software cannot start.")
            Me.Close()
        End Try
    End Sub
    Private Sub GetCJpegVersion()
        Try
            Dim cjpegProcessInfo As New ProcessStartInfo
            Dim cjpegProcess As Process
            cjpegProcessInfo.FileName = "cjpeg-static.exe"
            cjpegProcessInfo.Arguments = "-version"
            cjpegProcessInfo.CreateNoWindow = True
            cjpegProcessInfo.RedirectStandardError = True
            cjpegProcessInfo.UseShellExecute = False
            cjpegProcess = Process.Start(cjpegProcessInfo)
            cjpegProcess.WaitForExit()
            cjpeg_version.Text = "cjpeg version: " + cjpegProcess.StandardError.ReadLine()
        Catch ex As Exception
            MsgBox("cjpeg-static.exe was not found. The software cannot start.")
            Me.Close()
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IO.Directory.SetCurrentDirectory(IO.Path.GetDirectoryName(Process.GetCurrentProcess.MainModule.FileName))
        GetJpegTranVersion()
        GetCJpegVersion()
        LosslessRadioButton.Checked = My.Settings.LosslessMethod
        LossyRadioButton.Checked = My.Settings.LossyMethod
        CopyNone.Checked = My.Settings.CopyNone
        CopyComments.Checked = My.Settings.CopyComments
        CopyAll.Checked = My.Settings.CopyAll
        JPEGAnnexK.Checked = My.Settings.QuantizationJPEG
        FlatQuantization.Checked = My.Settings.QuantizationFlat
        CustomMSSSIM.Checked = My.Settings.QuantCustomMSSSIM
        ImageMagickQuantization.Checked = My.Settings.QuantImageMagick
        CustomPSNRHVS.Checked = My.Settings.QuantCustomPSNRHVS
        TableQuantization.Checked = My.Settings.QuantTable
        DCTInteger.Checked = My.Settings.DCTInt
        DCTFastInteger.Checked = My.Settings.DCTFastInt
        DCTFloat.Checked = My.Settings.DCTFloat
        DCOneScanAllComponents.Checked = My.Settings.DC0
        DCOneScanPerComponent.Checked = My.Settings.DC1
        DCOptimize.Checked = My.Settings.DC2
        LossyQuality.Value = My.Settings.Quality
    End Sub

    Private Sub LosslessRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles LosslessRadioButton.CheckedChanged
        My.Settings.LosslessMethod = LosslessRadioButton.Checked
        My.Settings.Save()
    End Sub

    Private Sub LossyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles LossyRadioButton.CheckedChanged
        My.Settings.LossyMethod = LossyRadioButton.Checked
        My.Settings.Save()
    End Sub

    Private Sub CopyNone_CheckedChanged(sender As Object, e As EventArgs) Handles CopyNone.CheckedChanged
        My.Settings.CopyNone = CopyNone.Checked
        My.Settings.Save()
    End Sub

    Private Sub CopyComments_CheckedChanged(sender As Object, e As EventArgs) Handles CopyComments.CheckedChanged
        My.Settings.CopyComments = CopyComments.Checked
        My.Settings.Save()
    End Sub

    Private Sub CopyAll_CheckedChanged(sender As Object, e As EventArgs) Handles CopyAll.CheckedChanged
        My.Settings.CopyAll = CopyAll.Checked
        My.Settings.Save()
    End Sub

    Private Sub JPEGAnnexK_CheckedChanged(sender As Object, e As EventArgs) Handles JPEGAnnexK.CheckedChanged
        My.Settings.QuantizationJPEG = JPEGAnnexK.Checked
        My.Settings.Save()
    End Sub

    Private Sub FlatQuantization_CheckedChanged(sender As Object, e As EventArgs) Handles FlatQuantization.CheckedChanged
        My.Settings.QuantizationFlat = FlatQuantization.Checked
        My.Settings.Save()
    End Sub

    Private Sub CustomMSSSIM_CheckedChanged(sender As Object, e As EventArgs) Handles CustomMSSSIM.CheckedChanged
        My.Settings.QuantCustomMSSSIM = CustomMSSSIM.Checked
        My.Settings.Save()
    End Sub

    Private Sub ImageMagickQuantization_CheckedChanged(sender As Object, e As EventArgs) Handles ImageMagickQuantization.CheckedChanged
        My.Settings.QuantImageMagick = ImageMagickQuantization.Checked
        My.Settings.Save()
    End Sub

    Private Sub CustomPSNRHVS_CheckedChanged(sender As Object, e As EventArgs) Handles CustomPSNRHVS.CheckedChanged
        My.Settings.QuantCustomPSNRHVS = CustomPSNRHVS.Checked
        My.Settings.Save()
    End Sub

    Private Sub TableQuantization_CheckedChanged(sender As Object, e As EventArgs) Handles TableQuantization.CheckedChanged
        My.Settings.QuantTable = TableQuantization.Checked
        My.Settings.Save()
    End Sub

    Private Sub DCTInteger_CheckedChanged(sender As Object, e As EventArgs) Handles DCTInteger.CheckedChanged
        My.Settings.DCTInt = DCTInteger.Checked
        My.Settings.Save()
    End Sub

    Private Sub DCTFastInteger_CheckedChanged(sender As Object, e As EventArgs) Handles DCTFastInteger.CheckedChanged
        My.Settings.DCTFastInt = DCTFastInteger.Checked
        My.Settings.Save()
    End Sub

    Private Sub DCTFloat_CheckedChanged(sender As Object, e As EventArgs) Handles DCTFloat.CheckedChanged
        My.Settings.DCTFloat = DCTFloat.Checked
        My.Settings.Save()
    End Sub

    Private Sub DCOneScanAllComponents_CheckedChanged(sender As Object, e As EventArgs) Handles DCOneScanAllComponents.CheckedChanged
        My.Settings.DC0 = DCOneScanAllComponents.Checked
        My.Settings.Save()
    End Sub

    Private Sub DCOneScanPerComponent_CheckedChanged(sender As Object, e As EventArgs) Handles DCOneScanPerComponent.CheckedChanged
        My.Settings.DC1 = DCOneScanPerComponent.Checked
        My.Settings.Save()
    End Sub

    Private Sub DCOptimize_CheckedChanged(sender As Object, e As EventArgs) Handles DCOptimize.CheckedChanged
        My.Settings.DC2 = DCOptimize.Checked
        My.Settings.Save()
    End Sub

    Private Sub LossyQuality_ValueChanged(sender As Object, e As EventArgs) Handles LossyQuality.ValueChanged
        My.Settings.Quality = LossyQuality.Value
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        If String.IsNullOrWhiteSpace(InputLocationTxtBox.Text) Then
            MessageBox.Show("The input location cannot be empty.")
        ElseIf String.IsNullOrWhiteSpace(OutputLocationTxtBox.Text) Then
            MessageBox.Show("The output location cannot be empty.")
        Else
            StartBtn.Enabled = False
            Dim StartTask As New Threading.Thread(Sub() JPEGOptimizationThread(InputLocationTxtBox.Text, OutputLocationTxtBox.Text))
            StartTask.Start()
        End If
    End Sub

    Private Sub RunProcess(file As String, processExe As String, CommandLine As String)
        Dim jpegProcessInfo As New ProcessStartInfo
        Dim jpegProcess As Process
        jpegProcessInfo.FileName = processExe
        jpegProcessInfo.Arguments = CommandLine
        jpegProcessInfo.CreateNoWindow = True
        jpegProcessInfo.UseShellExecute = False
        jpegProcess = Process.Start(jpegProcessInfo)
        jpegProcess.WaitForExit()
        ProgressBar1.BeginInvoke(Sub() ProgressBar1.PerformStep())
    End Sub

    Private Function JPEGLosslessOptimizationArgumentBuilder() As String
        Dim CommandLineArgs As String = "-copy "
        If My.Settings.CopyNone Then
            CommandLineArgs += "none "
        ElseIf My.Settings.CopyComments Then
            CommandLineArgs += "comments "
        Else
            CommandLineArgs += "all "
        End If
        Return CommandLineArgs
    End Function

    Private Function JPEGLossyOptimizationArgumentBuilder() As String
        Dim CommandLineArgs As String = "-quality " + My.Settings.Quality.ToString
        'Sets DCT argument
        If My.Settings.DCTInt Then
            CommandLineArgs += " -dct int"
        ElseIf My.Settings.DCTFastInt Then
            CommandLineArgs += " -dct fast"
        Else
            CommandLineArgs += " -dct float"
        End If
        'Sets DC option
        If My.Settings.DC0 Then
            CommandLineArgs += " -dc-scan-opt 0"
        ElseIf My.Settings.DC1 Then
            CommandLineArgs += " -dc-scan-opt 1"
        Else
            CommandLineArgs += " -dc-scan-opt 2"
        End If
        'Sets Quantization Table
        If My.Settings.QuantizationJPEG Then
            CommandLineArgs += " -quant-table 0"
        ElseIf My.Settings.QuantizationFlat Then
            CommandLineArgs += " -quant-table 1"
        ElseIf My.Settings.QuantCustomMSSSIM Then
            CommandLineArgs += " -quant-table 2"
        ElseIf My.Settings.QuantImageMagick Then
            CommandLineArgs += " -quant-table 3"
        ElseIf My.Settings.QuantCustomPSNRHVS Then
            CommandLineArgs += " -quant-table 4"
        Else
            CommandLineArgs += " -quant-table 5"
        End If
        Return CommandLineArgs
    End Function
    Private Sub JPEGOptimizationThread(InputLocation As String, OutputLocation As String)
        Dim Files As String() = IO.Directory.GetFiles(InputLocation)
        Dim JpegTasks As List(Of Action) = New List(Of Action)

        Dim CommandLine As String = String.Empty
        Dim ProcessExe As String = String.Empty
        If My.Settings.LosslessMethod Then
            CommandLine = JPEGLosslessOptimizationArgumentBuilder()
            ProcessExe = "jpegtran-static.exe"
        Else
            CommandLine = JPEGLossyOptimizationArgumentBuilder()
            ProcessExe = "cjpeg-static.exe"
        End If
        For Each file In Files
            If IO.Path.GetExtension(file) = ".jpg" Or IO.Path.GetExtension(file) = ".jpeg" Then
                JpegTasks.Add(Sub() RunProcess(file, ProcessExe, CommandLine + " -outfile """ + OutputLocation + "\" + IO.Path.GetFileName(file) + """ """ + file + """"))
            End If

        Next
        ProgressBar1.BeginInvoke(Sub()
                                     ProgressBar1.Maximum = JpegTasks.Count
                                     ProgressBar1.Value = 0
                                 End Sub)
        Parallel.Invoke(New ParallelOptions With {.MaxDegreeOfParallelism = Environment.ProcessorCount}, JpegTasks.ToArray())
        MessageBox.Show("Finished!")
        StartBtn.BeginInvoke(Sub() StartBtn.Enabled = True)
    End Sub

    Private Sub InputBrowseButton_Click(sender As Object, e As EventArgs) Handles InputBrowseButton.Click
        InputFolderBrowserDialog.ShowDialog()
        InputLocationTxtBox.Text = InputFolderBrowserDialog.SelectedPath
    End Sub

    Private Sub OutputBrowseButton_Click(sender As Object, e As EventArgs) Handles OutputBrowseButton.Click
        OutputFolderBrowserDialog.ShowDialog()
        OutputLocationTxtBox.Text = OutputFolderBrowserDialog.SelectedPath
    End Sub
End Class
