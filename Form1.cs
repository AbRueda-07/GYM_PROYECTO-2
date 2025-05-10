using System;
using System.Windows.Forms;

namespace GYM_Proyecto2_Forms_Ext.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           // InitializeComponent(); 
            InicializarMenuPrincipal(); 
        }


        private void InicializarMenuPrincipal() 

        {
            this.Text = "Sistema de Gestión del Gimnasio";
            this.Size = new System.Drawing.Size(400, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitulo = new Label
            {
                Text = "Menú Principal - Gestión del Gimnasio",
                Location = new System.Drawing.Point(60, 20),
                AutoSize = true,
                Font = new System.Drawing.Font("Mongolian Baiti", 10, System.Drawing.FontStyle.Bold)
            };

            Button btnMiembros = new Button { Text = "Gestionar Miembros", Location = new System.Drawing.Point(80, 70), Width = 240 };
            btnMiembros.Click += (s, e) => AbrirFormulario<FormMiembros>();

            Button btnMembresias = new Button { Text = "Gestionar Membresías", Location = new System.Drawing.Point(80, 110), Width = 240 };
            btnMembresias.Click += (s, e) => AbrirFormulario<FormMembresias>();

            Button btnClases = new Button { Text = "Gestionar Clases", Location = new System.Drawing.Point(80, 150), Width = 240 };
            btnClases.Click += (s, e) => AbrirFormulario<FormClases>();

            Button btnInstructores = new Button { Text = "Gestionar Instructores", Location = new System.Drawing.Point(80, 190), Width = 240 };
            btnInstructores.Click += (s, e) => AbrirFormulario<FormInstructores>();

            Button btnReservas = new Button { Text = "Gestionar Reservas", Location = new System.Drawing.Point(80, 230), Width = 240 };
            btnReservas.Click += (s, e) => AbrirFormulario<FormReservas>();

            Button btnSalir = new Button { Text = "Salir", Location = new System.Drawing.Point(80, 290), Width = 240 };
            btnSalir.Click += (s, e) => Application.Exit();

            this.Controls.Add(lblTitulo);
            this.Controls.Add(btnMiembros);
            this.Controls.Add(btnMembresias);
            this.Controls.Add(btnClases);
            this.Controls.Add(btnInstructores);
            this.Controls.Add(btnReservas);
            this.Controls.Add(btnSalir);
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            using (T form = new T())
            {
                form.ShowDialog(); 
            }
        }
    }
}