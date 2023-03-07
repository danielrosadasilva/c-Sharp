using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace componets
{
    public partial class DateTimePicker : Form
    {
        public DateTimePicker()
        {
            InitializeComponent();
        }

        private void btn_obterData_Click(object sender, EventArgs e)
        {
            tb_obterData.Text=dateTimePicker1.Text;
            tb_dia.Text=dateTimePicker1.Value.Day.ToString();
            tb_mes.Text=dateTimePicker1.Value.Month.ToString();
            tb_ano.Text=dateTimePicker1.Value.Year.ToString();
        }

        private void btn_alterarData_Click(object sender, EventArgs e)
        {
            try
            {
                int d, m, a;
                d = int.Parse(tb_dia.Text);
                m = int.Parse(tb_mes.Text);
                a = int.Parse(tb_ano.Text);
                dateTimePicker1.Value.AddDays(d);
                dateTimePicker1.Value.AddMonths(m);
                dateTimePicker1.Value.AddYears(a);
                DateTime dateTime = new DateTime(a, m, d);
                dateTimePicker1.Value = dateTime;
            } catch (Exception excessao){
               MessageBox.Show("Erro "+excessao.Message);

            }
            
           
        }
    }
}
