using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEsc
{
    public class Tools
    {
        public static void openNewForm(Form actualForm, Form newForm)
        {
            newForm.StartPosition = FormStartPosition.CenterScreen;

            newForm.Show();
            actualForm.Hide();
        }
    } 
}
