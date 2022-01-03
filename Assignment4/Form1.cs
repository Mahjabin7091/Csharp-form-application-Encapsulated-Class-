/*Author: Mahjabin Sajadi*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        string recordBeforeClear = "";
        public Form1()
        {
            InitializeComponent();
        }
        /****************Form load*******************/
        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadLoadListBox();
        }
        private void ReloadLoadListBox(string key = "")
        {
            List<ServiceSA> SN = ServiceSA.SAGetByStockName();
            SN = SN.OrderBy(p => p.ServiceName).ToList();
            lbShowResult.DisplayMember = "Service Name";
            lbShowResult.ValueMember = "ServiceName";
            lbShowResult.DataSource = SN;

            if (key != "")
            {
                lbShowResult.SelectedValue = key;
            }

        }

        /**************Close button****************/
        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        /*******************Cancel button***********/
        private void btnCancel_Click(object sender, EventArgs e)
        {

            //if (recordBeforeClear != "")
            //{
            //    lblError.Text = recordBeforeClear;
            //    lblError.ForeColor = Color.Red;
            //}
            //else
            //{
            //    lblError.Text = "Cancelled Successfully .../ previous record added ";
            //    lblError.ForeColor = Color.Green;
            //    ReloadLoadListBox();
            //}
            string[] fields = recordBeforeClear.Split('\t'); 
            txtNameSaleService.Text= fields[0];
             txtPrice.Text= fields[1];
            txtMinutes.Text= fields[2];

        }
        /*******************Clear Inputs button***********/  
        private void btnClearInput_Click(object sender, EventArgs e)
        {
            ServiceSA SrvClear = new ServiceSA(txtNameSaleService.Text, txtPrice.Text, txtMinutes.Text);
            SrvClear.IsProcedure = checkBox1.Checked;
            //recordBeforeClear = SrvClear.insert();
            recordBeforeClear = "";

            recordBeforeClear += txtNameSaleService.Text+"\t";
                txtNameSaleService.Clear();
            recordBeforeClear += txtPrice.Text + "\t";
                txtPrice.Clear();
            recordBeforeClear += txtMinutes.Text + "\t";
                txtMinutes.Clear();

        }
        /*******************Save button***********/
        private void btnSave_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            ServiceSA Srv = new ServiceSA(txtNameSaleService.Text, txtPrice.Text, txtMinutes.Text);

            
            Srv.IsProcedure = checkBox1.Checked;
            string results = Srv.insert();
           
             if (results.StartsWith("Warning"))
            {
                lblError.Text = results;
                lblError.ForeColor = Color.Blue;
                ReloadLoadListBox();

            }
            else if (results != "")
            {
                lblError.Text = results;
                lblError.ForeColor = Color.Red;
            }
            else
            {
                lblError.Text = "Saved Successfully .../ record added ";
                lblError.ForeColor = Color.Green;
                ReloadLoadListBox();
            }
        }
        private void PopulateForm(ServiceSA mainInfo)
        {
            lblError.Text = "";
            txtNameSaleService.Text = mainInfo.ServiceName;
            txtPrice.Text = mainInfo.Price.ToString();
            txtMinutes.Text = mainInfo.Minutes.ToString();

        }
        /*******************Delete button***********/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ServiceName = txtNameSaleService.Text;
            MessageBox.Show(ServiceName);
            ServiceSA.delete(ServiceName);
            ReloadLoadListBox();
        }

     

        private void lbShowResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbShowResult.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {

                string[] fields = lbShowResult.Items[index].ToString().Split('\t');
                txtNameSaleService.Text = fields[0];
                txtPrice.Text = fields[1];
                txtMinutes.Text = fields[2];

            }
        }
    }
}
