# Crystal-Report-creation-and-reporting-
# Crystal Report ile TextBox Arama ve Raporlama Projesi

Bu proje, C# Windows Forms kullanılarak geliştirilmiş bir Crystal Report uygulamasıdır.  
Kullanıcı TextBox üzerinden veri araması yapabilir ve sonuçları Crystal Report ile rapor halinde görüntüleyebilir.

---

## 🚀 Kullanılan Teknolojiler

- C#
- Windows Forms
- Microsoft Access
- Crystal Reports
- ADO.NET
- OleDbConnection

---

## 📌 Proje Özellikleri

✔ TextBox üzerinden veri arama  
✔ Access veritabanına bağlantı  
✔ Parametreli sorgu kullanımı  
✔ Crystal Report ile raporlama  
✔ DataGridView listeleme  
✔ Kullanıcı dostu arayüz  

---

## 🖥️ Uygulama Mantığı

1. Kullanıcı TextBox alanına veri girer  
2. Butona tıklanır  
3. Veritabanında arama yapılır  
4. Eşleşen kayıtlar listelenir  
5. Crystal Report ekranında rapor gösterilir  

---

## 📂 Veritabanı

Projede Microsoft Access veritabanı kullanılmıştır.

Örnek tablo alanları:
- ID
- ADI
- SOYADI
- TARİH
- RAPOR

---

## 🔍 Kullanılan Kod Yapıları

```csharp
OleDbConnection
OleDbCommand
OleDbDataAdapter
DataTable
CrystalReportViewer
