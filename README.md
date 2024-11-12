# Azure Cloud Resume

This project showcases my resume hosted on Azure. It demonstrates my skills in cloud computing, web development, and continuous integration/continuous deployment (CI/CD).

## Features

- **Static Website**: Hosted on Azure Blob Storage.
- **CI/CD Pipeline**: Implemented using GitHub Actions.
- **Infrastructure as Code**: Managed with Azure Resource Manager (ARM) templates.
- **Custom Domain**: Configured with Azure DNS.
- **SSL/TLS**: Secured with Azure CDN and HTTPS.

## Technologies Used

- Azure Blob Storage
- Azure CDN
- Azure DNS
- GitHub Actions
- ARM Templates

## Getting Started

To get started with this project, follow these steps:

1. Clone the repository:
    ```sh
    git clone https://github.com/yourusername/azurecloudresume.git
    ```
2. Navigate to the project directory:
    ```sh
    cd azurecloudresume
    ```
3. Deploy the infrastructure using ARM templates:
    ```sh
    az deployment group create --resource-group yourResourceGroup --template-file azuredeploy.json
    ```
4. Set up the CI/CD pipeline in GitHub Actions.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any inquiries, please contact me at [kbreed12@gmail.com](mailto:your.email@example.com).