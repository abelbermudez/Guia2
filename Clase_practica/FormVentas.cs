using Clase_practica.Entindades;
using Clase_practica.Repositorios;
using Clase_practica.Servicios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clase_practica
{
    public partial class FormVentas : Form

    {
        private readonly Iventasrepository _ventaRepository;

        private readonly Ventaservice _ventaService;

        private List<ventas> _ventas;
        public FormVentas()
        {
            InitializeComponent();
            _ventaRepository = new VentaRepository();

            _ventaService = new Ventaservice();

            InitializeComponent();


        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            try

            {

                lblestado.Text = "Cargando ventas...";

                progressBar1.Style = ProgressBarStyle.Marquee;

                btnCargar.Enabled = false;

                btnprocesar.Enabled = false;



                _ventas = await _ventaRepository.ObtenerVentasAsync();



                dgvVentas.DataSource = null;

                dgvVentas.DataSource = _ventas;



                lblestado.Text = "Ventas cargadas correctamente.";

            }

            catch (Exception ex)

            {

                MessageBox.Show("Ocurrió un error al cargar ventas: " + ex.Message);

            }

            finally

            {

                progressBar1.Style = ProgressBarStyle.Blocks;

                btnCargar.Enabled = true;

                btnprocesar.Enabled = true;
            }

        }

        private async void btnprocesar_Click(object sender, EventArgs e)
        {
            if (_ventas == null || _ventas.Count == 0)

            {

                MessageBox.Show("Primero debe cargar las ventas.");

                return;

            }



            try

            {

                lblestado.Text = "Procesando información...";

                progressBar1.Style = ProgressBarStyle.Marquee;

                btnprocesar.Enabled = false;



                string reporte = await _ventaService.ProcesarVentasAsync(_ventas);



                txtresultado.Text = reporte;

                lblestado.Text = "Procesamiento finalizado.";

            }

            catch (Exception ex)

            {

                MessageBox.Show("Ocurrió un error al procesar las ventas: " + ex.Message);

            }

            finally

            {

                progressBar1.Style = ProgressBarStyle.Blocks;

                btnprocesar.Enabled = true;

            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = null;

            txtresultado.Clear();

            lblestado.Text = "Sin datos";

            _ventas.Clear();
        }
    }
}

