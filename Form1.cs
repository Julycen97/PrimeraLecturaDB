using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraLecturaBD
{
    public partial class frmLecturaPokemons : Form
    {
        private List<Pokemon> pokemons;
        public frmLecturaPokemons()
        {
            InitializeComponent();
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            PokemonDatos aux = new PokemonDatos();
            pokemons = aux.ObtenerDatos();
            dgvDatos.DataSource = pokemons;
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbxImagenPokemon.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagenPokemon.Load("https://th.bing.com/th/id/OIP.hMlLJSmMJky9Rd1JwB86VgHaFl?pid=ImgDet&rs=1");
                
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon Aux = (Pokemon)dgvDatos.CurrentRow.DataBoundItem;
            CargarImagen(Aux.URLImagen);
        }
    }
}
