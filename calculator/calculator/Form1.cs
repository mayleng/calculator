using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double  temp1 = -1;
        int pos = 0;  //存储第一个数字
        
        /// <summary>
        /// 新建一个方法，添加数据
        /// </summary>
        /// <param name="num">button上的text</param>
        public void addNum(int num)
        {
           textBox1.Text = textBox1.Text + num.ToString();
            //textBox1.Text =  num.ToString();
            //继续了解属性相关，下面注释代码也能执行相同结果
            //源码可以实现123多个输输入

            //判断如果第一个字符是0去掉
            if (textBox1.Text.Length >=2)
            {
                if (textBox1.Text.Substring(0,1) == "0" && textBox1.Text.Substring(1, 1)!=".")
                {
                    textBox1.Text = textBox1.Text.Substring(1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNum(7); //在显示屏中添加数字
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addNum(8); //在显示屏中添加数字
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addNum(9); //在显示屏中添加数字
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addNum(4); //在显示屏中添加数字
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addNum(5); //在显示屏中添加数字
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addNum(6); //在显示屏中添加数字
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addNum(1); //在显示屏中添加数字
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addNum(2); //在显示屏中添加数字
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addNum(3); //在显示屏中添加数字
        }

        private void button13_Click(object sender, EventArgs e)
        {
            addNum(0); //在显示屏中添加数字
        }





       

        //乘法
        private void button8_Click(object sender, EventArgs e)
        {
            pos = 3;//修改计算标识符
            temp1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";//C#单双引号不可互用
        }

        //减法
        private void button12_Click(object sender, EventArgs e)
        {
            pos = 2;//修改计算标识符
            temp1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";//C#单双引号不可互用
        }

        //加法
        private void button16_Click(object sender, EventArgs e)
        {
            pos = 1;//修改计算标识符
            temp1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";//C#单双引号不可互用
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pos = 4;//修改计算标识符
            temp1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";//C#单双引号不可互用
        }

        //等号
        private void button15_Click(object sender, EventArgs e)
        {
            double  temp2 = Convert.ToDouble(textBox1.Text);
            switch(pos)
            {
                case 1:
                    textBox1.Text = (temp1 + temp2).ToString();
                    break;
                case 2:
                    textBox1.Text = (temp1 - temp2).ToString();
                    break;
                case 3:
                    textBox1.Text = (temp1 * temp2).ToString();
                    break;
                case 4:
                    textBox1.Text = (temp1 / temp2).ToString();
                    break;

            }

        }

        //归零
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            temp1 = 0;
            pos = 0;
        }

        //添加小数点
        private void button17_Click(object sender, EventArgs e)
        {
            //如果直接点击添加小数点，则添加0.
            if (textBox1.Text == "")
            {
                textBox1.Text = "0.";
            }
            //只能添加一个小数点
            else if (textBox1.Text.IndexOf(".") >= 0)
            {
                MessageBox.Show("已经添加了小数点！","提示");
            }

            //在显示框最后一位添加小数点
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }

            
        }
    }
}
