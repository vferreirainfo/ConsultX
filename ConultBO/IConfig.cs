﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Net.Interop;

namespace ConultBO
{
    public interface IConfig
    {
        string DiretoriaDB { get; set; }

        ISQLitePlatform Plataforma { get; set; }

        bool CriaConexaoDB();

    }
}