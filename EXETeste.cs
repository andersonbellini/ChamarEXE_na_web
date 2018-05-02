using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace prog
{
    public partial class EXETeste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Process process = new Process();

            process.StartInfo.FileName = "\\\C:\\Bellini\\ExeFile.exe";  // Pode ser o caminho do servidor, Será executado no servidor!
            string dados = "";
            dados = TextBox1.Text + " " + TextBox2.Text + " " + TextBox3.Text;

            process.StartInfo.Arguments = dados;
            process.Start();
            process.Close();
            
            try
            {
                lblResultado.Text = Convert.ToString(Convert.ToInt64(Convert.ToInt64(TextBox1.Text) + Convert.ToInt64(TextBox2.Text) + Convert.ToInt64(TextBox3.Text)));
            }
            catch (Exception)
            {
               lblResultado.Text = "SEM PARÂMETRO";
            }
        
        }
    }
}
