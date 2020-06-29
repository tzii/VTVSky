using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public class CustomForm : Form
    {
        public virtual void RefreshData() { }
        public virtual void Create() { }
        public virtual void SizeChange() { }
    }
}
