namespace GiocoImoiccatoParteGrafica
{
    public partial class Form1 : Form
    {
        bool jollyUtilizzato = false;
        int contatore = 0, contatoreErrate = 0;
        string[] ParolaC;
        string[] ArrayParole;
        string[] paroleCategoriaScelta;
        string parolaScelta;
        int tentativi = 3;
        int monete = 20;
        bool vittoria = false;
        bool jolly = false;
        string suggerimento = "";
        string parolaDef = "";
        string[] visualizzazione;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

        }
        private void inizio()
        {
            BottoneCanimali.Visible = false;
            BottoneCcittà.Visible = false;
            BottoneCoggetti.Visible = false;
            BottonInsertP.Visible = false;


        }
        private void FineBuona()
        {
            BottonePSemplici.Visible = false;
            BottonePMedie.Visible = false;
            BottonePDifficile.Visible = false;
            BottoneCanimali.Visible = false;
            BottoneCcittà.Visible = false;
            BottoneCoggetti.Visible = false;
            lblParola.Visible = false;
            LBLparolaErrata.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            LBLtentativi.Visible = false;
            textBox5.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox5.Visible = false;
            BottoneJolly.Visible = false;
            BottonInsertLett.Visible = false;
            tTentativi.Visible = false;
            CasellaInsTxt.Visible = false;
            lblinizio.Visible = false;
            BottonInsertP.Visible = false;
            txtInsertP.Visible = false;
            lblVittoria.Visible = true;

        }
        private void FineCattiva()
        {
            BottonePSemplici.Visible = false;
            BottonePMedie.Visible = false;
            BottonePDifficile.Visible = false;
            BottoneCanimali.Visible = false;
            BottoneCcittà.Visible = false;
            BottoneCoggetti.Visible = false;
            lblParola.Visible = false;
            lblPerso.Visible = true;
            LBLparolaErrata.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            LBLtentativi.Visible = false;
            textBox5.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox5.Visible = false;
            BottoneJolly.Visible = false;
            BottonInsertLett.Visible = false;
            tTentativi.Visible = false;
            CasellaInsTxt.Visible = false;
            lblinizio.Visible = false;
            BottonInsertP.Visible = false;
            txtInsertP.Visible = false;
            lblVittoria.Visible = true;
            

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            CasellaInsTxt.Visible = false;
            BottonInsertLett.Visible = false;
            tTentativi.Visible = false;
            BottoneJolly.Visible = false;
            label3.Visible = false;
            BottonInsertP.Visible = false;
            txtInsertP.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayParole = File.ReadAllLines("ParoleSemplici.csv");
            inizio();

            BottonePSemplici.Visible = false;
            BottonePMedie.Visible = false;
            BottonePDifficile.Visible = false;
            BottoneCanimali.Visible = true;
            BottoneCcittà.Visible = true;
            BottoneCoggetti.Visible = true;
            label4.Visible = true;
            CasellaInsTxt.Visible = true;
            BottonInsertLett.Visible = true;
            tTentativi.Visible = true;
            BottoneJolly.Visible = true;
            lblinizio.Visible = true;
            BottonInsertP.Visible = true;
            txtInsertP.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayParole = File.ReadAllLines("ParoleMedie.csv");
            inizio();

            BottonePSemplici.Visible = false;
            BottonePMedie.Visible = false;
            BottonePDifficile.Visible = false;
            BottoneCanimali.Visible = true;
            BottoneCcittà.Visible = true;
            BottoneCoggetti.Visible = true;
            label4.Visible = true;
            CasellaInsTxt.Visible = true;
            BottonInsertLett.Visible = true;
            tTentativi.Visible = true;
            BottoneJolly.Visible = true;
            label3.Visible = true;
            lblinizio.Visible = false;
            BottonInsertP.Visible = true;
            txtInsertP.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArrayParole = File.ReadAllLines("ParoleDifficili.csv");
            inizio();

            BottonePSemplici.Visible = false;
            BottonePMedie.Visible = false;
            BottonePDifficile.Visible = false;
            BottoneCanimali.Visible = true;
            BottoneCcittà.Visible = true;
            BottoneCoggetti.Visible = true;
            label4.Visible = true;
            CasellaInsTxt.Visible = true;
            BottonInsertLett.Visible = true;
            tTentativi.Visible = true;
            BottoneJolly.Visible = true;
            label3.Visible = true;
            lblinizio.Visible = false;
            BottonInsertP.Visible = true;
            txtInsertP.Visible = true;

        }

