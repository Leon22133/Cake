using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PractosNumber5
{
    internal class Cake
    {
        public int cost;
        public string forma;
        public string razmer;
        public string vkusy;
        public string Kolichestvo_Korgey;
        public string glazur;
        public string ukrashenia;
        public Cake(int ParamCost, string ParamForma, string ParamSize, string Paramvkus, string ParamKolvo_Korgey, string Paramglazur, string ParamDecor)
        {
            cost = ParamCost;
            forma = ParamForma;
            razmer = ParamSize;
            vkusy = Paramvkus;
            Kolichestvo_Korgey = ParamKolvo_Korgey;
            glazur = Paramglazur;
            ukrashenia = ParamDecor;
        }
    }
}