namespace szótár
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> szótár = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            szótár["apple"] = "alma";
            szótár["car"] = "autó";
            szótár["faith"] = "hit";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ha megvan kulcs alapján, akkor könnyű:
            if (szótár.ContainsKey(textBox1.Text))
                label2.Text = "Angol szó, magyarul: " + szótár[textBox1.Text];
            else
            //Ha nincs, megpróbálom érték alapján keresni:
            if (szótár.ContainsValue(textBox1.Text))
            {
                //Ha megvan, átnézem egyesével:
                foreach (KeyValuePair<string, string> elem in szótár)
                {
                    if (elem.Value == textBox1.Text)
                        label2.Text = "Magyar szó, angolul: " + elem.Key;
                }
            }
            else label2.Text = "Sajnos nem találtam meg a szót.";
        }
    }
}