        private void BottoneCoggetti_Click(object sender, EventArgs e)
        {
            textBox5.Visible = false;
            paroleCategoriaScelta = ArrayParole[0].Split("|");
            BottoneCanimali.Visible = false;
            BottoneCcittà.Visible = false;
            BottoneCoggetti.Visible = false;
            int num = rnd.Next(0, 5);
            parolaDef = paroleCategoriaScelta[num];
            visualizzazione = new string[parolaDef.Length];
            for (int i = 0; i < visualizzazione.Length; i++)
            {
                visualizzazione[i] = " _ ";
            }
            string trattini = "";
            for (int i = 0; i < visualizzazione.Length; i++)
            {
                trattini += visualizzazione[i];

            }
            lblParola.Text = trattini;
        }

        private void BottoneCanimali_Click(object sender, EventArgs e)
        {
            textBox5.Visible = false;
            paroleCategoriaScelta = ArrayParole[1].Split("|");
            int num = rnd.Next(0, 5);
            BottoneCanimali.Visible = false;
            BottoneCcittà.Visible = false;
            BottoneCoggetti.Visible = false;
            parolaDef = paroleCategoriaScelta[num];
            visualizzazione = new string[parolaDef.Length];
            for (int i = 0; i < visualizzazione.Length; i++)
            {
                visualizzazione[i] = " _ ";
            }
            string trattini = "";
            for (int i = 0; i < visualizzazione.Length; i++)
            {
                trattini += visualizzazione[i];

            }
            lblParola.Text = trattini;
        }

        private void BottoneCcittà_Click(object sender, EventArgs e)
        {
            textBox5.Visible = false;
            paroleCategoriaScelta = ArrayParole[2].Split("|");
            int num = rnd.Next(0, 5);
            BottoneCanimali.Visible = false;
            BottoneCcittà.Visible = false;
            BottoneCoggetti.Visible = false;
            parolaDef = paroleCategoriaScelta[num];
            visualizzazione = new string[parolaDef.Length];

            for (int i = 0; i < visualizzazione.Length; i++)
            {
                visualizzazione[i] = " _ ";
            }
            string trattini = "";
            for (int i = 0; i < visualizzazione.Length; i++)
            {
                trattini += visualizzazione[i];

            }
            lblParola.Text = trattini;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void CasellaInsTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void BottonInsertLett_Click(object sender, EventArgs e)
        {
            char[] paDef = parolaDef.ToCharArray();
            char lettera = CasellaInsTxt.Text[0];
            if (parolaDef.Contains(lettera))
            {
                for (int j = 0; j < paDef.Length; j++)
                {
                    if (paDef[j] == lettera)
                    {
                        visualizzazione[j] = " " + lettera + " ";
                    }
                }
                lblParola.Text = String.Join("", visualizzazione);
                contatore += 1;
                LBLparolaErrata.Text = "lettera Corretta!!!";
            }
            else
            {
                LBLparolaErrata.Text = "la lettera è errata reinserire";
                contatoreErrate += 1;
                LBLtentativi.Text = Convert.ToString(contatoreErrate);
                if (contatoreErrate == 5)
                {
                    lblPerso.Text = "HAI PERSO";
                    FineCattiva();
                }
            }
            if (contatore == paDef.Length)
            {
                lblVittoria.Text = "Complimenti HAI VINTO";
                FineBuona();
            }
        }

        private void BottonInsertP_Click(object sender, EventArgs e)
        {
            string parolaTotale = txtInsertP.Text; // stringa parola inserimento finale
            if (parolaDef == parolaTotale)
            {
                lblVittoria.Text = "Complimenti HAI VINTO";
                FineBuona();
            }
            else
            {
                lblPerso.Text = "HAI PERSO";
                FineCattiva();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BottoneJolly.Visible = false;
            jollyUtilizzato = true;
            Random rnd = new Random();       
            
            int indice = 0;
            while (visualizzazione[indice] != " _ ")
            {
                indice = rnd.Next(0, parolaDef.Length);
            }

            char letteraRivelata = parolaDef[indice];
            Console.WriteLine("JOLLY USATO! La lettera rivelata è:" + letteraRivelata);
            jollyUtilizzato = false;       

            for (int j = 0; j < parolaDef.Length; j++)
            {
                if (parolaDef[j] == letteraRivelata)
                {
                    visualizzazione[j] = " " + letteraRivelata.ToString() + " ";
                }
                lblParola.Text = String.Join("", visualizzazione);
                lbljollyUsato.Text = "JOLLY USATO!";
            }            
        }
    }
}
