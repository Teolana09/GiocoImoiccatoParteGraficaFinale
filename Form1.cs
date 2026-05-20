namespace GiocoImoiccatoParteGrafica
{
    public partial class Form1 : Form
    {

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
            lblVittoria.Visible = false;
            LBLparolaErrata.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            LBLtentativi.Visible = false;
            textBox5.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox5.Visible = false;
            button1.Visible = false;
            BottonInsertLett.Visible = false;
            textBox7.Visible = false;
            CasellaInsTxt.Visible = false;
            lblinizio.Visible = false;
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
            lblPerso.Visible = false;
            LBLparolaErrata.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            LBLtentativi.Visible = false;
            textBox5.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox5.Visible = false;
            button1.Visible = false;
            BottonInsertLett.Visible = false;
            textBox7.Visible = false;
            CasellaInsTxt.Visible = false;
            lblinizio.Visible = false;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            CasellaInsTxt.Visible = false;
            BottonInsertLett.Visible = false;
            textBox7.Visible = false;
            button1.Visible = false;
            label3.Visible = false;
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
            textBox7.Visible = true;
            button1.Visible = true;
            lblinizio.Visible = false;


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
            textBox7.Visible = true;
            button1.Visible = true;
            label3.Visible = true;
            lblinizio.Visible = false;


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
            textBox7.Visible = true;
            button1.Visible = true;
            label3.Visible = true;
            lblinizio.Visible = false;
        }

        private void BottoneCoggetti_Click(object sender, EventArgs e)
        {
            paroleCategoriaScelta = ArrayParole[0].Split("|");
            BottoneCanimali.Visible = false;
            BottoneCcittà.Visible = false;
            BottoneCoggetti.Visible = false;
            int num = rnd.Next(0, 5);
            parolaDef = paroleCategoriaScelta[num];
            string[] visualizzazione = new string[parolaDef.Length];
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
            paroleCategoriaScelta = ArrayParole[1].Split("|");
            int num = rnd.Next(0, 5);
            BottoneCanimali.Visible = false;
            BottoneCcittà.Visible = false;
            BottoneCoggetti.Visible = false;
            string parolaDef = paroleCategoriaScelta[num];
            string[] visualizzazione = new string[parolaDef.Length];
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
    }
}
