using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;



namespace UTF5_EJER1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            this.platosListBox.DataContext = (object) Plato.GetSamples(Path.Combine(Environment.CurrentDirectory, "Imagenes"));
      this.tipoComboBox.ItemsSource = (IEnumerable) new List<string>()
      {
        "China",
        "Americana",
        "Mexicana"
      };
        }
    }
}
