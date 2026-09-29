namespace listb
{
    public partial class Form1 : Form
    {
        List<string> ordati = new List<string>();
        public Form1()
        {
            InitializeComponent();
            ordati.Add("serpe");
            ordati.Add("cavallo");
            ordati.Add("formica");
            ordati.Add("uccello");
            ordati.Add("aquila");
            ordati.Add("cane");
            ordati.Add("gatto");
            agg();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (pV(txt1.Text) == false)
            {
                MessageBox.Show("erroe");
            }
            else
            {
                string nn = txt1.Text.ToLower();
                nn = nn.Trim();
                ordati.Add(nn);
                txt1.Text = "";
                agg();

            }
        }
        private void agg()
        {
            listAn.Items.Clear();
            foreach (string item in ordati)
            {
                listAn.Items.Add(item);
            }
        }
        private bool pV(string x)
        {
            if (x == null)
            {
                return false;
            }
            if (x == "")
            {
                return false;
            }
            for (int i = 0; i < ordati.Count; i++)
            {
                if (ordati[i] != "")
                {
                    return true;
                }
            }
            return false;
        }
        private void car()
        {
            if (File.Exists("animali.txt"))
            {

            }
            else
            {
                using (StreamReader sr = new StreamReader("animali.txt"))
                {
                    while (sr.EndOfStream==null) 
                    {

                        string line = sr.ReadLine();
                        if (pV(line) == true)
                        {
                            line = line.Trim();
                            line = line.ToLower();
                            ordati.Add(line);
                        }
                    }


                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }
    }
}
