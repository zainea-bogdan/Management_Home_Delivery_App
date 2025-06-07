# Management Home Delivery App

<p align="center">
  <img src="logo home delivery logo.png" alt="Logo" width="600">
</p>
<p align="center">
  <em>Created using Canva AI tools. I do not claim ownership of the visual elements.<br>
  If this image presents an issue, please feel free to contact me.</em>
</p>

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Postgres](https://img.shields.io/badge/postgres-%23316192.svg?style=for-the-badge&logo=postgresql&logoColor=white)

# Home Deliveries Management System

A Windows Forms application built using **C#** and **.NET Framework**, this project provides a prototype solution for managing home deliveries with both **client** and **admin** functionalities. The application handles user authentication, order placement, invoice generation, data visualization, and backend integration with a **PostgreSQL** database and local **JSON** storage.

## Table of Contents

- [Features](#features)
  - [Client Panel](#client-panel)
  - [Admin Panel](#admin-panel)
  - [Easter Eggs](#easter-eggs)
- [Technologies Used](#technologies-used)


## Features

### Authentication System
- **Sign In:** Users can register by providing a name and password. Basic validation is applied:
  - Name must meet spcific requirements.
  - Password must contain certain complexity elements.
- **Data Storage:**
  - User credentials are saved both in a **local JSON file** and a **PostgreSQL database**.
- **Login:** Validates credentials against stored JSON data to grant access to the client panel.

### Client Panel

Once logged in, users are redirected to a main dashboard with the following options:

#### Account Management
- View account details via a **MessageBox**.
- Download account info as a `.txt` file.

#### Order Management
- Access the **Command Panel** to place new orders:
  - Name and phone number fields are pre-filled.
  - User must input address and city.
  - View available **partner stores** via a button.
  - Select a store, and press another button to display  **product list** and prices.
  - Choose a **payment method**.
- View all previously placed commands:
  - Displayed in a **ListView**.
  - View specific command details.
  - Right-click options to **clear** or **sort** commands alphabetically by store name.

#### Invoice Management
- View all invoices linked to placed orders.
- Select and inspect invoice details.
- Option to **permanently delete** selected invoices.

#### Data Visualization
- View a **plot chart** of the number of commands per store.

### Admin Panel

Accessible only via a special admin login:
- View all registered accounts from both:
  - The PostgreSQL database.
  - The JSON storage.
- Add new **partner stores** to the system.

### Easter Eggs
- Hidden meme view.
- Music playback feature for fun.

## Technologies Used

- **C# (.NET Framework)**
- **Windows Forms (WinForms)**
- **PostgreSQL**

> Disclaimer 1:
> The videos and memes included as part of the Easter Eggs in this project are used purely for entertainment and educational purposes. I do not claim ownership of any copyrighted media contained therein.
> If you are the rightful owner and believe any content should be removed or credited differently, please feel free to contact me, and I will address the issue promptly.


> Disclaimer 2
> The partner stores used in this application are included solely for educational and demonstration purposes. I am not affiliated with any of the mentioned brands or businesses.
> If any store owner has concerns regarding their inclusion, please contact me directly, and I will take appropriate action.
