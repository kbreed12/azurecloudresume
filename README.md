# Azure Cloud Resume

Welcome to the Azure Cloud Resume project. This project showcases the integration of various Azure services to create a cloud-based resume.

## Features

- **Static Website**: Hosted on Azure Blob Storage.
- **CI/CD Pipeline**: Implemented using GitHub Actions.
- **Infrastructure as Code**: Managed with Azure Resource Manager (ARM) templates.
- **Visitor Counter**: Implemented using Azure Functions and Cosmos DB.

## Getting Started

To get started with this project, follow the steps below:

1. **Clone the repository**:
    ```sh
    git clone https://github.com/yourusername/azurecloudresume.git
    cd azurecloudresume
    ```

2. **Deploy the infrastructure**:
    ```sh
    az deployment group create --resource-group <your-resource-group> --template-file azuredeploy.json
    ```

3. **Set up CI/CD**:
    - Configure GitHub Actions with your Azure credentials.
    - Push changes to the `main` branch to trigger the pipeline.

4. **Update the website content**:
    - Modify the HTML/CSS files in the `web` directory.
    - Commit and push your changes.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License

This project is licensed under the MIT License. See the [LICENSE][def] file for details.

## Contact

For any questions or feedback, please open an issue in the repository.


[def]: LICENSE