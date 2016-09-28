using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SortMethod
{
    public partial class Form1 : Form
    {
        int Max = 20;
        List<int> BubbleValue = new List<int>();

        //冒泡排序(bubble sort)
        //插入排序(insertion sort)
        //归并排序(merge sort)
        //桶排序(bucket sort)
        //基数排序(Radix sort)
        //二叉树排序(Binary tree sort)
        //选择排序(selection sort)
        //希尔排序(shell sort)
        //堆排序(heapsort)
        //快速排序(quicksort)



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < Max+1; i++)
            {
                BubbleCountList.Items.Add(i);
            }
            BubbleCountList.SelectedIndex = 10;


            SortMethodList.Items.Add("冒泡排序");
            SortMethodList.Items.Add("插入排序");
            SortMethodList.Items.Add("归并排序");
            SortMethodList.Items.Add("桶排序");
            SortMethodList.Items.Add("基数排序");
            SortMethodList.Items.Add("二叉树排序");
            SortMethodList.Items.Add("选择排序");
            SortMethodList.Items.Add("希尔排序");
            SortMethodList.Items.Add("堆排序");
            SortMethodList.Items.Add("快速排序");

            SortStyleList.Items.Add("顺序执行");
            SortStyleList.Items.Add("单步执行");
        }

        private void BubbleCountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Max+1; i++)
            {
                Button BubbleBtn = this.Controls["Bubble" + i.ToString()] as Button;
                if (BubbleBtn != null)
                    this.Controls.Remove(BubbleBtn);
            }

            for (int i = 0; i < BubbleCountList.SelectedIndex+1; i++)
            {
                Button BubbleBtn = new Button();
                BubbleBtn.Name = "Bubble" + i.ToString();
                BubbleBtn.Text = "Bubble" + i.ToString();
                BubbleBtn.Size = new Size(50,50);
                BubbleBtn.Location = new Point(20 + i * 50, 70);
                this.Controls.Add(BubbleBtn);
            }
        }

        private void CreateRandomBtn_Click(object sender, EventArgs e)
        {
            BubbleValue.Clear();
            for (int i = 0; i < BubbleCountList.SelectedIndex + 1; i++)
            {
                Button BubbleBtn = this.Controls["Bubble" + i.ToString()] as Button;
                BubbleBtn.Text = GetRandomNum();
                BubbleValue.Add(Convert.ToInt32(BubbleBtn.Text));
            }
        }

        private string GetRandomNum()
        {
            string SrcString = Guid.NewGuid().ToString("N");
            string DigitString = "";
            for (int i = 0; i < SrcString.Length - 1; i++)
            {
                if (char.IsNumber(SrcString, i))
                {
                    DigitString += SrcString[i];
                }
                if (DigitString.Length == 3)
                {
                    break;
                }
            }
            return DigitString;
        }
    }
}
