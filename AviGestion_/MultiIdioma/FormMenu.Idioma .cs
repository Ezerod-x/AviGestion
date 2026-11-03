using System;
using System.Drawing;
using System.Windows.Forms;
using AviGestion_.Logica;

namespace AviGestion_.UI
{
    // Archivo aparte (partial) con todo lo del cambio de idioma del menú.
    partial class FormMenu
    {
        private ContextMenuStrip menuIdioma;

        // Lo llama el ítem "Cambiar idioma" de la lista DefinirItems (sección SISTEMA).
        private void MostrarMenuIdioma()
        {
            if (menuIdioma == null) CrearMenuIdioma();

            var item = items.Find(i => i.Texto == "Cambiar idioma");
            if (item == null || item.Boton == null) return;

            menuIdioma.Show(item.Boton, new Point(item.Boton.Width, 0));
        }

        private void CrearMenuIdioma()
        {
            menuIdioma = new ContextMenuStrip();
            var itemEs = new ToolStripMenuItem("Español");
            var itemEn = new ToolStripMenuItem("English");

            itemEs.Click += (s, e) => CambiarIdioma(Idioma.Espanol);
            itemEn.Click += (s, e) => CambiarIdioma(Idioma.Ingles);

            menuIdioma.Items.Add(itemEs);
            menuIdioma.Items.Add(itemEn);

            // Tilda el idioma activo cada vez que se abre la lista.
            menuIdioma.Opening += (s, e) =>
            {
                itemEs.Checked = Idioma.Actual == Idioma.Espanol;
                itemEn.Checked = Idioma.Actual == Idioma.Ingles;
            };
        }

        private void CambiarIdioma(string idioma)
        {
            Idioma.Cambiar(idioma);                    // guarda y traduce los forms abiertos
            Idioma.Aplicar(this);                      // menú lateral, header, botón Cerrar Sesión
            if (pantallaActual != null)
                Idioma.Aplicar(pantallaActual);        // pantalla incrustada en pnlContenido

            // Los textos chicos (catálogo, inventario) se dibujan en el Paint: hay que repintarlos.
            foreach (var i in items)
                if (i.Boton != null) i.Boton.Invalidate();
        }
    }
}
