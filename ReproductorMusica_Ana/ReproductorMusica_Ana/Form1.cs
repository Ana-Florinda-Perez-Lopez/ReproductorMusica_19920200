using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorMusica_Ana
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            PersonalizarDisenio();
        }

        private void PersonalizarDisenio() {
            panelMediosSubMenu.Visible=false;
            panelListaReproduccion.Visible=false;
            panelTools.Visible = false;
            
        }

        private void OcultarSubMenus() {
            if (panelMediosSubMenu.Visible == true){
                panelMediosSubMenu.Visible = false;
            }
            if (panelListaReproduccion.Visible == true){
                panelListaReproduccion.Visible = false;
            }
            if (panelTools.Visible == true){
                panelTools.Visible = false;
            }
        }

        private void MostrarSubMenu(Panel algunSubMenu) {
            if (algunSubMenu.Visible == false) {
                OcultarSubMenus();
                algunSubMenu.Visible = true;
            }
            else {
                algunSubMenu.Visible = false;
            }
        }

        #region RegionSubMenuMedios
        private void btnMedios_Click(object sender, EventArgs e) {
            MostrarSubMenu(panelMediosSubMenu);
         }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Form2());
            //...
            OcultarSubMenus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //...
            OcultarSubMenus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //...
            OcultarSubMenus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //...
            OcultarSubMenus();
        }
        #endregion RegionSubMenuMedios
        
        #region RegionSubMenuReproduccion 
        private void btnListaReproduccion_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelListaReproduccion);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            //...
            OcultarSubMenus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //...
            OcultarSubMenus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //...
            OcultarSubMenus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //...
            OcultarSubMenus();
        }
        #endregion RegionSubMenuReproduccion

        #region RegionSubMenuTools

        private void btnTools_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelTools);
        }
                
        private void button13_Click(object sender, EventArgs e)
        {
            //...
            OcultarSubMenus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //...
            OcultarSubMenus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //...
            OcultarSubMenus();
        }
        #endregion RegionSubMenuTools 
        private void button10_Click(object sender, EventArgs a)
        {
            abrirChildForm(new Form3());
            //...
            OcultarSubMenus();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            //...
            OcultarSubMenus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form formularioActivo = null;
        private void abrirChildForm(Form ChildForm){
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
                       
        }

    }
}
