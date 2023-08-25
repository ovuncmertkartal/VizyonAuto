using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VizyonAuto.Entity;


namespace VizyonAuto.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name = "Audi", Description = "Arac Audi"},
                new Category(){ Name = "BMW", Description = "Arac BMW"},
                new Category(){ Name = "Mercedes", Description = "Arac Mercedes"},
                new Category(){ Name = "Jaguar", Description = "Arac Jaguar"},
                new Category(){ Name = "Porsche", Description = "Arac Porsche"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                // AUDİ
                new Product(){
                    Name = "2023 Model Audi A6 Sedan 50 TDI Quattro Design",
                    Description = "Quattro Design Audi A6 Sedan, kavisli arka kenara sahip kısa bagaj bölmesi kapağının ortaya çıkardığı dinamik stiliyle öne çıkar.",
                    Price = 5723019,
                    Stock = 19,
                    IsApproved = true,
                    CategoryId = 1,
                    IsHome = true,
                    Image = "A1.png"},


                new Product(){
                    Name = "2023 Model Audi A7 Sportback 40 TDI S-Line Quattro",
                    Description = "Audi A7 Sportback, metalik Suzuka grisi Audi S Line Quattro kişiselleştirilmiş gövde rengi ile öne çıkar.",
                    Price = 4256420,
                    Stock = 11,
                    IsApproved = true,
                    CategoryId = 1,
                    IsHome = true,
                    Image = "A2.png"},

                new Product(){
                    Name = "2023 Model Audi A8 L Sedan 50 TDI Quattro Long",
                    Description = "Audi A8 L, Önde, arkada ve kapı kollarında bulunan parlak krom, zarif vurgular ekler ve aracın gövde rengine özel bir kontrast sağlar.",
                    Price = 6421760,
                    Stock = 7,
                    IsApproved = true,
                    CategoryId = 1,
                    IsHome = true,
                    Image = "A3.png"},

                new Product(){
                    Name = "2023 Model Audi Q7 SUV 50 TDI Quattro S-Line",
                    Description = "Audi Q7, S-Line Quattro dört tekerlekten çekiş, sportif kullanımıyla öne çıkar.",
                    Price = 7052204,
                    Stock = 14,
                    IsApproved = true,
                    CategoryId = 1,
                    IsHome = true,
                    Image = "A4.png"},

                new Product(){
                    Name = "2023 Model Audi Q8 SUV 50 TDI Quattro S-Line",
                    Description = "Audi Q8, Quattro S-Line, arkadan tahrikli ve her bir tekerlek için hassas bir şekilde ölçülü. Kendinden kilitlenen merkez diferansiyeline sahip quattro sürekli dört tekerlekten çekiş, tahrik gücünü ön ve arka akslar arasında 40:60 oranında dağıtarak olağanüstü çekiş ve yön dengesi sağlar.",
                    Price = 8112500,
                    Stock = 8,
                    IsApproved = true,
                    CategoryId = 1,
                    IsHome = true,
                    Image = "A5.png"},

                // BMW
                new Product(){
                    Name = "2023 Model BMW 520i Sedan 3.0 M Sport",
                    Description = "BMW 520i Sedan, BMW 5 Serisi M Sport Sedan, sportif business sedanın zirvesinde. İlk bakışta dinamik silueti ve sadeleştirilmiş tasarım diliyle kendini ifade eden, şık ve atletik bir etki yaratıyor. Pürüzsüz yüzeyleri ve keskin konturları şık dış tasarıma modern ve teknolojik bir atmosfer kazandırıyor.",
                    Price = 4256328,
                    Stock = 6,
                    IsApproved = true,
                    CategoryId = 2,
                    IsHome = true,
                    Image = "B1.png"},

                new Product(){
                    Name = "2023 Model BMW 740d xDrive Sedan M EXCELLENCE",
                    Description = "BMW 740d xDrive Sedan, mutlak şıklık ve tüm duyulara hitap eden eğlence anlayışı Yeni BMW 7 Serisi Sedan'da bir araya geliyor ve gerçek anlamda premium sürüş deneyimi sunuyor.",
                    Price = 9854621,
                    Stock = 16,
                    IsApproved = true,
                    CategoryId = 2,
                    IsHome = true,
                    Image = "B2.png"},

                new Product(){
                    Name = "2023 Model BMW 8 Coupé Sedan 3.0 M Sport",
                    Description = "BMW 8 Coupé Sedan, BMW 8 Serisi Coupé, spor otomobillere özgü karakteri BMW lüks sınıfının ayrıcalıklı şıklığıyla birleştiriyor.",
                    Price = 8052213,
                    Stock = 15,
                    IsApproved = true,
                    CategoryId = 2,
                    IsHome = true,
                    Image = "B3.png"},

                new Product(){
                    Name = "2023 Model BMW iX M60 SUV 3.0 Hybrid",
                    Description = "BMW iX M60 SUV, BMW iX M60, BMW i ve BMW M'in yenilikçi gücünü bir araya getiriyor. Spor Aktivite Aracı (SAV) performans segmentindeki tamamen elektrikli ilk BMW M aracını keşfedin.",
                    Price = 7420200,
                    Stock = 12,
                    IsApproved = true,
                    CategoryId = 2,
                    IsHome = true,
                    Image = "B4.png"},

                new Product(){
                    Name = "2023 Model BMW iX SUV 3.0 First Edition Sport",
                    Description = "BMW iX SUV, Bir vizyondan doğdu. Elektrikli mobilite için tasarlandı. Verimli BMW eDrive teknolojisi ve tamamen elektrikli dört çeker sistemi sayesinde olağanüstü bir menzile sahip olan BMW iX, hareket ettiği ilk andan itibaren etkileyici bir hızlanma vadediyor. Akıllı BMW İşletim Sistemi 8, tamamen sezgisel şekilde çalıştırılabiliyor.",
                    Price = 8210400,
                    Stock = 5,
                    IsApproved = true,
                    CategoryId = 2,
                    IsHome = true,
                    Image = "B5.png"},

                //MERCEDES
                new Product(){
                    Name = "2023 Model Mercedes-Benz A-180 AMG Sport 2.0 BlueEfficiency AMG",
                    Description = "Mercedes-Benz A-180 AMG, Çarpıcı radyatör ızgarası sahip yeni ön kısımdan düz LED farlara ve zarif sedan arka kısma kadar: Yeni A-Serisi Sedan her yerde kendini gösterir.",
                    Price = 1860410,
                    Stock = 12,
                    IsApproved = true,
                    CategoryId = 3,
                    IsHome = true,
                    Image = "M1.png"},

                new Product(){
                    Name = "2023 Model Mercedes-Benz AMG C-Serisi Sedan 2.0 4 Matic",
                    Description = "Mercedes-Benz AMG C-Serisi, C-Serisi Sedan modern lüksün gelişimini temsil eder. Tasarım dili belirgin bir şekilde en ince ayrıntısına kadar düşünülmüştür. 64 renkli aktif ambiyans aydınlatması dinamik geçişler yaparak ya da farklı bölgeleri çeşitli renklerle aydınlatarak size özel bir alan yaratır. Siz sadece arkanıza yaslanın ve rahatlayın.",
                    Price = 3025000,
                    Stock = 10,
                    IsApproved = true,
                    CategoryId = 3,
                    IsHome = true,
                    Image = "M2.png"},

                new Product(){
                    Name = "2023 Model Mercedes-Benz E 200 d AMG E-Serisi Sedan 2.0 4 Matic",
                    Description = "Mercedes-Benz E 200 d AMG E-Serisi, Dinamizmi ilk görüşte hissedin. Güç kubbelerine sahip öne doğru uzatılmış motor kaputu, güçlü led farlar ve modern jant tasarımları E-Serisi Sedan'a çarpıcı bir görünüm kazandırır.",
                    Price = 3305000,
                    Stock = 2,
                    IsApproved = true,
                    CategoryId = 3,
                    IsHome = true,
                    Image = "M3.png"},

                new Product(){
                    Name = "2023 Model Mercedes-Benz S 400 CDI S-Serisi Sedan 3.0",
                    Description = "Mercedes-Benz S 400 CDI S-Serisi, Mercedes-Benz S-Serisi’nin net tasarımı önemli detaylara odaklanmıştır: Dış mekanda mükemmel orantılar ve iç mekanda zamana uygun lüks. Bu sayede S-Serisi’nin trend belirleyen yenilikleri, vazgeçmek istemeyeceğiniz eşsiz bir görünüme sahip olur.",
                    Price = 11800000,
                    Stock = 9,
                    IsApproved = true,
                    CategoryId = 3,
                    IsHome = true,
                    Image = "M4.png"},

                new Product(){
                    Name = "2023 Model Mercedes-Benz Maybach S 400 CDI S-Serisi Sedan 3.0",
                    Description = "Mercedes-Benz Maybach S 400 CDI S-Serisi, Üstünlük ve eşsizlik tasarımı belirler. “Maybach” yazılı güçlü krom radyatör ızgarası ve krom süsleme çitalı motor kaputu ile vurgulanır. Aracın çevresinde, ikonik iki tonlu boya seçenekleriyle isteğe bağlı olarak mükemmel bir şekilde tamamlanan diğer birçok krom ayrıntı parlak bir şekilde ortaya çıkar.",
                    Price = 12100000,
                    Stock = 3,
                    IsApproved = true,
                    CategoryId = 3,
                    IsHome = true,
                    Image = "M5.png"},

                // JAGUAR
                new Product(){
                    Name = "2023 Model Jaguar XF Sedan 3.0 Premium",
                    Description = "Jaguar XF, İnce ve dikkat çekici ön animasyonlu sinyal lambalarıyla birlikte Premium LED farlar gün ışığına yakın bir ışık rengi üretir. Monogram desenli ızgara kafesi üzerindeki parlak siyah kaplama modelin şıklığını öne çıkarır.",
                    Price = 5440416,
                    Stock = 2,
                    IsApproved = true ,
                    CategoryId = 4,
                    IsHome = true,
                    Image = "J1.png"},

                new Product(){
                    Name = "2023 Model Jaguar XE Sedan 3.0 Sport Plus",
                    Description = "Jaguar XE, Kaslı yapısı, premium malzemeleri, ön ızgara tasarımı ve alaşım jantları ile kendinden emin bir duruş sergiler. Zarif ve şık Signature DRL özellikli LED farlar ve animasyonlu sinyal lambaları Jaguar XE modelinde standarttır. Arka bölümde ince LED stop lambaları aracın sportif özelliklerini tamamlar.",
                    Price = 4440416,
                    Stock = 0,
                    IsApproved = true ,
                    CategoryId = 4,
                    IsHome = true,
                    Image = "J2.png"},

                new Product(){
                    Name = "2023 Model Jaguar F-Type Sedan 2.0 R-DYNAMIC",
                    Description = "Jaguar F-Type, Signature DRL özellikli Pixel LED farlar, Jaguar F-TYPE'ın aerodinamik çizgileriyle birleşir. Hareketli Yön Göstergeleri, “J” Blade boyunca uzanır. İkonik Jaguar ambleminin yer aldığı çamurluk havalandırmaları, performans odaklı tasarımı mümkün olduğunca göz alıcı hale getirme ilkelerimizi tam olarak yansıtır.",
                    Price = 6950000,
                    Stock = 3,
                    IsApproved = true,
                    CategoryId =4,
                    IsHome = true,
                    Image = "J3.png"},

                new Product(){
                    Name = "2023 Model Jaguar E-Pace SUV 2.0 DYNAMIC",
                    Description = "Jaguar E-Pace, Jaguar E-PACE'in ince ve etkileyici LED farları, imza niteliğindeki çift \"J” şekli ve animasyonlu sinyal seçenekleriyle sunuluyor. Aynı zamanda piksel teknolojisini barındıran farlar, uzun far uzmanlığının en yeni örneklerini sunuyor.",
                    Price = 3065000,
                    Stock = 0,
                    IsApproved = true ,
                    CategoryId = 4,
                    IsHome = true,
                    Image = "J4.png"},

                new Product(){
                    Name = "2023 Model Jaguar F-Pace SUV 2.0 AWD R-SPORT",
                    Description = "Jaguar F-Pace, Motor kapağı, imza niteliği taşıyan monogram modelimizden ilham alan ön ızgarayı çevreler. Jaguar amblemini taşıyan çamurluk, havalandırmaları gibi detaylar Jaguar F-PACE'in duruşunu güçlendirir.",
                    Price = 3210000,
                    Stock = 1,
                    IsApproved = true ,
                    CategoryId = 4,
                    IsHome = true,
                    Image = "J5.png"},
                
                //PORSCHE
                new Product(){
                    Name = "2023 Model PORSCHE PANAMERA 4S 3.0 SPORT CHRONO",
                    Description = "PORSCHE PANAMERA 4S, Atletik, aerodinamik, net hatlara ve güçlü kaslara sahip.\r\nUzun dingil mesafesi, kısalan ön tampon ve uzayan arka tampon görsel dinamizm kazandırıyor. Yan yüzeylerin daha belirgin şekilde yapılandırılması, geleneksel Porsche bel hattını verirken hafiflik hissi yaratıyor.",
                    Price = 14000000,
                    Stock = 8,
                    IsApproved = true ,
                    CategoryId = 5,
                    IsHome = true,
                    Image = "P1.png"},

                new Product(){
                    Name = "2023 Model PORSCHE 718 Cayman 3.0 SPORT CHRONO",
                    Description = "PORSCHE 718 Cayman, Hassas ve gerçekçi. Kendinden emin ve sınır tanımayan. Alçak, geniş ve şık. 718 modellerinin dış tasarımı; sportif kenar kısımları ve net şekilde tanımlanmış muntazam konturlarıyla fark yaratır.",
                    Price = 9350000,
                    Stock = 0,
                    IsApproved = true ,
                    CategoryId = 5,
                    IsHome = true,
                    Image = "P2.png"},

                new Product(){
                    Name = "2023 Model PORSCHE 911 Carrera 4S 3.0 SPORT CHRONO",
                    Description = "PORSCHE 911 Carrera 4S, 911’in Coupé versiyonu Porsche DNA’sını en saf haliyle barındırır: uzun, düz kaput, dik bir eğime sahip olan ön cam. Ve tavan hatları, orijinal 911’de zaten karakterize edilmiş olduğu şekliyle, arkaya doğru hafif bir eğimle alçalır.",
                    Price = 13520400,
                    Stock = 2,
                    IsApproved = true ,
                    CategoryId = 5,
                    IsHome = true,
                    Image = "P3.png"},

                new Product(){
                    Name = "2023 Model PORSCHE Taycan 4S 3.0 Performance Plus",
                    Description = "PORSCHE Taycan 4S, Taycan 4S tavizsizdir ve günlük kullanım için mükemmel bir spor otomobildir. Çarpıcı oranlar, zamansız ve anında fark edilen tasarım. Geniş iç hacmi ve iki bagaj bölmesiyle dört kişiye konfor ve kolaylık sağlar.",
                    Price = 8600450,
                    Stock = 7,
                    IsApproved = true ,
                    CategoryId = 5,
                    IsHome = true,
                    Image = "P4.png"},

                new Product(){
                    Name = "2023 Model PORSCHE CAYENNE 3.0 Diesel PLATINUM EDITION",
                    Description = "PORSCHE CAYENNE 3.0 Diesel, Artık Cayenne’in kalbinde 474PS (349 kW) güç üreten ve 600 Nm torka sahip 3.0 litrelik çift turbolu V8 bir motor yer alıyor. V8 motorlar, olağanüstü hızlanma kabiliyetleri ile daha sarsıntısız kabin deneyimi sunarken, karakteristik bir Porsche deneyimi yaşatıyor.",
                    Price = 12000500,
                    Stock = 9,
                    IsApproved = true ,
                    CategoryId = 5,
                    IsHome = true,
                    Image = "P5.png"},


            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}