using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp1
{
    internal class PassThru
    {
        public static PassThru Events = new PassThru();
        internal event EventHandler<Form> openChildFormEvent;
        internal void openChildForm(Form form)
        {
            openChildFormEvent?.Invoke(this, form);
        }
      
    }
}
