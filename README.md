# CQRS ve MediatR ile Tek Projede Mimari

Bu projede, CQRS ile command ve query sorumluluklarının ayrılması, Mediator ile nesnelerin ilişkisinin tek bir yerden yönetildiği bir mimari ele alınmıştır. Basit tutulması ve sektör kullanımı açısından Mediator tasarım kalıbının kullanımı, MediatR kütüphanesi ile sağlanmıştır. Her iki prensibi ayrıca ele alan Repolarımı daha sonra ekleyeceğim.

## Paketler

Detaylı bilgi için [nuget](https://www.nuget.org/packages/MediatR).

```bash
dotnet add package MediatR --version 12.2.0
```
```bash
dotnet add package MediatR.Extensions.Microsoft.DependencyInjection --version 11.1.0
```

## Kurulum

```csharp
using MediatR;
using Microsoft.Extensions.DependencyInjection;

//detalı bilgi için https://chatgpt.com/share/5d97f1a4-2b22-4d77-aed5-2aafd7c943bd
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
```

## Klasörleme

    .
    ├── Med                     # Mediator ile ana dizin.
      ├── Commands              # CQRS Command sorumluluk dizini.
        ├── Request             # CQRS Command request nesne dizini.
        ├── Response            # CQRS Command response nesne dizini.
      ├── Handlers              # CQRS Handler sorumluluk dizini.
        ├── CommandHandlers     # CQRS Command Handler dizini.
        ├── QueryHandlers       # CQRS Query Handleer dizini.
     ├── Queries                # CQRS Queries sorumluluk dizini.
        ├── Request             # CQRS Queries request nesne dizini.
        ├── Response            # CQRS Queries rsponse nesne dizini.


> Katman için ayrıca projeler oluşturulması gerektiği gibi, repo için tek proje altında klasörleme yapılmıştır.


## Kaynaklar

[Gençay Yıldız CQRS](https://www.gencayyildiz.com/blog/cqrs-pattern-nedir-mediatr-kutuphanesi-ile-nasil-uygulanir/) -
[Gençay Yıldız Mediator](https://www.gencayyildiz.com/blog/c-mediator-design-patternmediator-tasarim-deseni/) -
[Gençay Yıldız Youtube](https://www.youtube.com/watch?v=LnIEFgs4iAA)

[TechBuddy Youtube](https://youtu.be/GDKy2xZsZhs)
