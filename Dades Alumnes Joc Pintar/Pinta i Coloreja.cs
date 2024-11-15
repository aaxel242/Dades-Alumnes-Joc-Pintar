using System;
using System.Data;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Dades_Alumnes_Joc_Pintar
{
    public partial class formJocPintar : Form

    {
        private PictureBox pictureBox;
        private string filePath;
        private bool mostrarImagen = true;


        public formJocPintar()
        {
            InitializeComponent();

        }

        private void btnAfegirFila_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Siusplau, obre un arxiu.");
                return;
            }

            try
            {
                DataTable taula = (DataTable)panelJSON.DataSource;
                DataRow fila = taula.NewRow();
                taula.Rows.Add(fila);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al afegir una fila: " + ex.Message);
            }
        }

        private void btnEliminarFila_Click(object sender, EventArgs e)
        {
            if (panelJSON.DataSource == null)
            {
                MessageBox.Show("Siusplau, obre un arxiu.");
                return;
            }

            if (panelJSON.SelectedRows.Count > 0)
            {
                try
                {
                    DataTable dataTable = (DataTable)panelJSON.DataSource;

                    foreach (DataGridViewRow row in panelJSON.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            dataTable.Rows.RemoveAt(row.Index);
                        }
                    }

                    panelJSON.DataSource = null;
                    panelJSON.DataSource = dataTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar. " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila.");
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Siusplau, obre un arxiu.");
                return;
            }

            try
            {
                DataTable json = (DataTable)panelJSON.DataSource;

                JArray jsonArray = new JArray();

                foreach (DataRow fila in json.Rows)
                {
                    JObject obj = new JObject();

                    foreach (DataColumn columna in json.Columns)
                    {
                        obj[columna.ColumnName] = JToken.FromObject(fila[columna]);
                    }
                    jsonArray.Add(obj);
                }

                string archivoAJSON = jsonArray.ToString();

                File.WriteAllText(filePath, archivoAJSON);

                MessageBox.Show("L'arxiu s'ha guardat correctament.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar l'arxiu: " + ex.Message);
            }
        }

        private void btnObrirArxiu_Click(object sender, EventArgs e)
        {




            if (panelJSON.Columns.Contains("imagenColumna"))
            {
                panelJSON.Columns.Remove("imagenColumna");
            }

            foreach (DataGridViewRow row in panelJSON.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells["imagenColumna"].Value = null;
                }
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos JSON (*.json)|*.json";
            openFileDialog.Title = "Selecciona l'arxiu";
            string descarrgues = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            openFileDialog.InitialDirectory = descarrgues;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                try
                {
                    string fileJson = File.ReadAllText(filePath);
                    JArray jsonArray = JArray.Parse(fileJson);
                    DataTable dataTable = new DataTable();

                    foreach (JObject obj in jsonArray)
                    {
                        foreach (JProperty property in obj.Properties())
                        {
                            if (!dataTable.Columns.Contains(property.Name))
                            {
                                dataTable.Columns.Add(property.Name);
                            }
                        }
                    }

                    foreach (JObject obj in jsonArray)
                    {
                        DataRow row = dataTable.NewRow();
                        foreach (JProperty property in obj.Properties())
                        {
                            row[property.Name] = property.Value;
                        }
                        dataTable.Rows.Add(row);
                    }

                    panelJSON.DataSource = dataTable;

                    mostrarImagen = false;
                    panelJSON.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo: " + ex.Message);
                }
            }
        }


        private void btnSortir_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void formJocPintar_Click(object sender, EventArgs e)
        {

        }


       // private void panelJSON_Paint(object sender, PaintEventArgs e)
        //{
         //   if (mostrarImagen && Properties.Resources.imgAfegir != null)
          //  {
           //     e.Graphics.DrawImage(Properties.Resources.imgAfegir, new Point(100, 10));
            //}
    //        }

       
    }
}
