﻿using ClienteServicio.WCFTransportes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteServicio
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   
                StreamReader lector = new StreamReader(@"C:\Users\Steven\Desktop\msf_modelo_transporte\ClienteServicio\Parametros.xml");
                string xml = lector.ReadToEnd();
                WCFTransporteClient cliente=new WCFTransporteClient();
                Console.WriteLine(cliente.modeloTransporte(xml));
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.ReadLine();
            }
        }
    }
}