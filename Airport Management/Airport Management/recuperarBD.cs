using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airport_Management.Clases;

namespace Airport_Management
{
    public partial class recuperarBD : Form
    {
        
        DataSet ds = new DataSet();
        public recuperarBD()
        {
            InitializeComponent();
        }

        private void recuperarBD_Load(object sender, EventArgs e)
        {
            AccesoDatos ad = new AccesoDatos();
            ad.IniciarTabla("select fecha_bkp as fecha, direccion_bkp as direccion from backups", "bk", ref ds, ref grd_backups);
            grd_backups.AutoResizeColumns();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarConsulta( "USE master SET NOCOUNT ON DECLARE @DBName varchar(50) DECLARE @spidstr varchar(8000) DECLARE @ConnKilled smallint SET @ConnKilled=0 SET @spidstr = '' Set @DBName = 'DATABASE_NAME_HERE' IF db_id(@DBName) < 4 BEGIN PRINT 'Connections to system databases cannot be killed' RETURN END SELECT @spidstr=coalesce(@spidstr,',' )+'kill '+convert(varchar, spid)+ '; ' FROM master..sysprocesses WHERE dbid=db_id(@DBName) IF LEN(@spidstr) > 0 BEGIN EXEC(@spidstr) SELECT @ConnKilled = COUNT(1) FROM master..sysprocesses WHERE dbid=db_id(@DBName) END" );
            
            string consultaSQL = "USE master RESTORE DATABASE Airport_Manager FROM  DISK = '" + grd_backups.CurrentRow.Cells["direccion"].Value +"'";
            ad.rutaMaster();
            ad.EjecutarConsulta(consultaSQL);
            MessageBox.Show("Se ha recuperado la Base de datos");
            ad.rutaAirportManager();
            this.Close();
        }
    }
}
