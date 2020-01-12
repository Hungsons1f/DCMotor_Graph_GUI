using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

/*Private include ---------------------------------------------------------------------------------------------------------*/
using System.IO.Ports;
using ZedGraph;


/*Main code ---------------------------------------------------------------------------------------------------------------*/
namespace SerialGUI
{
    public partial class FormSerialPort : Form
    {

    /*Private variables ---------------------------------------------------------------------------------------------------*/
        public enum graphStatus {GraphRun = 1, GraphStop = 0};
        public enum graphScroll {Scroll = 0, Compact = 1 };

        string outBuffer;
        int[] inBuffer = new int[5];

        double realtime = 0;                                    //Khai báo biến thời gian để vẽ đồ thị
        double realtimestep = 0.02;
        double setpoint = 0;                                       //Khai báo biến dữ liệu thứ nhất để vẽ đồ thị
        double measure = 0;                                      //Khai báo biến dữ liệu thứ 2 để vẽ đồ thị

        double Thetaa1 = 0;
        double Thetaa2 = 0;
        double Thetab1 = 0;
        double Thetab2 = 0;

        graphStatus status = graphStatus.GraphRun;
        graphScroll enScroll = graphScroll.Scroll;

        byte[] inByte = new byte[5];

        DataTable logTable = new DataTable();
        

    /*Form methods --------------------------------------------------------------------------------------------------------*/
        public FormSerialPort()
        {
            InitializeComponent();
        }

        private void FormSerialPort_Load(object sender, EventArgs e)
        {
            string[] port = SerialPort.GetPortNames();
            cBoxPortName.Items.AddRange(port);

            logTable.Columns.Add("Setpoint", typeof(float));
            logTable.Columns.Add("Measure", typeof(float));

            // Khởi tạo ZedGraph            
            GraphPane myPane = zGrphPlotData.GraphPane;      //Tác động các thành phần của Control, (GraphPane)
            myPane.Title.Text = "Giá trị đặt - Giá trị đo";
            myPane.XAxis.Title.Text = "Thời gian (s)";
            myPane.YAxis.Title.Text = "Dữ liệu";

            RollingPointPairList list = new RollingPointPairList(60000);        //Tạo mới danh sách dữ liệu 60000 phần tử, có khả năng cuốn chiếu
            LineItem curve = myPane.AddCurve("Giá trị đặt", list, Color.Red, SymbolType.None);         //Tạo mới đường cong của đồ thị trên GraphPane dựa vào danh sách dữ liệu
            RollingPointPairList list2 = new RollingPointPairList(60000);
            LineItem curve2 = myPane.AddCurve("Giá trị đo", list2, Color.MediumSlateBlue, SymbolType.None);

            myPane.XAxis.Scale.Min = 0;                         //Đặt giới hạn đồ thị
            myPane.XAxis.Scale.Max = 6;
            myPane.XAxis.Scale.MinorStep = 0.1;                   //Đặt các bước độ chia
            myPane.XAxis.Scale.MajorStep = 1;
            myPane.YAxis.Scale.Min = 0;                      //Tương tự cho trục y
            myPane.YAxis.Scale.Max = 2500;

            myPane.AxisChange();

            // Khởi tạo ZedGraph            
            GraphPane myPanePara = zGraphParameters.GraphPane;      //Tác động các thành phần của Control, (GraphPane)
            myPanePara.Title.Text = "Tham số";
            myPanePara.XAxis.Title.Text = "Thời gian (s)";
            myPanePara.YAxis.Title.Text = "Dữ liệu";

            RollingPointPairList listPara = new RollingPointPairList(60000);        //Tạo mới danh sách dữ liệu 60000 phần tử, có khả năng cuốn chiếu
            LineItem curvePara = myPanePara.AddCurve("a1", listPara, Color.Red, SymbolType.None);         //Tạo mới đường cong của đồ thị trên GraphPane dựa vào danh sách dữ liệu
            RollingPointPairList list2Para = new RollingPointPairList(60000);
            LineItem curve2Para = myPanePara.AddCurve("a2", list2Para, Color.MediumSlateBlue, SymbolType.None);

            myPanePara.XAxis.Scale.Min = 0;                         //Đặt giới hạn đồ thị
            myPanePara.XAxis.Scale.Max = 6;
            myPanePara.XAxis.Scale.MinorStep = 0.1;                   //Đặt các bước độ chia
            myPanePara.XAxis.Scale.MajorStep = 1;
            myPanePara.YAxis.Scale.Min = 0;                      //Tương tự cho trục y
            myPanePara.YAxis.Scale.Max = 10;

            myPanePara.AxisChange();

        }



