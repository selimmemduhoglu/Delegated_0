using System.ComponentModel;

namespace Delegated_0
{
    public partial class Form1 : Form
    {

        /*
            Bu bir geriye d�nd�rmeyen delegate tir. Yani i�ine alaca�� methodlarda vodi oalcak demektir. Ya hepsi void ya da hepsi de�er d�nd�recek demektir.
        Bu delegate parametre almad��� i�in i�ine alaca�� methodlarda parametre almayacak diyebiliriz.
         */
        delegate void MyDelegate();

        MyDelegate md1;

        delegate void TestDelegate(string item);

        TestDelegate td1;

        delegate int IslemYap(int sayi1, int sayi2);

        TestDelegate Id1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Medhod u delegate in i�inde kullan�rken methodu �a��rmay�p sadece nesne olarak delegate e verdi�imizden dolay� sadece ismini yazd�k.
            // Delegate Invoke edildi�i zaman methodlar� s�ral� �al��t�r.
            md1 = new MyDelegate(ChangedToColor);
            md1 += Hello;
            md1 += ChangedToColorBack;
            md1 += Hello;
            md1 += ChangedToColor;

            td1 = new TestDelegate(IsmeGoreSelamla);
            Id1 = new IslemYap(Topla);

        }

        public void Hello()
        {
            MessageBox.Show("Hello world");
        }
        public void ChangedToColorBack()
        {
            BackColor = Color.White;
        }
        public void ChangedToColor()
        {
            BackColor = Color.Red;

        }
        public int Topla(int x, int y)
        {
            return x + y;

        }
        public void IsmeGoreSelamla(string item)
        {
            MessageBox.Show($"Ho�geldin {item}");
        }
        private void btnInvoke_Click(object sender, EventArgs e)
        {
            md1.Invoke();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            td1.Invoke("Selim");
        }

        private void btn3Invoke_Click(object sender, EventArgs e)
        {
        }
    }
}