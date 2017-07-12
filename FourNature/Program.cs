using FourNature.model.dao;
using FourNature.model.metier;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourNature
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Accueil());

            DAO<Fournisseur> FournisseurDAO = DAOFactory.getFournisseurDAO();
            Fournisseur fournisseur = FournisseurDAO.select("BIOVERT");

            Debug.WriteLine("" + fournisseur.Nom.ToString());
            
            
        }
    }
}
