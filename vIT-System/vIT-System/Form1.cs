using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace vIT_System{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
            using (var test = new vITsEntities1()){
                
            }
        }

        SqlConnection connection = new SqlConnection(@"Data Source=STAIS3R\SQLEXPRESS;Initial Catalog=vITs;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e){

            //connection.Open();
            //using (SqlCommand command = new SqlCommand("Select * from Ansokan", connection))
            //{
             InitializeComponent();
    
    }
                
            }

        }


    }
}