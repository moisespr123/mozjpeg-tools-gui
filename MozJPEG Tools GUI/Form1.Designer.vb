<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cjpeg_version = New System.Windows.Forms.Label()
        Me.jpegtran_version = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MethodGroupBox = New System.Windows.Forms.GroupBox()
        Me.LosslessRadioButton = New System.Windows.Forms.RadioButton()
        Me.LossyRadioButton = New System.Windows.Forms.RadioButton()
        Me.OutputBrowseButton = New System.Windows.Forms.Button()
        Me.OutputLocationTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InputBrowseButton = New System.Windows.Forms.Button()
        Me.InputLocationTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DCGroupBox = New System.Windows.Forms.GroupBox()
        Me.DCOptimize = New System.Windows.Forms.RadioButton()
        Me.DCOneScanAllComponents = New System.Windows.Forms.RadioButton()
        Me.DCOneScanPerComponent = New System.Windows.Forms.RadioButton()
        Me.DCTGroupBox = New System.Windows.Forms.GroupBox()
        Me.DCTFloat = New System.Windows.Forms.RadioButton()
        Me.DCTFastInteger = New System.Windows.Forms.RadioButton()
        Me.DCTInteger = New System.Windows.Forms.RadioButton()
        Me.QuantizationGroupBox = New System.Windows.Forms.GroupBox()
        Me.TableQuantization = New System.Windows.Forms.RadioButton()
        Me.CustomPSNRHVS = New System.Windows.Forms.RadioButton()
        Me.ImageMagickQuantization = New System.Windows.Forms.RadioButton()
        Me.CustomMSSSIM = New System.Windows.Forms.RadioButton()
        Me.FlatQuantization = New System.Windows.Forms.RadioButton()
        Me.JPEGAnnexK = New System.Windows.Forms.RadioButton()
        Me.LossyQuality = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CopyAll = New System.Windows.Forms.RadioButton()
        Me.CopyComments = New System.Windows.Forms.RadioButton()
        Me.CopyNone = New System.Windows.Forms.RadioButton()
        Me.InputFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.OutputFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MethodGroupBox.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.DCGroupBox.SuspendLayout()
        Me.DCTGroupBox.SuspendLayout()
        Me.QuantizationGroupBox.SuspendLayout()
        CType(Me.LossyQuality, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cjpeg_version)
        Me.Panel1.Controls.Add(Me.jpegtran_version)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.StartBtn)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.MethodGroupBox)
        Me.Panel1.Controls.Add(Me.OutputBrowseButton)
        Me.Panel1.Controls.Add(Me.OutputLocationTxtBox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.InputBrowseButton)
        Me.Panel1.Controls.Add(Me.InputLocationTxtBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 444)
        Me.Panel1.TabIndex = 0
        '
        'cjpeg_version
        '
        Me.cjpeg_version.AutoSize = True
        Me.cjpeg_version.Location = New System.Drawing.Point(8, 284)
        Me.cjpeg_version.Name = "cjpeg_version"
        Me.cjpeg_version.Size = New System.Drawing.Size(73, 13)
        Me.cjpeg_version.TabIndex = 21
        Me.cjpeg_version.Text = "cjpeg version:"
        '
        'jpegtran_version
        '
        Me.jpegtran_version.AutoSize = True
        Me.jpegtran_version.Location = New System.Drawing.Point(8, 271)
        Me.jpegtran_version.Name = "jpegtran_version"
        Me.jpegtran_version.Size = New System.Drawing.Size(85, 13)
        Me.jpegtran_version.TabIndex = 20
        Me.jpegtran_version.Text = "jpegtran version:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(11, 226)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(380, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 19
        '
        'StartBtn
        '
        Me.StartBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartBtn.Location = New System.Drawing.Point(11, 151)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(380, 57)
        Me.StartBtn.TabIndex = 18
        Me.StartBtn.Text = "Start"
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 425)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "v1.0"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "GUI By: Moisés Cardona"
        '
        'MethodGroupBox
        '
        Me.MethodGroupBox.Controls.Add(Me.LosslessRadioButton)
        Me.MethodGroupBox.Controls.Add(Me.LossyRadioButton)
        Me.MethodGroupBox.Location = New System.Drawing.Point(11, 94)
        Me.MethodGroupBox.Name = "MethodGroupBox"
        Me.MethodGroupBox.Size = New System.Drawing.Size(137, 51)
        Me.MethodGroupBox.TabIndex = 15
        Me.MethodGroupBox.TabStop = False
        Me.MethodGroupBox.Text = "Method"
        '
        'LosslessRadioButton
        '
        Me.LosslessRadioButton.AutoSize = True
        Me.LosslessRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.LosslessRadioButton.Name = "LosslessRadioButton"
        Me.LosslessRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.LosslessRadioButton.TabIndex = 7
        Me.LosslessRadioButton.TabStop = True
        Me.LosslessRadioButton.Text = "Lossless"
        Me.LosslessRadioButton.UseVisualStyleBackColor = True
        '
        'LossyRadioButton
        '
        Me.LossyRadioButton.AutoSize = True
        Me.LossyRadioButton.Location = New System.Drawing.Point(77, 19)
        Me.LossyRadioButton.Name = "LossyRadioButton"
        Me.LossyRadioButton.Size = New System.Drawing.Size(52, 17)
        Me.LossyRadioButton.TabIndex = 8
        Me.LossyRadioButton.TabStop = True
        Me.LossyRadioButton.Text = "Lossy"
        Me.LossyRadioButton.UseVisualStyleBackColor = True
        '
        'OutputBrowseButton
        '
        Me.OutputBrowseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputBrowseButton.Location = New System.Drawing.Point(288, 62)
        Me.OutputBrowseButton.Name = "OutputBrowseButton"
        Me.OutputBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.OutputBrowseButton.TabIndex = 14
        Me.OutputBrowseButton.Text = "Browse"
        Me.OutputBrowseButton.UseVisualStyleBackColor = True
        '
        'OutputLocationTxtBox
        '
        Me.OutputLocationTxtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputLocationTxtBox.Location = New System.Drawing.Point(11, 64)
        Me.OutputLocationTxtBox.Name = "OutputLocationTxtBox"
        Me.OutputLocationTxtBox.Size = New System.Drawing.Size(271, 20)
        Me.OutputLocationTxtBox.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Step 2: Browse for a location to store the optimized JPEG files:"
        '
        'InputBrowseButton
        '
        Me.InputBrowseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputBrowseButton.Location = New System.Drawing.Point(288, 22)
        Me.InputBrowseButton.Name = "InputBrowseButton"
        Me.InputBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.InputBrowseButton.TabIndex = 11
        Me.InputBrowseButton.Text = "Browse"
        Me.InputBrowseButton.UseVisualStyleBackColor = True
        '
        'InputLocationTxtBox
        '
        Me.InputLocationTxtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputLocationTxtBox.Location = New System.Drawing.Point(11, 25)
        Me.InputLocationTxtBox.Name = "InputLocationTxtBox"
        Me.InputLocationTxtBox.Size = New System.Drawing.Size(271, 20)
        Me.InputLocationTxtBox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Step 1: Browse for an input folder with JPEG files:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(403, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 444)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DCGroupBox)
        Me.GroupBox2.Controls.Add(Me.DCTGroupBox)
        Me.GroupBox2.Controls.Add(Me.QuantizationGroupBox)
        Me.GroupBox2.Controls.Add(Me.LossyQuality)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 294)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lossy Options"
        '
        'DCGroupBox
        '
        Me.DCGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DCGroupBox.Controls.Add(Me.DCOptimize)
        Me.DCGroupBox.Controls.Add(Me.DCOneScanAllComponents)
        Me.DCGroupBox.Controls.Add(Me.DCOneScanPerComponent)
        Me.DCGroupBox.Location = New System.Drawing.Point(13, 187)
        Me.DCGroupBox.Name = "DCGroupBox"
        Me.DCGroupBox.Size = New System.Drawing.Size(345, 99)
        Me.DCGroupBox.TabIndex = 4
        Me.DCGroupBox.TabStop = False
        Me.DCGroupBox.Text = "DC Scan Optimization Mode"
        '
        'DCOptimize
        '
        Me.DCOptimize.AutoSize = True
        Me.DCOptimize.Location = New System.Drawing.Point(6, 65)
        Me.DCOptimize.Name = "DCOptimize"
        Me.DCOptimize.Size = New System.Drawing.Size(245, 30)
        Me.DCOptimize.TabIndex = 5
        Me.DCOptimize.TabStop = True
        Me.DCOptimize.Text = "Optimize between one scan for all components" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and one scan for 1st component"
        Me.DCOptimize.UseVisualStyleBackColor = True
        '
        'DCOneScanAllComponents
        '
        Me.DCOneScanAllComponents.AutoSize = True
        Me.DCOneScanAllComponents.Location = New System.Drawing.Point(6, 19)
        Me.DCOneScanAllComponents.Name = "DCOneScanAllComponents"
        Me.DCOneScanAllComponents.Size = New System.Drawing.Size(160, 17)
        Me.DCOneScanAllComponents.TabIndex = 3
        Me.DCOneScanAllComponents.TabStop = True
        Me.DCOneScanAllComponents.Text = "One scan for all components"
        Me.DCOneScanAllComponents.UseVisualStyleBackColor = True
        '
        'DCOneScanPerComponent
        '
        Me.DCOneScanPerComponent.AutoSize = True
        Me.DCOneScanPerComponent.Location = New System.Drawing.Point(6, 42)
        Me.DCOneScanPerComponent.Name = "DCOneScanPerComponent"
        Me.DCOneScanPerComponent.Size = New System.Drawing.Size(145, 17)
        Me.DCOneScanPerComponent.TabIndex = 4
        Me.DCOneScanPerComponent.TabStop = True
        Me.DCOneScanPerComponent.Text = "One scan per component"
        Me.DCOneScanPerComponent.UseVisualStyleBackColor = True
        '
        'DCTGroupBox
        '
        Me.DCTGroupBox.Controls.Add(Me.DCTFloat)
        Me.DCTGroupBox.Controls.Add(Me.DCTFastInteger)
        Me.DCTGroupBox.Controls.Add(Me.DCTInteger)
        Me.DCTGroupBox.Location = New System.Drawing.Point(13, 84)
        Me.DCTGroupBox.Name = "DCTGroupBox"
        Me.DCTGroupBox.Size = New System.Drawing.Size(120, 97)
        Me.DCTGroupBox.TabIndex = 3
        Me.DCTGroupBox.TabStop = False
        Me.DCTGroupBox.Text = "DCT:"
        '
        'DCTFloat
        '
        Me.DCTFloat.AutoSize = True
        Me.DCTFloat.Location = New System.Drawing.Point(6, 65)
        Me.DCTFloat.Name = "DCTFloat"
        Me.DCTFloat.Size = New System.Drawing.Size(89, 17)
        Me.DCTFloat.TabIndex = 2
        Me.DCTFloat.TabStop = True
        Me.DCTFloat.Text = "Floating Point"
        Me.DCTFloat.UseVisualStyleBackColor = True
        '
        'DCTFastInteger
        '
        Me.DCTFastInteger.AutoSize = True
        Me.DCTFastInteger.Location = New System.Drawing.Point(6, 42)
        Me.DCTFastInteger.Name = "DCTFastInteger"
        Me.DCTFastInteger.Size = New System.Drawing.Size(81, 17)
        Me.DCTFastInteger.TabIndex = 1
        Me.DCTFastInteger.TabStop = True
        Me.DCTFastInteger.Text = "Fast Integer"
        Me.DCTFastInteger.UseVisualStyleBackColor = True
        '
        'DCTInteger
        '
        Me.DCTInteger.AutoSize = True
        Me.DCTInteger.Location = New System.Drawing.Point(6, 19)
        Me.DCTInteger.Name = "DCTInteger"
        Me.DCTInteger.Size = New System.Drawing.Size(58, 17)
        Me.DCTInteger.TabIndex = 0
        Me.DCTInteger.TabStop = True
        Me.DCTInteger.Text = "Integer"
        Me.DCTInteger.UseVisualStyleBackColor = True
        '
        'QuantizationGroupBox
        '
        Me.QuantizationGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuantizationGroupBox.Controls.Add(Me.TableQuantization)
        Me.QuantizationGroupBox.Controls.Add(Me.CustomPSNRHVS)
        Me.QuantizationGroupBox.Controls.Add(Me.ImageMagickQuantization)
        Me.QuantizationGroupBox.Controls.Add(Me.CustomMSSSIM)
        Me.QuantizationGroupBox.Controls.Add(Me.FlatQuantization)
        Me.QuantizationGroupBox.Controls.Add(Me.JPEGAnnexK)
        Me.QuantizationGroupBox.Location = New System.Drawing.Point(160, 19)
        Me.QuantizationGroupBox.Name = "QuantizationGroupBox"
        Me.QuantizationGroupBox.Size = New System.Drawing.Size(207, 165)
        Me.QuantizationGroupBox.TabIndex = 2
        Me.QuantizationGroupBox.TabStop = False
        Me.QuantizationGroupBox.Text = "Quantization Table:"
        '
        'TableQuantization
        '
        Me.TableQuantization.AutoSize = True
        Me.TableQuantization.Location = New System.Drawing.Point(7, 132)
        Me.TableQuantization.Name = "TableQuantization"
        Me.TableQuantization.Size = New System.Drawing.Size(151, 30)
        Me.TableQuantization.TabIndex = 5
        Me.TableQuantization.TabStop = True
        Me.TableQuantization.Text = "Table from paper by Klein, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Silvestein and Carney"
        Me.TableQuantization.UseVisualStyleBackColor = True
        '
        'CustomPSNRHVS
        '
        Me.CustomPSNRHVS.AutoSize = True
        Me.CustomPSNRHVS.Location = New System.Drawing.Point(7, 111)
        Me.CustomPSNRHVS.Name = "CustomPSNRHVS"
        Me.CustomPSNRHVS.Size = New System.Drawing.Size(166, 17)
        Me.CustomPSNRHVS.TabIndex = 4
        Me.CustomPSNRHVS.TabStop = True
        Me.CustomPSNRHVS.Text = "Custom, tuned for PSNR-HVS"
        Me.CustomPSNRHVS.UseVisualStyleBackColor = True
        '
        'ImageMagickQuantization
        '
        Me.ImageMagickQuantization.AutoSize = True
        Me.ImageMagickQuantization.Location = New System.Drawing.Point(7, 88)
        Me.ImageMagickQuantization.Name = "ImageMagickQuantization"
        Me.ImageMagickQuantization.Size = New System.Drawing.Size(191, 17)
        Me.ImageMagickQuantization.TabIndex = 3
        Me.ImageMagickQuantization.TabStop = True
        Me.ImageMagickQuantization.Text = "ImageMagick table by N. Robidoux"
        Me.ImageMagickQuantization.UseVisualStyleBackColor = True
        '
        'CustomMSSSIM
        '
        Me.CustomMSSSIM.AutoSize = True
        Me.CustomMSSSIM.Location = New System.Drawing.Point(7, 65)
        Me.CustomMSSSIM.Name = "CustomMSSSIM"
        Me.CustomMSSSIM.Size = New System.Drawing.Size(158, 17)
        Me.CustomMSSSIM.TabIndex = 2
        Me.CustomMSSSIM.TabStop = True
        Me.CustomMSSSIM.Text = "Custom, tunied for MS-SSIM"
        Me.CustomMSSSIM.UseVisualStyleBackColor = True
        '
        'FlatQuantization
        '
        Me.FlatQuantization.AutoSize = True
        Me.FlatQuantization.Location = New System.Drawing.Point(7, 42)
        Me.FlatQuantization.Name = "FlatQuantization"
        Me.FlatQuantization.Size = New System.Drawing.Size(42, 17)
        Me.FlatQuantization.TabIndex = 1
        Me.FlatQuantization.TabStop = True
        Me.FlatQuantization.Text = "Flat"
        Me.FlatQuantization.UseVisualStyleBackColor = True
        '
        'JPEGAnnexK
        '
        Me.JPEGAnnexK.AutoSize = True
        Me.JPEGAnnexK.Location = New System.Drawing.Point(7, 19)
        Me.JPEGAnnexK.Name = "JPEGAnnexK"
        Me.JPEGAnnexK.Size = New System.Drawing.Size(95, 17)
        Me.JPEGAnnexK.TabIndex = 0
        Me.JPEGAnnexK.TabStop = True
        Me.JPEGAnnexK.Text = "JPEG Annex K"
        Me.JPEGAnnexK.UseVisualStyleBackColor = True
        '
        'LossyQuality
        '
        Me.LossyQuality.Location = New System.Drawing.Point(58, 40)
        Me.LossyQuality.Name = "LossyQuality"
        Me.LossyQuality.Size = New System.Drawing.Size(58, 20)
        Me.LossyQuality.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Quality:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CopyAll)
        Me.GroupBox1.Controls.Add(Me.CopyComments)
        Me.GroupBox1.Controls.Add(Me.CopyNone)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 50)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lossless Metadata Options"
        '
        'CopyAll
        '
        Me.CopyAll.AutoSize = True
        Me.CopyAll.Location = New System.Drawing.Point(189, 19)
        Me.CopyAll.Name = "CopyAll"
        Me.CopyAll.Size = New System.Drawing.Size(63, 17)
        Me.CopyAll.TabIndex = 11
        Me.CopyAll.TabStop = True
        Me.CopyAll.Text = "Keep all"
        Me.CopyAll.UseVisualStyleBackColor = True
        '
        'CopyComments
        '
        Me.CopyComments.AutoSize = True
        Me.CopyComments.Location = New System.Drawing.Point(58, 19)
        Me.CopyComments.Name = "CopyComments"
        Me.CopyComments.Size = New System.Drawing.Size(125, 17)
        Me.CopyComments.TabIndex = 10
        Me.CopyComments.TabStop = True
        Me.CopyComments.Text = "Copy Comments Only"
        Me.CopyComments.UseVisualStyleBackColor = True
        '
        'CopyNone
        '
        Me.CopyNone.AutoSize = True
        Me.CopyNone.Location = New System.Drawing.Point(6, 19)
        Me.CopyNone.Name = "CopyNone"
        Me.CopyNone.Size = New System.Drawing.Size(46, 17)
        Me.CopyNone.TabIndex = 9
        Me.CopyNone.TabStop = True
        Me.CopyNone.Text = "Strip"
        Me.CopyNone.UseVisualStyleBackColor = True
        '
        'InputFolderBrowserDialog
        '
        Me.InputFolderBrowserDialog.ShowNewFolderButton = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "MozJPEG Optimization Tools GUI"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MethodGroupBox.ResumeLayout(False)
        Me.MethodGroupBox.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.DCGroupBox.ResumeLayout(False)
        Me.DCGroupBox.PerformLayout()
        Me.DCTGroupBox.ResumeLayout(False)
        Me.DCTGroupBox.PerformLayout()
        Me.QuantizationGroupBox.ResumeLayout(False)
        Me.QuantizationGroupBox.PerformLayout()
        CType(Me.LossyQuality, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MethodGroupBox As GroupBox
    Friend WithEvents LosslessRadioButton As RadioButton
    Friend WithEvents LossyRadioButton As RadioButton
    Friend WithEvents OutputBrowseButton As Button
    Friend WithEvents OutputLocationTxtBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents InputBrowseButton As Button
    Friend WithEvents InputLocationTxtBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DCGroupBox As GroupBox
    Friend WithEvents DCOptimize As RadioButton
    Friend WithEvents DCOneScanAllComponents As RadioButton
    Friend WithEvents DCOneScanPerComponent As RadioButton
    Friend WithEvents DCTGroupBox As GroupBox
    Friend WithEvents DCTFloat As RadioButton
    Friend WithEvents DCTFastInteger As RadioButton
    Friend WithEvents DCTInteger As RadioButton
    Friend WithEvents QuantizationGroupBox As GroupBox
    Friend WithEvents TableQuantization As RadioButton
    Friend WithEvents CustomPSNRHVS As RadioButton
    Friend WithEvents ImageMagickQuantization As RadioButton
    Friend WithEvents CustomMSSSIM As RadioButton
    Friend WithEvents FlatQuantization As RadioButton
    Friend WithEvents JPEGAnnexK As RadioButton
    Friend WithEvents LossyQuality As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CopyAll As RadioButton
    Friend WithEvents CopyComments As RadioButton
    Friend WithEvents CopyNone As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents StartBtn As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents cjpeg_version As Label
    Friend WithEvents jpegtran_version As Label
    Friend WithEvents InputFolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents OutputFolderBrowserDialog As FolderBrowserDialog
End Class
