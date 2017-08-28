using FourNature.model;
using FourNature.model.dao.metier;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourNature.vue
{
    class Prompt
    {
        private Model model;

        public Prompt(Model model)
        {
            this.model = model;
        }

        public void ShowDialog(string text, string caption,string ncde)
        {
            Form prompt = new Form();
            prompt.MaximumSize = new Size(422,260);          
            prompt.Width = 422;
            prompt.Height = 260;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 3, Top = 10, Text = text };
            ListView listView = new ListView() { Left = 3, Top = 40, Width = 400 };
            listView.Height = 150;
            listView.View = View.Details;            
            listView.Columns.Add("Fournisseur");
            listView.Columns.Add("Article");
            listView.Columns.Add("Prix");
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView.Columns[0].Width = 80;
            listView.Columns[1].Width = 120;
            listView.Columns[1].TextAlign = HorizontalAlignment.Center;
            listView.Columns[2].Width = 50;
            listView.Columns[2].TextAlign = HorizontalAlignment.Center;

            List<Tarifs_articles> listArticle = model.getFournArticle(text);
            foreach (Tarifs_articles article in listArticle)
            {
                //MessageBox.Show(commande.Design);
                ListViewItem listItem = new ListViewItem();
                listItem.Text = article.Fourn;
                listItem.SubItems.Add(article.Article);
                listItem.SubItems.Add(article.Prix_achat.ToString());
                listView.Items.Add(listItem);               
            }

            Button confirmation = new Button() { Text = "Ok", Left = 305, Width = 100, Top = 195 };
            confirmation.Click += (sender, e) => 
            {
                //MessageBox.Show(listView.SelectedItems[0].SubItems[1].Text);
                if (listView.SelectedItems.Count > 0)
                {
                    Commandes_articles cmd = new Commandes_articles(ncde,listView.SelectedItems[0].Text, listView.SelectedItems[0].SubItems[1].Text, float.Parse(listView.SelectedItems[0].SubItems[2].Text));
                    model.maj_Commande(cmd);
                }                
                prompt.Close();
            };

            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(listView);
            prompt.ShowDialog();
            
            
        }
    }
}
