using System;
using System.IO;
using System.Windows.Forms;

namespace hafta7_odev1_dizinKopyalamaUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Dizin İçindeki Dosya, Klasör ve Alt Klasörleri Kopyalama Uygulaması \\
        string kaynakDizin, hedefDizin;
        private void bttn_DosyaSec_Click(object sender, EventArgs e)
        {
            // OpenFileDialog ile dosya seçimi yapılabildiği için dizin seçimi yapmak için FolderBrowser kullandım.
            // FolderBrowserDialog ile kaynak dizini seçtirmiş oldum.

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Kaynak Dizini Seç";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                kaynakDizin = folderBrowser.SelectedPath;
                label1.Text = kaynakDizin;
            }
        }
        private void bttn_KaydedilecekDosya_Click(object sender, EventArgs e)
        {
            // OpenFileDialog ile olduğu gibi SaveFileDialog da dosya seçmeye yarayan bir metot olduğu için FolderBrowserD kullandım.

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Hedef Dizini Seç";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                hedefDizin = folderBrowser.SelectedPath;
                label2.Text = hedefDizin;
            }
        }
        private void bttn_Kaydet_Click(object sender, EventArgs e)
        {
            // Kaydet tuşumuza bastığımızda Kaynak ve Hedef dosya seçilip seçilmediini kontrol edip eksik ise
            // MessageBox ile bilgilendirdim. Eğer ikisi de mevcut ise işleme başladım.

            if (label1.Text == " ")
            {
                MessageBox.Show("Kaynak Dosya Seçilmedi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (label2.Text == " ")
            {
                MessageBox.Show("Hedef Dizin Seçilmedi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string kaynakYolu = kaynakDizin;
                string hedefYolu = hedefDizin;

                try // Kullanımda hata çıkması durumunda kullanıcıya belirtmek için trt{}catch{} kullandım.
                {
                    DizinKopyala(kaynakYolu, hedefYolu); // Dizin kopyalayabildiğimiz metodumu recursive olduğu için aşağıda Private ekledim.
                    MessageBox.Show("Kopyalandı", "Bilgilemdirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DizinKopyala(string kaynak, string hedef) //   Klasör içindeki alt klasörleri kopyalamak için
                                                               // özyinelemeli kullanmam gerekti o yüzden metot oluşturdum.
        {
            if (!Directory.Exists(hedef))
            {
                // Hedef dizine kaynaktaki dizinleri oluşturdum.
                Directory.CreateDirectory(hedef);
            }
            string[] dosyaDizisi = Directory.GetFiles(kaynak);
            foreach (string dosya in dosyaDizisi)
            {
                string dosyaKonumu = Path.Combine(hedef, Path.GetFileName(dosya)); 
                // Hedef dizin ve dosya adının birleştirilerek dizin  dizin yolu oluşturulmasını sağlar. Böylece hedef kopyalanmasını sağlarım. 
                File.Copy(dosya, dosyaKonumu, true); //  'true' Eğer hedef var olan bir dosya ismi kullanıyorsa hedef dosyanın üstüne
                                                     // yazmasına olanak tanır yani 'overwrite'. 'true', yazarken tab'a bastığımda otomatik geldi ancak internetten araştırdım. 
            }
            string[] klasorDizisi = Directory.GetDirectories(kaynak);
            foreach (string klsr in klasorDizisi)
            {
                string klsrKonumu = Path.Combine(hedef, Path.GetFileName(klsr));
                DizinKopyala(klsr, klsrKonumu); // Alt klasörleri de dahil etmiş oldum.
            }
        }
    }
}
