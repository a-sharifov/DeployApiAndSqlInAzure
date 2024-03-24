# [TestDeployApiAndSqlInAzure](https://github.com/a-sharifov/DotNET.AlgorithmsAndDataStructures) [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/a-sharifov/TestDeployApiAndSqlInAzure/blob/master/LICENSE)

## Overview

This repository serves as an example demonstrating the deployment of a typical .NET API project to the Azure platform, utilizing Azure Web App and Azure SQL Server.

## Deploying a C# API Project to Azure with Azure SQL Server

### Step 1: Creating Azure SQL Server

1. **Sign in to Azure Portal:**
   - Go to [Azure Portal](https://portal.azure.com/).
   - Sign in with your Azure account.

2. **Create a new SQL Database resource:**
   - Click on "Create a resource" in the top-left corner.
   - Search for "SQL Database" and select it.
   - Click "Create" to begin setting up a new SQL database.

3. **Fill in the basic settings:**
   - Choose your subscription and create a new resource group.
   - Specify the database name, region, and pricing tier.

4. **Configure server parameters:**
   - Create a new SQL server by selecting "Create New".
   - Provide a server name, administrative login, and password for the server.

5. **Additional settings:**
   - Configure security, backup, and scaling options as needed.
   - Click "Review + create" to finalize setup and create the SQL database.

### Step 2: Obtaining Connection String

1. **Navigate to your SQL database:**
   - After creating the SQL database, go to its resource in the Azure portal.

2. **Get the connection string:**
   - In the "Settings" section, select "Connection strings".
   - Copy the ADO.NET connection string or any other suitable connection type.

3. **Set connection string**
   - after the copy, you should set this connection string in `appsettings.json`
     ```json
     "ConnectionStrings": {
       "AzureSql": "enter your connection string azure"
     }
     ```

### Step 3: Deploying API Project to Azure

1. **Prepare your project:**
   - Ensure your API project is configured to work with the SQL Server database.

2. **Deploy the project to Azure:**
   - Return to the Azure portal and select your Azure Web App resource.
   - In the "Deployment Center", choose your preferred deployment method (e.g., GitHub, Azure DevOps, FTP, etc.).
   - Configure the deployment parameters, including specifying your API project repository.

3. **Complete the deployment:**
   - Start the deployment process and wait for it to complete.
   - After successful deployment, your API project will be accessible via the URL of your Azure Web App.

Now you can use your API deployed on Azure, utilizing Azure SQL Server as your database. If you encounter any issues or have questions, feel free to consult Azure documentation or the Azure developer community for additional assistance.

---

## 🌟 Enjoyed my project?

- Please consider starring the repository.
- You can donate on [Patreon](https://www.patreon.com/a_sharifov).

## 📫 Contact

If you have any questions or suggestions, feel free to reach out to me.

This project is licensed under the [MIT License](LICENSE).
