using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistBoissonChaude
{
    public enum eBoissonChaude
    {
        Expresso,
        Allonge,
        Capucino,
        Chocolat,
        The
    }

    public enum eProduit
    { 
        Cafe,
        Sucre,
        Creme,
        The,
        Eau,
        Chocolat,
        Lait
    }

    public class BoissonChaude
    {
        Dictionary<eBoissonChaude, Func<float>> prix_boisson_chaude;
        Dictionary<eProduit, float> prix_produit;

        public BoissonChaude()
        {
            prix_produit = new Dictionary<eProduit, float>();
            prix_produit[eProduit.Cafe] = 1.0F;
            prix_produit[eProduit.Sucre] = 0.1F;
            prix_produit[eProduit.Creme] = 0.5F;
            prix_produit[eProduit.The] = 2.0F;
            prix_produit[eProduit.Eau] = 0.2F;
            prix_produit[eProduit.Chocolat] = 1.0F;
            prix_produit[eProduit.Lait] = 0.4F;

            prix_boisson_chaude = new Dictionary<eBoissonChaude,Func<float>>();
            prix_boisson_chaude[eBoissonChaude.Expresso] = prix_Expresso;
            prix_boisson_chaude[eBoissonChaude.Allonge] = prix_Allonge;
            prix_boisson_chaude[eBoissonChaude.Capucino] = prix_Capucino;
            prix_boisson_chaude[eBoissonChaude.Chocolat] = prix_Chocolat;
            prix_boisson_chaude[eBoissonChaude.The] = prix_The;
        }


        public string prix(eBoissonChaude _boissonChaude)
        {
            return (prix_boisson_chaude[_boissonChaude]() * 1.3F).ToString("n2");
        }

        public float prix_Expresso()
        {
            return prix_produit[eProduit.Cafe] 
                + prix_produit[eProduit.Eau];
        }

        public float prix_Allonge()
        {
            return prix_produit[eProduit.Cafe] 
                + (2 * prix_produit[eProduit.Eau]);
        }

        public float prix_Capucino()
        {
            return prix_produit[eProduit.Cafe] 
                + prix_produit[eProduit.Chocolat] 
                + prix_produit[eProduit.Eau] 
                + prix_produit[eProduit.Creme];
        }

        public float prix_Chocolat()
        {
            return (3 * prix_produit[eProduit.Chocolat])
                + (2 * prix_produit[eProduit.Lait])
                + prix_produit[eProduit.Eau]
                + prix_produit[eProduit.Sucre];
        }

        public float prix_The()
        {
            return prix_produit[eProduit.Chocolat]
                + (2 * prix_produit[eProduit.Eau]);
        }

    }
}
