using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bankapplibrary;

namespace bankapp
{
    public partial class Form1 : Form
    {
        Bank A = new Bank();
        public void update()
        {
            banksum.Text = Convert.ToString(A.sum);
            int ind = clients.SelectedIndex;
            if (ind == -1) { ind = 0; }
            id.Text = A.list[ind].id;
            money.Text = Convert.ToString(A.list[ind].banksum);
            name.Text = A.list[ind].name;
            deposits.Items.Clear();
            credits.Items.Clear();
            for (int i = 0; i < A.list[ind].credits.Count; i++)
            {
                credits.Items.Add("Сумма:" + Convert.ToString(A.list[ind].credits[i].sum + ", дата:" + A.list[ind].credits[i].date + ", процент:" + A.list[ind].credits[i].percent+"%"));
            }
            for (int i = 0; i < A.list[ind].deposits.Count; i++)
            {
                deposits.Items.Add("Сумма:" + Convert.ToString(A.list[ind].deposits[i].sum + ", дата:" + A.list[ind].deposits[i].date + ", процент:" + A.list[ind].deposits[i].percent + "%"));
            }
        }

        public Form1()
        {
            InitializeComponent();
            banksum.Text = Convert.ToString(A.sum);
            for(int i = 0; i < A.list.Count; i++)
            {
               clients.Items.Add( A.list[i].name);
            }
            for(int i = 0; i < A.percents.Count; i++)
            {
                percents.Items.Add(A.percents[i]);
            }
        }

        private void skipday_Click(object sender, EventArgs e)
        {
            monthCalendar1.TodayDate = monthCalendar1.TodayDate.AddDays(1);
            foreach (Client b in A.list)
            {
                foreach (Credit d in b.credits)
                {
                    if((monthCalendar1.TodayDate - d.lastdate).TotalDays >= 30)
                    {
                        int months = (int)(monthCalendar1.TodayDate - d.date).TotalDays / 30;
                        d.sum = (d.percent / 100 +1)*d.sum;
                       // d.sum = 0;
                        d.lastdate = monthCalendar1.TodayDate;
                        update();
                    }
                }
                foreach (Deposit d in b.deposits)
                {
                    if ((monthCalendar1.TodayDate - d.lastdate).TotalDays >= 30)
                    {
                        int months = (int)(monthCalendar1.TodayDate - d.date).TotalDays / 30;
                        d.sum = (d.percent / 100 +1) * d.sum;
                        //d.sum = 0;
                        d.lastdate = monthCalendar1.TodayDate;
                        update();
                    }
                }
            }
        }

        private void skipmonth_Click(object sender, EventArgs e)
        {

            monthCalendar1.TodayDate = monthCalendar1.TodayDate.AddDays(30);
            foreach (Client b in A.list)
            {
                foreach (Credit d in b.credits)
                {
                    if ((monthCalendar1.TodayDate - d.lastdate).TotalDays >= 30)
                    {
                        int months = (int)(monthCalendar1.TodayDate - d.date).TotalDays / 30;
                        d.sum = (d.percent / 100 + 1) * d.sum;
                        // d.sum = 0;
                        d.lastdate = monthCalendar1.TodayDate;
                        update();
                    }
                }
                foreach (Deposit d in b.deposits)
                {
                    if ((monthCalendar1.TodayDate - d.lastdate).TotalDays >= 30)
                    {
                        int months = (int)(monthCalendar1.TodayDate - d.date).TotalDays / 30;
                        d.sum = (d.percent / 100 + 1) * d.sum;
                        // d.sum = 0;
                        d.lastdate = monthCalendar1.TodayDate;
                        update();
                    }
                }
            }
        }

        private void clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if(creditdeposit.SelectedIndex == 0)
            {
               
                if (A.sum >= Convert.ToSingle(summ.Text))
                {
                    A.list[clients.SelectedIndex].addcredit(Convert.ToSingle(summ.Text), Convert.ToSingle(percents.SelectedItem), monthCalendar1.TodayDate);
                    A.sum -= Convert.ToSingle(summ.Text);
                    A.list[clients.SelectedIndex].addsum(Convert.ToSingle(summ.Text));
                }
            }
            if (creditdeposit.SelectedIndex == 1)
            {
                if (A.list[clients.SelectedIndex].banksum >= Convert.ToSingle(summ.Text))
                {
                    A.list[clients.SelectedIndex].adddeposit(Convert.ToSingle(summ.Text), Convert.ToSingle(percents.SelectedItem), monthCalendar1.TodayDate);
                    A.sum += Convert.ToSingle(summ.Text);
                    A.list[clients.SelectedIndex].removesum(Convert.ToSingle(summ.Text));
                }
            }
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user Client = new user (A.list[clients.SelectedIndex], clients.SelectedIndex, this, A);
            Client.Show();
        }

        private void creditors_Click(object sender, EventArgs e)
        {
            //var k = from A in A. select A ;
            List <Client> d = (from U in A.list where U.isDuty() == true select U).ToList<Client>();
            clients.Items.Clear();
            for (int i = 0; i < d.Count; i++)
            {
                clients.Items.Add(d[i].name);
            }
            for(int i = 0; i<d.Count; i++)
            {
                Client temp = A.list[i];
                A.list[i] = d[i];
                A.Add(temp);
            }
            A.list = A.list.Distinct().ToList<Client>();
        }

        private void sort_Click(object sender, EventArgs e)
        {
            A.list = (from U in A.list orderby U.allDeposit() descending select U).ToList<Client>();
            clients.Items.Clear();
            for (int i = 0; i < A.list.Count; i++)
            {
                clients.Items.Add(A.list[i].name);
            }
            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A.list = (from U in A.list orderby U.allDuty() descending select U).ToList<Client>();
            clients.Items.Clear();
            for (int i = 0; i < A.list.Count; i++)
            {
                clients.Items.Add(A.list[i].name);
            }
            update();
        }

        private void all_Click(object sender, EventArgs e)
        {
            A.list = (from U in A.list orderby U.banksum descending select U).ToList<Client>();
            clients.Items.Clear();
            for (int i = 0; i < A.list.Count; i++)
            {
                clients.Items.Add(A.list[i].name);
            }
            update();
        }
    }
}
