<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMinHumid = New System.Windows.Forms.TextBox()
        Me.txtMaxHumid = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMinTemp = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMaxTemp = New System.Windows.Forms.TextBox()
        Me.txtBoxDCUIP = New System.Windows.Forms.TextBox()
        Me.txtBoxHESIP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnALL = New System.Windows.Forms.Button()
        Me.btnRF = New System.Windows.Forms.Button()
        Me.btnPLC = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSVR = New System.Windows.Forms.Button()
        Me.MtrData = New System.Windows.Forms.ListBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.eventList = New System.Windows.Forms.ListBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("굴림", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label15.Location = New System.Drawing.Point(137, 468)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(248, 24)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "System Information"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("굴림", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label14.Location = New System.Drawing.Point(686, 468)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 24)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Statstics"
        '
        'txtMinHumid
        '
        Me.txtMinHumid.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtMinHumid.Location = New System.Drawing.Point(783, 623)
        Me.txtMinHumid.Name = "txtMinHumid"
        Me.txtMinHumid.Size = New System.Drawing.Size(189, 30)
        Me.txtMinHumid.TabIndex = 49
        Me.txtMinHumid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMaxHumid
        '
        Me.txtMaxHumid.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtMaxHumid.Location = New System.Drawing.Point(783, 588)
        Me.txtMaxHumid.Name = "txtMaxHumid"
        Me.txtMaxHumid.Size = New System.Drawing.Size(189, 30)
        Me.txtMaxHumid.TabIndex = 48
        Me.txtMaxHumid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("굴림", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label13.Location = New System.Drawing.Point(716, 626)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 20)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Min"
        '
        'txtMinTemp
        '
        Me.txtMinTemp.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtMinTemp.Location = New System.Drawing.Point(783, 553)
        Me.txtMinTemp.Name = "txtMinTemp"
        Me.txtMinTemp.Size = New System.Drawing.Size(189, 30)
        Me.txtMinTemp.TabIndex = 46
        Me.txtMinTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("굴림", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label12.Location = New System.Drawing.Point(716, 560)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 20)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Min"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("굴림", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label11.Location = New System.Drawing.Point(716, 597)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 20)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Max"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("굴림", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label10.Location = New System.Drawing.Point(716, 521)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 20)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Max"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("굴림", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label9.Location = New System.Drawing.Point(514, 597)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 20)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Humidity(%)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("굴림", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label8.Location = New System.Drawing.Point(514, 521)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 20)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Temperature(℃)"
        '
        'txtMaxTemp
        '
        Me.txtMaxTemp.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtMaxTemp.Location = New System.Drawing.Point(783, 518)
        Me.txtMaxTemp.Name = "txtMaxTemp"
        Me.txtMaxTemp.Size = New System.Drawing.Size(189, 30)
        Me.txtMaxTemp.TabIndex = 40
        Me.txtMaxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxDCUIP
        '
        Me.txtBoxDCUIP.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtBoxDCUIP.Location = New System.Drawing.Point(205, 587)
        Me.txtBoxDCUIP.Name = "txtBoxDCUIP"
        Me.txtBoxDCUIP.Size = New System.Drawing.Size(271, 30)
        Me.txtBoxDCUIP.TabIndex = 39
        Me.txtBoxDCUIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxHESIP
        '
        Me.txtBoxHESIP.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtBoxHESIP.Location = New System.Drawing.Point(205, 518)
        Me.txtBoxHESIP.Name = "txtBoxHESIP"
        Me.txtBoxHESIP.Size = New System.Drawing.Size(271, 30)
        Me.txtBoxHESIP.TabIndex = 38
        Me.txtBoxHESIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("굴림", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 590)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "DCU IP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("굴림", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 521)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 20)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "HES server IP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("굴림", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.Location = New System.Drawing.Point(663, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 24)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Meter Event"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("굴림", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.Location = New System.Drawing.Point(654, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 24)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Meter Control"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("굴림", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.Location = New System.Drawing.Point(186, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 24)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Meter Data"
        '
        'btnALL
        '
        Me.btnALL.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnALL.Location = New System.Drawing.Point(830, 152)
        Me.btnALL.Name = "btnALL"
        Me.btnALL.Size = New System.Drawing.Size(142, 100)
        Me.btnALL.TabIndex = 31
        Me.btnALL.Text = "ALL"
        Me.btnALL.UseVisualStyleBackColor = True
        '
        'btnRF
        '
        Me.btnRF.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnRF.Location = New System.Drawing.Point(674, 152)
        Me.btnRF.Name = "btnRF"
        Me.btnRF.Size = New System.Drawing.Size(142, 100)
        Me.btnRF.TabIndex = 30
        Me.btnRF.Text = "RF Meter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ID: 2)"
        Me.btnRF.UseVisualStyleBackColor = True
        '
        'btnPLC
        '
        Me.btnPLC.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnPLC.Location = New System.Drawing.Point(518, 152)
        Me.btnPLC.Name = "btnPLC"
        Me.btnPLC.Size = New System.Drawing.Size(142, 100)
        Me.btnPLC.TabIndex = 29
        Me.btnPLC.Text = "PLC Meter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ID:1)"
        Me.btnPLC.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("굴림", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(374, 681)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(577, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "All rights reserved by Myeongjin KIM (Smart Energy Consulting Team)"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(324, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 37)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Jin's HES(Head End System)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSVR
        '
        Me.btnSVR.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnSVR.Location = New System.Drawing.Point(805, 24)
        Me.btnSVR.Name = "btnSVR"
        Me.btnSVR.Size = New System.Drawing.Size(167, 37)
        Me.btnSVR.TabIndex = 52
        Me.btnSVR.Text = "Sever Start"
        Me.btnSVR.UseVisualStyleBackColor = True
        '
        'MtrData
        '
        Me.MtrData.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.MtrData.FormattingEnabled = True
        Me.MtrData.ItemHeight = 18
        Me.MtrData.Location = New System.Drawing.Point(35, 185)
        Me.MtrData.Name = "MtrData"
        Me.MtrData.Size = New System.Drawing.Size(441, 256)
        Me.MtrData.TabIndex = 55
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label16.Location = New System.Drawing.Point(45, 152)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 19)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "ID"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label17.Location = New System.Drawing.Point(74, 152)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 19)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Temp(℃)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label18.Location = New System.Drawing.Point(170, 152)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 19)
        Me.Label18.TabIndex = 58
        Me.Label18.Text = "Humid(%)"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label19.Location = New System.Drawing.Point(367, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 19)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "Time"
        '
        'eventList
        '
        Me.eventList.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.eventList.FormattingEnabled = True
        Me.eventList.ItemHeight = 20
        Me.eventList.Location = New System.Drawing.Point(518, 349)
        Me.eventList.Name = "eventList"
        Me.eventList.Size = New System.Drawing.Size(454, 84)
        Me.eventList.TabIndex = 60
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label20.Location = New System.Drawing.Point(266, 152)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 19)
        Me.Label20.TabIndex = 61
        Me.Label20.Text = "Event"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label21.Location = New System.Drawing.Point(636, 318)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 19)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "Event"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label22.Location = New System.Drawing.Point(845, 318)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 19)
        Me.Label22.TabIndex = 63
        Me.Label22.Text = "Time"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label23.Location = New System.Drawing.Point(532, 318)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(25, 19)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "ID"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnExit.Location = New System.Drawing.Point(37, 24)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 37)
        Me.btnExit.TabIndex = 65
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.eventList)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.MtrData)
        Me.Controls.Add(Me.btnSVR)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtMinHumid)
        Me.Controls.Add(Me.txtMaxHumid)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtMinTemp)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMaxTemp)
        Me.Controls.Add(Me.txtBoxDCUIP)
        Me.Controls.Add(Me.txtBoxHESIP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnALL)
        Me.Controls.Add(Me.btnRF)
        Me.Controls.Add(Me.btnPLC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Jin's HES Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtMinHumid As TextBox
    Friend WithEvents txtMaxHumid As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMinTemp As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMaxTemp As TextBox
    Friend WithEvents txtBoxDCUIP As TextBox
    Friend WithEvents txtBoxHESIP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnALL As Button
    Friend WithEvents btnRF As Button
    Friend WithEvents btnPLC As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSVR As Button
    Friend WithEvents MtrData As ListBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents eventList As ListBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents btnExit As Button
End Class
