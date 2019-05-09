using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACTETHERLib;

namespace PLCConn
{
    public partial class mitsuPLC : Form
    {
        public mitsuPLC()
        {
            InitializeComponent();


            //CPU TYPE COMBOBOX
            comboBoxCPUType.DisplayMember = "Text";
            comboBoxCPUType.ValueMember = "Value";

            var items = new[] {
                    new { Text = "A0J2H", Value = "258" },
                    new { Text = "A1FX", Value = "259" },
                    new { Text = "A1S,A1SJ", Value = "260" },
                    new { Text = "A1(N)", Value = "261" },
                    new { Text = "A2C,A2CJ", Value = "263" },
                    new { Text = "A2(N),A2S", Value = "264" },
                    new { Text = "A2SH", Value = "265" },
                    new { Text = "A3(N)", Value = "266" },
                    new { Text = "A2A", Value = "268" },
                    new { Text = "A3A", Value = "269" },
                    new { Text = "A2U,A2US,A2AS", Value = "270" },
                    new { Text = "A2USHS1", Value = "271" },
                    new { Text = "A3U,A2AS-S30/S60", Value = "272" },
                    new { Text = "A4U", Value = "273" },
                    new { Text = "Q2A", Value = "17" },
                    new { Text = "Q2AS1", Value = "18" },
                    new { Text = "Q3A", Value = "19" },
                    new { Text = "Q4A", Value = "20" },
                    new { Text = "FX0,FX0S", Value = "513" },
                    new { Text = "FX0N", Value = "514" },
                    new { Text = "FX1", Value = "515" },
                    new { Text = "FX1S", Value = "518" },
                    new { Text = "FX1N", Value = "519" },
                    new { Text = "FX2,FX2C", Value = "516" },
                    new { Text = "FX2N,FX2NC", Value = "517" },
                    new { Text = "FX3G", Value = "521" },
                    new { Text = "FX3UC", Value = "520" },
                    new { Text = "A171SH", Value = "1537" },
                    new { Text = "A172SH", Value = "1538" },
                    new { Text = "A173UH", Value = "1540" },
                    new { Text = "A273UH", Value = "1539" },
                    new { Text = "Q00J", Value = "48" },
                    new { Text = "Q00UJ", Value = "128" },
                    new { Text = "Q00", Value = "49" },
                    new { Text = "Q00U", Value = "129" },
                    new { Text = "Q01", Value = "50" },
                    new { Text = "Q01U", Value = "130" },
                    new { Text = "Q02(H)", Value = "34" },
                    new { Text = "Q02PH", Value = "69" },
                    new { Text = "Q02U", Value = "131" },
                    new { Text = "Q03UD", Value = "112" },
                    new { Text = "Q03UDE", Value = "144" },
                    new { Text = "Q04UDH", Value = "113" },
                    new { Text = "Q04UDEH", Value = "145" },
                    new { Text = "Q06H", Value = "35" },
                    new { Text = "Q06PH", Value = "70" },
                    new { Text = "Q06UDH", Value = "114" },
                    new { Text = "Q06UDEH", Value = "146" },
                    new { Text = "Q10UDH", Value = "117" },
                    new { Text = "Q10UDEH", Value = "149" },
                    new { Text = "Q12H", Value = "36" },
                    new { Text = "Q12PH", Value = "65" },
                    new { Text = "Q12PRH", Value = "67" },
                    new { Text = "Q13UDH", Value = "115" },
                    new { Text = "Q13UDEH", Value = "147" },
                    new { Text = "Q20UDH", Value = "118" },
                    new { Text = "Q20UDEH", Value = "150" },
                    new { Text = "Q25H", Value = "37" },
                    new { Text = "Q25PH", Value = "66" },
                    new { Text = "Q25PRH", Value = "68" },
                    new { Text = "Q25SS", Value = "85" },
                    new { Text = "Q26UDH", Value = "116" },
                    new { Text = "Q26UDEH", Value = "148" },
                    new { Text = "Q02(H)Amode", Value = "321" },
                    new { Text = "Q06H Amode", Value = "322" },
                    new { Text = "QS001", Value = "96" },
                    new { Text = "Board", Value = "1025" }
                };

            comboBoxCPUType.DataSource = items;


        }

