using HNI_TPmoyennes.HNI_TPmoyennes.HNI_TPmoyennes;
namespace HNI_TPmoyennes
{

    namespace HNI_TPmoyennes
    {
        public class Classe
        {
            internal string nomClasse { get; set; }
            List<Note> Notes { get; set; } = new List<Note>();
            public List<string> matieres = new List<string>();
            public List<Eleve> eleves = new List<Eleve>();

            public void ajouterEleve(string nom, string prenom)
            {
                if (eleves.Count >= 30)
                {
                    Console.WriteLine("La Classe est déjà rempli, aucun élève ne peut être ajouté.");
                }
                else
                {
                    Eleve eleve = new Eleve(nom, prenom);
                    eleves.Add(eleve);
                }
            }
            public void ajouterMatiere(string matiere)
            {
                if (matieres.Count >= 10)
                {
                    Console.WriteLine("Il y a trop de matieres, on ne peut plus en rajouter.");
                }
                else
                {
                    matieres.Add(matiere);
                }
            }

            public float moyenneMatiere(int matiere)
            {
                float somme = 0;
                for (int i = 0; i < eleves.Count; i++)
                {
                    somme += eleves[i].moyenneMatiere(matiere);
                }
                somme /= eleves.Count;
                somme = (float)Math.Round(somme, 2);
                return somme;
            }

            public float moyenneGeneral()
            {
                float somme = 0;
                for (int i = 0; i < matieres.Count; i++)
                {
                    somme += moyenneMatiere(i);
                }
                somme /= matieres.Count;
                somme = (float)Math.Round(somme, 2);
                return somme;
            }

            public Classe(string nom)
            {
                this.nomClasse = nom;
            }
        }

    }
}