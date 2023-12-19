using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace ServiceMetier.Utils
{
    public class Helpers
    {
        /// <summary>
        /// Rédiger le message d'erreur dans un fichier
        /// </summary>
        /// <param name="message">le message d'erreur</param>
        public static void WriteFileError(string message)
        {
            try
            {
                string path = System.Web.HttpContext.Current.Server.MapPath("~/Error/erreur.txt");
                System.IO.TextWriter writeFile = new StreamWriter(path, true);
                writeFile.WriteLine("" + DateTime.Now);
                writeFile.WriteLine(message);
                writeFile.WriteLine("---------------------------------------------------------------------------------------");
                writeFile.Flush();
                writeFile.Close();
                writeFile = null;
            }
            catch (IOException e)
            {
                WriteLogSystem(e.ToString(), "WriteFileError");
            }
        }

        /// <summary>
        /// gerer les logs de l'application
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool CreateFile(string message)
        {
            bool rep = false;
            string fileName = string.Format("{0}{1}{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            try
            {
                string path = System.Web.HttpContext.Current.Server.MapPath("~/Error/" + fileName + ".txt");
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.Create(path);
                bool fileUse = true;
                while (fileUse)
                {
                    try
                    {
                        System.IO.TextWriter writeFile = new StreamWriter(path, true);
                        writeFile.WriteLine("" + DateTime.Now);
                        writeFile.WriteLine(message);
                        writeFile.WriteLine("-------------------------------------------");
                        writeFile.Flush();
                        writeFile.Close();
                        writeFile = null;
                        fileUse = false;
                    }
                    catch (Exception e)
                    {
                        WriteLogSystem(e.ToString(), "CreateFile");
                    }
                }
                rep = true;
            }
            catch (IOException e)
            {
                WriteLogSystem(e.ToString(), "WriteFileError");
            }
            return rep;
        }


        /// <summary>
        /// Permet de gerer une liste d'erreur
        /// </summary>
        /// <param name="message">liste d' erreur</param>
        /// <param name="theFile">le nom du fichier</param>
        public void WriteErrorLoad(List<string> message, string theFile)
        {
            try
            {
                string path = System.Web.HttpContext.Current.Server.MapPath("~/Error/" + theFile + ".txt");
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                System.IO.TextWriter writeFile = new StreamWriter(path, true);
                //writeFile.WriteLine("" + DateTime.Now);
                //while (!IsFileReady(path))
                //{
                //    System.Threading.Thread.Sleep(1000);
                //}
                writeFile.WriteLine("---------------------DEBUT----------------------");
                foreach (var item in message)
                {
                    writeFile.WriteLine(item);
                }
                writeFile.WriteLine("----------------------FIN---------------------");
                writeFile.Flush();
                writeFile.Close();
                writeFile = null;
            }
            catch (IOException e)
            {
                WriteLogSystem(e.ToString(), "WriteErrorLoad");
            }
        }


        /// <summary>
        /// Cette methode permet de logger les erreurs dans le systeme
        /// </summary>
        /// <param name="erreur">erreur</param>
        /// <param name="libelle">Controlleur et page</param>
        public static void WriteLogSystem(string erreur, string libelle)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application Boutique";
                eventLog.WriteEntry(string.Format("date: {0}, libelle: {1}, description {2}", DateTime.Now, libelle, erreur), EventLogEntryType.Information, 101, 1);
            }
        }
    }
}