# **DocPlanner**

Bu uygulama özelleştirilmiş bir hekim randevu alma sistemi olarak simule edilmiştir. **ASP .Net Core Web API** projesi olarak sunulmuştur.


## **Kullanılan Teknoloji ve Araçlar**

Geliştirme ortamı olarak ***Visual Studio Community 2022 v17.9.2***

### Frameworks and Library

* .Net 8.0 (Long Term Support)
* Microsoft.EntityFrameworkCore v8.0.3
* Microsoft.EntityFrameworkCore.Design v8.0.3
* Microsoft.EntityFrameworkCore.Sqlite v8.0.3
* Microsoft.EntityFrameworkCore.Tools v8.0.3
* Newtonsoft.Json v13.0.3
* Swashbuckle.AspNetCore v6.4.0

## **Proje Kullanımı**

 

Proje içerisinden **SQLite** veritabanı kullanılmıştır. Migrations'lar oluşturulup veritabanına ait verilere ait ekleme yapılmıştır. Proje içerisinde **docplanner.db** dosyasında veritabanı verileri saklanmaktadır.


### Visual Studio aracılığıyla kullanım 
Local ortama çekildikten Github reposu klasörü içerisinde yer alan **DocPlannerStudyCase.sln** Visual Studio Solution bulunup açılmalı ve **Run** edilmelidir.

Kestrel server ya da ISS seçilip çalıştırılmışsa aşağıdaki link otomatik olarak açılacaktır.

http://localhost:5251/swagger/index.html

API'ları Swagger üzerinden rahatklıkla kullanabilirsiniz.

### API Listesi

**POST Metodları**

*BookVisitController* 'ına ait endpointler
```
/BookVisit
/cancelVisit
```
**GET Metodları**

*DoctorController* 'ına ait endpointler
```
/fetchDoctors
/exportDoctorCsv
```
*ScheduleController* 'ına ait endpointler
```
/fetchSchedule
```


## **Test Case'leri**

Projeye ait Unit Case'ler geliştirme sürecindedir. Belirtilen sürede yetiştirilememiştir.