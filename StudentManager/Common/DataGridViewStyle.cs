using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace StudentManager
{

    public class DataGridViewStyle
    {      
              
        public void DgvStyle1(DataGridView dgv)
        {
          
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         
            dgv.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dgv.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dgv.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
          
            dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
        
            dgv.ColumnHeadersHeight = 30;

        }

        public void DgvStyle2(DataGridView dgv)
        {
       
        
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
      
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dgv.ColumnHeadersHeight = 28;
      
            dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //this.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            //this.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            dgv.RowTemplate.DividerHeight = 1;
         
            dgv.EnableHeadersVisualStyles = false;

        }
       
        public void DgvStyle3(DataGridView dgv)
        {
      
            dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
      
            dgv.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Black;
      
            dgv.GridColor = System.Drawing.Color.Red;
  
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         
            dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         
            dgv.EnableHeadersVisualStyles = false;
         
            dgv.ColumnHeadersHeight = 35;

            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
      
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
           
            int RowsCount = dgv.Columns.Count;
            for (int i = 0; i < RowsCount; i++)
            {
                dgv.Columns[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Yellow;
            }
        }

    
        public static void DgvRowPostPaint(DataGridView dgv, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
             
                SolidBrush v_SolidBrush = new SolidBrush(dgv.RowHeadersDefaultCellStyle.ForeColor);
                int v_LineNo = 0;
                v_LineNo = e.RowIndex + 1;
                string v_Line = v_LineNo.ToString();
                e.Graphics.DrawString(v_Line, e.InheritedRowStyle.Font, v_SolidBrush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 5);
            }
            catch (Exception ex)
            {
                MessageBox.Show("add row line number " + ex.Message, "error");
            }
        }

    }
}
