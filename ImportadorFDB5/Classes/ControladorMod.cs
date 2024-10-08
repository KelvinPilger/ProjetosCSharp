﻿using ImportadorFDB5.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportadorFDB5.Classes
{
    public class ControladorMod
    {
        public static Color corFonte;
        public static Color corFundo;
        public static Image imgMod;
        public static Image pastaMod;
        public static Image alvoMod;
        public static Image bdMod;
        public static Image intercambioMod;
        public static Image logo;
        public static bool ligado = false;


        public static void TrocarMod()
        {
            if (ligado)
            {
                SetarModoClaro();
            }
            else
            {
                SetarModoEscuro();
            }
        }

        private static void SetarModoEscuro()
        {
            pastaMod = Resources.PastaLigth1;
            alvoMod = Resources.AlvoLigth;
            bdMod = Resources.base_de_dadosLigth;
            intercambioMod = Resources.intercambio;
            imgMod = Resources.ModLigth;
            logo = Resources.lglModClaro;
            corFonte = Color.Black;
            corFundo = Color.FromArgb(242, 242, 242);
            ligado = true;
        }

        private static void SetarModoClaro()
        {
            pastaMod = Resources.PastaDark1;
            alvoMod = Resources.AlvoDark;
            bdMod = Resources.BaseDedadosDark   ;
            intercambioMod = Resources.intercambioDark;
            imgMod = Resources.ModDark;
            logo = Resources.lglModDark;
            corFonte = Color.White;
            corFundo = Color.FromArgb(51, 51, 51);
            ligado = false;
        }
    }
}
