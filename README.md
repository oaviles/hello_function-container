# Creating containerized function apps

This is a collection of sample projects for Cloud Application Developer using Azure Cloud Platform. The sample projects are arranged in different topics about containerized Azure Funtions development and deployment on any cloud platfomr supported by Secure DevOps Practices.

#### Generate the Dockerfile
```sh
func init --docker
```
#### Creating your function app in a container, build the container image and verify locally
```sh
docker build --tag <DOCKER_ID>/<IMAGE_NAME>:v1.0.0 .
docker run -p 8080:80 -it <DOCKER_ID>/azurefunctionsimage:v1.0.0
```
#### Publish the container image to a registry, you can reuse this pipeline ["Build and Push image to Docker Hub"](https://github.com/oaviles/hello_function-container/actions/workflows/docker-image.yml)

#### Deploy image on any Cloud Platform
- Azure: [Deploy your first container app](https://learn.microsoft.com/en-us/azure/container-apps/get-started?tabs=bash)
```sh
az containerapp up --name my-container-app --resource-group my-container-apps --location centralus --environment 'oa-container-apps' --image <DOCKER_ID>/azurefunctionsimage:v1.0.0 --target-port 80 --ingress external --query properties.configuration.ingress.fqdn
```
- GCP: [Hosting Azure Functions in Google Cloud Run](https://mikhail.io/2020/02/azure-functions-in-google-cloud-run/)
- AWS: [Hosting Azure Funtions in AWS ECS](https://medium.com/@vbebins/deploying-aws-ecs-with-azure-devops-a-step-by-step-guide-de94d5a377e1)

#### Other Resources
- [Create a function app in a local Linux container](https://learn.microsoft.com/en-us/azure/azure-functions/functions-create-container-registry?tabs=acr%2Cbash&pivots=programming-language-csharp)
- [Working with containers and Azure Functions](https://learn.microsoft.com/en-us/azure/azure-functions/functions-create-container-registry?tabs=acr%2Cbash&pivots=programming-language-csharp)
- [Microsoft Artifact Registry](https://mcr.microsoft.com/catalog?search=functions)
- [Sample Image on Docker Hub](https://hub.docker.com/repository/docker/oaviles/oafunctioncontainer/general)

> Note: This page is getting updated so make sure to check regularly for new resources.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
