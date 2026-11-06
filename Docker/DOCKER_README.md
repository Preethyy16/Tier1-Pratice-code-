## The Docker Commands 

## To check the version
docker version

## To view the running contaiers 
docker ps

## To view the hidden running contaiers 
docker ps -a

### To Build Docker Image
docker build -t customer-discount-app . 

### Run Docker Container
docker run -it customer-discount-app

### View Docker Images
docker image ls

### View the hidden Docker Images
docker image ls -a