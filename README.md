# 🎮 CRYSTAL LOOP - 2D Platform Oyun Projesi

**Geliştirici:** Nehir Ceylan  
**Unity Versiyonu:** 2022.3.62f2  
**Test Edilen Platform:** Windows  
**Geliştirme Ortamı:** Unity Hub  
**Oyun Türü:** 2D Platform Macera Oyunu

---

## 📌 Oyun Hakkında

CRYSTAL LOOP, 2D platform türünde tasarlanmış bir macera oyunudur. Oyuncu, belirlenmiş tuş kombinasyonları ile karakteri yönlendirerek engelleri aşmaya, kristal toplayarak skor artırmaya (skore), can seviyesi (heart) engellere çarparak değişmekte ve sahneleri geçerek oyunun sonuna ulaşmaya çalışılmkatadır.

Oyun yalnızca bilgisayar üzerinde test edilmiş olup **Windows işletim sisteminde sorunsuz çalışmaktadır**. Android cihazlarda oyun açılabilse de kontrol tuşları tanımlı olmadığı için mobil platformda oynanabilir değildir.

Oyun toplam **8 sahneden** oluşmakta, 5 sahnede oyun yer almakta (level) diğer 3 sahne oyun başlangıç, oyunu tekrar oynama ve oyun bitiş sahnesi yer almaktadır. 
Oyuncu can seviyesini sıfırladığında **"Game Over Play Again?"** ekranı görüntülenir ve **Play** butonu ile oyuna tekrar başlatılmaktadır.
Oyuncu tüm sahneleri başarıyla tamamladığında **“Congratulations, You Won!”** ekranı görüntülenir ve **Replay** butonu ile oyun tekrar başlatılabilir.  



---

## 🕹️ Kontrol Tuşları

| Tuş | İşlev |
|-----|------|
| **D** | Sağ (ileri git) |
| **A** | Sol (geri git) |
| **W** | Zıplama |
| **W + A ** | Sağ zıplama |
| **W + D ** | Sol zıplama |
| **ALT + F4** | Oyunu kapat |

---

## 💎 Skor (Score) Sistemi

- Skor durumu sağ üst köşedeki **Score text ile gösterilir.**
- Oyunda yer alan **kristaller toplandıkça skor artar.**
- Sahneler arası geçişte **skor korunur ve üzerine eklenir.**
- Game Over durumunda skor **sıfırlanır.**

🎵 Kristal toplandığında özel **efekt sesi çalınmaktadır.**

---

## ❤️ Can (Health) Sistemi

| Durum | Can Azaltır mı? |
|-------|----------------|
| Engellere çarpma | ✔ |
| Suya düşme | ✔ |
| Bataklık | ✔ |
| Boşluk alanı | ✔ |

- Can durumu sağ üst köşedeki **heart text ile gösterilir.**
- **Heart = 0** olduğunda *Game Over Play Again?* ekranı açılır.
- *Play* butonuna basıldığında:
  - **Oyun yeniden başlar**
  - **Heart ve Score sıfırlanır**

---

## 🔊 Ses Sistemi

- Oyun başlangıcında arka plan müziği otomatik olarak çalıyor.
- Ses ** ses ikonu açma / kapama butonu ** ile açılıp kapatılabilir.
- Eğer ses açık bırakılırsa **farklı sahnelerde müzik kaldığı yerden devam eder.**
- Ses kapalıysa sahne geçişleri boyunca arka plan müziği çalmaz.

---

## 🔁 Sahne Yapısı

| Sahne No | Durum |
|----------|-------|
| 0 | Giriş sahnesi |
| 1-2-3-4-5 | Normal oyun ilerleyişi |
| 6 | Final sahnesi |
| 7 | GameOver sahnesi |


Final ekranında:
- Sağ üstte **heart ve score tekrar görünür**
- Oyuncuya **Replay ( yeniden oyna)** seçeneği sunulur.
  
GameOver ekranında:
- **heart ve score değerleri görünmez**
- Oyuncuya **Play ( yeniden oyna)**  seçeneği sunulur.
---

## 🎬 Oyun Tanıtım Videosu

🎥 Projenin oyun içi videosu sunumda gösterilecektir:

📎 *(https://drive.google.com/file/d/1mI9UF-ym6g65oDxTjI5PGrnqeQDM1eDE/view?usp=sharing)*  
https://drive.google.com/file/d/1mI9UF-ym6g65oDxTjI5PGrnqeQDM1eDE/view?usp=drive_link


---

## 📁 Projeyi Çalıştırma

```bash
1. Proje klasörünü bilgisayarınıza indirin.
2. Unity Hub → Open → Unity_L1 klasörünü seçin.
3. Unity sürümü farklıysa 2022.3.62f2 sürümünü yükleyin.
4. İlk sahneyi açın ve Play tuşuna basın.
