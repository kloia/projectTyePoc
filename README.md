﻿
#install Tye
dotnet tool install --global Microsoft.Tye --version 0.10.0-alpha.21420.1
#deploy images to registry and deploy to local cluster
tye deploy
#check running pods
kubectl get pods 
#check running pods
kubectl port-forward svc/webapp 5001:8000
