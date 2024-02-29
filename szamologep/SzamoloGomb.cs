using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamologep
{
    class SzamoloGomb : Button
    {
        int szám;

        public SzamoloGomb()
        {
            Width = 20;
            Height = 20;
            Click += SzamoloGomb_Click;
            szám = 1;
            Text = szám.ToString();
        }

        public void SzamoloGomb_Click(object sender, EventArgs e)
        {
            szám++;
            if (szám == 6)
            {
                szám = 1;
            }
            Text = szám.ToString();
        }
    }
}
