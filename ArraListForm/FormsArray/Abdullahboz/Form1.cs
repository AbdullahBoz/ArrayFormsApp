namespace Abdullahboz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Tek bir Form ekran�nda yap�lacak bir �devdir. 25 elemanl� 1-100 aras�nda rastgele tamsay�lardan olu�an bir dizi tan�mlanmal�d�r.
        Soru1: Olu�turulan diziyi Listbox�ta yazd�r�n.Listbox i�indeki eleman boyutunu Label�e yazd�r�n. (5 puan)
        Soru2: 50�den k���k say�lar� Listbox�ta yazd�r�n.Listbox i�indeki eleman boyutunu Label�e yazd�r�n. (5 puan)
        Soru3: T�m say�lar�n ortalamas�n� Listbox�ta yazd�r�n. (10 puan)
        Soru4: �retilen say�lardan en b�y��� Listbox�ta yazd�r�n. (�zel Fonksiyon kullan�m� yasakt�r! Algoritmik ��z�m ile yap�lmal�d�r.) (25 puan)
        Soru5: Dizi i�indeki asal say�lar� Listbox�ta yazd�r�n.Listbox i�indeki eleman boyutunu Label�e yazd�r�n. (30 puan)*/

        // Soru 4 ile 5 eklenecektir.

        private void Form1_Load(object sender, EventArgs e)
        {         
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); //rastgele say� olu�turuldu.
            int[] numbers = new int[25]; // 25 elemanl� dizi olu�turuldu. 
            
            for (int i = 0; i < 25; i++)
            {
                numbers[i] = rnd.Next(1, 100); // rastgele 1, 100 aras� say� atand�.
                listBox1.Items.Add(numbers[i]); // listbox'a eklendi say�lar.
            }
            int numbersSize = listBox1.Items.Count;  //say�lar�n eleman adeti bulundu.
            label1.Text = numbersSize.ToString();   //label 1'e eklendi label formstring yap�da oldu�u i�in �evrildi.

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
           
            int sum = 0; //de�i�ken tan�mland�.
            double avg;
            for (int i = 0; i < listBox1.Items.Count; i++) 
            {
                sum = sum + Convert.ToInt32(listBox1.Items[i]); //adetler topland�. intte �evrildi.
            }
            avg = sum / listBox1.Items.Count; // adetlerin ortalamas� bulundu.
            listBox1.Items.Clear();   // listbox cok dolu oldu�u i�in temizlendi.
            listBox1.Items.Add(avg);  // ortalamas� yaz�ld�.
        }
    }
}