using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace SCADA
{
    public partial class RequestForm : Form
    {
        SerialPort port = new SerialPort();
        string[] portString;
        bool kt = false;

        public RequestForm()
        {
            InitializeComponent();
            portString = SerialPort.GetPortNames();
            cbbPortName.DataSource = portString;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (port.IsOpen == false)
            {
                port = new SerialPort(cbbPortName.SelectedItem.ToString(), 9600, Parity.None, 8, StopBits.One);
                ConnectToArduino();
                timer1.Start();
                //timer2.Start();
                this.scadaBindingSource.AddNew();
            }
            else
                DisconnectFromArduino();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to quit?", "NQN", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        #region CRCCalculator
        static private void crcCalculator(byte[] message, ref byte[] CRC)
        {
            ushort CRCFull = 0xFFFF;
            byte CRCHigh = 0xFF, CRCLow = 0xFF;
            char CRCLSB;
            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRCFull = (ushort)(CRCFull ^ message[i]);
                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (char)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);
                    if (CRCLSB == 1)
                        CRCFull = (ushort)(CRCFull ^ 0xA001); // Modbus CRC16 Plolynial 0xA001
                }
            }
            CRC[1] = CRCHigh = (byte)((CRCFull >> 8) & 0xFF);
            CRC[0] = CRCLow = (byte)(CRCFull & 0xFF);
        }
        #endregion

        #region Connect_To_Arduino
        private void ConnectToArduino()
        {
            try
            {
                port.Open();
                btnConnect.Text = "Disconnect";
                MessageBox.Show("Connect complete!", "NQN");
            }
            catch (IOException)
            {
                MessageBox.Show("Please check your COM.", "NQN");
            }
        }
        #endregion

        #region Disconnect_From_Arduino
        private void DisconnectFromArduino()
        {
            try
            {
                port.Close();
                btnConnect.Text = "Connect";
                MessageBox.Show("COM is closed!", "NQN");
            }
            catch (IOException)
            {
            }
        }
        #endregion

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        byte[] message = new byte[8];
        //        byte[] CRC = new byte[2];

        //        byte _ID = byte.Parse(txbID.Text);
        //        byte _fncCode = byte.Parse(txbFncCode.Text);
        //        ushort _startAddr = ushort.Parse(txbStartAddr.Text);
        //        ushort _registerQty = ushort.Parse(txbRegisterQty.Text);

        //        message[0] = _ID;
        //        message[1] = _fncCode;
        //        message[2] = (byte)(_startAddr >> 8);
        //        message[3] = (byte)(_startAddr);
        //        message[4] = (byte)(_registerQty >> 8);
        //        message[5] = (byte)(_registerQty);
        //        crcCalculator(message, ref CRC);
        //        message[6] = CRC[0];
        //        message[7] = CRC[1];



        //        port.Write(message, 0, message.Length); //Send frame
        //        Thread.Sleep(50);
        //        byte[] buffRec = new byte[port.BytesToRead];
        //        int numberOfBytes = port.Read(buffRec, 0, buffRec.Length);

        //        string sendMsg = string.Empty;
        //        string recMsg = string.Empty;

        //        // Send
        //        foreach (var item in message)
        //        {
        //            sendMsg += string.Format("{0:X2}", item);
        //        }

        //        foreach (var item in buffRec)
        //        {
        //            recMsg += string.Format("{0:X2}", item);
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Không thể gửi!!!", "NQN", MessageBoxButtons.OK);
        //    }
        //}

        //private string hexToInt(string message)
        //{

        //    string intString = string.Empty;

        //    string[] hex_value = message.Split(' ');

        //    for (int i = 4; i < (hex_value.Length - 2); i++)
        //    {
        //        int Value = int.Parse(hex_value[i], System.Globalization.NumberStyles.HexNumber);
        //        intString += Value.ToString();
        //    }
        //    return intString;
        //}

        //private string hexToBin(string message)
        //{
        //    string binString = string.Empty;
        //    string value = string.Empty;
        //    string[] hex_value = message.Split(' ');

        //    for (int i = 4; i < (hex_value.Length - 2); i++)
        //    {
        //        string item = Convert.ToString(Convert.ToInt64(hex_value[i], 16), 2);
        //        value = "";
        //        for (int j = (item.Length - 1); j >= 0; j--)
        //        {
        //            value = value + item[j];
        //        }
        //        binString += value + " ";
        //    }
        //    return binString;
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ma ham 02, chan arduino 06, doc tin hieu digital in cam bien mua
            byte[] message = new byte[8];
            byte[] CRC = new byte[2];

            byte _startAddr02 = 6;
            byte _registerQty02 = 1;

            message[0] = 01;
            message[1] = 02;
            message[2] = (byte)(_startAddr02 >> 8);
            message[3] = (byte)(_startAddr02);
            message[4] = (byte)(_registerQty02 >> 8);
            message[5] = (byte)(_registerQty02);
            crcCalculator(message, ref CRC);
            message[6] = CRC[0];
            message[7] = CRC[1];

            port.Write(message, 0, message.Length); //Send frame
            Thread.Sleep(50);
            byte[] buffRec = new byte[port.BytesToRead];
            int numberOfBytes = port.Read(buffRec, 0, buffRec.Length);


            // xu li recMsg hien thi image
            if (buffRec[3] == 01)
            {
                ptcWeather.Image = Image.FromFile(@"D:\BackUp\ThayAu\SCADA\SCADA\SCADA\Resources\sunny.jpg");
                tHOITIETTextBox.Text = "NẮNG";
                dENTextBox.Text = "TẮT";
                //tat den
                byte _startAddr05 = 9;


                message[0] = 01;
                message[1] = 05;
                message[2] = (byte)(_startAddr05 >> 8);
                message[3] = (byte)(_startAddr05);
                message[4] = 0x00;
                message[5] = 0x00;
                crcCalculator(message, ref CRC);
                message[6] = CRC[0];
                message[7] = CRC[1];



                port.Write(message, 0, message.Length); //Send frame
                Thread.Sleep(50);
                byte[] buffRec2 = new byte[port.BytesToRead];
                int numberOfBytes2 = port.Read(buffRec2, 0, buffRec2.Length);

                if (buffRec2[4] == 0x00)
                {
                   ptcLed.Image = Image.FromFile(@"D:\BackUp\ThayAu\SCADA\SCADA\SCADA\Resources\turnoff.jpg");
                }

            }
            else
            {
                ptcWeather.Image = Image.FromFile(@"D:\BackUp\ThayAu\SCADA\SCADA\SCADA\Resources\rain.jpg");
                tHOITIETTextBox.Text = "ĐANG MƯA";
                dENTextBox.Text = "BẬT";
                //bat den
                byte _startAddr05 = 9;

                message[0] = 01;
                message[1] = 05;
                message[2] = (byte)(_startAddr05 >> 8);
                message[3] = (byte)(_startAddr05);
                message[4] = 0xFF;
                message[5] = 0x00;
                crcCalculator(message, ref CRC);
                message[6] = CRC[0];
                message[7] = CRC[1];

                port.Write(message, 0, message.Length); //Send frame
                Thread.Sleep(50);
                byte[] buffRec2 = new byte[port.BytesToRead];
                int numberOfBytes2 = port.Read(buffRec2, 0, buffRec2.Length);

                if (buffRec2[4] == 0xFF)
                {
                   ptcLed.Image = Image.FromFile(@"D:\BackUp\ThayAu\SCADA\SCADA\SCADA\Resources\turnon.jpg");
                }

            }
            port.DiscardInBuffer();
            timer1.Stop();
            timer2.Start();

        }
  

        private void timer2_Tick(object sender, EventArgs e)
        {

            byte[] message = new byte[8];
            byte[] CRC = new byte[2];

            // ma ham 04 doc tin hieu analog chan A0

            byte _startAddr04 = 0;
            byte _registerQty04 = 1;

            message[0] = 02;
            message[1] = 04;
            message[2] = (byte)(_startAddr04 >> 8);
            message[3] = (byte)(_startAddr04);
            message[4] = (byte)(_registerQty04 >> 8);
            message[5] = (byte)(_registerQty04);
            crcCalculator(message, ref CRC);
            message[6] = CRC[0];
            message[7] = CRC[1];

            port.Write(message, 0, message.Length); //Send frame
            Thread.Sleep(50);
            byte[] buffRec1 = new byte[port.BytesToRead];
            int numberOfBytes1 = port.Read(buffRec1, 0, buffRec1.Length);

            string data = string.Empty;

            data = buffRec1[3].ToString();
            ushort temp11 = ushort.Parse(data);
            data = buffRec1[4].ToString();
            ushort temp22 = ushort.Parse(data);

            ushort temp1 = (ushort)(temp11 << 8);
            ushort temp2 = (ushort)(temp22);

            ushort temp = (ushort)(temp1 | temp2);
            temp &= 0xFFFF;

            float voltage = temp * 5000 / 1024;
            float nhietdo = voltage / 10;
           // txtNhietdo.Text = nhietdo.ToString();
            nHIETDOTextBox.Text = nhietdo.ToString();
            label2.Text = nHIETDOTextBox.Text + "*C";
            if (nhietdo > 20)
            {
                cOITextBox.Text = "BẬT";
            }

            else cOITextBox.Text = "TẮT";

            string recMsg = string.Empty;

            foreach (var item in buffRec1)
            {
                recMsg += string.Format("{0:X2}", item);
            }
        //    kq.Text = recMsg;


            if (nhietdo > 25) //bat chuong bao dong
            {
                byte _startAddr06 = 10;
               // byte _registerQty06 = 1;

                message[0] = 02;
                message[1] = 06;
                message[2] = (byte)(_startAddr06 >> 8);
                message[3] = (byte)(_startAddr06);
                message[4] = (byte)(0);
                message[5] = (byte)(50);
                crcCalculator(message, ref CRC);
                message[6] = CRC[0];
                message[7] = CRC[1];

                port.Write(message, 0, message.Length); //Send frame
                Thread.Sleep(50);



                ptcBuzzer.Image = Image.FromFile(@"D:\BackUp\ThayAu\SCADA\SCADA\SCADA\Resources\ring.jpg");

            }
            else //khong bat chuong bao dong
            {
                byte _startAddr06 = 10;
               // byte _registerQty06 = 50;

                message[0] = 02;
                message[1] = 06;
                message[2] = (byte)(_startAddr06 >> 8);
                message[3] = (byte)(_startAddr06);
                message[4] = (byte)(0);
                message[5] = (byte)(0);
                crcCalculator(message, ref CRC);
                message[6] = CRC[0];
                message[7] = CRC[1];

                port.Write(message, 0, message.Length); //Send frame
                Thread.Sleep(50);

               ptcBuzzer.Image = Image.FromFile(@"D:\BackUp\ThayAu\SCADA\SCADA\SCADA\Resources\silent.jpg");
            }
            //txb1.Text = buffRec1[4].ToString();
            //txb2.Text = tempx.ToString();

            port.DiscardInBuffer();
            
            timer2.Stop();
            DateTime DATE = DateTime.Now;
            nGAYTextBox.Text = DATE.ToShortDateString();
            

            //this.Validate();
            //this.scadaBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.database1DataSet1);
            timer3.Start();
            kt = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (kt == true)
            {
                timer1.Stop();
                timer2.Stop();
                port.DiscardInBuffer();
                this.Validate();
                this.scadaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database1DataSet1);
            }
            else 
                return;
          //  timer3.Stop();
        }

        private void scadaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scadaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Scada' table. You can move, or remove it, as needed.
            this.scadaTableAdapter.Fill(this.database1DataSet1.Scada);

        }

      

        private void timer3_Tick(object sender, EventArgs e)
        {
           // timer1.Stop();
           // timer2.Stop();
           // this.Validate();
           // this.scadaBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.database1DataSet1);
           
            this.scadaBindingSource.AddNew();
            timer3.Stop();
            kt = true;
            timer1.Start();
        }

        private void nGAYToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.scadaTableAdapter.SEARCH(this.database1DataSet1.Scada, textBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
