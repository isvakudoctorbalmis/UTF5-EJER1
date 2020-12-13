using System.IO;
using System.Collections.Generic;
using System.ComponentModel;

namespace UTF5_EJER1
{
    class Plato : INotifyPropertyChanged
    {
        private string nombre;
        private string imagen { get; set; }
        private string tipo { get; set; }
        private bool gluten { get; set; }
        private bool soja { get; set; }
        private bool leche { get; set; }
        private bool sulfitos { get; set; }

    
        public string Nombre
    {
            get { return this.nombre; }
            set { 
                nombre = value;
                NotifyPropertyChanged("nombre"); }
        }

        public string Imagen
        {
            get { return this.imagen; }
            set
            {
                imagen = value;
                NotifyPropertyChanged("imagen");
            }
        }
        public string Tipo
        {
            get { return this.tipo; }
            set
            {
                tipo = value;
                NotifyPropertyChanged("tipo");
            }
        }
        public bool Gluten
        {
            get { return this.gluten; }
            set
            {
                gluten = value;
                NotifyPropertyChanged("gluten");
            }
        }
        public bool Soja
        {
            get { return this.soja; }
            set
            {
                soja = value;
                NotifyPropertyChanged("soja");
            }
        }
        public bool Leche
        {
            get { return this.leche; }
            set
            {
                leche = value;
                NotifyPropertyChanged("leche");
            }
        }
        public bool Sulfitos
        {
            get { return this.sulfitos; }
            set
            {
                sulfitos = value;
                NotifyPropertyChanged("sulfitos");
            }
        }

        public Plato(string nombre, string imagen, string tipo, bool gluten, bool soja, bool leche, bool sulfitos)
        {
            Nombre = nombre;
            Imagen = imagen;
            Tipo = tipo;
            Gluten = gluten;
            Soja = soja;
            Leche = leche;
            Sulfitos = sulfitos;
        }

        public Plato()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public static List<Plato> GetSamples(string rutaImagenes)
        {
            List<Plato> lista = new List<Plato>();

            lista.Add(new Plato("Hamburguesa", Path.Combine(rutaImagenes, @"burguer.jpg"), "Americana", true, false, true, true));
            lista.Add(new Plato("Dumplings", Path.Combine(rutaImagenes, @"dumplings.jpg"), "China", true, true, false, false));
            lista.Add(new Plato("Tacos", Path.Combine(rutaImagenes, @"tacos.jpg"), "Mexicana", true, false, false, true));
            lista.Add(new Plato("Cerdo agridulce", Path.Combine(rutaImagenes, @"cerdoagridulce.jpg"), "China", true, true, false, true));
            lista.Add(new Plato("Hot dogs", Path.Combine(rutaImagenes, @"hotdog.jpg"), "Americana", true, true, true, true));
            lista.Add(new Plato("Fajitas", Path.Combine(rutaImagenes, @"fajitas.jpg"), "Mexicana", true, false, false, true));

            return lista;
        }
    }
}
