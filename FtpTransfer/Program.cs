using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FtpTransfer
{
    class Program
    {
        static void Main(string[] args)
        {
            FtpClient ftp = new FtpClient(@"ftp://127.0.0.1/", "willian", "123456");

            ftp.download("etc/colab2.txt", @"C:\Users\arrud\Desktop\copiado2.txt");
            ftp.delete("etc/colab2.txt");

            //ftp.createDirectory("etc/misc");

            //string[] listaSimples = ftp.directoryListSimple("etc");

            //foreach (var item in listaSimples)
            //{
            //Console.WriteLine(item.ToString());
            //}
        }

      
    }
}
