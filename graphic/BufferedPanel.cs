﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace graphic {


    class BufferedPanel: Panel {

        public BufferedPanel() {
            this.DoubleBuffered = true;
        }
    
    
    }
}
