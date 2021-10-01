﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion3._1901
{
    public partial class Matrices : Form
    {
        public Matrices()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declarar la matriz
            int[,] matrizDeEjemplo = new int[2, 3] { 
                                                    { 5, 9, 30 }, 
                                                    { 1, 7, 2 } 
                                                   };

            //matrizDeEjemplo[0, 0] = 12;

            int[,] matrizDos = new int[3, 3];

            //Llenar la matriz

            for (int fila = 0; fila < matrizDos.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matrizDos.GetLength(1); columna++)
                {
                    matrizDos[fila, columna] = 4 + (fila + 4) * (columna + 3);
                }
            }

            //Mostrar la matriz al usuario

            for (int fila = 0; fila < matrizDos.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matrizDos.GetLength(1); columna++)
                {
                    listBox1.Items.Add("La posición: [" + fila + "," + columna + "] = " + matrizDos[fila, columna]);
                }
            }


        }
    }
}
