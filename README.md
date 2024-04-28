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

> Note: This page is getting updated so make sure to check regularly for new resources.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
