﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GraficadorDeSeñales
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            plnGrafica.Points.Add(new Point(0, 10));
            plnGrafica.Points.Add(new Point(20, 15));
            plnGrafica.Points.Add(new Point(100, 50));
            plnGrafica.Points.Add(new Point(200, 1));
            plnGrafica.Points.Add(new Point(300, 70));
            plnGrafica.Points.Add(new Point(1000, 70));
        }

        private void Btn_graficar_Click(object sender, RoutedEventArgs e)
        {
            double amplitud =
                double.Parse(txt_amplitud.Text);
            double fase =
                double.Parse(txt_fase.Text);
            double frecuencia =
                double.Parse(txt_frecuencia.Text);
            double tiempoInicial =
                double.Parse(txt_tiempo_inicial.Text);
            double tiempoFinal =
                double.Parse(tiempo_Final.Text);
            double frecuenciaMuestreo =
                double.Parse(txt_frecuencia_de_muestreo.Text);

            SeñalSenoidal señal = new SeñalSenoidal(amplitud, fase, frecuencia);

            double periodoMuestreo =
                1.0 / frecuenciaMuestreo;
            plnGrafica.Points.Clear();
            for (double i = tiempoInicial; i <= tiempoFinal; i += periodoMuestreo);

            {
                plnGrafica.Points.Add(
                    adaptarCoordenadas(if,
                    señal.evaluar(i), tiempoIncial));

            }

            polyX.Points.Clear();
            polyX.Points.Add(
                adaptarCoordenadas(tiempoInicial, 0.0, tiempoInicial)
                );
            polyX.Points.Add(
                adaptarCoordenadas(tiempoInicial, 0.0, tiempoInicial)
                );


        }
        public Point adaptarCoordenadas(double x, double y, double tiempoInicial)

    }
}
