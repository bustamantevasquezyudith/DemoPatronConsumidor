using System.Diagnostics.Eventing.Reader;
using System.Threading;

namespace DemoPatronConsumidor
{
    public partial class Form1 : Form
    {
        private int contadorId = 1;
        private Cola<Usuario> colaUsuario;
        private Productor productor;
        private Consumidor consumidor;
        public Form1()
        {
            InitializeComponent();
            colaUsuario = new Cola<Usuario>(10);
            productor = new Productor(colaUsuario);
            consumidor = new Consumidor(colaUsuario);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario(
               contadorId++,
               txtNombres.Text,
               txtCorreoElectronico.Text
                );
            ThreadPool.QueueUserWorkItem(
                state =>
                {
                    colaUsuario.Agregar(nuevoUsuario);

                }
                );
            txtNombres.Clear();
            txtCorreoElectronico.Clear();

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Thread HiloConsumidor = new Thread(procesarUsuario);
             HiloConsumidor.Start();
        }
        private void procesarUsuario()
        {
            Usuario usuario = colaUsuario.Extraer();
            AgregarUsuarioADataGrid(usuario);
        }
        private void AgregarUsuarioADataGrid(Usuario usuarios)
        {
            if (dgvUsuario.InvokeRequired)
            {
                dgvUsuario.Invoke(new Action(() =>
                {
                    dgvUsuario.Rows.Add
                    (
                        usuarios.Id, usuarios.Nombre,
                        usuarios.CorreoElectronico,
                        usuarios.FechaCreacion
                    );
                }));
            }
            else
            {
                dgvUsuario.Rows.Add
                (
                   usuarios.Id, usuarios.Nombre,
                   usuarios.CorreoElectronico,
                   usuarios.FechaCreacion
                );
            }

        }
    }
}