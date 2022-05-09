namespace Abdullahboz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Tek bir Form ekranýnda yapýlacak bir ödevdir. 25 elemanlý 1-100 arasýnda rastgele tamsayýlardan oluþan bir dizi tanýmlanmalýdýr.
        Soru1: Oluþturulan diziyi Listbox’ta yazdýrýn.Listbox içindeki eleman boyutunu Label’e yazdýrýn. (5 puan)
        Soru2: 50’den küçük sayýlarý Listbox’ta yazdýrýn.Listbox içindeki eleman boyutunu Label’e yazdýrýn. (5 puan)
        Soru3: Tüm sayýlarýn ortalamasýný Listbox’ta yazdýrýn. (10 puan)
        Soru4: Üretilen sayýlardan en büyüðü Listbox’ta yazdýrýn. (Özel Fonksiyon kullanýmý yasaktýr! Algoritmik çözüm ile yapýlmalýdýr.) (25 puan)
        Soru5: Dizi içindeki asal sayýlarý Listbox’ta yazdýrýn.Listbox içindeki eleman boyutunu Label’e yazdýrýn. (30 puan)*/

        // Soru 4 ile 5 eklenecektir.

        private void Form1_Load(object sender, EventArgs e)
        {         
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); //rastgele sayý oluþturuldu.
            int[] numbers = new int[25]; // 25 elemanlý dizi oluþturuldu. 
            
            for (int i = 0; i < 25; i++)
            {
                numbers[i] = rnd.Next(1, 100); // rastgele 1, 100 arasý sayý atandý.
                listBox1.Items.Add(numbers[i]); // listbox'a eklendi sayýlar.
            }
            int numbersSize = listBox1.Items.Count;  //sayýlarýn eleman adeti bulundu.
            label1.Text = numbersSize.ToString();   //label 1'e eklendi label formstring yapýda olduðu için çevrildi.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            int[] numbers = new int[25];
            
            for (int i = 0; i < 25; i++)
            {           
                numbers[i] = rnd.Next(1, 50);
                listBox1.Items.Add(numbers[i]);            
            }
            int numbersSize = listBox1.Items.Count;
            label1.Text = numbersSize.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            int sum = 0; //deðiþken tanýmlandý.
            double avg;
            for (int i = 0; i < listBox1.Items.Count; i++) 
            {
                sum = sum + Convert.ToInt32(listBox1.Items[i]); //adetler toplandý. intte çevrildi.
            }
            avg = sum / listBox1.Items.Count; // adetlerin ortalamasý bulundu.
            listBox1.Items.Clear();   // listbox cok dolu olduðu için temizlendi.
            listBox1.Items.Add(avg);  // ortalamasý yazýldý.
        }
    }
}