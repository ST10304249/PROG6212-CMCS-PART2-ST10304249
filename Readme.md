REPO https://github.com/ST10304249/POE_CMCS_PART3_ST10304249.git

# Contract Monthly Claim System (CMCS)

## Overview

The **Contract Monthly Claim System (CMCS)** is a web application designed to streamline the submission, approval, and management of monthly claims for Independent Contractor lecturers. The system allows lecturers to submit claims for reimbursement, which can be reviewed and approved by the HR department. The application ensures efficient and accurate handling of claims and invoices.

## Features

- **Lecturer Claims Management**: Lecturers can submit their claims and manage them within the application.
- **Invoice Generation**: HR can generate invoices based on approved claims.
- **Lecturer Updates**: HR has the ability to update lecturer details and manage their claims.
- **Responsive Design**: The system is designed to be responsive and works on desktop and mobile devices.

## Requirements

Before running the application, ensure you have the following installed:

- [.NET SDK 6.0 or higher](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or another compatible database.
- [Visual Studio or Visual Studio Code](https://code.visualstudio.com/)

## Installation

1. **Clone the repository**:

   ```bash
   git clone https://github.com/your-repository-link.git
   cd CMCS
   ```

2. **Restore dependencies**:

   Run the following command to restore the necessary NuGet packages:

   ```bash
   dotnet restore
   ```

3. **Configure Database Connection**:

   In the `appsettings.json` file, configure the connection string for your database:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=CMCS;Trusted_Connection=True;"
   }
   ```

   Replace `localhost` and `CMCS` with your database server and name.

4. **Apply Migrations**:

   To create the database schema, run the following command:

   ```bash
   dotnet ef database update
   ```

5. **Run the Application**:

   After setting up the database and applying migrations, you can start the application by running:

   ```bash
   dotnet run
   ```

   This will launch the application, and you can access it via `http://localhost:5000`.

## Project Structure

- `Controllers/HRController.cs`: Contains the logic for managing claims and lecturer data.
- `Models/Lecturer.cs`: Represents the lecturer data model.
- `Models/Claim.cs`: Represents the claim data model.
- `Database/ApplicationDbContext.cs`: Database context used to interact with the database.
- `Views`: Contains the views (UI) for managing claims, lecturers, and invoices.
- `wwwroot`: Contains static files (CSS, JavaScript, images) used in the application.

## Usage

### Claims Management

1. **Submitting Claims**: Lecturers can submit claims through the Claims page.
2. **Managing Claims**: HR can view and manage submitted claims via the Claims page.

### Invoice Generation

HR can generate invoices based on claims and use the `GenerateInvoice` action to create invoice details.

### Updating Lecturer Information

HR can update lecturer information using the `UpdateLecturer` view, which allows editing lecturer details.

## Technologies Used

- **ASP.NET Core MVC**: For building the web application.
- **Entity Framework Core**: For data access and handling the database.
- **SQL Server**: For storing application data.
- **HTML, CSS, JavaScript**: For the frontend.

## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/feature-name`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature/feature-name`).
5. Create a new Pull Request.

## License

This project is licensed under the MIT License.

---

This README structure provides all the essential details to set up and run your project, along with explanations of the features and technologies used. Feel free to modify the content as necessary to suit your project needs.