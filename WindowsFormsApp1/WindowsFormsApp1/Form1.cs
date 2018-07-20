using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet.student' 資料表。您可以視需要進行移動或移除。
            this.studentTableAdapter.Fill(this.database1DataSet.student);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.studentTableAdapter.Update(this.database1DataSet.student);

        }
    }
}
