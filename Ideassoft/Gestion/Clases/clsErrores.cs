﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Class
{
    class ClsErrores
    {
        public ClsErrores() { }
        public void WarningError(string Error)
        {
            WarningException ne = new WarningException(Error);
            MessageBox.Show(ne.Message, "Advertencia");
        }
        public void WarningFaltaDatos(string Error)
        {
            WarningException ne = new WarningException(Error);
            MessageBox.Show(ne.Message, "Advertencia");
        }
    }
}
