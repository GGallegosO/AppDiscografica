# 🎸 Sistema de Gestión de Eventos - Discográfica

[![.NET](https://img.shields.io/badge/.NET-5.0+-512bd4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2019+-red?style=for-the-badge&logo=microsoft-sql-server)](https://www.microsoft.com/en-us/sql-server/)

Este proyecto es el trabajo final para la asignatura de Programación en **Santo Tomás**. Se trata de una aplicación de escritorio diseñada para gestionar conciertos y eventos musicales, aplicando estándares de industria en arquitectura y persistencia de datos.

---

## 🚀 Características (CRUD)

El sistema permite gestionar el ciclo de vida completo de la información de eventos:

-   **[C]reate:** Registro de nuevos eventos con validaciones de precio y nombre.
-   **[R]ead:** Visualización en tiempo real mediante un `DataGridView` sincronizado.
-   **[U]pdate:** Modificación de registros existentes con carga automática de datos.
-   **[D]elete:** Eliminación segura con cuadros de diálogo de confirmación.

---

## 🏗️ Arquitectura del Sistema

Se implementó una **Arquitectura N-Capas** para garantizar el desacoplamiento y la mantenibilidad del código:

| Capa | Responsabilidad |
| :--- | :--- |
| **AppDiscograficaUI** | Interfaz de usuario (Windows Forms). Maneja eventos y captura de datos. |
| **AppDiscografica.Negocios** | Capa BO (Business Objects). Valida reglas de negocio antes de la persistencia. |
| **AppDiscografica.Datos** | Capa DAO (Data Access Object). Maneja la comunicación con SQL Server. |
| **AppDiscografica.Clases** | Entidades del dominio compartidas entre todas las capas. |

[Image of three-tier architecture diagram for software applications]

---

## 🛠️ Stack Tecnológico

-   **Lenguaje:** C# / .NET
-   **Framework UI:** Windows Forms
-   **Motor de DB:** SQL Server
-   **ORM:** Entity Framework Core (Database First / Code First)
-   **Control de Versiones:** Git & GitHub

---

## 🔧 Configuración e Instalación

1. **Clonar el repositorio:**
   ```bash
   git clone [https://github.com/GGallegosO/AppDiscografica.git](https://github.com/GGallegosO/AppDiscografica.git)
