using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        double setpoint = 0;                                       //Khai báo biến dữ liệu thứ nhất để vẽ đồ thị
        double measure = 0;                                      //Khai báo biến dữ liệu thứ 2 để vẽ đồ thị
        graphStatus status = graphStatus.GraphStop;
        graphScroll enScroll = graphScroll.Scroll;



    /*Form methods --------------------------------------------------------------------------------------------------------*/
        public FormSerialPort()
        {
            InitializeComponent();
        }

        private void FormSerialPort_Load(object sender, EventArgs e)
        {
            string[] port = SerialPort.GetPortNames();
            cBoxPortName.Items.AddRange(port);            

            // Khởi tạo ZedGraph            
            GraphPane myPane = zGrphPlotData.GraphPane;      //Tác động các thành phần của Control, (GraphPane)
            myPane.Title.Text = "Đồ thị dữ liệu theo thời gian";
            myPane.XAxis.Title.Text = "Thời gian (s)";
            myPane.YAxis.Title.Text = "Dữ liệu";

            RollingPointPairList list = new RollingPointPairList(60000);        //Tạo mới danh sách dữ liệu 60000 phần tử, có khả năng cuốn chiếu
            LineItem curve = myPane.AddCurve("Giá trị đặt", list, Color.Red, SymbolType.None);         //Tạo mới đường cong của đồ thị trên GraphPane dựa vào danh sách dữ liệu
            RollingPointPairList list2 = new RollingPointPairList(60000);
            LineItem curve2 = myPane.AddCurve("Giá trị đo", list2, Color.MediumSlateBlue, SymbolType.None);

            myPane.XAxis.Scale.Min = 0;                         //Đặt giới hạn đồ thị
            myPane.XAxis.Scale.Max = 30;
            myPane.XAxis.Scale.MinorStep = 1;                   //Đặt các bước độ chia
            myPane.XAxis.Scale.MajorStep = 5;
            myPane.YAxis.Scale.Min = -100;                      //Tương tự cho trục y
            myPane.YAxis.Scale.Max = 100;

            myPane.AxisChange();
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

        private void btnRun_Click(object sender, EventArgs e)
        {
            status = graphStatus.GraphRun;
            btnRun.Enabled = false;
            btnStop.Enabled = true;

            gBoxWhatToMeasure.Enabled = false;
            gBoxPID.Enabled = false;
            tBoxSetPoint.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            status = graphStatus.GraphStop;
            btnStop.Enabled = false;
            btnRun.Enabled = true;

            gBoxWhatToMeasure.Enabled = true;
            gBoxPID.Enabled = true;
            tBoxSetPoint.Enabled = true;
        }

        private void btnClearGraph_Click(object sender, EventArgs e)
        {
            clearGraph();
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
                byte[] temp = new byte[1];
                temp[0] = (byte)UARTCom.controlHeader.Run;
                sPort.Write(temp, 0, 1);

                btnMotorRun.Enabled = false;
                btnMotorStop.Enabled = true;
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
                byte[] temp = new byte[1];
                temp[0] = (byte)UARTCom.controlHeader.Stop;
                sPort.Write(temp, 0, 1);

                btnMotorRun.Enabled = true;
                btnMotorStop.Enabled = false; ;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }





        /*Serial Port methods -----------------------------------------------------------------------------------------------------------------*/
        private void sPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                readBuffer(ref inBuffer);
                this.Invoke(new EventHandler(showAndSaveData));

                if (status == graphStatus.GraphRun)
                    Draw();
            }
            catch (Exception err)
            {                
                MessageBox.Show(err.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void readBuffer(ref int[] outBuffer)
        {
            for (int ii = 0; ii <= 4; ii++)
            {
                outBuffer[ii] = sPort.ReadByte();
            }
        }

        private void showAndSaveData(object sender, EventArgs e)
        {
            int[] dataWithoutHeader;
            UARTCom.dataHeader header = UARTCom.classifyData(inBuffer, out dataWithoutHeader);
            float displayValue = UARTCom.uARTtoFloat(dataWithoutHeader);

            if (header != UARTCom.dataHeader.Message)
            {
                switch (header)
                {
                    case UARTCom.dataHeader.Realtime:
                        realtime = displayValue;
                        break;
                    case UARTCom.dataHeader.Setpoint:
                        setpoint = displayValue;
                        break;
                    case UARTCom.dataHeader.Measure:
                        measure = displayValue;
                        break;
                    default:
                        break;
                }

                tBoxDisplayGet.Text += displayValue.ToString();
                tBoxDisplayGet.Text += Environment.NewLine;
                tBoxTime.Text = realtime.ToString();
                tBoxMeasure.Text = measure.ToString();
            }
            else
            {
                tBoxDisplayGet.Text += dataWithoutHeader.ToString();
                tBoxDisplayGet.Text += Environment.NewLine;
            }

            realtime += 0.25;

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
                    xScale.Max = realtime + xScale.MajorStep;       //Tự dời đồ thị qua 1 MajorStep 
                    xScale.Min = xScale.Max - 30;
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
                zGrphPlotData.AxisChange();                      //Thay đổi trục theo giá trị Scale
            }
            zGrphPlotData.Invalidate();                      //Mở khoá để và vẽ lại
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



    /*Radio Button methods*/
        private void rBtnVP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                clearGraph();
                if (rBtnVelocity.Checked)
                {
                    lbVelocity.Text = "Velocity (RPM)";
                    byte[] temp = new byte[1];
                    temp[0] = (byte)UARTCom.controlHeader.Velocity;
                    sPort.Write(temp, 0, 1);
                }
                else
                {
                    lbVelocity.Text = "Position (Deg)";
                    byte[] temp = new byte[1];
                    temp[0] = (byte)UARTCom.controlHeader.Position;
                    sPort.Write(temp, 0, 1);                    
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
            setpoint = 0;
            measure = 0;

            // Khởi tạo ZedGraph            
            GraphPane myPane = zGrphPlotData.GraphPane;      //Tác động các thành phần của Control, (GraphPane)
            myPane.Title.Text = "Đồ thị dữ liệu theo thời gian";
            myPane.XAxis.Title.Text = "Thời gian (s)";
            myPane.YAxis.Title.Text = "Dữ liệu";

            RollingPointPairList list = new RollingPointPairList(60000);        //Tạo mới danh sách dữ liệu 60000 phần tử, có khả năng cuốn chiếu
            LineItem curve = myPane.AddCurve("Giá trị đặt", list, Color.Red, SymbolType.None);         //Tạo mới đường cong của đồ thị trên GraphPane dựa vào danh sách dữ liệu
            RollingPointPairList list2 = new RollingPointPairList(60000);
            LineItem curve2 = myPane.AddCurve("Giá trị đo", list2, Color.MediumSlateBlue, SymbolType.None);

            myPane.XAxis.Scale.Min = 0;                         //Đặt giới hạn đồ thị
            myPane.XAxis.Scale.Max = 30;
            myPane.XAxis.Scale.MinorStep = 1;                   //Đặt các bước độ chia
            myPane.XAxis.Scale.MajorStep = 5;
            myPane.YAxis.Scale.Min = -100;                      //Tương tự cho trục y
            myPane.YAxis.Scale.Max = 100;
            myPane.AxisChange();
        }
    }



    /*Private classes ------------------------------------------------------------------------------------------------------------------------*/
    static public class UARTCom
    {
        public enum dataHeader { Realtime = 0x01, Setpoint = 0x02, Measure = 0x03, Message = 0x04, Run = 0x11, Stop = 0x12, Velocity = 0x13, Position = 0x14};
        public enum controlHeader { Run = 0x11, Stop = 0x12, Velocity = 0x13, Position = 0x14, Setpoint = 0x15 };

        static public dataHeader classifyData(int[] inData, out int[] outData)
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
            }*/
            outData[0] = inData[1];
            outData[1] = inData[2];
            outData[2] = inData[3];
            outData[3] = inData[4];
            return (dataHeader)inData[0];
        }

        static public float uARTtoFloat(int[] uBuffer)
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
        }

        static public byte[] stringtoUART (string text)
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
        }

        static public byte[] headerEncapsulation (dataHeader header, string text)
        {
            byte[] temp = new byte[5];
            switch (header)
            {
                case dataHeader.Realtime:
                    break;
                case dataHeader.Setpoint:
                    temp[0] = (byte)dataHeader.Setpoint;
                    break;
                case dataHeader.Measure:
                    break;
                default:
                    break;
            }
            byte[] tempBuffer = stringtoUART(text);
            temp[1] = tempBuffer[0];
            temp[2] = tempBuffer[1];
            temp[3] = tempBuffer[2];
            temp[4] = tempBuffer[3];
            return temp;
        }

        static public byte[] headerEncapsulation(controlHeader header, string text)
        {
            byte[] temp = new byte[5];
            switch (header)
            {
                case controlHeader.Setpoint:
                    temp[0] = (byte)controlHeader.Setpoint;
                    break;
                default:
                    break;
            }
            byte[] tempBuffer = stringtoUART(text);
            temp[1] = tempBuffer[0];
            temp[2] = tempBuffer[1];
            temp[3] = tempBuffer[2];
            temp[4] = tempBuffer[3];
            return temp;
        }

    }
}
