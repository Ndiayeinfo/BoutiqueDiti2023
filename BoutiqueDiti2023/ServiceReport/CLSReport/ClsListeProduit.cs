using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

namespace ServiceReport.CLSReport
{
    public class ClsListeProduit
    {
        ServiceMetier.Service1Client metier=new ServiceMetier.Service1Client();
        public DataTable GetTableListeProduit()
        {
            DataTable table = new DataTable();
            table.Columns.Add("NomProduit", typeof(string));
            table.Columns.Add("CategorieProduit", typeof(string));
            table.Columns.Add("Quantite", typeof(float));
            table.Columns.Add("PrixUnitaire", typeof(double));
            table.Columns.Add("DatePeremption", typeof(DateTime));

            var liste = metier.getListeProduit();
            
            foreach(var i in liste)
            {
                table.Rows.Add(i.NameProduit, "", i.QteMinimal, i.PriceProduit, "");
            }
            
            return table;
        }


        public byte[] FileListeProduit()
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt
= new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            try
            {
                rpt.Load("~/Report/rptListeProduit.rpt");
                rpt.SetDataSource(GetTableListeProduit());
                Stream stream =
                rpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                var taille = stream.Length - 1;
                byte[] buffer = new byte[taille];
                using (MemoryStream ms = new MemoryStream())
                {
                    int read;
                    while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ms.Write(buffer, 0, read);
                    }
                    return ms.ToArray();
                }
            }
            finally
            {
                rpt.Dispose();
                rpt.Close();
            }
        }
    }
}