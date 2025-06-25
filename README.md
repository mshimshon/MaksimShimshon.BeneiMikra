# MaksimShimshon.BeneiMikra
Be'nei Mikra a Karaite Project





/Client
│
├── Application/                 ← CQRS Layer (what the UI wants to do)
│   ├── Commands/
│   │   ├── CreateArticle/
│   │   │   ├── CreateArticleCommand.cs
│   │   │   ├── CreateArticleHandler.cs
│   │   │   └── CreateArticleValidator.cs
│   ├── Queries/
│   │   ├── GetFeaturedArticles/
│   │   │   ├── GetFeaturedArticlesQuery.cs
│   │   │   ├── GetFeaturedArticlesHandler.cs
│   │   │   └── GetFeaturedArticlesValidator.cs
│   └── Interfaces/
│       └── IArticleRepository.cs       ← Used by Handlers
│
├── Domain/                     ← Frontend domain models (not tied to backend)
│   ├── Models/
│   │   └── Article.cs
│   └── Enums/
│       └── ArticleStatus.cs
│
├── Infrastructure/             ← Implementation of Repositories, Http logic
│   ├── Repositories/
│   │   └── ArticleRepository.cs      ← Implements IArticleRepository
│   └── Http/
│       ├── IStrapiHttpClient.cs
│       ├── StrapiHttpClient.cs
│       └── Extensions/
│           └── HttpResponseExtensions.cs
│
├── Shared/                     ← Reusable UI / Services / Global Components
│   ├── Services/
│   │   ├── NavigationService.cs
│   │   └── NotificationService.cs
│   └── Components/
│       ├── LoadingSpinner.razor
│       └── Pagination.razor
│
├── Features/                   ← UI Features (views + partial logic)
│   ├── Articles/
│   │   ├── Pages/
│   │   │   └── Featured.razor
│   │   └── ViewModels/
│   │       └── FeaturedArticleViewModel.cs
│
├── Dtos/                       ← (Optional) Mirrors backend contracts only
│   ├── Requests/
│   ├── Responses/
│   └── Errors/
│
├── Pulsars/                      ← Optional (StatePulse, Fluxor, etc.)
│   ├── Requests/
│   ├── Responses/
│   └── Errors/
│
├── Program.cs                  ← Blazor entry
├── App.razor
└── MainLayout.razor
