Imports System.Net
Imports System.Net.Sockets

Public Class Form1

    Dim plcMTRstatus As Integer     '0 is On, 1 is Off
    Dim rfMTRstatus As Integer
    Dim minTemp, maxTemp, minHumid, maxHumid, tmpTemp, tmpHumid As String
    Dim svrStop, tx2DCU, rcvData, txPLC, txRF As String

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()      'Program exit
    End Sub

    Dim ctrlBtnClick As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strHostName As String
        Dim strIPAddress As String

        txPLC = "0"         'Intitiate PLC and RF meter with On command('0')
        txRF = "0"

        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()

        txtBoxHESIP.Text = strIPAddress     'Get HES server's IP address

    End Sub

    Private Sub btnPLC_Click(sender As Object, e As EventArgs) Handles btnPLC.Click

        ctrlBtnClick = True

        If plcMTRstatus = 1 Then
            With btnPLC
                .Text = "PLC Meter On"
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With
            plcMTRstatus = 0
            txPLC = "0"         'PLC meter(Device ID: 1) On(0)

        ElseIf plcMTRstatus = 0 Then
            With btnPLC
                .Text = "PLC Meter Off"
                .BackColor = Color.Gray
                .ForeColor = Color.White
            End With
            plcMTRstatus = 1
            txPLC = "1"         'PLC meter(Device ID: 1) Off(1)

        End If

        allMTRCtrl()

    End Sub

    Private Sub btnRF_Click(sender As Object, e As EventArgs) Handles btnRF.Click
        ctrlBtnClick = True

        If rfMTRstatus = 1 Then
            With btnRF
                .Text = "RF Meter On"
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With
            rfMTRstatus = 0
            txRF = "0"         'RF meter(Device ID: 2) On(0)

        ElseIf rfMTRstatus = 0 Then
            With btnRF
                .Text = "RF Meter Off"
                .BackColor = Color.Gray
                .ForeColor = Color.White
            End With
            rfMTRstatus = 1
            txRF = "1"         'RF (Device ID: 2) Off(0)

        End If

        allMTRCtrl()

    End Sub

    Private Sub btnALL_Click(sender As Object, e As EventArgs) Handles btnALL.Click
        ctrlBtnClick = True

        If rfMTRstatus = 1 And plcMTRstatus = 1 Then
            With btnRF
                .Text = "RF Meter On"
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With

            With btnPLC
                .Text = "PLC Meter On"
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With

            With btnALL
                .Text = "ALL On"
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With
            plcMTRstatus = 0
            rfMTRstatus = 0
            tx2DCU = "00" 'ALL meter On(0)

        ElseIf rfMTRstatus = 0 And plcMTRstatus = 0 Then
            With btnRF
                .Text = "RF Meter Off"
                .BackColor = Color.Gray
                .ForeColor = Color.White
            End With

            With btnPLC
                .Text = "PLC Meter Off"
                .BackColor = Color.Gray
                .ForeColor = Color.White
            End With

            With btnALL
                .Text = "ALL Off"
                .BackColor = Color.Gray
                .ForeColor = Color.White
            End With
            plcMTRstatus = 1
            rfMTRstatus = 1
            tx2DCU = "11" 'ALL meter Off(1)
        Else
            With btnRF
                .Text = "RF Meter On"
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With

            With btnPLC
                .Text = "PLC Meter On"
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With

            With btnALL
                .Text = "ALL On"
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With
            plcMTRstatus = 0
            rfMTRstatus = 0
            tx2DCU = "00" 'ALL meter(3) On(0)


        End If
    End Sub

    Private Sub MtrData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MtrData.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSVR.Click

        With btnSVR
            .Text = "Sever ON"
            .BackColor = Color.Green
            .ForeColor = Color.White
        End With

        svrOn()

    End Sub

    Private Sub svrOn()

        Dim server As TcpListener       'TCP Listener declare

        server = Nothing

        ' Tcp 통신에 사용할 포트와 서버IP 주소 변수 선언
        Dim port As Int32 = 23
        'parse 메서드는 string을 int32로 변환

        Dim localAddr As IPAddress = IPAddress.Parse("192.168.0.100")  'SSID: wifitest
        'Dim localAddr As IPAddress = IPAddress.Parse("192.168.0.2")  '사무실 유선IP
        'Dim localAddr As IPAddress = IPAddress.Parse("192.168.0.20") '우리집 IP
        '위의 IP와 포트를 입력해준다.

        server = New TcpListener(localAddr, port)

        ' 서버 시작====================================================
        server.Start()

        Dim bytes(1024) As Byte
        Dim client As TcpClient = server.AcceptTcpClient()
        Dim rcvData As String = Nothing

        ' 스트림 오브젝트를 선언하고 클라이언트로 스트림을 얻는다.
        Dim stream As NetworkStream = client.GetStream()

        rcvData = Nothing

        'i는 버퍼 bytes의 길이를 저장할 변수
        Dim i As Int32

        'socket 접속한 remote Client의 IP address 표기-----------------------------
        Dim IPaddrOfClient As String = client.Client.RemoteEndPoint.ToString.Remove(client.Client.RemoteEndPoint.ToString.IndexOf(":"))

        txtBoxDCUIP.Text = IPaddrOfClient

        '스트림의 값을 바이트 단위로 읽고 버퍼의 길이를 반환함
        'read(읽어올 데이터가 저장된 메모리주소,시작 offset,데이터길이)
        i = stream.Read(bytes, 0, bytes.Length)

        ' 클라이언트로 부터 모든 데이터를 받기 위한 루프문
        While True          '서버 수신 모드

            ' 바이트를 아스키코드로 변환하고 합쳐 string 형태로 저장
            'rcvData는 #123450, #는 헤더, 1은 미터기 아이디, 23은 온도, 45는 습도, 0은 이벤트

            While i = 6 Or i = 7       'PLC 미터는 Event가 없어서 6 byte, RF는 이벤트가 있어서 7

                'DCU를 거처 미터기 값 수신
                rcvData = System.Text.Encoding.ASCII.GetString(bytes, 0, i)


                MtrData.Items.Insert(0, "  " + rcvData.Substring(0, 1) + "        " +
                rcvData.Substring(1, 2) + "           " +
                rcvData.Substring(3, 2) + "            " +
                rcvData.Substring(5, 1) + "    " +
                DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + vbLf)

                If rcvData.Substring(5, 1) = 1 Then
                    eventList.Items.Insert(0, "  " + rcvData.Substring(0, 1) + "         " +
                   "Case Open" + "         " + DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + vbLf)
                End If

                'Statistics
                'minTemp, maxTemp ----------------------------------------------
                maxTemp = Convert.ToInt32(rcvData.Substring(1, 2))
                minTemp = maxTemp

                If minTemp >= Convert.ToInt32(rcvData.Substring(1, 2)) Then
                    minTemp = Convert.ToInt32(rcvData.Substring(1, 2))
                    txtMinTemp.Clear()
                    txtMinTemp.AppendText(minTemp)
                End If
                If maxTemp <= Convert.ToInt32(rcvData.Substring(1, 2)) Then
                    maxTemp = Convert.ToInt32(rcvData.Substring(1, 2))
                    txtMaxTemp.Clear()
                    txtMaxTemp.AppendText(maxTemp)
                End If

                'minHumid, maxHumid ----------------------------------------------
                maxHumid = Convert.ToInt32(rcvData.Substring(3, 2))
                minHumid = maxHumid

                If minHumid >= Convert.ToInt32(rcvData.Substring(3, 2)) Then
                    minHumid = Convert.ToInt32(rcvData.Substring(3, 2))
                    txtMinHumid.Clear()
                    txtMinHumid.AppendText(minHumid)
                End If
                If maxHumid <= Convert.ToInt32(rcvData.Substring(3, 2)) Then
                    maxHumid = Convert.ToInt32(rcvData.Substring(3, 2))
                    txtMaxHumid.Clear()
                    txtMaxHumid.AppendText(maxHumid)
                End If

                '================================================================
                Application.DoEvents()          '무한 while에서 빠져나오기

                If ctrlBtnClick = True Then
                    ' String을 Byte로 변환해서 저장한 msg byte변수를 다시 Client에 전송함
                    'tx2DCU에 Header(!) 붙여서 보냄
                    Dim msg1 As Byte() = System.Text.Encoding.ASCII.GetBytes("!" & tx2DCU)
                    stream.Write(msg1, 0, msg1.Length)

                End If

                'HES가 미터기에게 cmd 전송 후 다시 미터값을 읽는 Loop
                i = stream.Read(bytes, 0, bytes.Length)

            End While

            '
            If i <> 6 Or i <> 7 Then
                ' 클라이언트 통신연결을 끊음.

                Try
                Catch e As SocketException
                    client.Close()
                Finally
                    'Finally 문은 throw 여부에 상관없이 항상 실행된다. 서버정지.
                    server.Stop()
                    'Exit Sub
                End Try
                'Exit Sub

                Exit While
                'GoTo svrRestart
            End If
            'MsgBox("svr off")
            'server.Stop()

        End While

        '규격에 맞지 않는 data가 들어오면 client connection을 close하고, 서버도 close
        '다시 Server start 버튼(Button1)을 클릭해서 서버 재가동
        Call Button1_Click(Nothing, Nothing)

    End Sub

    Sub allMTRCtrl()
        If rfMTRstatus = 1 And plcMTRstatus = 1 Then
            With btnRF
                .Text = "RF Meter Off"
                .BackColor = Color.Gray
                .ForeColor = Color.White
            End With

            With btnPLC
                .Text = "PLC Meter Off"
                .BackColor = Color.Gray
                .ForeColor = Color.White
            End With

            With btnALL
                .Text = "ALL Off"
                .BackColor = Color.Gray
                .ForeColor = Color.White
            End With
            plcMTRstatus = 1
            rfMTRstatus = 1
            tx2DCU = "11" 'ALL meter(3) Off(0)

        ElseIf rfMTRstatus = 0 And plcMTRstatus = 0 Then
            With btnRF
                .Text = "RF Meter On"
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With

            With btnPLC
                .Text = "PLC Meter On"
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With

            With btnALL
                .Text = "ALL On"
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With

            plcMTRstatus = 0
            rfMTRstatus = 0
            tx2DCU = "00" 'ALL meter(3) On(0)
        ElseIf rfMTRstatus = 0 And plcMTRstatus = 1 Then
            With btnRF
                .Text = "RF Meter On"
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With

            With btnPLC
                .Text = "PLC Meter Off"
                .BackColor = Color.Gray
                .ForeColor = Color.White
            End With

            With btnALL
                .Text = "A Device Off"
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With

            plcMTRstatus = 1
            rfMTRstatus = 0
            tx2DCU = "10" 'ALL meter(3) On(0)

        ElseIf rfMTRstatus = 1 And plcMTRstatus = 0 Then
            With btnRF
                .Text = "RF Meter Off"
                .BackColor = Color.Gray
                .ForeColor = Color.White
            End With

            With btnPLC
                .Text = "PLC Meter On"
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With

            With btnALL
                .Text = "A Device Off"
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With

            plcMTRstatus = 0
            rfMTRstatus = 1
            tx2DCU = "01" 'ALL meter(3) On(0)
        Else
            With btnALL
                .Text = "ALL"
                .BackColor = Color.Yellow
                .ForeColor = Color.Black
            End With

        End If
    End Sub

End Class


