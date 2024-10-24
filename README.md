# PROG6212-CMCS-PART2-ST10304249
---
# Contract Monthly Claim System (CMCS)

The **Contract Monthly Claim System (CMCS)** is a web application developed using .NET Core MVC to streamline the submission and approval process for monthly claims submitted by Independent Contractor (IC) lecturers. This system serves as a crucial tool for enhancing efficiency, user satisfaction, and transparency in claims management. The CMCS simulates real-world scenarios, making it a valuable learning resource for professional settings.

## Features

### User Roles:

- **Lecturer**: Can submit claims and upload supporting documents.
- **Programme Coordinator**: Verifies and approves claims submitted by lecturers.
- **Academic Manager**: Reviews approved claims and manages re-evaluations.

### Key Features:

- **Claim Submission**: Lecturers can submit monthly claims with relevant details and upload supporting documents.
- **Approval Workflow**: Claims are reviewed by the Programme Coordinator and the Academic Manager, ensuring a streamlined approval process.
- **Session Management**: User sessions are managed to provide a personalized experience for each role.
- **Real-Time Tracking**: Users can track the status of claims transparently from submission to final settlement.

---

## Getting Started

### Prerequisites:

- .NET Core SDK (version X.X)
- SQL Server (or another compatible database)

### Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/yourusername/your-repo-name.git
   cd your-repo-name
   ```

2. **Restore NuGet packages:**

   ```bash
   dotnet restore
   ```

3. **Configure the database:**

   - Update the connection string in `appsettings.json` to point to your SQL Server instance.

4. **Run database migrations (if applicable):**

   ```bash
   dotnet ef database update
   ```

5. **Build and run the application:**

   ```bash
   dotnet run
   ```

---

## Usage

1. **Navigate to the application** in your web browser (typically at `http://localhost:5000`).
2. **Log in** with your credentials based on your user role (Lecturer, Programme Coordinator, or Academic Manager).
3. **Follow the prompts** to submit claims, review claims, or manage user sessions.

---

## Running Tests

To run the unit tests for the application, use the following command in your test project directory:

```bash
dotnet test
```

Ensure that you have the necessary test dependencies installed.

---

## Contributing

If you would like to contribute to this project:

1. Fork the repository.
2. Submit a pull request.
3. Make sure to follow the project's coding standards and guidelines.

---

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## Acknowledgments

Special thanks to the .NET community for their support and resources.  
Gratitude to [any mentors or collaborators] for their contributions to this project.

---

## Tips for Customization

- **Add Specific Instructions**: Include specific details about setting up or configuring the project in the relevant sections.
- **Include Screenshots**: If applicable, add screenshots or diagrams to illustrate features or usage.
- **Update Links**: Ensure all links and placeholders (e.g., repository URL, names, etc.) are updated before finalizing the README.

---

This README provides a clear overview of the CMCS, along with setup instructions, usage, testing, and contribution guidelines. 


