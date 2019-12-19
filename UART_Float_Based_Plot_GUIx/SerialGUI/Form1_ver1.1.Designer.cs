namespace SerialGUI
{
    partial class FormSerialPort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSerialPort));
            this.gBoxChooseSerialPort = new System.Windows.Forms.GroupBox();
            this.cBoxStopBit = new System.Windows.Forms.ComboBox();
            this.cBoxParity = new System.Windows.Forms.ComboBox();
            this.cBoxDataBit = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.lbStopBit = new System.Windows.Forms.Label();
            this.lbDataBit = new System.Windows.Forms.Label();
            this.lbParity = new System.Windows.Forms.Label();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.lbPortName = new System.Windows.Forms.Label();
            this.cBoxPortName = new System.Windows.Forms.ComboBox();
            this.sPort = new System.IO.Ports.SerialPort(this.components);
            this.gBoxCtrlSerialPort = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnDisCon = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tBoxDisplaySend = new System.Windows.Forms.TextBox();
            this.gBoxTransmitter = new System.Windows.Forms.GroupBox();
            this.gBoxReceiver = new System.Windows.Forms.GroupBox();
            this.tBoxDisplayGet = new System.Windows.Forms.TextBox();
            this.btnClearGet = new System.Windows.Forms.Button();
            this.zGrphPlotData = new ZedGraph.ZedGraphControl();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCompact = new System.Windows.Forms.Button();
            this.gBoxMotor = new System.Windows.Forms.GroupBox();
            this.btnMotorStop = new System.Windows.Forms.Button();
            this.btnMotorRun = new System.Windows.Forms.Button();
            this.gBoxWhatToMeasure = new System.Windows.Forms.GroupBox();
            this.rBtnPosition = new System.Windows.Forms.RadioButton();
            this.rBtnVelocity = new System.Windows.Forms.RadioButton();
            this.tBoxMeasure = new System.Windows.Forms.TextBox();
            this.tBoxSetPoint = new System.Windows.Forms.TextBox();
            this.tBoxTime = new System.Windows.Forms.TextBox();
            this.lbVelocity = new System.Windows.Forms.Label();
            this.lbSetpoint = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.gBoxPID = new System.Windows.Forms.GroupBox();
            this.lbKd = new System.Windows.Forms.Label();
            this.lbKi = new System.Windows.Forms.Label();
            this.tBoxKd = new System.Windows.Forms.TextBox();
            this.tBoxKi = new System.Windows.Forms.TextBox();
            this.tBoxKp = new System.Windows.Forms.TextBox();
            this.lbKp = new System.Windows.Forms.Label();
            this.gBoxGraphControl = new System.Windows.Forms.GroupBox();
            this.gBoxChooseSerialPort.SuspendLayout();
            this.gBoxCtrlSerialPort.SuspendLayout();
            this.gBoxTransmitter.SuspendLayout();
            this.gBoxReceiver.SuspendLayout();
            this.gBoxMotor.SuspendLayout();
            this.gBoxWhatToMeasure.SuspendLayout();
            this.gBoxPID.SuspendLayout();
            this.gBoxGraphControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxChooseSerialPort
            // 
            this.gBoxChooseSerialPort.Controls.Add(this.cBoxStopBit);
            this.gBoxChooseSerialPort.Controls.Add(this.cBoxParity);
            this.gBoxChooseSerialPort.Controls.Add(this.cBoxDataBit);
            this.gBoxChooseSerialPort.Controls.Add(this.cBoxBaudRate);
            this.gBoxChooseSerialPort.Controls.Add(this.lbStopBit);
            this.gBoxChooseSerialPort.Controls.Add(this.lbDataBit);
            this.gBoxChooseSerialPort.Controls.Add(this.lbParity);
            this.gBoxChooseSerialPort.Controls.Add(this.lbBaudRate);
            this.gBoxChooseSerialPort.Controls.Add(this.lbPortName);
            this.gBoxChooseSerialPort.Controls.Add(this.cBoxPortName);
            this.gBoxChooseSerialPort.Location = new System.Drawing.Point(13, 18);
            this.gBoxChooseSerialPort.Name = "gBoxChooseSerialPort";
            this.gBoxChooseSerialPort.Size = new System.Drawing.Size(177, 158);
            this.gBoxChooseSerialPort.TabIndex = 0;
            this.gBoxChooseSerialPort.TabStop = false;
            this.gBoxChooseSerialPort.Text = "Choose Serial Port";
            // 
            // cBoxStopBit
            // 
            this.cBoxStopBit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxStopBit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxStopBit.FormattingEnabled = true;
            this.cBoxStopBit.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBit.Location = new System.Drawing.Point(70, 127);
            this.cBoxStopBit.Name = "cBoxStopBit";
            this.cBoxStopBit.Size = new System.Drawing.Size(98, 21);
            this.cBoxStopBit.Sorted = true;
            this.cBoxStopBit.TabIndex = 9;
            this.cBoxStopBit.Text = "One";
            // 
            // cBoxParity
            // 
            this.cBoxParity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxParity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxParity.FormattingEnabled = true;
            this.cBoxParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cBoxParity.Location = new System.Drawing.Point(70, 100);
            this.cBoxParity.Name = "cBoxParity";
            this.cBoxParity.Size = new System.Drawing.Size(98, 21);
            this.cBoxParity.TabIndex = 8;
            this.cBoxParity.Text = "None";
            // 
            // cBoxDataBit
            // 
            this.cBoxDataBit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxDataBit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxDataBit.FormattingEnabled = true;
            this.cBoxDataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cBoxDataBit.Location = new System.Drawing.Point(70, 73);
            this.cBoxDataBit.Name = "cBoxDataBit";
            this.cBoxDataBit.Size = new System.Drawing.Size(98, 21);
            this.cBoxDataBit.TabIndex = 7;
            this.cBoxDataBit.Text = "8";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxBaudRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(70, 46);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(98, 21);
            this.cBoxBaudRate.TabIndex = 6;
            this.cBoxBaudRate.Text = "9600";
            // 
            // lbStopBit
            // 
            this.lbStopBit.AutoSize = true;
            this.lbStopBit.Location = new System.Drawing.Point(6, 130);
            this.lbStopBit.Name = "lbStopBit";
            this.lbStopBit.Size = new System.Drawing.Size(44, 13);
            this.lbStopBit.TabIndex = 5;
            this.lbStopBit.Text = "Stop Bit";
            // 
            // lbDataBit
            // 
            this.lbDataBit.AutoSize = true;
            this.lbDataBit.Location = new System.Drawing.Point(6, 76);
            this.lbDataBit.Name = "lbDataBit";
            this.lbDataBit.Size = new System.Drawing.Size(45, 13);
            this.lbDataBit.TabIndex = 5;
            this.lbDataBit.Text = "Data Bit";
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Location = new System.Drawing.Point(7, 103);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(33, 13);
            this.lbParity.TabIndex = 5;
            this.lbParity.Text = "Parity";
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Location = new System.Drawing.Point(6, 49);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(58, 13);
            this.lbBaudRate.TabIndex = 5;
            this.lbBaudRate.Text = "Baud Rate";
            // 
            // lbPortName
            // 
            this.lbPortName.AutoSize = true;
            this.lbPortName.Location = new System.Drawing.Point(7, 22);
            this.lbPortName.Name = "lbPortName";
            this.lbPortName.Size = new System.Drawing.Size(57, 13);
            this.lbPortName.TabIndex = 5;
            this.lbPortName.Text = "Port Name";
            // 
            // cBoxPortName
            // 
            this.cBoxPortName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxPortName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxPortName.FormattingEnabled = true;
            this.cBoxPortName.Location = new System.Drawing.Point(70, 19);
            this.cBoxPortName.Name = "cBoxPortName";
            this.cBoxPortName.Size = new System.Drawing.Size(98, 21);
            this.cBoxPortName.TabIndex = 0;
            // 
            // sPort
            // 
            this.sPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sPort_DataReceived);
            // 
            // gBoxCtrlSerialPort
            // 
            this.gBoxCtrlSerialPort.Controls.Add(this.progressBar1);
            this.gBoxCtrlSerialPort.Controls.Add(this.btnDisCon);
            this.gBoxCtrlSerialPort.Controls.Add(this.btnConnect);
            this.gBoxCtrlSerialPort.Location = new System.Drawing.Point(13, 182);
            this.gBoxCtrlSerialPort.Name = "gBoxCtrlSerialPort";
            this.gBoxCtrlSerialPort.Size = new System.Drawing.Size(177, 68);
            this.gBoxCtrlSerialPort.TabIndex = 1;
            this.gBoxCtrlSerialPort.TabStop = false;
            this.gBoxCtrlSerialPort.Text = "Serial Port Control";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(163, 10);
            this.progressBar1.TabIndex = 1;
            // 
            // btnDisCon
            // 
            this.btnDisCon.Enabled = false;
            this.btnDisCon.Location = new System.Drawing.Point(96, 35);
            this.btnDisCon.Name = "btnDisCon";
            this.btnDisCon.Size = new System.Drawing.Size(75, 23);
            this.btnDisCon.TabIndex = 0;
            this.btnDisCon.Text = "Disconnect";
            this.btnDisCon.UseVisualStyleBackColor = true;
            this.btnDisCon.Click += new System.EventHandler(this.btnDisCon_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 35);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(97, 19);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(74, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tBoxDisplaySend
            // 
            this.tBoxDisplaySend.Location = new System.Drawing.Point(6, 19);
            this.tBoxDisplaySend.Multiline = true;
            this.tBoxDisplaySend.Name = "tBoxDisplaySend";
            this.tBoxDisplaySend.Size = new System.Drawing.Size(85, 23);
            this.tBoxDisplaySend.TabIndex = 2;
            // 
            // gBoxTransmitter
            // 
            this.gBoxTransmitter.Controls.Add(this.tBoxDisplaySend);
            this.gBoxTransmitter.Controls.Add(this.btnSend);
            this.gBoxTransmitter.Location = new System.Drawing.Point(13, 256);
            this.gBoxTransmitter.Name = "gBoxTransmitter";
            this.gBoxTransmitter.Size = new System.Drawing.Size(177, 51);
            this.gBoxTransmitter.TabIndex = 3;
            this.gBoxTransmitter.TabStop = false;
            this.gBoxTransmitter.Text = "Transmitter";
            // 
            // gBoxReceiver
            // 
            this.gBoxReceiver.Controls.Add(this.tBoxDisplayGet);
            this.gBoxReceiver.Controls.Add(this.btnClearGet);
            this.gBoxReceiver.Location = new System.Drawing.Point(13, 313);
            this.gBoxReceiver.Name = "gBoxReceiver";
            this.gBoxReceiver.Size = new System.Drawing.Size(177, 139);
            this.gBoxReceiver.TabIndex = 3;
            this.gBoxReceiver.TabStop = false;
            this.gBoxReceiver.Text = "Receiver";
            // 
            // tBoxDisplayGet
            // 
            this.tBoxDisplayGet.Location = new System.Drawing.Point(6, 19);
            this.tBoxDisplayGet.Multiline = true;
            this.tBoxDisplayGet.Name = "tBoxDisplayGet";
            this.tBoxDisplayGet.ReadOnly = true;
            this.tBoxDisplayGet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBoxDisplayGet.Size = new System.Drawing.Size(165, 85);
            this.tBoxDisplayGet.TabIndex = 2;
            this.tBoxDisplayGet.TextChanged += new System.EventHandler(this.tBoxDisplayGet_TextChanged);
            // 
            // btnClearGet
            // 
            this.btnClearGet.Location = new System.Drawing.Point(6, 110);
            this.btnClearGet.Name = "btnClearGet";
            this.btnClearGet.Size = new System.Drawing.Size(75, 23);
            this.btnClearGet.TabIndex = 0;
            this.btnClearGet.Text = "Clear";
            this.btnClearGet.UseVisualStyleBackColor = true;
            this.btnClearGet.Click += new System.EventHandler(this.btnClearGet_Click);
            // 
            // zGrphPlotData
            // 
            this.zGrphPlotData.Location = new System.Drawing.Point(371, 18);
            this.zGrphPlotData.Name = "zGrphPlotData";
            this.zGrphPlotData.ScrollGrace = 0D;
            this.zGrphPlotData.ScrollMaxX = 0D;
            this.zGrphPlotData.ScrollMaxY = 0D;
            this.zGrphPlotData.ScrollMaxY2 = 0D;
            this.zGrphPlotData.ScrollMinX = 0D;
            this.zGrphPlotData.ScrollMinY = 0D;
            this.zGrphPlotData.ScrollMinY2 = 0D;
            this.zGrphPlotData.Size = new System.Drawing.Size(625, 434);
            this.zGrphPlotData.TabIndex = 5;
            this.zGrphPlotData.UseExtendedPrintDialog = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(6, 25);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(6, 54);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(87, 25);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClearGraph_Click);
            // 
            // btnCompact
            // 
            this.btnCompact.Location = new System.Drawing.Point(87, 54);
            this.btnCompact.Name = "btnCompact";
            this.btnCompact.Size = new System.Drawing.Size(75, 23);
            this.btnCompact.TabIndex = 7;
            this.btnCompact.Text = "Compact";
            this.btnCompact.UseVisualStyleBackColor = true;
            this.btnCompact.Click += new System.EventHandler(this.btnCompact_Click);
            // 
            // gBoxMotor
            // 
            this.gBoxMotor.Controls.Add(this.btnMotorStop);
            this.gBoxMotor.Controls.Add(this.btnMotorRun);
            this.gBoxMotor.Controls.Add(this.gBoxWhatToMeasure);
            this.gBoxMotor.Controls.Add(this.tBoxMeasure);
            this.gBoxMotor.Controls.Add(this.tBoxSetPoint);
            this.gBoxMotor.Controls.Add(this.tBoxTime);
            this.gBoxMotor.Controls.Add(this.lbVelocity);
            this.gBoxMotor.Controls.Add(this.lbSetpoint);
            this.gBoxMotor.Controls.Add(this.lbTime);
            this.gBoxMotor.Location = new System.Drawing.Point(196, 18);
            this.gBoxMotor.Name = "gBoxMotor";
            this.gBoxMotor.Size = new System.Drawing.Size(169, 223);
            this.gBoxMotor.TabIndex = 8;
            this.gBoxMotor.TabStop = false;
            this.gBoxMotor.Text = "Motor Control";
            // 
            // btnMotorStop
            // 
            this.btnMotorStop.Enabled = false;
            this.btnMotorStop.Location = new System.Drawing.Point(87, 188);
            this.btnMotorStop.Name = "btnMotorStop";
            this.btnMotorStop.Size = new System.Drawing.Size(75, 23);
            this.btnMotorStop.TabIndex = 8;
            this.btnMotorStop.Text = "Stop";
            this.btnMotorStop.UseVisualStyleBackColor = true;
            this.btnMotorStop.Click += new System.EventHandler(this.btnMotorStop_Click);
            // 
            // btnMotorRun
            // 
            this.btnMotorRun.Location = new System.Drawing.Point(6, 188);
            this.btnMotorRun.Name = "btnMotorRun";
            this.btnMotorRun.Size = new System.Drawing.Size(75, 23);
            this.btnMotorRun.TabIndex = 8;
            this.btnMotorRun.Text = "Run";
            this.btnMotorRun.UseVisualStyleBackColor = true;
            this.btnMotorRun.Click += new System.EventHandler(this.btnMotorRun_Click);
            // 
            // gBoxWhatToMeasure
            // 
            this.gBoxWhatToMeasure.Controls.Add(this.rBtnPosition);
            this.gBoxWhatToMeasure.Controls.Add(this.rBtnVelocity);
            this.gBoxWhatToMeasure.Location = new System.Drawing.Point(9, 20);
            this.gBoxWhatToMeasure.Name = "gBoxWhatToMeasure";
            this.gBoxWhatToMeasure.Size = new System.Drawing.Size(154, 69);
            this.gBoxWhatToMeasure.TabIndex = 7;
            this.gBoxWhatToMeasure.TabStop = false;
            this.gBoxWhatToMeasure.Text = "What to Measure?";
            // 
            // rBtnPosition
            // 
            this.rBtnPosition.AutoSize = true;
            this.rBtnPosition.Location = new System.Drawing.Point(7, 43);
            this.rBtnPosition.Name = "rBtnPosition";
            this.rBtnPosition.Size = new System.Drawing.Size(106, 17);
            this.rBtnPosition.TabIndex = 0;
            this.rBtnPosition.Text = "Position (Degree)";
            this.rBtnPosition.UseVisualStyleBackColor = true;
            this.rBtnPosition.CheckedChanged += new System.EventHandler(this.rBtnVP_CheckedChanged);
            // 
            // rBtnVelocity
            // 
            this.rBtnVelocity.AutoSize = true;
            this.rBtnVelocity.Checked = true;
            this.rBtnVelocity.Location = new System.Drawing.Point(7, 20);
            this.rBtnVelocity.Name = "rBtnVelocity";
            this.rBtnVelocity.Size = new System.Drawing.Size(95, 17);
            this.rBtnVelocity.TabIndex = 0;
            this.rBtnVelocity.TabStop = true;
            this.rBtnVelocity.Text = "Velocity (RPM)";
            this.rBtnVelocity.UseVisualStyleBackColor = true;
            this.rBtnVelocity.CheckedChanged += new System.EventHandler(this.rBtnVP_CheckedChanged);
            // 
            // tBoxMeasure
            // 
            this.tBoxMeasure.Location = new System.Drawing.Point(72, 154);
            this.tBoxMeasure.Name = "tBoxMeasure";
            this.tBoxMeasure.ReadOnly = true;
            this.tBoxMeasure.Size = new System.Drawing.Size(91, 20);
            this.tBoxMeasure.TabIndex = 6;
            // 
            // tBoxSetPoint
            // 
            this.tBoxSetPoint.Location = new System.Drawing.Point(72, 127);
            this.tBoxSetPoint.Name = "tBoxSetPoint";
            this.tBoxSetPoint.Size = new System.Drawing.Size(91, 20);
            this.tBoxSetPoint.TabIndex = 6;
            this.tBoxSetPoint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxSetPoint_KeyDown);
            // 
            // tBoxTime
            // 
            this.tBoxTime.Location = new System.Drawing.Point(72, 100);
            this.tBoxTime.Name = "tBoxTime";
            this.tBoxTime.ReadOnly = true;
            this.tBoxTime.Size = new System.Drawing.Size(91, 20);
            this.tBoxTime.TabIndex = 6;
            // 
            // lbVelocity
            // 
            this.lbVelocity.AutoSize = true;
            this.lbVelocity.Location = new System.Drawing.Point(6, 157);
            this.lbVelocity.Name = "lbVelocity";
            this.lbVelocity.Size = new System.Drawing.Size(44, 13);
            this.lbVelocity.TabIndex = 5;
            this.lbVelocity.Text = "Velocity";
            // 
            // lbSetpoint
            // 
            this.lbSetpoint.AutoSize = true;
            this.lbSetpoint.Location = new System.Drawing.Point(6, 130);
            this.lbSetpoint.Name = "lbSetpoint";
            this.lbSetpoint.Size = new System.Drawing.Size(50, 13);
            this.lbSetpoint.TabIndex = 5;
            this.lbSetpoint.Text = "Set Point";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(6, 103);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(30, 13);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "Time";
            // 
            // gBoxPID
            // 
            this.gBoxPID.Controls.Add(this.lbKd);
            this.gBoxPID.Controls.Add(this.lbKi);
            this.gBoxPID.Controls.Add(this.tBoxKd);
            this.gBoxPID.Controls.Add(this.tBoxKi);
            this.gBoxPID.Controls.Add(this.tBoxKp);
            this.gBoxPID.Controls.Add(this.lbKp);
            this.gBoxPID.Location = new System.Drawing.Point(196, 247);
            this.gBoxPID.Name = "gBoxPID";
            this.gBoxPID.Size = new System.Drawing.Size(169, 100);
            this.gBoxPID.TabIndex = 8;
            this.gBoxPID.TabStop = false;
            this.gBoxPID.Text = "PID Control";
            // 
            // lbKd
            // 
            this.lbKd.AutoSize = true;
            this.lbKd.Location = new System.Drawing.Point(6, 73);
            this.lbKd.Name = "lbKd";
            this.lbKd.Size = new System.Drawing.Size(15, 13);
            this.lbKd.TabIndex = 5;
            this.lbKd.Text = "D";
            // 
            // lbKi
            // 
            this.lbKi.AutoSize = true;
            this.lbKi.Location = new System.Drawing.Point(6, 47);
            this.lbKi.Name = "lbKi";
            this.lbKi.Size = new System.Drawing.Size(10, 13);
            this.lbKi.TabIndex = 5;
            this.lbKi.Text = "I";
            // 
            // tBoxKd
            // 
            this.tBoxKd.Location = new System.Drawing.Point(72, 72);
            this.tBoxKd.Name = "tBoxKd";
            this.tBoxKd.Size = new System.Drawing.Size(91, 20);
            this.tBoxKd.TabIndex = 6;
            this.tBoxKd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxKd_KeyDown);
            // 
            // tBoxKi
            // 
            this.tBoxKi.Location = new System.Drawing.Point(72, 46);
            this.tBoxKi.Name = "tBoxKi";
            this.tBoxKi.Size = new System.Drawing.Size(91, 20);
            this.tBoxKi.TabIndex = 6;
            this.tBoxKi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxKi_KeyDown);
            // 
            // tBoxKp
            // 
            this.tBoxKp.Location = new System.Drawing.Point(72, 20);
            this.tBoxKp.Name = "tBoxKp";
            this.tBoxKp.Size = new System.Drawing.Size(91, 20);
            this.tBoxKp.TabIndex = 6;
            this.tBoxKp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxKp_KeyDown);
            // 
            // lbKp
            // 
            this.lbKp.AutoSize = true;
            this.lbKp.Location = new System.Drawing.Point(6, 23);
            this.lbKp.Name = "lbKp";
            this.lbKp.Size = new System.Drawing.Size(14, 13);
            this.lbKp.TabIndex = 5;
            this.lbKp.Text = "P";
            // 
            // gBoxGraphControl
            // 
            this.gBoxGraphControl.Controls.Add(this.btnRun);
            this.gBoxGraphControl.Controls.Add(this.btnStop);
            this.gBoxGraphControl.Controls.Add(this.btnClear);
            this.gBoxGraphControl.Controls.Add(this.btnCompact);
            this.gBoxGraphControl.Location = new System.Drawing.Point(196, 353);
            this.gBoxGraphControl.Name = "gBoxGraphControl";
            this.gBoxGraphControl.Size = new System.Drawing.Size(169, 99);
            this.gBoxGraphControl.TabIndex = 9;
            this.gBoxGraphControl.TabStop = false;
            this.gBoxGraphControl.Text = "Graph Control";
            // 
            // FormSerialPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 466);
            this.Controls.Add(this.gBoxGraphControl);
            this.Controls.Add(this.gBoxPID);
            this.Controls.Add(this.gBoxMotor);
            this.Controls.Add(this.gBoxReceiver);
            this.Controls.Add(this.gBoxTransmitter);
            this.Controls.Add(this.zGrphPlotData);
            this.Controls.Add(this.gBoxCtrlSerialPort);
            this.Controls.Add(this.gBoxChooseSerialPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSerialPort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Graph";
            this.Load += new System.EventHandler(this.FormSerialPort_Load);
            this.gBoxChooseSerialPort.ResumeLayout(false);
            this.gBoxChooseSerialPort.PerformLayout();
            this.gBoxCtrlSerialPort.ResumeLayout(false);
            this.gBoxTransmitter.ResumeLayout(false);
            this.gBoxTransmitter.PerformLayout();
            this.gBoxReceiver.ResumeLayout(false);
            this.gBoxReceiver.PerformLayout();
            this.gBoxMotor.ResumeLayout(false);
            this.gBoxMotor.PerformLayout();
            this.gBoxWhatToMeasure.ResumeLayout(false);
            this.gBoxWhatToMeasure.PerformLayout();
            this.gBoxPID.ResumeLayout(false);
            this.gBoxPID.PerformLayout();
            this.gBoxGraphControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxChooseSerialPort;
        private System.Windows.Forms.Label lbStopBit;
        private System.Windows.Forms.Label lbDataBit;
        private System.Windows.Forms.Label lbParity;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.Label lbPortName;
        private System.Windows.Forms.ComboBox cBoxPortName;
        private System.Windows.Forms.ComboBox cBoxStopBit;
        private System.Windows.Forms.ComboBox cBoxParity;
        private System.Windows.Forms.ComboBox cBoxDataBit;
        private System.IO.Ports.SerialPort sPort;
        private System.Windows.Forms.GroupBox gBoxCtrlSerialPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDisCon;
        private System.Windows.Forms.TextBox tBoxDisplaySend;
        private System.Windows.Forms.GroupBox gBoxTransmitter;
        private System.Windows.Forms.GroupBox gBoxReceiver;
        private System.Windows.Forms.TextBox tBoxDisplayGet;
        private System.Windows.Forms.Button btnClearGet;
        private ZedGraph.ZedGraphControl zGrphPlotData;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCompact;
        private System.Windows.Forms.GroupBox gBoxMotor;
        private System.Windows.Forms.GroupBox gBoxWhatToMeasure;
        private System.Windows.Forms.RadioButton rBtnPosition;
        private System.Windows.Forms.RadioButton rBtnVelocity;
        private System.Windows.Forms.TextBox tBoxMeasure;
        private System.Windows.Forms.TextBox tBoxSetPoint;
        private System.Windows.Forms.TextBox tBoxTime;
        private System.Windows.Forms.Label lbVelocity;
        private System.Windows.Forms.Label lbSetpoint;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.GroupBox gBoxPID;
        private System.Windows.Forms.Label lbKd;
        private System.Windows.Forms.Label lbKi;
        private System.Windows.Forms.TextBox tBoxKd;
        private System.Windows.Forms.TextBox tBoxKi;
        private System.Windows.Forms.TextBox tBoxKp;
        private System.Windows.Forms.Label lbKp;
        private System.Windows.Forms.GroupBox gBoxGraphControl;
        private System.Windows.Forms.Button btnMotorStop;
        private System.Windows.Forms.Button btnMotorRun;
    }
}

