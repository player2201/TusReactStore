# TusReactStore fake E-commerece store project

## Description

TusReactStore is a full-stack, fake e-commerce store front made for the purpose learning key modern technologies:
- Frontend: React, TypeScript, Redux Toolkit, Material-UI
- Backend: ASP.NET Core 9.0 Web API (C#) with Entity Framework Core

#### Deployment
- Youtube demo video here : [Link](https://youtu.be/_YESWfte0uw)
- or : https://youtu.be/_YESWfte0uw
- My project is deployed here: [Project](https://tusreactstore.azurewebsites.net/)  
- or: https://tusreactstore.azurewebsites.net/  
If the hosted page has 500.30 error, this means that I am using a free Azure license and its runtime is out. Please contact me if you want to test the site and I can restart the site but it only runs for 1 hour then it is down again :)

## Features
- User registration and authentication
- Product catalog and order management
- Payment integration (Stripe)
- Admin inventory page for product management
- Responsive UI with Material UI
- Error handling and notifications using react-toastify
- Product image upload using Cloudinary

## Frontend Architecture
- **React + TypeScript**: strong type safety with hook-based components
- **Redux Toolkit**: manages global state - products, cart, user sessions, admin state
- **Material-UI (MUI v7)**: provides styled UI components (AppBar, Cards, Typography, Forms,...)
- **Thunks**: for async actions like fetching products or checkout
- **React Router Dom**: for routing `/`,`/products`,`/checkout`,`login`,...

## Backend Architecture
- **ASP.NET Core 9.0 Web API**
- **Entity Framework Core 9**: first model with SQLite database then moved to Microsoft SQL Server
- **Authentication**: ASP.NET Core Identity
- **Controllers**: for endpoints creations and CRUD operations for products

## Getting Started

### Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Node.js (LTS)](https://nodejs.org/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Setup

#### Backend

Open the terminal and enter these commands:

1. Navigate to API folder:
    ```sh
    cd API
    ```
2. Restore packages and update the database:
   ```sh
    dotnet restore
    dotnet ef database update
    ```
3. Run backend:
    ```sh
    dotnet run
    ```
   or
   ```sh
    dotnet watch
    ```

#### Frontend

Open a different terminal and enter these commmands:

1. Navigate to client folder:
   ```sh
   cd client
   ```
2. Install dependencies:
   ```sh
   npm install
   ```
3. Run the frontend:
   ```sh
   npm start
   ```
   or  
   ```sh
   npm run dev
   ```
#### Existing Users
- **Admin**
    - username/email: `admin@test.com`
    - password: `Pa$$w0rd`
- **Customer**
    - username/email: `bob@test.com`
    - password: `Pa$$w0rd`

#### Configuration

- Update file `appsetings.json` in the API project with your SQL Server and Cloudinary credentials.
- Update your Stripe keys as needed in `appsettings.Development.json`.  


