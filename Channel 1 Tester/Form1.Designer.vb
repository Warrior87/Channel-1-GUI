<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.myTimer = New System.Windows.Forms.Timer(Me.components)
        Me.refresh_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.disconnect_button = New System.Windows.Forms.Button()
        Me.connect_button = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.batt1VoltageBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LPFVoltageBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CalModeBox = New System.Windows.Forms.TextBox()
        Me.CH1ChargeENButton = New System.Windows.Forms.RadioButton()
        Me.CH1ChargeDisableButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.PortName = "COM4"
        '
        'myTimer
        '
        Me.myTimer.Enabled = True
        '
        'refresh_button
        '
        Me.refresh_button.Location = New System.Drawing.Point(318, 28)
        Me.refresh_button.Name = "refresh_button"
        Me.refresh_button.Size = New System.Drawing.Size(75, 23)
        Me.refresh_button.TabIndex = 41
        Me.refresh_button.Text = "Refresh"
        Me.refresh_button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "COM Ports"
        '
        'disconnect_button
        '
        Me.disconnect_button.Location = New System.Drawing.Point(233, 28)
        Me.disconnect_button.Name = "disconnect_button"
        Me.disconnect_button.Size = New System.Drawing.Size(75, 23)
        Me.disconnect_button.TabIndex = 39
        Me.disconnect_button.Text = "Disconnect"
        Me.disconnect_button.UseVisualStyleBackColor = True
        '
        'connect_button
        '
        Me.connect_button.Location = New System.Drawing.Point(152, 28)
        Me.connect_button.Name = "connect_button"
        Me.connect_button.Size = New System.Drawing.Size(75, 23)
        Me.connect_button.TabIndex = 38
        Me.connect_button.Text = "Connect"
        Me.connect_button.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(662, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Data from Arduino"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(662, 274)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 164)
        Me.TextBox1.TabIndex = 42
        Me.TextBox1.WordWrap = False
        '
        'batt1VoltageBox
        '
        Me.batt1VoltageBox.Location = New System.Drawing.Point(12, 169)
        Me.batt1VoltageBox.Name = "batt1VoltageBox"
        Me.batt1VoltageBox.Size = New System.Drawing.Size(118, 20)
        Me.batt1VoltageBox.TabIndex = 44
        Me.batt1VoltageBox.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Battery 1 Voltage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(413, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "LPF Voltage Feedback"
        '
        'LPFVoltageBox
        '
        Me.LPFVoltageBox.Location = New System.Drawing.Point(416, 31)
        Me.LPFVoltageBox.Name = "LPFVoltageBox"
        Me.LPFVoltageBox.Size = New System.Drawing.Size(100, 20)
        Me.LPFVoltageBox.TabIndex = 46
        Me.LPFVoltageBox.WordWrap = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(550, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Cal Mode State"
        '
        'CalModeBox
        '
        Me.CalModeBox.Location = New System.Drawing.Point(553, 31)
        Me.CalModeBox.Name = "CalModeBox"
        Me.CalModeBox.Size = New System.Drawing.Size(100, 20)
        Me.CalModeBox.TabIndex = 48
        Me.CalModeBox.WordWrap = False
        '
        'CH1ChargeENButton
        '
        Me.CH1ChargeENButton.AutoSize = True
        Me.CH1ChargeENButton.Location = New System.Drawing.Point(6, 19)
        Me.CH1ChargeENButton.Name = "CH1ChargeENButton"
        Me.CH1ChargeENButton.Size = New System.Drawing.Size(59, 17)
        Me.CH1ChargeENButton.TabIndex = 50
        Me.CH1ChargeENButton.Text = "Charge"
        Me.CH1ChargeENButton.UseVisualStyleBackColor = True
        '
        'CH1ChargeDisableButton
        '
        Me.CH1ChargeDisableButton.AutoSize = True
        Me.CH1ChargeDisableButton.Checked = True
        Me.CH1ChargeDisableButton.Location = New System.Drawing.Point(6, 42)
        Me.CH1ChargeDisableButton.Name = "CH1ChargeDisableButton"
        Me.CH1ChargeDisableButton.Size = New System.Drawing.Size(73, 17)
        Me.CH1ChargeDisableButton.TabIndex = 51
        Me.CH1ChargeDisableButton.TabStop = True
        Me.CH1ChargeDisableButton.Text = "Discharge"
        Me.CH1ChargeDisableButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CH1ChargeENButton)
        Me.GroupBox1.Controls.Add(Me.CH1ChargeDisableButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 64)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CH 1 Charge Enable"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(136, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "V"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(522, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "V"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton1.TabIndex = 58
        Me.RadioButton1.Text = "2000 mA"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 47)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton2.TabIndex = 59
        Me.RadioButton2.Text = "1500 mA"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 70)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton3.TabIndex = 60
        Me.RadioButton3.Text = "1000 mA"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 93)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(61, 17)
        Me.RadioButton4.TabIndex = 61
        Me.RadioButton4.Text = "500 mA"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(138, 140)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CH 1 Discharge Current"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 116)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(61, 17)
        Me.RadioButton5.TabIndex = 62
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "100 mA"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CalModeBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LPFVoltageBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.batt1VoltageBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.refresh_button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.disconnect_button)
        Me.Controls.Add(Me.connect_button)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents myTimer As Timer
    Friend WithEvents refresh_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents disconnect_button As Button
    Friend WithEvents connect_button As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents batt1VoltageBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LPFVoltageBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CalModeBox As TextBox
    Friend WithEvents CH1ChargeENButton As RadioButton
    Friend WithEvents CH1ChargeDisableButton As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
End Class
