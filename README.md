
#Install Tye
```dotnet tool install --global Microsoft.Tye --version 0.10.0-alpha.21420.1```
#Deploy images to registry and deploy to local cluster
```tye deploy```
#Check running pods
```kubectl get pods``` 
#Port forward 
```kubectl port-forward svc/webapp 5001:8000```
