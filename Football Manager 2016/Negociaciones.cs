using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Football_Manager_2016
{
    public partial class Negociaciones : Form
    {
        public string ApellidoCompleto { get; set; }

        public Negociaciones()
        {
            InitializeComponent();
        }

        private void lblFuerzaMin_Click(object sender, EventArgs e)
        {

        }

        private void numericTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFuerzaMax_Click(object sender, EventArgs e)
        {

        }

        private void Negociaciones_Load(object sender, EventArgs e)
        {
            CargarArchivosUsuario();
            CargarUsuario();
            CargarJugadores();
        }


        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
        ListaUsuario Lista = new ListaUsuario();
        Usuario Usu = new Usuario();
        Jugadores Jug = new Jugadores();
        public void CargarArchivosUsuario()
        {
            string LeerDatos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosUsuarios.json";

            using (StreamReader Entrada = new StreamReader(LeerDatos))
            {
                string contenido = Entrada.ReadToEnd();

                Lista.LU = JsonConvert.DeserializeObject<List<Usuario>>(contenido);
            }
        }
        public void CargarUsuario()
        {
            string LeerTemp = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosTemp.json";

            using (StreamReader Entrada = new StreamReader(LeerTemp))
            {
                string contenido = Entrada.ReadToEnd();

                Usu = JsonConvert.DeserializeObject<Usuario>(contenido);
            }
        }
        public void CargarJugadores()
        {
            string LeerTemp = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosJugadores.json";

            using (StreamReader Entrada = new StreamReader(LeerTemp))
            {
                string contenido = Entrada.ReadToEnd();

                Jug.ListaJugadores = JsonConvert.DeserializeObject<List<Jugador>>(contenido);
            }
        }

        private void cbxClub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public List<Jugador> ListaJugadoresDevueltos = new List<Jugador>(); //PRE-SELECCION DE JUGADORES A MOSTRAR EN GRILLA
        //for (int i = 0; i<GrillaJugadoresNegociaciones.RowCount; i++) // compruebo que no este el jugador ya cargado
        //    {
        //        if (item.Nombre == GrillaJugadoresNegociaciones.Rows[i].Cells[2].Value.ToString())

        private bool ExisteJugadorEnLista(Jugador item)
        {
            /*bool existe = ListaJugadoresDevueltos.Exists(x => x.EquipoActual == item.EquipoActual); */////PROBLEMA/////
            bool existe = ListaJugadoresDevueltos.Contains(item);
            return existe;
        }
        private void AgregarJugadoresEnGrilla(int F, Jugador item)
        {
            
            F = GrillaJugadoresNegociaciones.Rows.Add();

            GrillaJugadoresNegociaciones.Rows[F].Cells[0].Value = item.Fuerza;
            GrillaJugadoresNegociaciones.Rows[F].Cells[1].Value = item.EquipoActual;
            GrillaJugadoresNegociaciones.Rows[F].Cells[2].Value = item.Nombre;
            GrillaJugadoresNegociaciones.Rows[F].Cells[3].Value = item.Posicion;
            GrillaJugadoresNegociaciones.Rows[F].Cells[4].Value = item.Salario;
            GrillaJugadoresNegociaciones.Rows[F].Cells[5].Value = item.Valor;
            GrillaJugadoresNegociaciones.Rows[F].Cells[6].Value = item.Edad;

        }
        private void BusquedaFuerza(int F)
        {
            if (Convert.ToInt32(ntxtFuerMin.Text) < Convert.ToInt32(ntxtFuerMax.Text))
            {
                foreach (var item in Jug.ListaJugadores)
                {
                    if (item.Fuerza >= Convert.ToInt32(ntxtFuerMin.Text) && item.Fuerza <= Convert.ToInt32(ntxtFuerMax.Text))
                    {
                        if (ExisteJugadorEnLista(item) == false)
                        {
                            ListaJugadoresDevueltos.Add(item);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("¡Campos de FUERZA ambiguos!", "Buscar Jugador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BusquedaSalario(int F)
        {
            if (Convert.ToInt32(ntxtSalMin.Text) < Convert.ToInt32(ntxtSalMax.Text))
            {
                foreach (var item in Jug.ListaJugadores)
                {
                    if (item.Salario >= Convert.ToInt32(ntxtSalMin.Text) && item.Salario <= Convert.ToInt32(ntxtSalMax.Text))
                    {
                        if (ExisteJugadorEnLista(item) == false)
                        {
                            ListaJugadoresDevueltos.Add(item);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("¡Campos de SALARIO ambiguos!", "Buscar Jugador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BusquedaValor(int F)
        {
            if (Convert.ToInt32(ntxtValMin.Text) < Convert.ToInt32(ntxtValMax.Text))
            {
                foreach (var item in Jug.ListaJugadores)
                {
                    if (item.Valor >= Convert.ToInt32(ntxtValMin.Text) && item.Valor <= Convert.ToInt32(ntxtValMax.Text))
                    {
                        if (ExisteJugadorEnLista(item) == false)
                        {
                            ListaJugadoresDevueltos.Add(item);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("¡Campos de VALOR ambiguos!", "Buscar Jugador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BusquedaEquipo(int F)
        {
            foreach (var item in Jug.ListaJugadores)
            {
                if (cbxClub.SelectedItem.ToString() == item.EquipoActual)
                {
                    if (ExisteJugadorEnLista(item) == false)
                    {
                        ListaJugadoresDevueltos.Add(item);
                    }
                }
            }
        }
        private void BusquedaApellido(int F)
        {
            string apellido = "";
            foreach (var item in Jug.ListaJugadores)
            {
                for (int i = 0; i < item.Nombre.Length; i++)
                {
                    if (item.Nombre[i] != ',') //Recorto solo el apellido del jugador
                    {
                        apellido += item.Nombre[i];
                    }
                    else
                    {
                        break;
                    }
                }
                if (txtApellido.Text == apellido)
                {
                    ApellidoCompleto = item.Nombre;
                    if (ExisteJugadorEnLista(item) == false)
                    {
                        ListaJugadoresDevueltos.Add(item);
                    }
                }
                apellido = "";
            }
        }
        private void BusquedaPosicion(int F)
        {
            foreach (var item in Jug.ListaJugadores)
            {
                if (cbxPosicion.SelectedItem.ToString() == item.Posicion)
                {
                    if (ExisteJugadorEnLista(item) == false)
                    {
                        ListaJugadoresDevueltos.Add(item);
                    }
                }
            }
        }
        private void BusquedaEdad(int F)
        {
            foreach (var item in Jug.ListaJugadores)
            {
                if (Convert.ToInt32(cbxEdad.SelectedItem) == item.Edad)
                {
                    if (ExisteJugadorEnLista(item) == false)
                    {
                        ListaJugadoresDevueltos.Add(item);
                    }
                }
            }
        }
        private int CantidadParametros()
        {
            int CP = 0;
            if (cbxClub.SelectedItem != null) //EQUIPO
            {
                CP += 1;
            }
            if (ntxtFuerMax.Text != "" && ntxtFuerMin.Text != "") //FUERZA
            {
                CP += 1;
            }
            if (txtApellido.Text != "") //APELLIDO
            {
                CP += 1;
            }
            if (cbxPosicion.SelectedItem != null)
            {
                CP += 1;
            }
            if (cbxEdad.SelectedItem != null)
            {
                CP += 1;
            }
            if (ntxtSalMin.Text != "" && ntxtSalMax.Text != "")
            {
                CP += 1;
            }
            if (ntxtValMin.Text != "" && ntxtValMax.Text != "")
            {
                CP += 1;
            }
            return CP;
        }
        private void CoincidenciasJugador(int F)
        {        
            foreach (var item in ListaJugadoresDevueltos)
            {
                int C = 0;

                if (cbxClub.SelectedItem != null)
                {
                    if (item.EquipoActual == cbxClub.SelectedItem.ToString())
                    {
                        C += 1;
                    }
                }
                if (ntxtFuerMin.Text != "" && ntxtFuerMax.Text != "")
                {
                    if (item.Fuerza >= Convert.ToInt32(ntxtFuerMin.Text) && item.Fuerza <= Convert.ToInt32(ntxtFuerMax.Text))
                    {
                        C += 1;
                    }
                }         
                if (item.Nombre == ApellidoCompleto)
                {
                    C += 1;
                }
                if (cbxPosicion.SelectedItem != null)
                {
                    if (item.Posicion == cbxPosicion.SelectedItem.ToString())
                    {
                        C += 1;
                    }
                }            
                if (item.Edad == Convert.ToInt32(cbxEdad.SelectedItem))
                {
                    C += 1;
                }
                if (ntxtSalMin.Text != "" && ntxtSalMax.Text != "")
                {
                    if (item.Salario >= Convert.ToInt32(ntxtSalMin.Text) && item.Salario <= Convert.ToInt32(ntxtSalMax.Text))
                    {
                        C += 1;
                    }
                }
                if (ntxtValMin.Text != "" && ntxtValMax.Text != "")
                {
                    if (item.Valor >= Convert.ToInt32(ntxtValMin.Text) && item.Valor <= Convert.ToInt32(ntxtValMax.Text))
                    {
                        C += 1;
                    }
                }
                int CantPar = CantidadParametros();
                if (CantPar == C)
                {
                    AgregarJugadoresEnGrilla(F, item);
                }
            }          
        }
        private void btnBuscarNegociaciones_Click(object sender, EventArgs e)
        {
            GrillaJugadoresNegociaciones.Rows.Clear();
            ListaJugadoresDevueltos.Clear();
            ApellidoCompleto = null;
            if (cbxClub.SelectedItem == null && ntxtFuerMax.Text == "" && ntxtFuerMin.Text == "" && txtApellido.Text == "" && cbxEdad.SelectedItem == null && cbxPosicion.SelectedItem == null && ntxtSalMin.Text == "" && ntxtSalMax.Text == "" && ntxtValMin.Text == "" && ntxtValMax.Text == "")
            {
                MessageBox.Show("¡Rellene algun campo para buscar un jugador!", "Buscar Jugador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //quiere decir que por lo menos un campo esta relleno
            {
                int F = 0; //Fila de la Grilla
                if (cbxClub.SelectedItem != null) //EQUIPO
                {
                    BusquedaEquipo(F);     
                }
                if (ntxtFuerMax.Text != "" && ntxtFuerMin.Text != "") //FUERZA
                {
                    BusquedaFuerza(F);
                }
                if (txtApellido.Text != "") //APELLIDO
                {
                    BusquedaApellido(F);
                }
                if (cbxPosicion.SelectedItem != null)
                {
                    BusquedaPosicion(F);
                }
                if (cbxEdad.SelectedItem != null)
                {
                    BusquedaEdad(F);
                }
                if (ntxtSalMin.Text != "" && ntxtSalMax.Text != "")
                {
                    BusquedaSalario(F);
                }
                if (ntxtValMin.Text != "" && ntxtValMax.Text != "")
                {
                    BusquedaValor(F);
                }

                CoincidenciasJugador(F);                     
            }
        }

        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            cbxClub.SelectedItem = null;
            ntxtFuerMax.Text = "";
            ntxtFuerMin.Text = "";
            txtApellido.Text = "";
            cbxEdad.SelectedItem = null;
            cbxPosicion.SelectedItem = null;
            ntxtSalMin.Text = "";
            ntxtSalMax.Text = "";
            ntxtValMin.Text = "";
            ntxtValMax.Text = "";
        }      
    }
}


