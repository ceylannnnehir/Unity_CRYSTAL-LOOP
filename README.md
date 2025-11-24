# 🎮 Unity_L1 - 2D Platform Oyun Projesi

**Geliştirici:** Nehir Ceylan  
**Unity Versiyonu:** 2022.3.62f2  
**Test Edilen Platform:** Windows  
**Geliştirme Ortamı:** Unity Hub  
**Oyun Türü:** 2D Platform Macera Oyunu

---

## 📌 Oyun Hakkında

Unity_L1, oyuncunun engelleri aşarak kristaller topladığı ve sahneler arası ilerleyerek oyunun finaline ulaşmaya çalıştığı 2D platform türünde bir oyundur. Oyunda can ve skor sistemi aktif olarak kullanılmaktadır.  

Toplam **7 sahne** bulunmaktadır. Oyuncu tüm sahneleri başarıyla tamamladığında **“Congratulations, You Won!”** ekranı görüntülenir ve **Replay** seçeneği ile oyun yeniden başlatılabilir.

---

## 🕹️ Kontrol Tuşları

| Tuş | İşlev |
|-----|------|
| **D** | Sağ (ileri git) |
| **A** | Sol (geri git) |
| **W** | Zıplama |
| **Boşluk (Space)** | Alternatif zıplama |
| **M veya Ses İkonu** | Müzik aç/kapa |
| **ESC** | Menüye dön |
| **ALT + F4** | Oyunu kapat |

---

## 💎 Skor Sistemi

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

- Can durumu sağ üst köşedeki **heart ikonuyla gösterilir.**
- **Can = 0** olduğunda *Game Over* ekranı açılır.
- *Play Again?* butonuna basıldığında:
  - **Oyun yeniden başlar**
  - **Can ve skor sıfırlanır**

---

## 🔊 Ses Sistemi

- Oyun başlangıcında arka plan müziği otomatik olarak çalıyor.
- Ses **buton veya M tuşu** ile açılıp kapatılabilir.
- Eğer ses açık bırakılırsa **farklı sahnelerde müzik kaldığı yerden devam eder.**
- Ses kapalıysa sahne geçişleri boyunca hiçbir ses çalmaz.

---

## 🔁 Sahne Yapısı

| Sahne No | Durum |
|----------|-------|
| 1 – 6 | Normal oyun ilerleyişi |
| 7 | Final sahnesi |
| Final | 🎉 “Congratulations, You Won!” ekranı |

Final ekranında:
- Sağ üstte **heart ve score tekrar görünür**
- Oyuncuya **Replay (yeniden oyna)** seçeneği sunulur

---

## 🎬 Oyun Tanıtım Videosu

🎥 Projenin oyun içi videosu sunumda gösterilecektir:

📎 *Ekran Kaydı 2025-11-24 15:55:18.mp4*  
*(Gerekirse harici bağlantı olarak paylaşılabilir.)*

---

## 📁 Projeyi Çalıştırma

```bash
1. Proje klasörünü bilgisayarınıza indirin.
2. Unity Hub → Open → Unity_L1 klasörünü seçin.
3. Unity sürümü farklıysa 2022.3.62f2 sürümünü yükleyin.
4. İlk sahneyi açın ve Play tuşuna basın.
