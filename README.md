# GG-Case-Project

Proje Gulliver's Games stajyerlik başvurusu kapsamında geliştirilmiştir. Kullanılan Unity versiyon: 2018.4.22 LTS

Proje içeriği;

Assets/_Prefabs ; ilgili proje içerisinde görmemiz gereken Canvas objesini içermektedir.
Assets/_Scenes ; ilgili proje içerisindeki gerekli objeleri tutan sahneyi içermektedir.
Assets/_Sprites ; ilgili proje içerisinde kullanılacak olan görsellerin .jps formatını içermektedir.
Assets/_Scripts ; ilgili proje içerisinde kullanılan kod script lerini içermektedir.

Projemizde kullanılan kodlar Assets/Scripts içerisindeki ButtonHandler script i içerisindedir. Bu script ise Canvas/SkinUnlockButton Buton objesine bağlıdır.
Button Handler Script i ile konsol ekranından Skin elementleri, Skin Source Image adresleri ve Skinler içerisinde kullanılacak olan görselleri tutmaktadır.

Button Handler Script kod sayfası içerisinde ise ; skin çerçevisini değiştirmek için, skin görselini değiştirmek için ve skin çerçevisini rastgele bir şekilde gezmek için method lar bulunmaktadır.


Proje başlarken;

Eğer simpleScene veya untitledScene sahnesi açılırsa Project/Assets/_Scene -> CaseScene menusu açılmalıdır.

Game ekranındaki taşma sorunu için;

File/Build Setting/Android-> Switch Platform işlemini gerçekleştirdikten sonra; Game ekranındaki Game yazısı altından formatı 2560x1440 Portrait seçmeniz tavsiye edilir.

Proje başlayınca;

Unlock Button tetiklendiğinde 9 skin frame i içerisinde rastgele bir gezinme yapıp son durduğu skin in görselini aktif etmektedir. 
Tüm skin lerin görselleri aktif edilene kadar bu işlem devam ettirilebilir.
Rastgele gezinme esnasında görseli aktif edilmiş bir skin e tekrar uğranmamaktadır.
Tüm skin lerin görselleri aktif edildiğinde Unlock Button un erişimi kullanıcıya kapatılmaktadır.

İyi Oyunlar..
Alperen İLERİ

