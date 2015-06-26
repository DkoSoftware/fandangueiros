using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dkosoftware.Fandangueiros.Helpers
{
    public class GridView
    {
        public enum TypeButton
        {
            Search
        }

        public delegate void EventEdit(object sender,EventArgs e);
        public delegate void EventDelete(object sender, DataGridViewCellEventArgs e);

        public void AddButtonInColumns(ref DataGridView dgv, TypeButton tb, EventEdit editEvent, EventDelete deleteEvent)
        {
            switch (tb)
            {
                case TypeButton.Search:

                    DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
                    editColumn.Text = "Editar";
                    editColumn.Name = "Editar";
                    editColumn.Width = 45;
                    editColumn.DataPropertyName = "btnDgvEdit";
                    dgv.Columns.Add(editColumn);
                    editColumn.DataGridView.CellContentClick += new DataGridViewCellEventHandler(editEvent);
                  
                    DataGridViewButtonColumn delColumn = new DataGridViewButtonColumn();
                    delColumn.Text = "Deletar";
                    delColumn.Name = "Deletar";
                    delColumn.Width = 45;
                    delColumn.DataPropertyName = "btnDgvEditDelete";
                    dgv.Columns.Add(delColumn);
                    delColumn.DataGridView.CellContentClick += new DataGridViewCellEventHandler(deleteEvent);


                    //image column 
                    //DataGridViewImageColumn img = new DataGridViewImageColumn();
                    //Image image = Image.FromFile(@"..\Resources\plus.png");
                    //img.Image = image;
                    //dgv.Columns.Add(img);
                    //img.HeaderText = "Image";
                    //img.Name = "img";

                    break;
            }
        }

        public virtual void btnDgvEdit_Click(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("btnEdit");
        }

        public void btnDgvDelete_Click(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("btnDelete");
        }
    }
}
