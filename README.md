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