        public ActQNUDECPUUDP udpQ = new ActQNUDECPUUDP(); //in use only
       //public ActQNUDECPUTCP tcpQ = new ActQNUDECPUTCP(); 
       //public ActAJ71E71TCP tcpE7 = new ActAJ71E71TCP(); 
        public ActFXENETTCP tcpFX = new ActFXENETTCP(); 

     
        //CONNECT 
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxWriteValue.Text, out int portNo))
            {
                

                int ret;
                string cpuName;
                int cpuCode;
                if(portNo > 0) { tcpFX.ActDestinationPortNumber = portNo; }
                udpQ.ActHostAddress = textBoxIPAddress.Text;
                udpQ.ActCpuType = int.Parse((comboBoxCPUType.SelectedItem as dynamic).Value);
                ret = udpQ.FreeDeviceStatus();
                if (ret != 0) //not connected
                {

                    udpQ.Close(); //close connection if open first
                    ret = udpQ.Open();
                    if (ret == 0) //connected
                    {
                        udpQ.GetCpuType(out cpuName, out cpuCode);
                        OutResult("Success, connected to:  " + cpuName + " " + cpuCode+ "  " );

                    }
                    else
                    {
                        OutResult("PLC err: " + ret);
                    }

                }
                else
                {
                    OutResult("Already connected");
                }
            }
            else
                OutResult("Port # must be an intiger - 0 for none.");

            }

        //DISCONNECT 
        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            int ret = udpQ.Close(); //close connection if open first
            if (ret == 0) //connected
            {

                OutResult("Success, disconnected");

            }
            else
            {
                OutResult("PLC err: " + ret);
            }
        }

        //WRITE SINGLE 
        private void BtnWriteSingle_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBoxWriteValue.Text, out int userVal))
            {
                int ret = udpQ.SetDevice(textBoxWriteTo.Text, userVal);
                if (ret == 0) //OK
                    OutResult("Set device OK");

                else
                    OutResult("PLC err: " + ret);

            }
            else
            OutResult("Enter a number [int only]"); 


        }

        //WRITE BLOCK 
        private void BtnWriteBlock_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBoxWriteValue.Text, out int userVal) && int.TryParse(textBoxWriteBlockSize.Text, out int blockSize) && int.TryParse(textBoxWriteInc.Text, out int inc))
            {

                int[] data = new int[blockSize+1];

                    for (int i = 0; i < data.Length; i++)
                    {

                        data[i] = userVal;

                       userVal += inc;
                    }
                

                int ret = udpQ.WriteDeviceBlock(textBoxWriteTo.Text, blockSize, ref data[blockSize]);
                if (ret == 0) //OK
                    OutResult("Set device block OK");

                else
                    OutResult("PLC err: " + ret);

            }
            else
             OutResult("Enter a number [int only]"); 
        }

        //READ SINGLE 
        private void BtnReadSingle_Click(object sender, EventArgs e)
        {
            int ret = udpQ.GetDevice(textBoxReadFrom.Text, out int gotDevice);
            if (ret == 0) //OK
                OutResult("Read single OK: " + gotDevice);

            else
                OutResult("PLC err: " + ret);
        }

        //READ BLOCK 
        private void BtnReadBlock_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxReadBlock.Text, out int blockSize))
            {

                int[] data = new int[blockSize + 1];
                int ret = udpQ.ReadDeviceBlock(textBoxReadFrom.Text, blockSize, out data[blockSize]);
                if (ret == 0) //OK
                    OutResult("Read block OK: " + string.Join(",", data));

                else
                    OutResult("PLC err: " + ret);
                }
            else
                OutResult("Enter a number [int only]");
        }


        //LOG OUTPUT
        private void OutResult(string ret)
        {
            CheckForIllegalCrossThreadCalls = false;
            StringBuilder output = new StringBuilder();

            Invoke(new Action(() =>
            {
                if (textBoxLogs.Lines.Length > 20)
                {

                    output.Append(textBoxLogs.Text);
                    output.Append(ret);
                    output.Append(Environment.NewLine);
                    textBoxLogs.Text = output.ToString();
                    textBoxLogs.Lines = textBoxLogs.Lines.Skip(1).ToArray();
                }
                else
                {
                    output.Append(textBoxLogs.Text);
                    output.Append(ret);
                    output.Append(Environment.NewLine);
                    textBoxLogs.Text = output.ToString();
                }
            }));


        }

        //CLEAR LOG
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBoxLogs.Text = "";
        }


    }
}
