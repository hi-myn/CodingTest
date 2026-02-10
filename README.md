# ☕ Coffee Recommendation API — Coding Challenge

This project was developed as part of a technical coding challenge.

The goal is to build a REST API that calculates current caffeine levels based on recent coffee consumption and recommends the next coffee type along with the ideal waiting time before drinking it.

---

## 🚀 What was implemented

- Project structure using **ASP.NET Core Web API**
- Models and in-memory repository
- Service layer with:
  - Caffeine half-life calculation
  - Business logic for coffee recommendations
- Dependency Injection
- REST endpoints (GET & POST)

---

## 🧠 Main Idea

The API simulates how caffeine decays in the body using a half-life model (5 hours) and suggests when it is safe to consume more caffeine, keeping the total around the ideal performance level (175mg).

---

## 📚 Notes

This project focuses mainly on architecture, business logic, and learning.  
Some parts are still being improved, as this was a great hands-on learning experience.

---

## 🛠 Tech Stack

- .NET 8
- ASP.NET Core Web API
- C#
