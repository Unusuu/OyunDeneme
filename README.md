# OyunDeneme

Unity ile hazırlanmış, platform hareketlerini ve ateş etme mekaniğini birleştiren 2D aksiyon oyunu prototipi.

[![Tanıtım videosu](https://img.youtube.com/vi/U9kb3HWPuTI/hqdefault.jpg)](https://www.youtube.com/watch?v=U9kb3HWPuTI)

## Özellikler

- Yatay hareket, zıplama ve karakter yönünü çevirme
- Fare ile mermi oluşturma ve düşmanlara hasar verme
- Oyuncu ve düşman can barları
- Düşman öldürme ve ateşlenen mermi istatistikleri
- Toplam istatistikleri yerel dosyada saklama
- Ana menü, duraklatma, devam etme, yeniden başlatma ve ana menüye dönme akışları
- Menü ve oyun sahnesi

## Gereksinimler

- Unity Hub
- Unity Editor `2022.2.21f1`
- Git

## Kurulum

```bash
git clone https://github.com/Unusuu/OyunDeneme.git
```

1. Unity Hub'da **Add project from disk** seçeneğini açın.
2. Depo klasörünü seçin ve projeyi `2022.2.21f1` ile açın.
3. `Assets/Scenes/MenuScene.unity` sahnesini açın.
4. Play düğmesiyle projeyi çalıştırın.

## Kontroller

| Eylem | Kontrol |
|---|---|
| Hareket | Unity `Horizontal` ekseni (`A/D` veya yön tuşları) |
| Zıplama | Unity `Vertical` ekseninin yukarı yönü (`W` veya yukarı ok) |
| Ateş | Sol fare tuşu |
| Duraklat / devam et | Oyun içi arayüz düğmeleri |

## Proje yapısı

```text
Assets/
├── Scenes/          # Menü ve oyun sahneleri
├── Scripts/         # Oyuncu, düşman, mermi, veri ve menü yönetimi
├── PreFabs/         # Oyun nesneleri
├── Animations/      # Karakter ve arayüz animasyonları
└── Resources/       # Font ve fizik materyalleri
```

## Kullanılan paket ve varlıklar

- TigerForge Easy File Save
- Bayat Games Free Platform Game Assets
- Casual Game Sounds

Üçüncü taraf varlıkları yeniden dağıtmadan veya ticari bir build yayımlamadan önce ilgili paketlerin lisans koşullarını kontrol edin.

## Proje durumu

Bu depo bir prototiptir. Üretim sürümü için oyun sonu arayüzü, hata kontrolleri, testler, dengeli hasar hesapları ve güncel bir Unity LTS sürümüne geçiş önerilir.

## Lisans

Bu depoda proje geneli için bir lisans dosyası bulunmuyor. Üçüncü taraf varlıkların kendi lisansları geçerlidir.
