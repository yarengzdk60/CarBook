# 🚗 CarBook – Onion Architecture Based ASP.NET Core API

CarBook, ASP.NET Core Web API kullanılarak geliştirilmiş,
Onion Architecture yaklaşımını temel alan bir araç kiralama (rent-a-car) sistemidir.

Bu proje, katmanlı mimariyi doğru şekilde uygulamak,
tasarım desenlerini gerçek bir sektör senaryosu üzerinde kullanmak
ve ölçeklenebilir bir backend mimarisi oluşturmak amacıyla geliştirilmektedir.

> 📌 Proje aktif olarak geliştirilmeye devam etmektedir.

---

## 🏗️ Mimari Yapı

Projede **Onion Architecture** kullanılmıştır. Katmanlar arası bağımlılıklar
temiz bir şekilde ayrılmış ve SOLID prensiplerine uygun bir yapı kurulmuştur.

### Kullanılan Tasarım Desenleri
- CQRS (Command Query Responsibility Segregation)
- Mediator Pattern
- Repository Pattern

---

## ⚙️ Kullanılan Teknolojiler ve Yapılar

- ASP.NET Core Web API
- Onion Architecture
- Entity Framework Core
- CQRS & MediatR
- JWT (Json Web Token)
- Fluent Validation
- SignalR
- DTO Pattern
- Pivot Table yapıları

---

## 🚘 Proje Senaryosu

CarBook, araç kiralama süreçlerini yöneten bir backend API projesidir.
Araçlar, lokasyonlar, rezervasyonlar ve kullanıcı işlemleri
CQRS yaklaşımı ile ayrı ayrı ele alınmıştır.

---

## 🚧 Geliştirme Durumu

Proje geliştirme süreci devam etmektedir.
Yeni modüller, validasyonlar ve gerçek hayata daha yakın senaryolar
eklenmeye devam edilmektedir.
