# 🧠 Planlytic

**Planlytic** is an AI-powered Kanban project management app designed to help individuals and teams organize tasks smarter and faster. Built with **React**, **ASP.NET Core**, and **SQLite**, Planlytic offers modern UX with OpenAI integration to assist in breaking down tasks into actionable subtasks.

---

## 🚀 Features (MVP)

✅ = implemented, 🔄 = in progress, ⏳ = planned

### 🔐 Authentication
- ⏳ User registration & login (JWT-based)
- ⏳ Protected API routes
- ⏳ Password hashing & basic user model

### 📁 Project & Task Management
- ⏳ Projects (create, edit, delete)
- ⏳ Boards (Kanban columns like To Do, In Progress, Done)
- ⏳ Task items (CRUD, status, priority, due dates)
- ⏳ Drag-and-drop tasks between columns
- ⏳ Task reordering within columns

### 🤖 AI Integration
- ⏳ AI-powered subtask generation (OpenAI GPT API)
- ⏳ Accept/modify suggested subtasks from the assistant

### 🖥 Frontend
- ⏳ React + Vite + TypeScript
- ⏳ Tailwind CSS styling
- ⏳ Auth forms & dashboard
- ⏳ Kanban board UI
- ⏳ Axios or React Query for API requests

### 🛠 Dev & Deployment
- ⏳ Swagger/OpenAPI docs
- ⏳ Dockerized backend
- ⏳ GitHub Actions CI for backend

---

## 🧰 Tech Stack

| Layer            | Tech                                      |
|------------------|--------------------------------------------|
| Frontend         | React + TypeScript + Tailwind CSS          |
| Backend          | ASP.NET Core Web API                       |
| Database         | SQLite (PostreSQL for prod) + Entity Framework Core         |
| AI Integration   | OpenAI GPT-4 API?                           |
| Auth             | JWT (JSON Web Tokens)                      |
| CI/CD            | GitHub Actions                             |

---

## 📦 Setup (WIP)

```bash
# Clone repo
git clone https://github.com/your-username/planlytic.git
cd planlytic

# Backend setup
cd API
dotnet restore
# Add connection string in appsettings.json
dotnet ef database update
dotnet run

# Frontend setup
cd ../client
npm install
npm run dev
```

> 🔑 You'll need an OpenAI API key stored in `.env` or secrets manager.

---

## 📈 Future Features (Post-MVP Ideas)

| Feature                                    | Status     |
|--------------------------------------------|------------|
| Invite team members to projects (roles)     | ⏳ Planned |
| Realtime task updates (SignalR)             | ⏳ Planned |
| AI-generated full project structure         | ⏳ Planned |
| Calendar view with drag-and-drop tasks      | ⏳ Planned |
| Subtask progress tracking                   | ⏳ Planned |
| Email / push notifications                  | ⏳ Planned |
| Activity logs & audit trail                 | ⏳ Planned |
| User productivity metrics dashboard         | ⏳ Planned |
| Light/dark mode                             | ⏳ Planned |
| Unit & integration testing                  | ⏳ Planned |

---

## 🧠 Why Planlytic?

- Full-stack real-world architecture
- Modern UI with drag-and-drop and responsive design
- Showcases GPT/AI integration in a practical app
---

## ✨ Contributors

- [Tymoteusz Marzec](https://github.com/InfoTCube) - Creator & Developer
