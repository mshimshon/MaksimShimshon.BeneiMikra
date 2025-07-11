# B'nei Mikra Application

**BeneiMikra** is an open-source front-end project created to share, preserve, and providing accurate information on Karaite Jewish beliefs, culture, and traditions — directly from a Karaite perspective. 
This initiative is both personal and communal: it's my own journey as a Torah-loving Karaite, and an invitation for others to contribute. 
This project invites Karaite and non-Karaite alike to explore our way of life without distortion, misrepresentation, or Rabbinic bias.

For too long, Karaite Judaism has been explained by outsiders who often mischaracterize or diminish our practices. 
**BeneiMikra** aims to change that. It is a tool to **educate**, **connect**, and **inspire** through insights and Karaite teachings.

## 🔹 What the app will include:
- **Personal Essays & Reflections**  
  On Torah living, challenges faced by converts, diaspora identity, and walking a Karaite path in modern times.

- **Karaite Authority Consensus**  
  Clarity on halakhic matters as agreed upon by the recognized Karaite institutions and scholars.

- **Blessing Book**  
  Karaite blessings with guidance, structure, and purpose... How many time have you been on to go without your blessing book?

- **Educational Guides**  
  How to make **tzitzit**, **count the omer**, observe **Shabbat**, and more.

- **Holiday Guide**  
  Step-by-step explanations of the **Karaite calendar** and holidays, made simple and direct.

- **Daily/Weekly/Monthly Torah Integration**  
  Future support for a **calendar** that integrates Torah portions, omer counting, and feast preparation reminders.

---

This project is a growing expression of a living tradition — not a museum piece. 
It's built with love for the Torah and a desire to help others navigate, question, and embrace a Karaite Jewish life.

If you're Karaite, may this deepen your understanding.  
If you're not, may this offer you an honest window into who we truly are.

> "We are not Rabbinic. We are not a sect. We are Israelites seeking Torah truth — directly from Scripture as B'nei Mikra (Children of the Scriptures)."

# Development
### Clean Architecture
This project uses clean architecture for its front-end so structural is very important for contributors.

```
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
```

## Policy of View Model to Component
- Variable should only be passed down to view model if it is used or manipulated.
- Therefore, when variable is available on the view model it is mandatory to use the viewmodel's to render and ignore the local parameter.
- Variables should be set on initialize or parameterset depending on logic and then call the ```Initialize``` or ```ParameterRefresh``` from the ViewModel.
