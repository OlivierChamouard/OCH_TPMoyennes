namespace HNI_TPmoyennes.HNI_TPmoyennes
{
    namespace HNI_TPmoyennes
    {
        public class Eleve
        {
            public string nom { get; private set; }
            public string prenom { get; private set; }
            internal List<Note> notes { get; private set; } = new List<Note>();
            public Eleve(string nom, string prenom)
            {
                this.nom = nom;
                this.prenom = prenom;
            }
            internal void ajouterNote(Note note)
            {
                if (notes.Count >= 200)
                {
                    Console.WriteLine("Il y a trop de notes, on ne peut plus en rajouter.");
                }
                else
                {
                    notes.Add(note);
                }
            }
            public float moyenneMatiere(int matiere)
            {
                float somme = 0;
                int count = 0;
                foreach (var note in notes)
                {
                    if (note.matiere == matiere)
                    {
                        somme += note.note;
                        count++;
                    }
                }
                somme /= count;
                somme = (float)Math.Round(somme, 2);
                return count <= 0 ? 0 : somme;
            }
            public float moyenneGeneral()
            {
                float somme = 0;
                int differentesMatieres = notes.Select(n => n.matiere).Distinct().Count();
                foreach (var matiere in notes.Select(n => n.matiere).Distinct())
                {
                    somme += moyenneMatiere(matiere);
                }
                somme /= differentesMatieres;
                somme = (float)Math.Round(somme, 2);
                return differentesMatieres > 0 ? somme : 0;
            }
        }
    }
}