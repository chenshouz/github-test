using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACTMULTILib;

namespace ReadPLC
{
    public partial class Form1 : Form
    {
        private ACTMULTILib.ActEasyIF plcobject;
        public Form1()
        {
            InitializeComponent();
            plcobject = new ACTMULTILib.ActEasyIF();
            plcobject.ActLogicalStationNumber = 1;//workstation name

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           if (plcobject.Open() == 0)
            {
                //read
                Int16[] Ary = new short[10];
                //Stopwatch sw = new Stopwatch();//計算時間
                //sw.Restart();//開始計時
                int result = plcobject.ReadDeviceBlock2("B50", 10, out Ary[0]);//讀取陣列值
                string bit = Convert.ToString(Ary[0], 2).PadLeft(16,'0');//轉換為2進位
               // plcobject.GetDevice2("B0", out Ary[0]);//讀取1個點位

                //write
                Ary[0] = 1024;//更改整排陣
                plcobject.WriteDeviceBlock2("B50", 10, ref Ary[0]);
                //plcobject.SetDevice2("B50", 8);//更改B0的位址為1

                //sw.Stop();//結束計時
                //Console.WriteLine("waste time =" + sw.ElapsedMilliseconds.ToString());
                //MessageBox.Show("waste time =" + sw.ElapsedMilliseconds.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Int16[] Ary = new short[10];
            //Stopwatch sw = new Stopwatch();//計算時間
            //sw.Restart();//開始計時
            int result = plcobject.ReadDeviceBlock2("B50", 10, out Ary[0]);//讀取陣列值
            string bit = Convert.ToString(Ary[0], 2).PadLeft(16, '0');//轉換為2進位
                                                                      // plcobject.GetDevice2("B0", out Ary[0]);//讀取1個點位

            //write
            Ary[0] = 1024;//更改整排陣
            plcobject.WriteDeviceBlock2("B50", 10, ref Ary[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int16[] Ary = new short[10];
            //Stopwatch sw = new Stopwatch();//計算時間
            //sw.Restart();//開始計時
            int result = plcobject.ReadDeviceBlock2("B50", 10, out Ary[0]);//讀取陣列值
            string bit = Convert.ToString(Ary[0], 2).PadLeft(16, '0');//轉換為2進位
                                                                      // plcobject.GetDevice2("B0", out Ary[0]);//讀取1個點位

            //write
            Ary[0] = 2048;//更改整排陣
            plcobject.WriteDeviceBlock2("B50", 10, ref Ary[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int16[] Ary = new short[10];
            //Stopwatch sw = new Stopwatch();//計算時間
            //sw.Restart();//開始計時
            int result = plcobject.ReadDeviceBlock2("B50", 10, out Ary[0]);//讀取陣列值
            string bit = Convert.ToString(Ary[0], 2).PadLeft(16, '0');//轉換為2進位
                                                                      // plcobject.GetDevice2("B0", out Ary[0]);//讀取1個點位

            //write
            Ary[0] = 3072;//更改整排陣
            plcobject.WriteDeviceBlock2("B50", 10, ref Ary[0]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Int16[] Ary = new short[10];
            //Stopwatch sw = new Stopwatch();//計算時間
            //sw.Restart();//開始計時
            int result = plcobject.ReadDeviceBlock2("B50", 10, out Ary[0]);//讀取陣列值
            string bit = Convert.ToString(Ary[0], 2).PadLeft(16, '0');//轉換為2進位
                                                                      // plcobject.GetDevice2("B0", out Ary[0]);//讀取1個點位

            //write
            Ary[0] = 4096;//更改整排陣
            plcobject.WriteDeviceBlock2("B50", 10, ref Ary[0]);
        }
    }
}
