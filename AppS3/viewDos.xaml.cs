﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class viewDos : ContentPage
    {
        public viewDos(string usuario, string contrasena)
        {
            InitializeComponent();
            //Envio a los Label

            lblUsuario.Tex = usuario;
            lblContrasena,Tex = contrasena;






        }
    }
}