        /*Button methods -------------------------------------------------------------------------------------------------*/
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                sPort.PortName = cBoxPortName.Text;
                sPort.BaudRate = Int32.Parse(cBoxBaudRate.Text);
                sPort.DataBits = Int32.Parse(cBoxDataBit.Text);
                sPort.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParity.Text); //có kiểu enum parity chứa các giá trị có sẵn của parity
                sPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBit.Text);
                //sPort.ReadBufferSize = 32
                
                sPort.Open();                
                progressBar1.Value = 100;               

                btnConnect.Enabled = false;
                btnDisCon.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            
        }

        private void btnDisCon_Click(object sender, EventArgs e)
        {
            try
            {
                sPort.Close();
                progressBar1.Value = 0;

                btnDisCon.Enabled = false;
                btnConnect.Enabled = true;

                realtime = 0;                                    //Khai báo biến thời gian để vẽ đồ thị
                setpoint = 0;                                       //Khai báo biến dữ liệu thứ nhất để vẽ đồ thị
                measure = 0;                                      //Khai báo biến dữ liệu thứ 2 để vẽ đồ thị
                Thetaa1 = 0;
                Thetaa2 = 0;
                Thetab1 = 0;
                Thetab2 = 0;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (sPort.IsOpen)
            {
                try
                {
                    sPort.WriteTimeout = 5000;
                    outBuffer = tBoxDisplaySend.Text;
                    sPort.Write(outBuffer);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }
            else
            {
                MessageBox.Show("Connect Serial port first!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearGet_Click(object sender, EventArgs e)
        {
            tBoxDisplayGet.Text = null;
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case graphStatus.GraphRun:
                    status = graphStatus.GraphStop;
                    btnGraph.Text = "Graph";
                    break;
                case graphStatus.GraphStop:
                    status = graphStatus.GraphRun;
                    btnGraph.Text = "NotGraph";
                    break;
                default:
                    break;
            }
        }

        private void btnCompact_Click(object sender, EventArgs e)
        {
            switch (enScroll)
            {
                case graphScroll.Scroll:
                    enScroll = graphScroll.Compact;
                    btnCompact.Text = "Scroll";
                    break;
                case graphScroll.Compact:
                    enScroll = graphScroll.Scroll;
                    btnCompact.Text = "Compact";
                    break;
                default:
                    break;
            }
        }

        private void btnMotorRun_Click(object sender, EventArgs e)
        {
            try
            {
                clearGraph();

                byte[] setPointBuffer = UARTCom.headerEncapsulation(UARTCom.controlHeader.Run, "0");
                sPort.Write(setPointBuffer, 0, 5);
                
                //btnMotorRun.Enabled = false;
                //btnMotorStop.Enabled = true;

                //gBoxWhatToMeasure.Enabled = false;
                //gBoxPID.Enabled = false;
                //tBoxSetPoint.Enabled = false;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void btnMotorStop_Click(object sender, EventArgs e)
        {
            try
            {
                //byte[] temp = new byte[1];
                //temp[0] = (byte)UARTCom.controlHeader.Stop;
                //sPort.Write(temp, 0, 1);
                byte[] setPointBuffer = UARTCom.headerEncapsulation(UARTCom.controlHeader.Stop, "0");
                sPort.Write(setPointBuffer, 0, 5);
                
                //btnMotorRun.Enabled = true;
                //btnMotorStop.Enabled = false;

                //gBoxWhatToMeasure.Enabled = true;
                //gBoxPID.Enabled = true;
                //tBoxSetPoint.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            try
            {
                //byte[] temp = new byte[1];
                //temp[0] = (byte)UARTCom.controlHeader.Stop;
                //sPort.Write(temp, 0, 1);
                byte[] setPointBuffer = UARTCom.headerEncapsulation(UARTCom.controlHeader.Request, "0");
                sPort.Write(setPointBuffer, 0, 5);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhóm tác giả: \n" +
                "\t Lý Ngọc Trân Châu\n" +
                "\t Nguyễn Hùng Sơn \n" +
                "\t Lê Xuân Thuyên \n" +
                "\n" +
                "Thông số calib bộ điều khiển PID vị trí: \n" +
                "\t Kp = 0.01 \n" +
                "\t Ki = 0.001 \n" +
                "\t Kd = 0.0004 \n" +
                "\t Vận tốc tối đa: 2300 xung / 20ms \n", "About...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Export2Excel export = new Export2Excel();
                export.table = logTable;
                export.SaveToExcel();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }





        /*Serial Port methods -----------------------------------------------------------------------------------------------------------------*/
        private void sPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                readBuffer(ref inByte);//inBuffer);
                //sPort.Read(inByte, 0, 5);

                this.Invoke(new EventHandler(showAndSaveData));


            }
            catch (Exception err)
            {                
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void readBuffer(ref byte[] outBuffer)
        {
            for (int ii = 0; ii <= 4; ii++)
            {
                outBuffer[ii] = Convert.ToByte(sPort.ReadByte());
            }
        }

        int textupdate = 50;
        private void showAndSaveData(object sender, EventArgs e)
        {
            /*int[]*/byte[] dataWithoutHeader;
            //UARTCom.dataHeader header = UARTCom.classifyData(inBuffer, out dataWithoutHeader);
            //float displayValue = UARTCom.uARTtoFloat(dataWithoutHeader);

            UARTCom.dataHeader header = UARTCom.classifyByte(inByte, out dataWithoutHeader);
            float displayValue = UARTCom.uARTBytetoFloat(dataWithoutHeader);

            switch (header)
            {
                case UARTCom.dataHeader.Realtime:
                    //realtimestep = displayValue;
                    break;
                case UARTCom.dataHeader.Setpoint:
                    setpoint = displayValue;
                    tBoxDisplayGet.Text += UARTCom.motorMessage[4];
                    tBoxDisplayGet.Text += displayValue.ToString();
                    tBoxDisplayGet.Text += Environment.NewLine;
                    break;
                case UARTCom.dataHeader.Measure:
                    measure = displayValue;
                    realtime += realtimestep;
                    break;
                case UARTCom.dataHeader.Run:
                    tBoxDisplayGet.Text += UARTCom.motorMessage[0];
                    tBoxDisplayGet.Text += Environment.NewLine;
                    break;
                case UARTCom.dataHeader.Stop:
                    tBoxDisplayGet.Text += UARTCom.motorMessage[1];
                    tBoxDisplayGet.Text += Environment.NewLine;
                    break;
                case UARTCom.dataHeader.Velocity:
                    tBoxDisplayGet.Text += UARTCom.motorMessage[2];
                    tBoxDisplayGet.Text += Environment.NewLine;
                    break;
                case UARTCom.dataHeader.Position:
                    tBoxDisplayGet.Text += UARTCom.motorMessage[3];
                    tBoxDisplayGet.Text += Environment.NewLine;
                    break;
                case UARTCom.dataHeader.Kp:
                    tBoxDisplayGet.Text += UARTCom.motorMessage[5];
                    tBoxDisplayGet.Text += displayValue.ToString();
                    tBoxDisplayGet.Text += Environment.NewLine;
                    break;
                case UARTCom.dataHeader.Ki:
                    tBoxDisplayGet.Text += UARTCom.motorMessage[6];
                    tBoxDisplayGet.Text += displayValue.ToString();
                    tBoxDisplayGet.Text += Environment.NewLine;
                    break;
                case UARTCom.dataHeader.Kd:
                    tBoxDisplayGet.Text += UARTCom.motorMessage[7];
                    tBoxDisplayGet.Text += displayValue.ToString();
                    tBoxDisplayGet.Text += Environment.NewLine;
                    break;
                case UARTCom.dataHeader.Message:
                    char transChar = (char)displayValue;
                    tBoxDisplayGet.Text += Convert.ToString(transChar);
                    break;
                case UARTCom.dataHeader.Floattype:
                    tBoxDisplayGet.Text += displayValue.ToString();
                    tBoxDisplayGet.Text += Environment.NewLine;
                    break;
                case UARTCom.dataHeader.Calib:
                    tBoxDisplayGet.Text += UARTCom.motorMessage[8];
                    tBoxDisplayGet.Text += displayValue.ToString();
                    tBoxDisplayGet.Text += Environment.NewLine;
                    break;
                case UARTCom.dataHeader.Parak0:
                    tBoxDisplayGet.Text += UARTCom.motorMessage[9];
                    tBoxDisplayGet.Text += displayValue.ToString();
                    tBoxDisplayGet.Text += Environment.NewLine;
                    break;
                case UARTCom.dataHeader.Parak1:
                    tBoxDisplayGet.Text += UARTCom.motorMessage[10];
                    tBoxDisplayGet.Text += displayValue.ToString();
                    tBoxDisplayGet.Text += Environment.NewLine;
                    break;
                case UARTCom.dataHeader.Parak2:
                    tBoxDisplayGet.Text += UARTCom.motorMessage[11];
                    tBoxDisplayGet.Text += displayValue.ToString();
                    tBoxDisplayGet.Text += Environment.NewLine;
                    break;
                case UARTCom.dataHeader.Parak3:
                    tBoxDisplayGet.Text += UARTCom.motorMessage[12];
                    tBoxDisplayGet.Text += displayValue.ToString();
                    tBoxDisplayGet.Text += Environment.NewLine;
                    break;
                case UARTCom.dataHeader.ParaThetaa1:
                    Thetaa1 = displayValue;
                    break;
                case UARTCom.dataHeader.ParaThetaa2:
                    Thetaa2 = displayValue;
                    break;
                case UARTCom.dataHeader.ParaThetab1:
                    Thetab1 = displayValue;
                    break;
                case UARTCom.dataHeader.ParaThetab2:
                    Thetab2 = displayValue;
                    break;
                case UARTCom.dataHeader.Null:
                    sPort.ReadExisting();
                    break;
                default:
                    break;
            }

            textupdate--;
            if (textupdate == 0)
            {
                tBoxTime.Text = realtime.ToString();
                tBoxMeasure.Text = measure.ToString();
                tBoxDisplayGet.Text += displayValue.ToString();
                tBoxDisplayGet.Text += Environment.NewLine;
                textupdate = 50;
            }

            if (status == graphStatus.GraphRun)
                Draw();
            

            if (cBoxLog.Checked == true)
            {
                logTable.Rows.Add( setpoint, measure);
            }
        }

        // Vẽ đồ thị
        private void Draw()
        {
            LineItem curve = zGrphPlotData.GraphPane.CurveList[0] as LineItem;   //Khai báo đường cong từ danh sách đường cong đồ thị (kế thừa từ heap của dữ liệu ở Form_load)
            if (curve == null)
                return;
            LineItem curve2 = zGrphPlotData.GraphPane.CurveList[1] as LineItem;
            if (curve2 == null)
                return;
            IPointListEdit list = curve.Points as IPointListEdit;   //Khai báo danh sách dữ liệu cho đường cong đồ thị
            if (list == null)
                return;
            IPointListEdit list2 = curve2.Points as IPointListEdit;
            if (list2 == null)
                return;
            list.Add(realtime, setpoint);                          // Thêm điểm trên đồ thị
            list2.Add(realtime, measure);                        // Thêm điểm trên đồ thị

            Scale xScale = zGrphPlotData.GraphPane.XAxis.Scale;  //Giới hạn của đồ thị
            Scale yScale = zGrphPlotData.GraphPane.YAxis.Scale;

            if (enScroll == graphScroll.Scroll)
            {
                // Tự động Scale theo trục x
                if (realtime > xScale.Max - xScale.MajorStep)       //Nếu realtime lớn hơn Max x trừ đi 1 MajorStep (2 vạch lớn)
                {
                    xScale.Min = xScale.Min + realtime - (xScale.Max - xScale.MajorStep);
                    xScale.Max = realtime + xScale.MajorStep;       //Tự dời đồ thị qua 1 MajorStep 
                    //xScale.Min = xScale.Max - 6;
                }
                // Tự động Scale theo trục y
                if (setpoint > yScale.Max - yScale.MajorStep)          //Nếu datas vượt quá giới hạn trừ 1 MajorStep
                {
                    yScale.Max = setpoint + yScale.MajorStep;          //Thì tăng giới hạn thêm 1 MajorStep
                }
                else if (setpoint < yScale.Min + yScale.MajorStep)
                {
                    yScale.Min = setpoint - yScale.MajorStep;
                }
            }

            {
                zGrphPlotData.AxisChange();                      //Thay đổi trục theo giá trị Scale
                zGrphPlotData.Invalidate();                      //Mở khoá để và vẽ lại
            }

            LineItem curvePara = zGraphParameters.GraphPane.CurveList[0] as LineItem;   //Khai báo đường cong từ danh sách đường cong đồ thị (kế thừa từ heap của dữ liệu ở Form_load)
            if (curvePara == null)
                return;
            LineItem curve2Para = zGraphParameters.GraphPane.CurveList[1] as LineItem;
            if (curve2Para == null)
                return;
            IPointListEdit listPara = curvePara.Points as IPointListEdit;   //Khai báo danh sách dữ liệu cho đường cong đồ thị
            if (listPara == null)
                return;
            IPointListEdit list2Para = curve2Para.Points as IPointListEdit;
            if (list2Para == null)
                return;
            listPara.Add(realtime, Thetaa1);                          // Thêm điểm trên đồ thị
            list2Para.Add(realtime, Thetaa2);                        // Thêm điểm trên đồ thị

            Scale xScalePara = zGraphParameters.GraphPane.XAxis.Scale;  //Giới hạn của đồ thị
            Scale yScalePara = zGraphParameters.GraphPane.YAxis.Scale;

            if (enScroll == graphScroll.Scroll)
            {
                // Tự động Scale theo trục x
                if (realtime > xScalePara.Max - xScalePara.MajorStep)       //Nếu realtime lớn hơn Max x trừ đi 1 MajorStep (2 vạch lớn)
                {
                    xScalePara.Min = xScalePara.Min + realtime - (xScalePara.Max - xScalePara.MajorStep);
                    xScalePara.Max = realtime + xScalePara.MajorStep;       //Tự dời đồ thị qua 1 MajorStep 
                    //xScale.Min = xScale.Max - 6;
                }
                // Tự động Scale theo trục y
                if (setpoint > yScalePara.Max - yScalePara.MajorStep)          //Nếu datas vượt quá giới hạn trừ 1 MajorStep
                {
                    yScalePara.Max = setpoint + yScalePara.MajorStep;          //Thì tăng giới hạn thêm 1 MajorStep
                }
                else if (setpoint < yScalePara.Min + yScalePara.MajorStep)
                {
                    yScalePara.Min = setpoint - yScalePara.MajorStep;
                }
            }

            {
                zGraphParameters.AxisChange();                      //Thay đổi trục theo giá trị Scale
                zGraphParameters.Invalidate();                      //Mở khoá để và vẽ lại
            }
        }

   



    /*Text Box methods ------------------------------------------------------------------------------------------------------------------------*/
    private void tBoxDisplayGet_TextChanged(object sender, EventArgs e)
        {
            tBoxDisplayGet.SelectionStart = tBoxDisplayGet.Text.Length;
            tBoxDisplayGet.ScrollToCaret();
        }

        private void tBoxSetPoint_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    setpoint = float.Parse(tBoxSetPoint.Text);
                    byte[] setPointBuffer = UARTCom.headerEncapsulation(UARTCom.controlHeader.Setpoint, tBoxSetPoint.Text);
                    sPort.Write(setPointBuffer, 0, 5);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void tBoxKp_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    byte[] kpBuffer = UARTCom.headerEncapsulation(UARTCom.controlHeader.Kp, tBoxKp.Text);
                    sPort.Write(kpBuffer, 0, 5);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }

        }

        private void tBoxKi_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    byte[] kiBuffer = UARTCom.headerEncapsulation(UARTCom.controlHeader.Ki, tBoxKi.Text);
                    sPort.Write(kiBuffer, 0, 5);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void tBoxKd_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    byte[] kdBuffer = UARTCom.headerEncapsulation(UARTCom.controlHeader.Kd, tBoxKd.Text);
                    sPort.Write(kdBuffer, 0, 5);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void tBoxTimeStep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                realtimestep = Double.Parse(tBoxTimeStep.Text);
            }
        }

        private void tBoxCalib_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    byte[] setPointBuffer = UARTCom.headerEncapsulation(UARTCom.controlHeader.Calib, tbCalib.Text);
                    sPort.Write(setPointBuffer, 0, 5);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }





        /*Radio Button methods*/
        private void rBtnVP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                clearGraph();
                if (rBtnVelocity.Checked)
                {
                    lbVelocity.Text = "Velocity";
                    tbCalib.Text = "4.8";

                    GraphPane myPane = zGrphPlotData.GraphPane;
                    myPane.YAxis.Scale.Min = 0;                      //Tương tự cho trục y
                    myPane.YAxis.Scale.Max = 2500;
                    myPane.AxisChange();
                    
                    //byte[] temp = new byte[1];
                    //temp[0] = (byte)UARTCom.controlHeader.Velocity;
                    //sPort.Write(temp, 0, 1);
                    byte[] setPointBuffer = UARTCom.headerEncapsulation(UARTCom.controlHeader.Velocity, "0");
                    sPort.Write(setPointBuffer, 0, 5);
                }
                else
                {
                    lbVelocity.Text = "Position";
                    tbCalib.Text = "40";

                    GraphPane myPane = zGrphPlotData.GraphPane;
                    myPane.YAxis.Scale.Min = 0;                      //Tương tự cho trục y
                    myPane.YAxis.Scale.Max = 600;
                    myPane.AxisChange();

                    //byte[] temp = new byte[1];
                    //temp[0] = (byte)UARTCom.controlHeader.Position;
                    //sPort.Write(temp, 0, 1);         
                    byte[] setPointBuffer = UARTCom.headerEncapsulation(UARTCom.controlHeader.Position, "0");
                    sPort.Write(setPointBuffer, 0, 5);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        

    /*Other methods ---------------------------------------------------------------------------------------------------------------------------*/
        private void clearGraph ()
        {
            zGrphPlotData.GraphPane.CurveList.Clear();                  // Xóa đường
            zGrphPlotData.GraphPane.GraphObjList.Clear();               // Xóa đối tượng
            zGrphPlotData.AxisChange();
            zGrphPlotData.Invalidate();

            realtime = 0;
            //setpoint = 0;
            measure = 0;

            // Khởi tạo ZedGraph            
            GraphPane myPane = zGrphPlotData.GraphPane;      //Tác động các thành phần của Control, (GraphPane)
            myPane.Title.Text = "Giá trị đặt - giá trị đo";
            myPane.XAxis.Title.Text = "Thời gian (s)";
            myPane.YAxis.Title.Text = "Dữ liệu";

            RollingPointPairList list = new RollingPointPairList(60000);        //Tạo mới danh sách dữ liệu 60000 phần tử, có khả năng cuốn chiếu
            LineItem curve = myPane.AddCurve("Giá trị đặt", list, Color.Red, SymbolType.None);         //Tạo mới đường cong của đồ thị trên GraphPane dựa vào danh sách dữ liệu
            RollingPointPairList list2 = new RollingPointPairList(60000);
            LineItem curve2 = myPane.AddCurve("Giá trị đo", list2, Color.MediumSlateBlue, SymbolType.None);

            myPane.XAxis.Scale.Min = 0;                         //Đặt giới hạn đồ thị
            myPane.XAxis.Scale.Max = 6;
            myPane.XAxis.Scale.MinorStep = 0.1;                   //Đặt các bước độ chia
            myPane.XAxis.Scale.MajorStep = 1;
            //myPane.YAxis.Scale.Min = 0;                      //Tương tự cho trục y
            //myPane.YAxis.Scale.Max = 100;

            myPane.AxisChange();

            zGraphParameters.GraphPane.CurveList.Clear();                  // Xóa đường
            zGraphParameters.GraphPane.GraphObjList.Clear();               // Xóa đối tượng
            zGraphParameters.AxisChange();
            zGraphParameters.Invalidate();

            // Khởi tạo ZedGraph            
            GraphPane myPanePara = zGraphParameters.GraphPane;      //Tác động các thành phần của Control, (GraphPane)
            myPanePara.Title.Text = "Tham số";
            myPanePara.XAxis.Title.Text = "Thời gian (s)";
            myPanePara.YAxis.Title.Text = "Dữ liệu";

            RollingPointPairList listPara = new RollingPointPairList(60000);        //Tạo mới danh sách dữ liệu 60000 phần tử, có khả năng cuốn chiếu
            LineItem curvePara = myPanePara.AddCurve("Giá trị đặt", listPara, Color.Red, SymbolType.None);         //Tạo mới đường cong của đồ thị trên GraphPane dựa vào danh sách dữ liệu
            RollingPointPairList list2Para = new RollingPointPairList(60000);
            LineItem curve2Para = myPanePara.AddCurve("Giá trị đo", list2Para, Color.MediumSlateBlue, SymbolType.None);

            myPanePara.XAxis.Scale.Min = 0;                         //Đặt giới hạn đồ thị
            myPanePara.XAxis.Scale.Max = 6;
            myPanePara.XAxis.Scale.MinorStep = 0.1;                   //Đặt các bước độ chia
            myPanePara.XAxis.Scale.MajorStep = 1;
            myPanePara.YAxis.Scale.Min = 0;                      //Tương tự cho trục y
            myPanePara.YAxis.Scale.Max = 10;

            myPanePara.AxisChange();

        }



        private void tBoxK0_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    byte[] setPointBuffer = UARTCom.headerEncapsulation(UARTCom.controlHeader.Parak0, tBoxK0.Text);
                    sPort.Write(setPointBuffer, 0, 5);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void tBoxK1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    byte[] setPointBuffer = UARTCom.headerEncapsulation(UARTCom.controlHeader.Parak1, tBoxK1.Text);
                    sPort.Write(setPointBuffer, 0, 5);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void tBoxK2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    byte[] setPointBuffer = UARTCom.headerEncapsulation(UARTCom.controlHeader.Parak2, tBoxK2.Text);
                    sPort.Write(setPointBuffer, 0, 5);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void tBoxK3_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    byte[] setPointBuffer = UARTCom.headerEncapsulation(UARTCom.controlHeader.Parak3, tBoxK3.Text);
                    sPort.Write(setPointBuffer, 0, 5);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
    }



    /*Private classes ------------------------------------------------------------------------------------------------------------------------*/
    static public class UARTCom
    {
        public enum dataHeader { Realtime = 0x01, Setpoint = 0x02, Measure = 0x03,
                                    Message = 0x04, Floattype = 0x05,
                                    ParaThetaa1 = 0x06, ParaThetaa2 = 0x07, ParaThetab1 = 0x08, ParaThetab2 = 0x09,
                                    Run = 0x11, Stop = 0x12, Velocity = 0x13, Position = 0x14,
                                    Kp = 0x17, Ki = 0x18, Kd = 0x19,
                                    Calib = 0x31,
                                    Parak0 = 0x41, Parak1 = 0x42, Parak2 = 0x43, Parak3 = 0x44,
                                    Null = 0x00
                                    };
        public enum controlHeader { Run = 0x11, Stop = 0x12, Velocity = 0x13, Position = 0x14, Setpoint = 0x15, Realtime = 0x16,
                                    Kp = 0x17, Ki = 0x18, Kd = 0x19,
                                    Request = 0x21, Calib = 0x31,
                                    Parak0 = 0x41, Parak1 = 0x42, Parak2 = 0x43, Parak3 = 0x44 };
        public static string[] motorMessage =
        {
            "Motor is running...",
            "Motor Stopped!",
            "Velocity Mode",
            "Position Mode",
            "Setpoint Set: ",
            "Kp Set: ",
            "Ki Set: ",
            "Kd Set: ",
            "Calib Set: ",
            "Parameter k0 Set: ",
            "Parameter k1 Set: ",
            "Parameter k2 Set: ",
            "Parameter k3 Set: "
        };

        static public byte[] stringtoUART(string text)
        {
            byte[] temp = new byte[4];
            float floattemp = float.Parse(text);
            temp = BitConverter.GetBytes(floattemp);
            return temp;
        }

        static public byte[] headerEncapsulation(controlHeader header, string text)
        {
            byte[] temp = new byte[5];
            switch (header)
            {
                case controlHeader.Realtime:
                    temp[0] = (byte)controlHeader.Realtime;
                    break;
                case controlHeader.Setpoint:
                    temp[0] = (byte)controlHeader.Setpoint;
                    break;
                case controlHeader.Run:
                    temp[0] = (byte)controlHeader.Run;
                    break;
                case controlHeader.Stop:
                    temp[0] = (byte)controlHeader.Stop;
                    break;
                case controlHeader.Velocity:
                    temp[0] = (byte)controlHeader.Velocity;
                    break;
                case controlHeader.Position:
                    temp[0] = (byte)controlHeader.Position;
                    break;
                case controlHeader.Kp:
                    temp[0] = (byte)controlHeader.Kp;
                    break;
                case controlHeader.Ki:
                    temp[0] = (byte)controlHeader.Ki;
                    break;
                case controlHeader.Kd:
                    temp[0] = (byte)controlHeader.Kd;
                    break;
                case controlHeader.Request:
                    temp[0] = (byte)controlHeader.Request;
                    break;
                case controlHeader.Calib:
                    temp[0] = (byte)controlHeader.Calib;
                    break;
                case controlHeader.Parak0:
                    temp[0] = (byte)controlHeader.Parak0;
                    break;
                case controlHeader.Parak1:
                    temp[0] = (byte)controlHeader.Parak1;
                    break;
                case controlHeader.Parak2:
                    temp[0] = (byte)controlHeader.Parak2;
                    break;
                case controlHeader.Parak3:
                    temp[0] = (byte)controlHeader.Parak3;
                    break;
                default:
                    break;
            }
            byte[] tempBuffer = stringtoUART(text);
            temp[1] = tempBuffer[3];
            temp[2] = tempBuffer[2];
            temp[3] = tempBuffer[1];
            temp[4] = tempBuffer[0];
            return temp;
        }

        static public dataHeader classifyByte(byte[] inData, out byte[] outData)
        {
            outData = new byte[100];

            outData[0] = inData[4];
            outData[1] = inData[3];
            outData[2] = inData[2];
            outData[3] = inData[1];
            return (dataHeader)inData[0];
        }

        static public float uARTBytetoFloat(byte[] uBuffer)
        {
            float value = 0;
            value = BitConverter.ToSingle(uBuffer, 0);
            return value;
        }

    }


    /*{
        byte[] bytes = { 0, 0, 0x70, 0x41 };
        float value = BitConverter.ToSingle(bytes, 0);
        //outp.Text = Convert.ToString(value);
        byte[] byteout = BitConverter.GetBytes(value);
        outp.Text = BitConverter.ToString(byteout);
    }*/

}



/*static public dataHeader classifyByteTemp(byte[] inData, out byte[] outData)
{
    outData = new byte[100];
    /*int i = 0;
    foreach (var item in inData)
    {
        if (i == 0)
        {
            i++;
            continue;
        }
        else
        {
            outData[i - 1] = item;
            i++;
        }
    }
    outData[0] = inData[1];
    outData[1] = inData[2];
    outData[2] = inData[3];
    outData[3] = inData[4];
    return (dataHeader)inData[0];
}*/

/*static public float uARTBytetoFloatTemp(byte[] uBuffer)
{
    float value = 0;
    unsafe
    {
        long temp = 0;
        temp = uBuffer[0];
        temp = (temp << 8) + uBuffer[1];
        temp = (temp << 8) + uBuffer[2];
        temp = (temp << 8) + uBuffer[3];
        float* pFloat;
        pFloat = (float*)&temp;
        value = *pFloat;
    }
    return value;
}*/

/*static public dataHeader classifyData(int[] inData, out int[] outData)
{
outData = new int[100];
/*int i = 0;
foreach (var item in inData)
{
    if (i == 0)
    {
        i++;
        continue;
    }
    else
    {
        outData[i - 1] = item;
        i++;
    }
}
outData[0] = inData[1];
outData[1] = inData[2];
outData[2] = inData[3];
outData[3] = inData[4];
return (dataHeader)inData[0];
}*/

/*static public float uARTtoFloat(int[] uBuffer)
{
    float value = 0;
    unsafe
    {
        long temp = 0;
        temp = uBuffer[0];
        temp = (temp << 8) + uBuffer[1];
        temp = (temp << 8) + uBuffer[2];
        temp = (temp << 8) + uBuffer[3];
        float* pFloat;
        pFloat = (float*)&temp;
        value = *pFloat;
    }
    return value;
}*/


/*static public byte[] stringtoUARTtemp(string text)
{
    byte[] temp = new byte[4];
    float floattemp = float.Parse(text);
    unsafe
    {
        long* pLong;
        pLong = (long*)&floattemp;
        temp[0] = Convert.ToByte((*pLong & 0xff000000) >> 24);
        temp[1] = Convert.ToByte((*pLong & 0x00ff0000) >> 16);
        temp[2] = Convert.ToByte((*pLong & 0x0000ff00) >> 8);
        temp[3] = Convert.ToByte((*pLong & 0x000000ff));
    }
    return temp;
}*/