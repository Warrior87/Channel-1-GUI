Imports System
Imports System.IO
Imports System.Threading

Public Class Form1

    Dim dataString As String = "0"
    Dim prevDataString As String = "1"
    Dim ch1CurrentSetVal As Int32 = 500
    'Dim prev_ch1CurrentSetVal As String = "0"
    Dim CH1ChargeEN As Int32 = 0
    Dim ch1EnterFlag As Boolean = False
    'Dim stringArray(2) As String

    'when the program loads, find available serial ports and add them to the combobox
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each AvailableSerialPorts As String In SerialPort1.GetPortNames()
            ComboBox1.Items.Add(AvailableSerialPorts)
            ComboBox1.Text = AvailableSerialPorts
            SerialPort1.ReadTimeout = 10000
            TextBox1.ScrollBars = ScrollBars.Vertical
        Next

    End Sub

    'when the refresh button is pressed, refresh the com port list
    Private Sub refresh_button_Click(sender As Object, e As EventArgs) Handles refresh_button.Click

        ComboBox1.Items.Clear()

        For Each AvailableSerialPorts As String In SerialPort1.GetPortNames()
            ComboBox1.Items.Add(AvailableSerialPorts)
            ComboBox1.Text = AvailableSerialPorts
            SerialPort1.ReadTimeout = 10000
            TextBox1.ScrollBars = ScrollBars.Vertical
        Next

    End Sub

    '-----this is for serial communication from arduino------
    Delegate Sub myMethodDelegate(ByVal [text] As String)
    Dim myD1 As New myMethodDelegate(AddressOf myShowStringMethod)

    ' This delegate enables asynchronous calls for setting
    ' the text property on a TextBox control.
    Delegate Sub StringArgReturningVoidDelegate([text] As String)

    Sub myShowStringMethod(ByVal myString As String)
        TextBox1.AppendText(myString)
    End Sub

    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim str As String = SerialPort1.ReadExisting

        Dim stringArray() As String = str.Split(New [Char]() {":"c})

        'string format
        'bat1Voltage:LPFVoltageFeeback:CalModeSet:ch1CurrentSetVal
        'string array index starts at 0

        Me.Setbatt1VoltageBox(stringArray(0))
        Me.SetLPFVoltageBox(stringArray(1))
        Me.SetCalModeBox(stringArray(2))
        'If ch1EnterFlag = True Then
        '    ch1EnterFlag = False
        '    Me.SetLPFVoltageSetBox(stringArray(3))
        'End If
        'If Not (prev_ch1CurrentSetVal.Equals(stringArray(3))) Then
        '    prev_ch1CurrentSetVal = stringArray(3)
        '    Me.SetLPFVoltageSetBox(stringArray(3))
        'End If
        Invoke(myD1, str)
    End Sub

    Private Sub Setbatt1VoltageBox(ByVal [text] As String)
        If Me.batt1VoltageBox.InvokeRequired Then
            Dim d As New StringArgReturningVoidDelegate(AddressOf Setbatt1VoltageBox)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.batt1VoltageBox.Text = [text]
        End If
    End Sub

    Private Sub SetLPFVoltageBox(ByVal [text] As String)
        If Me.LPFVoltageBox.InvokeRequired Then
            Dim d As New StringArgReturningVoidDelegate(AddressOf SetLPFVoltageBox)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.LPFVoltageBox.Text = [text]
        End If
    End Sub

    Private Sub SetCalModeBox(ByVal [text] As String)
        If Me.CalModeBox.InvokeRequired Then
            Dim d As New StringArgReturningVoidDelegate(AddressOf SetCalModeBox)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.CalModeBox.Text = [text]
        End If
    End Sub

    'when the connect button is pressed, a serial connection is opened
    Private Sub connect_button_Click(sender As Object, e As EventArgs) Handles connect_button.Click
        SerialPort1.BaudRate = "115200"
        SerialPort1.PortName = ComboBox1.SelectedItem

        If SerialPort1.IsOpen = False Then
            SerialPort1.Open()
        End If
        myTimer.Start()
    End Sub

    'this closes the serial connection
    Private Sub disconnect_button_Click(sender As Object, e As EventArgs) Handles disconnect_button.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.Close()
        End If
    End Sub

    Private Sub myTimer_Tick(sender As Object, e As EventArgs) Handles myTimer.Tick
        myTimer.Stop()
        dataString = Convert.ToString(ch1CurrentSetVal) + ":" + Convert.ToString(CH1ChargeEN)
        If Not dataString.Equals(prevDataString) Then
            sendData()
        End If
    End Sub

    Private Sub sendData()
        If SerialPort1.IsOpen Then
            SerialPort1.Write(dataString)
            prevDataString = dataString
        End If
    End Sub

    Private Sub CH1ChargeENButton_CheckedChanged(sender As Object, e As EventArgs) Handles CH1ChargeENButton.CheckedChanged
        If CH1ChargeENButton.Checked Then
            CH1ChargeEN = 1
        End If
        myTimer.Start()
    End Sub

    Private Sub CH1ChargeDisableButton_CheckedChanged(sender As Object, e As EventArgs) Handles CH1ChargeDisableButton.CheckedChanged
        If CH1ChargeDisableButton.Checked Then
            CH1ChargeEN = 0
        End If
        myTimer.Start()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            ch1CurrentSetVal = 2000
        End If
        myTimer.Start()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            ch1CurrentSetVal = 1500
        End If
        myTimer.Start()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            ch1CurrentSetVal = 1000
        End If
        myTimer.Start()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            ch1CurrentSetVal = 500
        End If
        myTimer.Start()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton4.Checked Then
            ch1CurrentSetVal = 100
        End If
        myTimer.Start()
    End Sub
End Class
