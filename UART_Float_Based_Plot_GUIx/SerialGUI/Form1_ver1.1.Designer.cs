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
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnCompact = new System.Windows.Forms.Button();
            this.gBoxMotor = new System.Windows.Forms.GroupBox();
            this.cBoxLog = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMotorStop = new System.Windows.Forms.Button();
            this.btnMotorRun = new System.Windows.Forms.Button();
            this.gBoxWhatToMeasure = new System.Windows.Forms.GroupBox();
            this.rBtnPosition = new System.Windows.Forms.RadioButton();
            this.rBtnVelocity = new System.Windows.Forms.RadioButton();
            this.tBoxMeasure = new System.Windows.Forms.TextBox();
            this.tBoxTimeStep = new System.Windows.Forms.TextBox();
            this.tbCalib = new System.Windows.Forms.TextBox();
            this.tBoxSetPoint = new System.Windows.Forms.TextBox();
            this.tBoxTime = new System.Windows.Forms.TextBox();
            this.lbCalib = new System.Windows.Forms.Label();
            this.lbTimeStep = new System.Windows.Forms.Label();
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
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.gBoxPara = new System.Windows.Forms.GroupBox();
            this.lbK3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbK1 = new System.Windows.Forms.Label();
            this.tBoxK3 = new System.Windows.Forms.TextBox();
            this.tBoxK2 = new System.Windows.Forms.TextBox();
            this.tBoxK1 = new System.Windows.Forms.TextBox();
            this.tBoxK0 = new System.Windows.Forms.TextBox();
            this.lbK0 = new System.Windows.Forms.Label();
            this.zGraphParameters = new ZedGraph.ZedGraphControl();
            this.gBoxChooseSerialPort.SuspendLayout();
            this.gBoxCtrlSerialPort.SuspendLayout();
            this.gBoxTransmitter.SuspendLayout();
            this.gBoxReceiver.SuspendLayout();
            this.gBoxMotor.SuspendLayout();
            this.gBoxWhatToMeasure.SuspendLayout();
            this.gBoxPID.SuspendLayout();
            this.gBoxPara.SuspendLayout();
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
            this.cBoxStopBit.Text = "Two";
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
            this.cBoxParity.Text = "Odd";
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
            this.cBoxBaudRate.Text = "115200";
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
            this.gBoxReceiver.Size = new System.Drawing.Size(177, 326);
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
            this.tBoxDisplayGet.Size = new System.Drawing.Size(165, 272);
            this.tBoxDisplayGet.TabIndex = 2;
            this.tBoxDisplayGet.TextChanged += new System.EventHandler(this.tBoxDisplayGet_TextChanged);
            // 
            // btnClearGet
            // 
            this.btnClearGet.Location = new System.Drawing.Point(6, 297);
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
            this.zGrphPlotData.Size = new System.Drawing.Size(591, 650);
            this.zGrphPlotData.TabIndex = 5;
            this.zGrphPlotData.UseExtendedPrintDialog = true;
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(6, 293);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(75, 23);
            this.btnGraph.TabIndex = 6;
            this.btnGraph.Text = "NotGraph";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnCompact
            // 
            this.btnCompact.Location = new System.Drawing.Point(88, 293);
            this.btnCompact.Name = "btnCompact";
            this.btnCompact.Size = new System.Drawing.Size(75, 23);
            this.btnCompact.TabIndex = 7;
            this.btnCompact.Text = "Compact";
            this.btnCompact.UseVisualStyleBackColor = true;
            this.btnCompact.Click += new System.EventHandler(this.btnCompact_Click);
            // 
            // gBoxMotor
            // 
            this.gBoxMotor.Controls.Add(this.cBoxLog);
            this.gBoxMotor.Controls.Add(this.btnGraph);
            this.gBoxMotor.Controls.Add(this.btnSave);
            this.gBoxMotor.Controls.Add(this.btnMotorStop);
            this.gBoxMotor.Controls.Add(this.btnMotorRun);
            this.gBoxMotor.Controls.Add(this.gBoxWhatToMeasure);
            this.gBoxMotor.Controls.Add(this.btnCompact);
            this.gBoxMotor.Controls.Add(this.tBoxMeasure);
            this.gBoxMotor.Controls.Add(this.tBoxTimeStep);
            this.gBoxMotor.Controls.Add(this.tbCalib);
            this.gBoxMotor.Controls.Add(this.tBoxSetPoint);
            this.gBoxMotor.Controls.Add(this.tBoxTime);
            this.gBoxMotor.Controls.Add(this.lbCalib);
            this.gBoxMotor.Controls.Add(this.lbTimeStep);
            this.gBoxMotor.Controls.Add(this.lbVelocity);
            this.gBoxMotor.Controls.Add(this.lbSetpoint);
            this.gBoxMotor.Controls.Add(this.lbTime);
            this.gBoxMotor.Location = new System.Drawing.Point(196, 18);
            this.gBoxMotor.Name = "gBoxMotor";
            this.gBoxMotor.Size = new System.Drawing.Size(169, 322);
            this.gBoxMotor.TabIndex = 8;
            this.gBoxMotor.TabStop = false;
            this.gBoxMotor.Text = "Motor Control";
            // 
            // cBoxLog
            // 
            this.cBoxLog.AutoSize = true;
            this.cBoxLog.Location = new System.Drawing.Point(8, 239);
            this.cBoxLog.Name = "cBoxLog";
            this.cBoxLog.Size = new System.Drawing.Size(75, 17);
            this.cBoxLog.TabIndex = 9;
            this.cBoxLog.Text = "Log to File";
            this.cBoxLog.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMotorStop
            // 
            this.btnMotorStop.Location = new System.Drawing.Point(88, 264);
            this.btnMotorStop.Name = "btnMotorStop";
            this.btnMotorStop.Size = new System.Drawing.Size(75, 23);
            this.btnMotorStop.TabIndex = 8;
            this.btnMotorStop.Text = "Stop";
            this.btnMotorStop.UseVisualStyleBackColor = true;
            this.btnMotorStop.Click += new System.EventHandler(this.btnMotorStop_Click);
            // 
            // btnMotorRun
            // 
            this.btnMotorRun.Location = new System.Drawing.Point(6, 264);
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
            this.tBoxMeasure.Location = new System.Drawing.Point(87, 199);
            this.tBoxMeasure.Name = "tBoxMeasure";
            this.tBoxMeasure.ReadOnly = true;
            this.tBoxMeasure.Size = new System.Drawing.Size(76, 20);
            this.tBoxMeasure.TabIndex = 6;
            // 
            // tBoxTimeStep
            // 
            this.tBoxTimeStep.Location = new System.Drawing.Point(87, 121);
            this.tBoxTimeStep.Name = "tBoxTimeStep";
            this.tBoxTimeStep.Size = new System.Drawing.Size(76, 20);
            this.tBoxTimeStep.TabIndex = 6;
            this.tBoxTimeStep.Text = "0.02";
            this.tBoxTimeStep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxTimeStep_KeyDown);
            // 
            // tbCalib
            // 
            this.tbCalib.Location = new System.Drawing.Point(87, 95);
            this.tbCalib.Name = "tbCalib";
            this.tbCalib.Size = new System.Drawing.Size(76, 20);
            this.tbCalib.TabIndex = 6;
            this.tbCalib.Text = "4.8";
            this.tbCalib.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxCalib_KeyDown);
            // 
            // tBoxSetPoint
            // 
            this.tBoxSetPoint.Location = new System.Drawing.Point(87, 147);
            this.tBoxSetPoint.Name = "tBoxSetPoint";
            this.tBoxSetPoint.Size = new System.Drawing.Size(76, 20);
            this.tBoxSetPoint.TabIndex = 6;
            this.tBoxSetPoint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxSetPoint_KeyDown);
            // 
            // tBoxTime
            // 
            this.tBoxTime.Location = new System.Drawing.Point(87, 173);
            this.tBoxTime.Name = "tBoxTime";
            this.tBoxTime.ReadOnly = true;
            this.tBoxTime.Size = new System.Drawing.Size(76, 20);
            this.tBoxTime.TabIndex = 6;
            // 
            // lbCalib
            // 
            this.lbCalib.AutoSize = true;
            this.lbCalib.Location = new System.Drawing.Point(6, 98);
            this.lbCalib.Name = "lbCalib";
            this.lbCalib.Size = new System.Drawing.Size(83, 13);
            this.lbCalib.TabIndex = 5;
            this.lbCalib.Text = "Calib angle coef";
            // 
            // lbTimeStep
            // 
            this.lbTimeStep.AutoSize = true;
            this.lbTimeStep.Location = new System.Drawing.Point(6, 124);
            this.lbTimeStep.Name = "lbTimeStep";
            this.lbTimeStep.Size = new System.Drawing.Size(69, 13);
            this.lbTimeStep.TabIndex = 5;
            this.lbTimeStep.Text = "Time Step (s)";
            // 
            // lbVelocity
            // 
            this.lbVelocity.AutoSize = true;
            this.lbVelocity.Location = new System.Drawing.Point(7, 202);
            this.lbVelocity.Name = "lbVelocity";
            this.lbVelocity.Size = new System.Drawing.Size(44, 13);
            this.lbVelocity.TabIndex = 5;
            this.lbVelocity.Text = "Velocity";
            // 
            // lbSetpoint
            // 
            this.lbSetpoint.AutoSize = true;
            this.lbSetpoint.Location = new System.Drawing.Point(6, 150);
            this.lbSetpoint.Name = "lbSetpoint";
            this.lbSetpoint.Size = new System.Drawing.Size(50, 13);
            this.lbSetpoint.TabIndex = 5;
            this.lbSetpoint.Text = "Set Point";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(6, 176);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(44, 13);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "Time (s)";
            // 
            // gBoxPID
            // 
            this.gBoxPID.Controls.Add(this.lbKd);
            this.gBoxPID.Controls.Add(this.lbKi);
            this.gBoxPID.Controls.Add(this.tBoxKd);
            this.gBoxPID.Controls.Add(this.tBoxKi);
            this.gBoxPID.Controls.Add(this.tBoxKp);
            this.gBoxPID.Controls.Add(this.lbKp);
            this.gBoxPID.Location = new System.Drawing.Point(196, 346);
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
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(19, 645);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 9;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(109, 645);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // gBoxPara
            // 
            this.gBoxPara.Controls.Add(this.lbK3);
            this.gBoxPara.Controls.Add(this.label1);
            this.gBoxPara.Controls.Add(this.lbK1);
            this.gBoxPara.Controls.Add(this.tBoxK3);
            this.gBoxPara.Controls.Add(this.tBoxK2);
            this.gBoxPara.Controls.Add(this.tBoxK1);
            this.gBoxPara.Controls.Add(this.tBoxK0);
            this.gBoxPara.Controls.Add(this.lbK0);
            this.gBoxPara.Location = new System.Drawing.Point(196, 452);
            this.gBoxPara.Name = "gBoxPara";
            this.gBoxPara.Size = new System.Drawing.Size(169, 125);
            this.gBoxPara.TabIndex = 8;
            this.gBoxPara.TabStop = false;
            this.gBoxPara.Text = "Parameters";
            // 
            // lbK3
            // 
            this.lbK3.AutoSize = true;
            this.lbK3.Location = new System.Drawing.Point(6, 99);
            this.lbK3.Name = "lbK3";
            this.lbK3.Size = new System.Drawing.Size(19, 13);
            this.lbK3.TabIndex = 5;
            this.lbK3.Text = "k3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "k2";
            // 
            // lbK1
            // 
            this.lbK1.AutoSize = true;
            this.lbK1.Location = new System.Drawing.Point(6, 47);
            this.lbK1.Name = "lbK1";
            this.lbK1.Size = new System.Drawing.Size(28, 13);
            this.lbK1.TabIndex = 5;
            this.lbK1.Text = "beta";
            // 
            // tBoxK3
            // 
            this.tBoxK3.Location = new System.Drawing.Point(72, 98);
            this.tBoxK3.Name = "tBoxK3";
            this.tBoxK3.Size = new System.Drawing.Size(91, 20);
            this.tBoxK3.TabIndex = 6;
            this.tBoxK3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxK3_KeyDown);
            // 
            // tBoxK2
            // 
            this.tBoxK2.Location = new System.Drawing.Point(72, 72);
            this.tBoxK2.Name = "tBoxK2";
            this.tBoxK2.Size = new System.Drawing.Size(91, 20);
            this.tBoxK2.TabIndex = 6;
            this.tBoxK2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxK2_KeyDown);
            // 
            // tBoxK1
            // 
            this.tBoxK1.Location = new System.Drawing.Point(72, 46);
            this.tBoxK1.Name = "tBoxK1";
            this.tBoxK1.Size = new System.Drawing.Size(91, 20);
            this.tBoxK1.TabIndex = 6;
            this.tBoxK1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxK1_KeyDown);
            // 
            // tBoxK0
            // 
            this.tBoxK0.Location = new System.Drawing.Point(72, 20);
            this.tBoxK0.Name = "tBoxK0";
            this.tBoxK0.Size = new System.Drawing.Size(91, 20);
            this.tBoxK0.TabIndex = 6;
            this.tBoxK0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxK0_KeyDown);
            // 
            // lbK0
            // 
            this.lbK0.AutoSize = true;
            this.lbK0.Location = new System.Drawing.Point(6, 23);
            this.lbK0.Name = "lbK0";
            this.lbK0.Size = new System.Drawing.Size(33, 13);
            this.lbK0.TabIndex = 5;
            this.lbK0.Text = "alpha";
            // 
            // zGraphParameters
            // 
            this.zGraphParameters.Location = new System.Drawing.Point(371, 346);
            this.zGraphParameters.Name = "zGraphParameters";
            this.zGraphParameters.ScrollGrace = 0D;
            this.zGraphParameters.ScrollMaxX = 0D;
            this.zGraphParameters.ScrollMaxY = 0D;
            this.zGraphParameters.ScrollMaxY2 = 0D;
            this.zGraphParameters.ScrollMinX = 0D;
            this.zGraphParameters.ScrollMinY = 0D;
            this.zGraphParameters.ScrollMinY2 = 0D;
            this.zGraphParameters.Size = new System.Drawing.Size(591, 322);
            this.zGraphParameters.TabIndex = 5;
            this.zGraphParameters.UseExtendedPrintDialog = true;
            this.zGraphParameters.Visible = false;
            // 
            // FormSerialPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 686);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.gBoxPara);
            this.Controls.Add(this.gBoxPID);
            this.Controls.Add(this.gBoxMotor);
            this.Controls.Add(this.gBoxReceiver);
            this.Controls.Add(this.gBoxTransmitter);
            this.Controls.Add(this.zGraphParameters);
            this.Controls.Add(this.zGrphPlotData);
            this.Controls.Add(this.gBoxCtrlSerialPort);
            this.Controls.Add(this.gBoxChooseSerialPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSerialPort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hồi sinh quái thú v1.1";
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
            this.gBoxPara.ResumeLayout(false);
            this.gBoxPara.PerformLayout();
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
        private System.Windows.Forms.Button btnGraph;
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
        private System.Windows.Forms.Button btnMotorStop;
        private System.Windows.Forms.Button btnMotorRun;
        private System.Windows.Forms.TextBox tBoxTimeStep;
        private System.Windows.Forms.Label lbTimeStep;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lbCalib;
        private System.Windows.Forms.TextBox tbCalib;
        private System.Windows.Forms.CheckBox cBoxLog;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gBoxPara;
        private System.Windows.Forms.Label lbK3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbK1;
        private System.Windows.Forms.TextBox tBoxK3;
        private System.Windows.Forms.TextBox tBoxK2;
        private System.Windows.Forms.TextBox tBoxK1;
        private System.Windows.Forms.TextBox tBoxK0;
        private System.Windows.Forms.Label lbK0;
        private ZedGraph.ZedGraphControl zGraphParameters;
    }
}

