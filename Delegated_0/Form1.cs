using System.ComponentModel;

namespace Delegated_0
{
    public partial class Form1 : Form
    {

        /*
            Bu bir geriye döndürmeyen delegate tir. Yani içine alacaðý methodlarda vodi oalcak demektir. Ya hepsi void ya da hepsi deðer döndürecek demektir.
        Bu delegate parametre almadýðý için içine alacaðý methodlarda parametre almayacak diyebiliriz.
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
            // Medhod u delegate in içinde kullanýrken methodu çaðýrmayýp sadece nesne olarak delegate e verdiðimizden dolayý sadece ismini yazdýk.
            // Delegate Invoke edildiði zaman methodlarý sýralý çalýþtýr.
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
            MessageBox.Show($"Hoþgeldin {item}");
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