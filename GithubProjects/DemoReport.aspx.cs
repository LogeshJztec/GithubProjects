using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DemoReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }

    public void bind()
    {

        try
        {

            DataTable table = new DataTable();
            table.Columns.Add("rating", typeof(string));
            table.Columns.Add("rcount", typeof(string));
            table.Columns.Add("percentage", typeof(string));

            table.Rows.Add("Complied", "1", "20");
            table.Rows.Add("In Progress", "2", "20");
            table.Rows.Add("Not Complied", "4", "60");

            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/DemoReport.rdlc");

            ReportDataSource rds1 = new ReportDataSource("DataSet1", table);
            ReportViewer1.LocalReport.DataSources.Add(rds1);

            ReportViewer1.LocalReport.Refresh();

        }
        catch (Exception ex)
        {
            

        }




    }
}