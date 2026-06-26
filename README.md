# Field Renting System

A Windows Forms (C#) desktop application for renting sports fields/grounds. The system supports three types of users — **Admin**, **Seller** (field owner), and **User** (renter) — and manages field listings, booking requests, approvals, and rental records.

## Features

- **User Registration & Login** – Separate registration flows for regular users and sellers, with a shared login screen.
- **Admin Dashboard** – View and manage registered users, approve/reject listed fields, and oversee platform activity.
- **Seller Dashboard** – Sellers can add new fields for rent (`add_fld`), view their listed fields, and manage incoming booking requests.
- **Field Listings** – Browse all approved/listed fields available for rent.
- **Booking System** – Users can submit booking requests for a field; sellers/admins can view and act on pending requests.
- **Approval Workflow** – Admin can view and approve listed fields before they go live (`view_Table_approved`).
- **Rental Records** – Track historical rental/booking records (`rentrecord`).

## Tech Stack

- **Language:** C# (.NET, Windows Forms)
- **UI:** WinForms (Designer-generated `.Designer.cs` / `.resx` files)
- **Project type:** Visual Studio Solution (`.sln` / `.csproj`)

## Project Structure

```
Field-Renting-System/
├── Properties/                  # Assembly info and project properties
├── Resources/                    # Images/icons used in the UI
├── Program.cs                    # Application entry point
├── LoginUser.cs                  # User login screen
├── Registration.cs               # User registration
├── SellerReg.cs                  # Seller registration
├── AdminDash.cs                  # Admin dashboard
├── Adminuserupdate.cs            # Admin: update/manage user info
├── Dashboard.cs                  # Main user dashboard
├── add_fld.cs                    # Seller: add a new field listing
├── listed_fields.cs              # Browse listed fields
├── seller_home.cs                # Seller home screen
├── seller_info.cs                # Seller profile/info
├── Booking.cs                    # Booking screen
├── bookingreq.cs                 # Booking request handling
├── Userbookingreq.cs             # User-side booking requests
├── view_Table_approved.cs        # Admin view of approved fields
├── rentrecord.cs                 # Rental history records
└── Field Renting System.sln/.csproj
```

## Getting Started

### Prerequisites

- Windows OS
- [Visual Studio](https://visualstudio.microsoft.com/) (2019 or later recommended) with .NET desktop development workload
- SQL Server / database configured in `App.config` (update the connection string to match your local setup)

### Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/mahinfah/Field-Renting-System.git
   ```
2. Open `Field Renting System.sln` in Visual Studio.
3. Update the database connection string in `App.config` to point to your local database.
4. Restore NuGet packages if prompted.
5. Build and run the project (`F5`).

## Usage

1. **Register** as a User or Seller from the registration screen.
2. **Login** with your credentials.
3. **Sellers** can add fields for rent and manage booking requests.
4. **Users** can browse listed fields and submit booking requests.
5. **Admins** review and approve listed fields and manage user accounts.

## Roles

| Role   | Capabilities                                                         |
|--------|----------------------------------------------------------------------|
| Admin  | Approve fields, manage users, oversee bookings                       |
| Seller | Register, list fields, manage own listings and booking requests      |
| User   | Register, browse fields, submit booking requests                     |

## Contributing

Contributions, issues, and feature requests are welcome. Feel free to fork the repo and submit a pull request.

## License

No license has been specified for this project. Consider adding one (e.g., MIT) if you plan to share or accept contributions.
