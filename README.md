# Optical Management System

This project is a comprehensive Optical Shop Management System composed of two main components:

1. **Desktop Application** – Manages customers, bills, workers, suppliers, and warehouse operations.
2. **API Service** – Provides backend endpoints for mobile and remote interactions.

---

## Table of Contents

- [Features](#features)
  - [Desktop Application](#desktop-application)
    - [Login Form](#1-login-form)
    - [Main Form Tabs](#2-main-form-tabs)
      - [Bills Tab](#bills-tab)
      - [Customer Tab](#customer-tab)
      - [Suppliers Tab](#suppliers-tab)
      - [Workers Tab](#workers-tab)
      - [Push Report Tab](#push-report-tab)
      - [Warehouse Tab](#warehouse-tab)
  - [API Endpoints](#api-endpoints)
- [Screenshots](#screenshots)
- [Installation](#installation)
- [Contributing](#contributing)
- [License](#license)

---

## Features

### Desktop Application

#### 1. Login Form
- Secure login form with **username** and **password**.
- Validates user credentials before accessing the system.

> 📸 *Image Required: Screenshot of the login form*  
> Save as: `screenshots/login_form.png`

#### 2. Main Form Tabs

##### Bills Tab
- Add a new bill for a customer.
- Enter:
  - Customer Name
  - Optic Code
  - Type of Glasses Frame

> 📸 *Image Required: Screenshot of the Bills Tab*  
> Save as: `screenshots/bills_tab.png`

##### Customer Tab
- View a list of customer bills.
- Track:
  - Total due and paid amounts.
  - Payment status.
- Features:
  - Add new customer
  - Record payments

> 📸 *Image Required: Screenshot of the Customer Tab*  
> Save as: `screenshots/customer_tab.png`

##### Suppliers Tab
- Track payments made to suppliers and their sources.
- Add new suppliers.
- Pay or deposit money into supplier accounts.

> 📸 *Image Required: Screenshot of the Suppliers Tab*  
> Save as: `screenshots/suppliers_tab.png`

##### Workers Tab
- Manage worker profiles:
  - Add, edit, or delete workers
  - Record borrowings or destroyed objects
  - Check account status
  - Process salary payments

> 📸 *Image Required: Screenshot of the Workers Tab*  
> Save as: `screenshots/workers_tab.png`

##### Push Report Tab
- Push daily reports from the desktop application to a connected mobile app.

> 📸 *Image Required: Screenshot of the Push Report Tab*  
> Save as: `screenshots/push_report_tab.png`

##### Warehouse Tab
- Inventory and price management:
  - Add optics to warehouse
  - Add new optic types
  - Edit prices
  - Manage optic manufacturers

> 📸 *Image Required: Screenshot of the Warehouse Tab*  
> Save as: `screenshots/warehouse_tab.png`

---

### API Endpoints

| Endpoint            | Method | Description                                  |
|---------------------|--------|----------------------------------------------|
| `/upload-report`    | POST   | Upload daily reports from the desktop system |
| `/get-daily-report` | GET    | Retrieve the latest daily report             |
| `/get-date`         | GET    | Check current server date/time               |
| `/get-all-reports`  | GET    | Fetch all historical reports                 |

---

## Screenshots

All application interface images should be placed in the `screenshots/` folder within the project directory:

