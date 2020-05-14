using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDRequestBoardLibrary
{

    public enum APDCategory : int
    {
        Masker = 1,
        Pelindung_Mata = 2,
        Pelindung_Wajah = 3,
        Gaun_Medis = 4,
        Sarung_Tangan_Medis = 5,
        Penutup_Kepala = 6,
        Sepatu_Pelindung = 7
    }

    static class APDCategories
    {
        public static APDDetails GetAPDDetails(this int s1)
        {
            switch (s1)
            {
                case 1:
                    return new APDDetails(
                        "Masker",
                        "Ada 2 jenis masker yang umumnya digunakan sebagai APD dalam penanganan pasien COVID-19 atau orang yang dicurigai terinfeksi virus Corona, yaitu masker bedah dan masker N95.\nMasker bedah merupakan masker penutup wajah yang terdiri dari 3 lapisan bahan yang digunakan sekali pakai.Masker ini dinilai efektif untuk mencegah masuknya virus Corona melalui mulut atau hidung, ketika ada percikan ludah penderita COVID - 19 saat ia batuk, bersin, atau bicara.\nMasker yang lebih efektif untuk mencegah virus Corona adalah masker N95.Masker ini terbuat dari bahan polyurethane dan polypropylene yang mampu menyaring hampir 95 % partikel berukuran kecil.Masker N95 memiliki bentuk yang dapat menutup area mulut dan hidung dengan lebih rapat, bila ukurannya sesuai.\nNamun, perlu Anda ketahui bahwa masker N95 hanya diperuntukkan bagi tenaga medis yang sedang menangani pasien dengan penyakit menular tertentu, termasuk pasien COVID - 19.\nUntuk mengurangi risiko penularan dan mencegah penularan kepada orang lain, pemerintah menyarankan masyarakat yang bukan tenaga medis untuk menggunakan masker kain.",
                        "https://id-test-11.slatic.net/shop/2c1a8c094767d21e22a13833f68ad43c.jpeg");
                case 2:
                    return new APDDetails(
                        "Pelindung Mata",
                        "Pelindung mata atau google terbuat dari bahan plastik transparan yang berfungsi untuk melindungi mata dari paparan virus yang dapat masuk ke dalam tubuh melalui mata. Alat pelindung ini harus pas menutupi area mata, serta tidak mudah berkabut atau mengganggu penglihatan.",
                        "https://s2.bukalapak.com/img/7935279653/w-1000/Kacamata_Safety_Clear_Pelindung_Mata_Motor_Alat_Las_Gurinda_.jpg");
                case 3:
                    return new APDDetails(
                        "Pelindung Wajah",
                        "Sama halnya dengan pelindung mata, pelindung wajah juga terbuat dari bahan plastik jernih dan transparan. Jenis APD ini dapat menutupi seluruh area wajah, mulai dari dahi hingga dagu.\nBersama masker dan pelindung mata, pelindung wajah mampu melindungi area wajah dari percikan air liur atau dahak saat pasien COVID - 19 batuk atau bersin.",
                        "https://cf.shopee.co.id/file/70ba908b115bddbd8ac5fff2c48e5b0c");
                case 4:
                    return new APDDetails(
                        "Gaun Medis",
                        "Gaun medis digunakan untuk melindungi lengan dan area tubuh dari paparan virus selama tenaga medis melakukan prosedur penanganan dan perawatan pasien.\nBerdasarkan penggunaannya, terdapat dua jenis gaun medis, yaitu gaun sekali pakai dan gaun yang bisa dipakai ulang. Gaun sekali pakai adalah gaun yang dirancang untuk dibuang setelah satu kali pakai. Jenis gaun ini terbuat dari bahan serat sintetis, seperti polypropylene, poliester, dan polyethylene, yang dikombinasikan dengan plastik.\nSedangkan gaun yang bisa dipakai ulang adalah gaun yang dapat digunakan lagi setelah dicuci atau dibersihkan. Pemakaiannya bisa hingga maksimal 50 kali, selama gaun tidak robek atau rusak. Gaun ini terbuat dari bahan katun atau poliester, atau kombinasi keduanya.\nGaun medis juga perlu dilengkapi dengan celemek atau apron untuk melapisi bagian luar gaun. Apron tersebut umumnya terbuat dari plastik yang tahan terhadap disinfektan.",
                        "https://cdn.shopify.com/s/files/1/1794/7341/products/5476119_71a3eb01-5d75-449b-beee-0bd96ab77490_500_500_large.jpg?v=1495531965");
                case 5:
                    return new APDDetails(
                        "Sarung Tangan Medis",
                        "Sarung tangan medis digunakan untuk melindungi tangan para petugas medis dari cairan tubuh pasien selama merawat pasien COVID-19. Sarung tangan ini idealnya tidak mudah sobek, aman digunakan, dan ukurannya pas di tangan.\nSarung tangan yang sesuai standar penanganan COVID-19 harus terbuat bahan lateks atau karet, polyvynil chloride (PVC), nitrile, dan polyurethane.",
                        "https://cf.shopee.co.id/file/282a1d3bfdc002da6cd0441cde1d3b14");
                case 6:
                    return new APDDetails(
                        "Penutup Kepala",
                        "Penutup kepala berfungsi untuk melindungi kepala dan rambut para petugas medis dari percikan air liur atau dahak pasien selama mereka merawat atau memeriksa pasien. Penutup kepala harus terbuat dari bahan yang dapat menahan cairan, tidak mudah robek, dan ukurannya pas di kepala. Jenis APD ini umumnya bersifat sekali pakai.",
                        "https://cf.shopee.co.id/file/26076064fe63e0d47159f4fab14b9e45");
                case 7:
                    return new APDDetails(
                        "Sepatu Pelindung",
                        "Sepatu pelindung digunakan untuk melindungi bagian kaki petugas medis dari paparan cairan tubuh pasien COVID-19. Sepatu pelindung umumnya terbuat dari karet atau kain yang tahan air dan harus menutup seluruh kaki hingga betis.",
                        "https://cf.shopee.co.id/file/647f778b917f92816f72fe01152a1fd3");
                default:
                    return new APDDetails(
                        "Kosong!",
                        "Kosong!",
                        "Kosong!");
            }
        }
    }
}
